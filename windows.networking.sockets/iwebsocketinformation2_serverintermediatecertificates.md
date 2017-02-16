---
-api-id: P:Windows.Networking.Sockets.IWebSocketInformation2.ServerIntermediateCertificates
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Security.Cryptography.Certificates.Certificate> ServerIntermediateCertificates { get; }
-->

# Windows.Networking.Sockets.IWebSocketInformation2.ServerIntermediateCertificates

## -description
Gets the intermediate certificates sent by the server during SSL negotiation when making an SSL connection with a WebSockets server.

## -property-value
The set of certificates sent by the server during SSL negotiation.

## -remarks
This property returns the intermediate server certificates used when making an SSL connection with a WebSockets server. These certificates are provided by the server during the SSL connection negotiation. The properties on the [Certificate](../windows.security.cryptography.certificates/certificate.md) objects in the returned vector can be used to get detailed information on the certificates.

By the time the list of intermediate certificates is available through this property, the SSL connection has already been established. If you wish to inspect the server certificates during the connection process in order to perform custom validation, you should register a handler for the appropriate [MessageWebSocket.ServerCustomValidationRequested](messagewebsocket_servercustomvalidationrequested.md) or [StreamWebSocket.ServerCustomValidationRequested](streamwebsocket_servercustomvalidationrequested.md) event, and perform your custom server validation in that handler, using the [WebSocketServerCustomValidationRequestedEventArgs](websocketservercustomvalidationrequestedeventargs.md) instance passed to your event handler to inspect the intermediate certificates.

## -examples

## -see-also
