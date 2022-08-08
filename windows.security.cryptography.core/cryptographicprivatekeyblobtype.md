---
-api-id: T:Windows.Security.Cryptography.Core.CryptographicPrivateKeyBlobType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Cryptography.Core.CryptographicPrivateKeyBlobType : int
-->

# CryptographicPrivateKeyBlobType

## -description
Specifies the type of the private key contained in a buffer.

## -enum-fields
### -field Pkcs8RawPrivateKeyInfo:0
This is the default value. The private key is encoded as an ASN.1 **PrivateKeyInfo** type defined in the PKCS#8 standard. The private key information syntax is defined as follows in RFC 5208.

```xml
PrivateKeyInfo ::= SEQUENCE {
  version                   Version,
  privateKeyAlgorithm       PrivateKeyAlgorithmIdentifier,
  privateKey                PrivateKey,
  attributes           [0]  IMPLICIT Attributes OPTIONAL }

Version ::= INTEGER

PrivateKeyAlgorithmIdentifier ::= AlgorithmIdentifier

PrivateKey ::= OCTET STRING

Attributes ::= SET OF Attribute

```



### -field Pkcs1RsaPrivateKey:1
The key is an RSA private key defined in the PKCS #1 standard. For more information, see the RSA Cryptography Specification in RFC 3347.

### -field BCryptPrivateKey:2
Microsoft private key format defined by Cryptography API: Next Generation (CNG). For examples, see the following CNG structures:


+ [BCRYPT_DH_KEY_BLOB](/windows/win32/api/bcrypt/ns-bcrypt-bcrypt_dh_key_blob)
+ [BCRYPT_DSA_KEY_BLOB](/windows/win32/api/bcrypt/ns-bcrypt-bcrypt_dsa_key_blob)
+ [BCRYPT_ECCKEY_BLOB](/windows/win32/api/bcrypt/ns-bcrypt-bcrypt_ecckey_blob)
+ [BCRYPT_KEY_BLOB](/windows/win32/api/bcrypt/ns-bcrypt-bcrypt_key_blob)
+ [BCRYPT_RSAKEY_BLOB](/windows/win32/api/bcrypt/ns-bcrypt-bcrypt_rsakey_blob)


### -field Capi1PrivateKey:3
Microsoft private key format defined by the legacy Cryptography API (CAPI). For more information, see [Base Provider Key BLOBs](/windows/desktop/SecCrypto/base-provider-key-blobs).

### -field BCryptEccFullPrivateKey:4
The key is a BCrypt full elliptic curve cryptography (ECC) private key.


## -remarks

## -examples

## -see-also