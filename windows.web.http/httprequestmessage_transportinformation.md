---
-api-id: P:Windows.Web.Http.HttpRequestMessage.TransportInformation
-api-type: winrt property
---

<!-- Property syntax
public Windows.Web.Http.HttpTransportInformation TransportInformation { get; }
-->

# Windows.Web.Http.HttpRequestMessage.TransportInformation

## -description
Get information about the underlying transport socket used by an HTTP connection.

## -property-value
Information about the underlying transport socket used by an HTTP connection.

## -remarks
The primary use of the TransportInformation property is to get SSL information when SSL is used for the HTTP connection. This is commonly used to get the SSL certificate from the server or to view a list of errors that occurred when making an SSL connection.

## -examples

## -see-also
