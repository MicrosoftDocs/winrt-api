---
-api-id: P:Windows.Web.Http.HttpTransportInformation.ServerCertificateErrorSeverity
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Sockets.SocketSslErrorSeverity ServerCertificateErrorSeverity { get; }
-->

# Windows.Web.Http.HttpTransportInformation.ServerCertificateErrorSeverity

## -description
Gets the category of an error on an SSL connection.

## -property-value
The category of error on an SSL connection.

## -remarks
SSL server errors should only be ignored in advanced scenarios. Disregarding server certificate errors when the ServerCertificateErrorSeverity property is either **Ignorable** or **Fatal** may result in the loss of privacy or integrity of the content passed over the SSL session.

## -examples

## -see-also
[HttpBaseProtocolFilter.IgnorableServerCertificateErrors](../windows.web.http.filters/httpbaseprotocolfilter_ignorableservercertificateerrors.md), [ServerCertificate](httptransportinformation_servercertificate.md), [ServerCertificateErrors](httptransportinformation_servercertificateerrors.md), [ServerIntermediateCertificates](httptransportinformation_serverintermediatecertificates.md), [SocketSslErrorSeverity](../windows.networking.sockets/socketsslerrorseverity.md)
