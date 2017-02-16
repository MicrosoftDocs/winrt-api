---
-api-id: P:Windows.Networking.Sockets.StreamSocketInformation.ServerCertificateErrorSeverity
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Sockets.SocketSslErrorSeverity ServerCertificateErrorSeverity { get; }
-->

# Windows.Networking.Sockets.StreamSocketInformation.ServerCertificateErrorSeverity

## -description
Gets the category of an error that occurred making an SSL connection with a [StreamSocket](streamsocket.md).

## -property-value
The category of error on an SSL connection.

## -remarks
SSL server errors should only be ignored in advanced scenarios. Disregarding server certificate errors when the [ServerCertificateErrorSeverity](streamsocketinformation_servercertificateerrorseverity.md) property is either **Ignorable** or **Fatal** may result in the loss of privacy or integrity of the content passed over the SSL session.

## -examples

## -see-also
[How to use advanced socket controls ](http://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls ](http://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [Supporting proximity and tapping](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [ServerCertificate](streamsocketinformation_servercertificate.md), [ServerCertificateErrors](streamsocketinformation_servercertificateerrors.md), [ServerIntermediateCertificates](streamsocketinformation_serverintermediatecertificates.md), [SocketSslErrorSeverity](socketsslerrorseverity.md), [StreamSocket](streamsocket.md)