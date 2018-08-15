---
-api-id: P:Windows.Web.Http.HttpTransportInformation.ServerIntermediateCertificates
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Security.Cryptography.Certificates.Certificate> ServerIntermediateCertificates { get; }
-->

# Windows.Web.Http.HttpTransportInformation.ServerIntermediateCertificates

## -description
Gets the intermediate certificates sent by the server during SSL negotiation on this [HttpTransportInformation](httptransportinformation.md) object.

## -property-value
The set of certificates sent by the server during SSL negotiation on this [HttpTransportInformation](httptransportinformation.md) object.

## -remarks
This property returns the intermediate server certificates used for an SSL connection. These certificates are provided by the server during the SSL connection negotiation. The properties on the [Certificate](../windows.security.cryptography.certificates/certificate.md) objects in the returned vector can be used to determine detailed information on the certificates.

This property can also be used to enforce stronger security than the default connection using the [Certificate](../windows.security.cryptography.certificates/certificate.md) objects returned. The [BuildChainAsync](../windows.security.cryptography.certificates/certificate_buildchainasync_1634621379.md) methods and other properties on the [Certificate](../windows.security.cryptography.certificates/certificate.md) objects and methods on the [CertificateChain](../windows.security.cryptography.certificates/certificatechain.md) object can be used when an app requires stronger security than the standard SSL negotiation.

## -examples

## -see-also
[BuildChainAsync](../windows.security.cryptography.certificates/certificate_buildchainasync_1634621379.md), [Certificate](../windows.security.cryptography.certificates/certificate.md), [HttpBaseProtocolFilter.IgnorableServerCertificateErrors](../windows.web.http.filters/httpbaseprotocolfilter_ignorableservercertificateerrors.md), [ServerCertificate](httptransportinformation_servercertificate.md), [ServerCertificateErrorSeverity](httptransportinformation_servercertificateerrorseverity.md), [ServerCertificateErrors](httptransportinformation_servercertificateerrors.md), [SocketSslErrorSeverity](../windows.networking.sockets/socketsslerrorseverity.md)