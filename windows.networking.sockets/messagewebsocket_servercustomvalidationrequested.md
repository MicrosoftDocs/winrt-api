---
-api-id: E:Windows.Networking.Sockets.MessageWebSocket.ServerCustomValidationRequested
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ServerCustomValidationRequested<Windows.Networking.Sockets.MessageWebSocket,  Windows.Networking.Sockets.WebSocketServerCustomValidationRequestedEventArgs>
-->

# Windows.Networking.Sockets.MessageWebSocket.ServerCustomValidationRequested

## -description
Occurs when a new [MessageWebSocket](messagewebsocket.md) connection to a secured server URI (**wss:** protocol) is being validated. Handle this event if you want to implement custom server validation for the connection.

## -remarks
Note that this event is raised after the default OS validation has been performed successfully, and that the default OS validation includes taking the [IgnorableServerCertificateErrors](messagewebsocketcontrol_ignorableservercertificateerrors.md) control option into account.

Use the [WebSocketServerCustomValidationRequestedEventArgs](websocketservercustomvalidationrequestedeventargs.md) properties to access the server certificate and intermediate certificates being offered for validation.

In order to ensure proper completion, if your custom validation process involves any async operations, be sure to use the [WebSocketServerCustomValidationRequestedEventArgs.GetDeferral](websocketservercustomvalidationrequestedeventargs_getdeferral.md) method to get a deferral object that your event handler holds for the duration of the validation operation. When your validation is complete, you must call [Deferral.Complete](../windows.foundation/deferral_complete.md) whether you accept or reject validation.

As an example of the kind of validation you can do in this event handler: you could compare the server certificate to a locally stored trusted certificate that matches the expected server certificate. In your event handler, you would compare the SHA-256 hash of the local certificate to the hash of the server certificate. If the hash values match, then the certificates are assumed to match, and server validation should succeed. If the hash values don't match, then the certificates don't match and validation should fail.

To indicate validation failure, call the [WebSocketServerCustomValidationRequestedEventArgs.Reject](websocketservercustomvalidationrequestedeventargs_reject.md) method. To indicate validation success, simply return from the event handler.

Note that whether validation succeeds or fails, you must call [Deferral.Complete](../windows.foundation/deferral_complete.md) on the deferral object you acquired when you started the validation process.

## -examples

## -see-also
