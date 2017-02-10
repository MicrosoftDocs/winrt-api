---
-api-id: P:Windows.Networking.Sockets.StreamWebSocketInformation.ServerCertificateErrorSeverity
-api-type: winrt property
---

<!-- Property syntax
public Windows.Networking.Sockets.SocketSslErrorSeverity ServerCertificateErrorSeverity { get; }
-->

# Windows.Networking.Sockets.StreamWebSocketInformation.ServerCertificateErrorSeverity

## -description
Gets the category of an error that occurred making an SSL connection with a StreamWebSocket server.

## -property-value
The category of error on an SSL connection.

## -remarks
SSL server errors should only be ignored in advanced scenarios. Disregarding server certificate errors when this property is either **Ignorable** or **Fatal** may result in the loss of privacy or integrity of the content passed over the SSL session.

## -examples

## -see-also
