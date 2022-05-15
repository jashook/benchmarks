#ifndef __TYPE_PASSING_HPP__
#define __TYPE_PASSING_HPP__

////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////

namespace ev30 {

////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////

const char* s_version = "v1.0.0";
const char* s_pid = "1011";
const char* s_process_name = "native_passing_lib";
const char* s_object_id = "objectid";
const char* s_data = "12873819837274hjskdhdsjhds";
const char* s_data_hash = "znxksuaygbnkuytrfdcvbnjkuytrfdcvbnjkiutfgjkiuytf";
const char* s_data_algorithm = "sha256";
const char* s_data_identifier = "asjjjkloiuhbnmkloi98765trfgbhnjk";
const char* s_data_identifiers = "asjjjkloiuhbnmkloi98765trfgbhnjk;asjjjkloiuhbnmkloi98765trfgbhnjk;asjjjkloiuhbnmkloi98765trfgbhnjk;asjjjkloiuhbnmkloi98765trfgbhnjk;asjjjkloiuhbnmkloi98765trfgbhnjk;asjjjkloiuhbnmkloi98765trfgbhnjk;asjjjkloiuhbnmkloi98765trfgbhnjk;asjjjkloiuhbnmkloi98765trfgbhnjk;asjjjkloiuhbnmkloi98765trfgbhnjk;asjjjkloiuhbnmkloi98765trfgbhnjk;asjjjkloiuhbnmkloi98765trfgbhnjk;asjjjkloiuhbnmkloi98765trfgbhnjk;asjjjkloiuhbnmkloi98765trfgbhnjk;asjjjkloiuhbnmkloi98765trfgbhnjk;asjjjkloiuhbnmkloi98765trfgbhnjk;asjjjkloiuhbnmkloi98765trfgbhnjk;asjjjkloiuhbnmkloi98765trfgbhnjk";
const char* s_valid_date = "12-may-2012-0000z";
const char* s_expiration_date = "13-may-2012-0000z";
const char* s_identity = "kfcvbnmkiuytrdcvbjkiuytrfdcvbnjkiuytrfdcvbnmkiuytfdcv";
const char* s_parent_identity = "jhgfdfcvbhjmnbvcdswe4r567uikmnbgfr5678uikjmnbvfrtyu";
const char* s_parent_strong_identifiers = "jhgfdsxcvbnjyt56yujnbvcxswertewszxc vbnmko9876t5rfgvb";
const char* s_policy = "smiles";
const char* s_reason = "two smiles";
const char* s_matched_data = "kfcvbnmkiuytrdcvbjkiuytrfdcvbnjkiuytrfdcvbnmkiuytfdcv";
const char* s_matched_parent_data = "jhgfdsxcvbnjyt56yujnbvcxswertewszxc";
const char* s_matched_parent_identifier = "jhgfdfcvbhjmnbvcdswe4r567uikmnbgfr5678uikjmnbvfrtyu";

struct ReturnType
{
    const char* Version;
    const char* Pid;
    const char* ProcessName;
    const char* ObjectId;
    int Level;
    const char* Data;
    const char* DataHash;
    const char* DataAlgorithm;
    const char* DataIdentifier;
    const char* DataIdentifiers;
    const char* ValidDate;
    const char* ExpirationDate;
    const char* Identity;
    const char* ParentIdentifier;
    const char* ParentStrongIdentifier;
    const char* Policy;
    int Result;
    const char* Reason;
    const char* MatchedData;
    const char* MatchedParentData;
    const char* MatchedParentIdentifier;
};

////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////

} // ev30

////////////////////////////////////////////////////////////////////////////////
////////////////////////////////////////////////////////////////////////////////

#endif // __TYPE_PASSING_H__