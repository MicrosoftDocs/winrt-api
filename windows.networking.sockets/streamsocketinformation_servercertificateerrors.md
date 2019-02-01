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
The [ServerCertificateErrors](streamsocketinformation_servercertificateerrors.md) property gets a vector of [ChainValidationResult](../windows.security.cryptography.certificates/chainvalidationresult.md) enumeration values of errors that occurred making an SSL connection with a [StreamSocket](streamsocket.md).

SSL server certificate errors should only be ignored in advanced scenarios. Disregarding server certificate errors may result in the loss of privacy or integrity of the content passed over the SSL session.

## -examples

## -see-also
[How to use advanced socket controls ](https://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls ](https://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [Supporting proximity and tapping](https://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [ChainValidationResult](../windows.security.cryptography.certificates/chainvalidationresult.md), [ServerCertificate](streamsocketinformation_servercertificate.md), [ServerCertificateErrorSeverity](streamsocketinformation_servercertificateerrorseverity.md), [ServerIntermediateCertificates](streamsocketinformation_serverintermediatecertificates.md), [SocketSslErrorSeverity](socketsslerrorseverity.md), [StreamSocketControl.IgnorableServerCertificateErrors](streamsocketcontrol_ignorableservercertificateerrors.md), [StreamSocket](streamsocket.md)
