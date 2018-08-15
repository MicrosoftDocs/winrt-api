---
-api-id: P:Windows.Networking.Sockets.StreamSocketInformation.ServerIntermediateCertificates
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Security.Cryptography.Certificates.Certificate> ServerIntermediateCertificates { get; }
-->

# Windows.Networking.Sockets.StreamSocketInformation.ServerIntermediateCertificates

## -description
Gets the intermediate certificates sent by the server during SSL negotiation when making an SSL connection with a [StreamSocket](streamsocket.md).

## -property-value
The set of certificates sent by the server during SSL negotiation.

## -remarks
This property returns the intermediate server certificates used when making an SSL connection with a [StreamSocket](streamsocket.md). These certificates are provided by the server during the SSL connection negotiation. The properties on the [Certificate](../windows.security.cryptography.certificates/certificate.md) objects in the returned vector can be used to get detailed information on the certificates.

This property can also be used to enforce stronger security than the default connection using the [Certificate](../windows.security.cryptography.certificates/certificate.md) objects returned. The [BuildChainAsync](../windows.security.cryptography.certificates/certificate_buildchainasync_1634621379.md) methods and other properties on the [Certificate](../windows.security.cryptography.certificates/certificate.md) objects and methods on the [CertificateChain](../windows.security.cryptography.certificates/certificatechain.md) object can be used when an app needs stronger security than the standard SSL negotiation.

## -examples

## -see-also
[How to use advanced socket controls ](http://msdn.microsoft.com/library/2e1071d8-a1c7-44c0-b93a-31a701d431c4), [How to use advanced socket controls ](http://msdn.microsoft.com/library/f2c5be73-3461-452e-a38f-d2ddef9b5682), [Supporting proximity and tapping](http://msdn.microsoft.com/library/84a30dcf-ef14-4a93-9e7c-7a3de867d46b), [BuildChainAsync](../windows.security.cryptography.certificates/certificate_buildchainasync_1634621379.md), [Certificate](../windows.security.cryptography.certificates/certificate.md), [CertificateChain](../windows.security.cryptography.certificates/certificatechain.md), [ServerCertificate](streamsocketinformation_servercertificate.md), [ServerCertificateErrorSeverity](streamsocketinformation_servercertificateerrorseverity.md), [ServerCertificateErrors](streamsocketinformation_servercertificateerrors.md), [StreamSocket](streamsocket.md)