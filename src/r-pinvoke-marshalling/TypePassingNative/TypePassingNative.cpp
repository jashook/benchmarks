#include "ReturnType.hpp"

#include <cstdlib>
#include <cstring>

extern "C" __declspec(dllexport) ev30::ReturnType GetReturnType()
{
    ev30::ReturnType value;
    
    value.Data = ev30::s_data;
    value.DataAlgorithm = ev30::s_data_algorithm;
    value.DataHash = ev30::s_data_hash;
    value.DataIdentifier = ev30::s_data_identifier;
    value.DataIdentifiers = ev30::s_data_identifiers;
    value.ExpirationDate = ev30::s_expiration_date;
    value.Identity = ev30::s_identity;
    value.Level = 0;
    value.MatchedData = ev30::s_matched_data;
    value.MatchedParentData = ev30::s_matched_parent_data;
    value.MatchedParentIdentifier = ev30::s_matched_parent_identifier;
    value.ObjectId = ev30::s_object_id;
    value.ParentIdentifier = ev30::s_parent_identity;
    value.ParentStrongIdentifier = ev30::s_parent_strong_identifiers;
    value.Pid = ev30::s_pid;
    value.Policy = ev30::s_policy;
    value.ProcessName = ev30::s_process_name;
    value.Reason = ev30::s_reason;
    value.Result = 10;
    value.ValidDate = ev30::s_valid_date;
    value.Version = ev30::s_version;

    return value;
}

extern "C" __declspec(dllexport) void GitReturnType(char* version,
                                                    int* versionCount,
                                                    char* pid,
                                                    int* pidCount,
                                                    char* processName,
                                                    int* processNameCount,
                                                    char* objectId,
                                                    int* objectIdCount,
                                                    int* level,
                                                    char* data,
                                                    int* dataCount,
                                                    char* dataHash,
                                                    int* dataHashCount,
                                                    char* dataAlgorithm,
                                                    int* dataAlgorithmCount,
                                                    char* dataIdentifier,
                                                    int* dataIdentifierCount,
                                                    char* dataIdentifiers,
                                                    int* dataIdentifiersCount,
                                                    char* validDate,
                                                    int* validDateCount,
                                                    char* expirationDate,
                                                    int* expirationDateCount,
                                                    char* identity,
                                                    int* identityCount,
                                                    char* parentIdentifier,
                                                    int* parentIdentifierCount,
                                                    char* parentStrongIdentifier,
                                                    int* parentStrongIdentifierCount,
                                                    char* policy,
                                                    int* policyCount,
                                                    int* result,
                                                    char* reason,
                                                    int* reasonCount,
                                                    char* matchedData,
                                                    int* matchedDataCount,
                                                    char* matchedParentData,
                                                    int* matchedParentDataCount,
                                                    char* matchedParentIdentifier,
                                                    int* matchedParentIdentifierCount)
{
    memcpy(data, ev30::s_data, sizeof(ev30::s_data));
    memcpy(dataAlgorithm, ev30::s_data_algorithm, sizeof(ev30::s_data_algorithm));
    memcpy(dataHash, ev30::s_data_hash, sizeof(ev30::s_data_hash));
    memcpy(dataIdentifier, ev30::s_data_identifier, sizeof(ev30::s_data_identifier));
    memcpy(dataIdentifiers, ev30::s_data_identifiers, sizeof(ev30::s_data_identifiers));
    memcpy(expirationDate, ev30::s_expiration_date, sizeof(ev30::s_expiration_date));
    memcpy(identity, ev30::s_identity, sizeof(ev30::s_identity));

    *level = 0;

    memcpy(matchedData, ev30::s_matched_data, sizeof(ev30::s_matched_data));
    memcpy(matchedParentData, ev30::s_matched_parent_data, sizeof(ev30::s_matched_parent_data));
    memcpy(matchedParentIdentifier, ev30::s_matched_parent_identifier, sizeof(ev30::s_matched_parent_identifier));
    memcpy(objectId, ev30::s_object_id, sizeof(ev30::s_object_id));
    memcpy(parentIdentifier, ev30::s_parent_identity, sizeof(ev30::s_parent_identity));
    memcpy(parentStrongIdentifier, ev30::s_parent_strong_identifiers, sizeof(ev30::s_parent_strong_identifiers));
    memcpy(pid, ev30::s_pid, sizeof(ev30::s_pid));
    memcpy(policy, ev30::s_policy, sizeof(ev30::s_policy));
    memcpy(processName, ev30::s_process_name, sizeof(ev30::s_process_name));
    memcpy(reason, ev30::s_reason, sizeof(ev30::s_reason));

    *result = 10;

    memcpy(validDate, ev30::s_valid_date, sizeof(ev30::s_valid_date));
    memcpy(version, ev30::s_version, sizeof(ev30::s_version));
}