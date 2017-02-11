---
-api-id: P:Windows.Web.Http.HttpTransportInformation.ServerCertificate
-api-type: winrt property
---

<!-- Property syntax
public Windows.Security.Cryptography.Certificates.Certificate ServerCertificate { get; }
-->

# Windows.Web.Http.HttpTransportInformation.ServerCertificate

## -description
Gets the certificate from the server with the SSL information.

## -property-value
The certificate from the server with the SSL information.

## -remarks
This property gets the server certificate used for an SSL connection. This certificate is provided by the server during the SSL connection negotiation. The properties on the [Certificate](../windows.security.cryptography.certificates/certificate.md) object returned can be used to determine detailed information on the certificate.

This property is useful for notifying the user why an SSL connection failed.

This property can also be used to enforce stronger security than the default connection using the [Certificate](../windows.security.cryptography.certificates/certificate.md) object returned. The [BuildChainAsync](../windows.security.cryptography.certificates/certificate_buildchainasync.md) methods and other properties on the [Certificate](../windows.security.cryptography.certificates/certificate.md) object and methods on the [CertificateChain](../windows.security.cryptography.certificates/certificatechain.md) object can be used when an app requires stronger security than the standard SSL negotiation.

## -examples

## -see-also
[BuildChainAsync](../windows.security.cryptography.certificates/certificate_buildchainasync.md), [Certificate](../windows.security.cryptography.certificates/certificate.md), [HttpBaseProtocolFilter.IgnorableServerCertificateErrors](../windows.web.http.filters/httpbaseprotocolfilter_ignorableservercertificateerrors.md), [ServerCertificateErrorSeverity](httptransportinformation_servercertificateerrorseverity.md), [ServerCertificateErrors](httptransportinformation_servercertificateerrors.md), [ServerIntermediateCertificates](httptransportinformation_serverintermediatecertificates.md), [SocketSslErrorSeverity](../windows.networking.sockets/socketsslerrorseverity.md)