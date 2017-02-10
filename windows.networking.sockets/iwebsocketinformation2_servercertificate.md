---
-api-id: P:Windows.Networking.Sockets.IWebSocketInformation2.ServerCertificate
-api-type: winrt property
---

<!-- Property syntax
public Windows.Security.Cryptography.Certificates.Certificate ServerCertificate { get; }
-->

# Windows.Networking.Sockets.IWebSocketInformation2.ServerCertificate

## -description
Gets the certificate provided by the server when a secure WebSocket connection has been established.

## -property-value
The server certificate.

## -remarks
By the time the server certificate is available through this property, the SSL connection has already been established.

If you wish to inspect the server certificate during the connection process in order to perform custom validation, you should register a handler for the appropriate [MessageWebSocket.ServerCustomValidationRequested](messagewebsocket_servercustomvalidationrequested.md) or [StreamWebSocket.ServerCustomValidationRequested](streamwebsocket_servercustomvalidationrequested.md) event, and perform your custom server validation in that handler.

If you merely wish to ignore certain classes of error when the server certificate is validated (for example, you are using a self-signed certificate and wish to ignore the validation error caused by this condition) you can use the [IgnorableServerCertificateErrors](iwebsocketcontrol2_ignorableservercertificateerrors.md) property to ignore the relevant classes of errors.

## -examples

## -see-also
