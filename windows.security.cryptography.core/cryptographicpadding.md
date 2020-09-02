---
-api-id: T:Windows.Security.Cryptography.Core.CryptographicPadding
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Security.Cryptography.Core.CryptographicPadding : int
-->

# CryptographicPadding

## -description
Specifies a padding mode for asymmetric algorithm signature or encryption operations.

## -enum-fields
### -field None:0
Do not use padding.

### -field RsaOaep:1
Use the Optimal Asymmetric Encryption Padding (OAEP) scheme.

### -field RsaPkcs1V15:2
Use the standard padding scheme for public-key cryptography based on the RSA algorithm as defined in [RFC 3447](https://www.ietf.org/rfc/rfc3447.txt).

### -field RsaPss:3
Use the Probabilistic Signature Scheme (PSS) scheme.


## -remarks

## -examples

## -see-also
