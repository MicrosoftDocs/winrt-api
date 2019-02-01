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


+ [BCRYPT_DH_KEY_BLOB](https://msdn.microsoft.com/library/6004b2e5-7e06-4108-a0da-472b9b6d5fea)
+ [BCRYPT_DSA_KEY_BLOB](https://msdn.microsoft.com/library/3db36170-106e-49c8-9866-e25759bdd7f9)
+ [BCRYPT_ECCKEY_BLOB](https://msdn.microsoft.com/library/e60f6630-e4b0-4f35-a3cf-95dbcb007124)
+ [BCRYPT_KEY_BLOB](https://msdn.microsoft.com/library/ae7e8db3-858d-4573-afe1-c9bc14d76480)
+ [BCRYPT_RSAKEY_BLOB](https://msdn.microsoft.com/library/bbf3f4b9-5c69-4212-bb23-34bb2c84185c)


### -field Capi1PublicKey:3
Microsoft public key format defined by the legacy Cryptography API (CAPI). For more information, see [Base Provider Key BLOBs](https://msdn.microsoft.com/library/b4592036-0fa3-4b7e-beed-78cf1d2f39a9).

### -field BCryptEccFullPublicKey:4
The key is a BCrypt full elliptic curve cryptography (ECC) private key.


## -remarks

## -examples

## -see-also