---
-api-id: T:Windows.Security.Cryptography.Core.CryptographicPublicKeyBlobType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Cryptography.Core.CryptographicPublicKeyBlobType : int
-->

# CryptographicPublicKeyBlobType

## -description
Specifies the type of the public key contained in a buffer.

## -enum-fields
### -field X509SubjectPublicKeyInfo:0
This is the default value. The public key is encoded as an ASN.1 **SubjectPublicKeyInfo** type defined in RFC 5280 and RFC 3280.

```xml
SubjectPublicKeyInfo  ::=  SEQUENCE  {
    algorithm            AlgorithmIdentifier,
    subjectPublicKey     BIT STRING  }

```



### -field Pkcs1RsaPublicKey:1
The key is an RSA public key defined in the PKCS #1 standard. For more information, see the RSA Cryptography Specification in RFC 3347.

### -field BCryptPublicKey:2
Microsoft public key format defined by Cryptography API: Next Generation (CNG). For examples, see the following CNG structures:


+ [BCRYPT_DH_KEY_BLOB](/windows/win32/api/bcrypt/ns-bcrypt-bcrypt_dh_key_blob)
+ [BCRYPT_DSA_KEY_BLOB](/windows/win32/api/bcrypt/ns-bcrypt-bcrypt_dsa_key_blob)
+ [BCRYPT_ECCKEY_BLOB](/windows/win32/api/bcrypt/ns-bcrypt-bcrypt_ecckey_blob)
+ [BCRYPT_KEY_BLOB](/windows/win32/api/bcrypt/ns-bcrypt-bcrypt_key_blob)
+ [BCRYPT_RSAKEY_BLOB](/windows/win32/api/bcrypt/ns-bcrypt-bcrypt_rsakey_blob)


### -field Capi1PublicKey:3
Microsoft public key format defined by the legacy Cryptography API (CAPI). For more information, see [Base Provider Key BLOBs](/windows/desktop/SecCrypto/base-provider-key-blobs).

### -field BCryptEccFullPublicKey:4
The key is a BCrypt full elliptic curve cryptography (ECC) private key.


## -remarks

## -examples

## -see-also