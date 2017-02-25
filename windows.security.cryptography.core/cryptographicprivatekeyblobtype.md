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


+ [BCRYPT_DH_KEY_BLOB](http://msdn.microsoft.com/library/6004b2e5-7e06-4108-a0da-472b9b6d5fea)
+ [BCRYPT_DSA_KEY_BLOB](http://msdn.microsoft.com/library/3db36170-106e-49c8-9866-e25759bdd7f9)
+ [BCRYPT_ECCKEY_BLOB](http://msdn.microsoft.com/library/e60f6630-e4b0-4f35-a3cf-95dbcb007124)
+ [BCRYPT_KEY_BLOB](http://msdn.microsoft.com/library/ae7e8db3-858d-4573-afe1-c9bc14d76480)
+ [BCRYPT_RSAKEY_BLOB](http://msdn.microsoft.com/library/bbf3f4b9-5c69-4212-bb23-34bb2c84185c)


### -field Capi1PrivateKey:3
Microsoft private key format defined by the legacy Cryptography API (CAPI). For more information, see [Base Provider Key BLOBs](http://msdn.microsoft.com/library/b4592036-0fa3-4b7e-beed-78cf1d2f39a9).

### -field BCryptEccFullPrivateKey:4



## -remarks

## -examples

## -see-also