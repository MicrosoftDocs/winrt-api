---
-api-id: T:Windows.Networking.Connectivity.NetworkEncryptionType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Networking.Connectivity.NetworkEncryptionType : int
-->

# NetworkEncryptionType

## -description
Defines values that indicate the type of encryption used for authentication.

## -enum-fields

### -field Ccmp:6
Specifies an AES-CCMP algorithm, as specified in the IEEE 802.11i-2004 standard and RFC 3610. Advanced Encryption Standard (AES) is the encryption algorithm defined in FIPS PUB 197.

### -field Gcmp:10
Specifies an AES-GCMP algorithm, as specified in the IEEE 802.11-2016 standard, with a 128-bit key. Advanced Encryption Standard (AES) is the encryption algorithm defined in FIPS PUB 197.

### -field Gcmp256:11
Specifies an AES-GCMP algorithm, as specified in the IEEE 802.11-2016 standard, with a 256-bit key. Advanced Encryption Standard (AES) is the encryption algorithm defined in FIPS PUB 197.

### -field Ihv:9
Specifies an encryption type defined by an independent hardware vendor (IHV).

### -field None:0
No encryption enabled.

### -field RsnUseGroup:8
Specifies a Robust Security Network (RSN) Use Group Key cipher suite. For more information about the Use Group Key cipher suite, refer to Clause 7.3.2.25.1 of the IEEE 802.11i-2004 standard.

### -field Tkip:5
Specifies a Temporal Key Integrity Protocol (TKIP) algorithm, which is the RC4-based cipher suite that is based on the algorithms that are defined in the WPA specification and IEEE 802.11i-2004 standard. This cipher also uses the Michael Message Integrity Code (MIC) algorithm for forgery protection.

### -field Unknown:1
Encryption method unknown.

### -field Wep:2
Specifies a WEP cipher algorithm with a cipher key of any length.

### -field Wep104:4
Specifies a WEP cipher algorithm with a 104-bit cipher key.

### -field Wep40:3
Specifies a Wired Equivalent Privacy (WEP) algorithm, which is the RC4-based algorithm that is specified in the IEEE 802.11-1999 standard. This enumerator specifies the WEP cipher algorithm with a 40-bit cipher key.

### -field WpaUseGroup:7
Specifies a Wifi Protected Access (WPA) Use Group Key cipher suite. For more information about the Use Group Key cipher suite, refer to Clause 7.3.2.25.1 of the IEEE 802.11i-2004 standard.

## -remarks

## -examples

## -see-also
[NetworkEncryptionType (Property)](networksecuritysettings_networkencryptiontype.md)
