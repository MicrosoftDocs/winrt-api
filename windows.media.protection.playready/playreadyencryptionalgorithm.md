---
-api-id: T:Windows.Media.Protection.PlayReady.PlayReadyEncryptionAlgorithm
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Protection.PlayReady.PlayReadyEncryptionAlgorithm : int
-->

# PlayReadyEncryptionAlgorithm

## -description
Indicates the type of encryption algorithm specified in a PlayReady content header.

## -enum-fields
### -field Unprotected:0
Content is not encrypted.

### -field Aes128Ctr:1
AES-128 Counter-mode encryption.

### -field Cocktail:4
Cocktail encryption.

### -field Uninitialized:2147483647
The encryption method has not been set.


### -field Aes128Cbc:5
AES128CBC encryption.

### -field Unspecified:65535
The encryption method is unspecified.

## -remarks

Starting with Windows 10, version 1709, this enumeration supports the values **Aes128Cbc** and **Unspecified**. On previous versions of Windows 10, some PlayReady APIs will thrown an exception if these values are used. For this reason, you should check for the presence of the enumeration value by calling **[ApiInformationIsApiContractPresent](/uwp/api/windows.foundation.metadata.apiinformation#Windows_Foundation_Metadata_ApiInformation_IsApiContractPresent_System_String_System_UInt16_)** and specifying major contract version 5 before using the new enum values. For more information, see [PlayReadyContentHeader](playreadycontentheader_playreadycontentheader_40363517.md) and [PlayReadyStatics.CheckSupportedHardware](playreadystatics_checksupportedhardware_389210608.md).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | Aes128Cbc |
| 1709 | 16299 | Unspecified |

## -examples

## -see-also

