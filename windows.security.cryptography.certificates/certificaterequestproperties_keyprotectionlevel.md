---
-api-id: P:Windows.Security.Cryptography.Certificates.CertificateRequestProperties.KeyProtectionLevel
-api-type: winrt property
---

<!-- Property syntax
public Windows.Security.Cryptography.Certificates.KeyProtectionLevel KeyProtectionLevel { get;  set; }
-->

# Windows.Security.Cryptography.Certificates.CertificateRequestProperties.KeyProtectionLevel

## -description
Gets or sets the level of strong key protection.

## -property-value
Strong key protection level.

## -remarks
The default [KeyProtectionLevel](keyprotectionlevel.md) value is **NoConsent**. By default, therefore, strong key protection is not specified.

## -examples


[!code-csharp[ShowProtectionLevel](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowProtectionLevel)]

## -see-also
