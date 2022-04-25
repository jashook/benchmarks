namespace ev30
{
    using System;
    using System.Collections.Generic;
    using System.Net.Security;
    using System.Security.Cryptography.X509Certificates;
    using BenchmarkDotNet.Attributes;

    [MemoryDiagnoser]
    public class X509Timings
    {
        private List<X509Certificate2> inMemoryCertificates;
        private List<X509Certificate2> m_clientCertificates;
        private string certificateCommonName = "client";

        public X509Timings()
        {
            this.inMemoryCertificates = new();
            this.m_clientCertificates = new();

        }

        [Benchmark]
        public void Baseline()
        {
            var test = static (X509Timings obj) => {
                obj.m_clientCertificates.Clear();
                obj.inMemoryCertificates.Clear();
                
                StoreName storeName = StoreName.My;
                StoreLocation storeLocation = StoreLocation.LocalMachine;

                List<X509Certificate2> clientCertificates = null;
                using (X509Store store = new X509Store(storeName, storeLocation))
                {
                    store.Open(OpenFlags.ReadOnly);

                    foreach (X509Certificate2 cert in store.Certificates)
                    {
                        if (cert.SubjectName.Name.Contains(obj.certificateCommonName, StringComparison.OrdinalIgnoreCase) &&
                            cert.NotBefore <= DateTime.UtcNow &&
                            cert.NotAfter > DateTime.UtcNow &&
                            !obj.inMemoryCertificates.Contains(cert))
                        {
                            try
                            {
                                if (!cert.HasPrivateKey || cert.GetRSAPrivateKey() == null)
                                {
                                    continue;
                                }
                            }
                            catch (Exception)
                            {
                                // GetRSAPrivateKey may throw
                            }

                            if (clientCertificates == null)
                            {
                                clientCertificates = new List<X509Certificate2>() { cert };
                            }
                            else
                            {
                                clientCertificates.Add(cert);
                            }
                        }
                    }
                }

                if (clientCertificates != null)
                {
                    foreach (X509Certificate2 inMemoryCert in obj.inMemoryCertificates)
                    {
                        clientCertificates.Add(inMemoryCert);
                    }
                }

                obj.m_clientCertificates.Clear();
                obj.inMemoryCertificates.Clear();
            };

            for (int index = 0; index < 100; ++index)
            {
                test(this);
            }
        }

        [Benchmark]
        public void AvoidListAlloc()
        {
            var test = static (X509Timings obj) => {
                obj.m_clientCertificates.Clear();
                obj.inMemoryCertificates.Clear();

                StoreName storeName = StoreName.My;
                StoreLocation storeLocation = StoreLocation.LocalMachine;

                using (X509Store store = new X509Store(storeName, storeLocation))
                {
                    store.Open(OpenFlags.ReadOnly);

                    foreach (X509Certificate2 cert in store.Certificates)
                    {
                        if (cert.SubjectName.Name.Contains(obj.certificateCommonName, StringComparison.OrdinalIgnoreCase) &&
                            cert.NotBefore <= DateTime.UtcNow &&
                            cert.NotAfter > DateTime.UtcNow &&
                            !obj.inMemoryCertificates.Contains(cert))
                        {
                            try
                            {
                                if (!cert.HasPrivateKey || cert.GetRSAPrivateKey() == null)
                                {
                                    continue;
                                }
                            }
                            catch (Exception)
                            {
                                // GetRSAPrivateKey may throw
                            }

                            obj.m_clientCertificates.Add(cert);
                        }
                    }
                }

                if (obj.m_clientCertificates != null)
                {
                    foreach (X509Certificate2 inMemoryCert in obj.inMemoryCertificates)
                    {
                        obj.m_clientCertificates.Add(inMemoryCert);
                    }
                }

                obj.m_clientCertificates.Clear();
                obj.inMemoryCertificates.Clear();
            };

            for (int index = 0; index < 100; ++index)
            {
                test(this);
            }
        }
    }
}