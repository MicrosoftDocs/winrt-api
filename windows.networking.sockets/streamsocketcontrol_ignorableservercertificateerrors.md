---
-api-id: P:Windows.Networking.Sockets.StreamSocketControl.IgnorableServerCertificateErrors
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Security.Cryptography.Certificates.ChainValidationResult> IgnorableServerCertificateErrors { get; }
-->

# Windows.Networking.Sockets.StreamSocketControl.IgnorableServerCertificateErrors

## -description
Get a vector of SSL server errors to ignore when making an SSL connection with a [StreamSocket](streamsocket.md).

## -property-value
A vector of SSL server errors to ignore.

## -remarks
The IgnorableServerCertificateErrors property gets a vector of [ChainValidationResult](../windows.security.cryptography.certificates/chainvalidationresult.md) enumeration values for the SSL server errors to ignore.

SSL server errors should only be ignored in advanced scenarios. Disregarding server certificate errors may result in the loss of privacy or integrity of the content passed over the SSL session.

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [ChainValidationResult](../windows.security.cryptography.certificates/chainvalidationresult.md), [ServerCertificate](streamsocketinformation_servercertificate.md), [ServerCertificateErrorSeverity](streamsocketinformation_servercertificateerrorseverity.md), [ServerCertificateErrors](streamsocketinformation_servercertificateerrors.md), [ServerIntermediateCertificates](streamsocketinformation_serverintermediatecertificates.md), [SocketSslErrorSeverity](socketsslerrorseverity.md), [StreamSocket](streamsocket.md)
