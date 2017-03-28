---
-api-id: P:Windows.Security.Cryptography.Certificates.CertificateRequestProperties.KeyUsages
-api-type: winrt property
---

<!-- Property syntax
public Windows.Security.Cryptography.Certificates.EnrollKeyUsages KeyUsages { get;  set; }
-->

# Windows.Security.Cryptography.Certificates.CertificateRequestProperties.KeyUsages

## -description
Gets or sets the operation that can be performed by the private key created for this certificate request. The default value is **Signing**.

## -property-value
Private key usage.

## -remarks
The default key usage value is **Signing**.

## -examples


[!code-csharp[ShowKeyUsages](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowKeyUsages)]

## -see-also
