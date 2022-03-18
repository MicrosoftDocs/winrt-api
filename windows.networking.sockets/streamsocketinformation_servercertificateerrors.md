---
-api-id: P:Windows.Networking.Sockets.StreamSocketInformation.ServerCertificateErrors
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Security.Cryptography.Certificates.ChainValidationResult> ServerCertificateErrors { get; }
-->

# Windows.Networking.Sockets.StreamSocketInformation.ServerCertificateErrors

## -description
Gets the list of errors that occurred making an SSL connection with a [StreamSocket](streamsocket.md).

## -property-value
The list of errors that occurred making an SSL connection.

## -remarks
The ServerCertificateErrors property gets a vector of [ChainValidationResult](../windows.security.cryptography.certificates/chainvalidationresult.md) enumeration values of errors that occurred making an SSL connection with a [StreamSocket](streamsocket.md).

SSL server certificate errors should only be ignored in advanced scenarios. Disregarding server certificate errors may result in the loss of privacy or integrity of the content passed over the SSL session.

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [Supporting proximity and tapping](/previous-versions/windows/apps/hh465229(v=win.10)), [ChainValidationResult](../windows.security.cryptography.certificates/chainvalidationresult.md), [ServerCertificate](streamsocketinformation_servercertificate.md), [ServerCertificateErrorSeverity](streamsocketinformation_servercertificateerrorseverity.md), [ServerIntermediateCertificates](streamsocketinformation_serverintermediatecertificates.md), [SocketSslErrorSeverity](socketsslerrorseverity.md), [StreamSocketControl.IgnorableServerCertificateErrors](streamsocketcontrol_ignorableservercertificateerrors.md), [StreamSocket](streamsocket.md)
