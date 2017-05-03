---
-api-id: P:Windows.Security.Cryptography.Certificates.CertificateRequestProperties.Subject
-api-type: winrt property
---

<!-- Property syntax
public string Subject { get;  set; }
-->

# Windows.Security.Cryptography.Certificates.CertificateRequestProperties.Subject

## -description
Gets or sets the subject name.

## -property-value
The X.500 distinguished name (DN).

## -remarks
This value is an X.500 distinguished name (DN). This can be a full DN string that contains one or more relative distinguished names (RDNs) in the format of "CN=;OU=,..", or the subject name can be a simple string that contains the common name (CN) component of the full DN.

## -examples


[!code-csharp[ShowSubjectName](../windows.security.cryptography/code/crypto-snippets/cs/cryptosnippets.cs#ShowSubjectName)]

## -see-also
