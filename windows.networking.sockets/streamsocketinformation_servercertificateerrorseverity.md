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
SSL server errors should only be ignored in advanced scenarios. Disregarding server certificate errors when the ServerCertificateErrorSeverity property is either **Ignorable** or **Fatal** may result in the loss of privacy or integrity of the content passed over the SSL session.

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [Supporting proximity and tapping](/previous-versions/windows/apps/hh465229(v=win.10)), [ServerCertificate](streamsocketinformation_servercertificate.md), [ServerCertificateErrors](streamsocketinformation_servercertificateerrors.md), [ServerIntermediateCertificates](streamsocketinformation_serverintermediatecertificates.md), [SocketSslErrorSeverity](socketsslerrorseverity.md), [StreamSocket](streamsocket.md)
