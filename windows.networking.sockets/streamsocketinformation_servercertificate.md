---
-api-id: P:Windows.Networking.Sockets.StreamSocketInformation.ServerCertificate
-api-type: winrt property
---

<!-- Property syntax
public Windows.Security.Cryptography.Certificates.Certificate ServerCertificate { get; }
-->

# Windows.Networking.Sockets.StreamSocketInformation.ServerCertificate

## -description
Gets the certificate from the server when making an SSL connection with a [StreamSocket](streamsocket.md).

## -property-value
The certificate from the server with the SSL information.

## -remarks
This property gets the server certificate used for an SSL connection when connecting with a [StreamSocket](streamsocket.md). This certificate is provided by the server during the SSL connection negotiation. The properties on the [Certificate](../windows.security.cryptography.certificates/certificate.md) object returned can be used to get detailed information on the certificate.

This property is useful for notifying the user why an SSL connection failed.

This property can also be used to enforce stronger security than the default connection using the [Certificate](../windows.security.cryptography.certificates/certificate.md) object returned. The [BuildChainAsync](../windows.security.cryptography.certificates/certificate_buildchainasync_1634621379.md) methods and other properties on the [Certificate](../windows.security.cryptography.certificates/certificate.md) object and methods on the [CertificateChain](../windows.security.cryptography.certificates/certificatechain.md) object can be used when an app needs stronger security than the standard SSL negotiation.

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [Supporting proximity and tapping](/previous-versions/windows/apps/hh465229(v=win.10)), [BuildChainAsync](../windows.security.cryptography.certificates/certificate_buildchainasync_1634621379.md), [Certificate](../windows.security.cryptography.certificates/certificate.md), [CertificateChain](../windows.security.cryptography.certificates/certificatechain.md), [StreamSocketControl.IgnorableServerCertificateErrors](streamsocketcontrol_ignorableservercertificateerrors.md), [ServerCertificateErrorSeverity](streamsocketinformation_servercertificateerrorseverity.md), [ServerCertificateErrors](streamsocketinformation_servercertificateerrors.md), [ServerIntermediateCertificates](streamsocketinformation_serverintermediatecertificates.md), [SocketSslErrorSeverity](socketsslerrorseverity.md), [StreamSocket](streamsocket.md)
