---
-api-id: P:Windows.Networking.Sockets.MessageWebSocketControl.IgnorableServerCertificateErrors
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.Security.Cryptography.Certificates.ChainValidationResult> IgnorableServerCertificateErrors { get; }
-->

# Windows.Networking.Sockets.MessageWebSocketControl.IgnorableServerCertificateErrors

## -description
Gets a list of ignorable server certificate errors. Get this list and add [ChainValidationResult](../windows.security.cryptography.certificates/chainvalidationresult.md) values for server certificate errors that you wish to ignore during the secure WebSocket (**wss://** protocol) server certificate validation process.

## -property-value
A list of [ChainValidationResult](../windows.security.cryptography.certificates/chainvalidationresult.md) values indicating the server certificate errors to ignore when validating server certificates. By default, the list is empty, and all errors cause validation to fail.

## -remarks

## -examples
The following example demonstrates how to ignore the [ChainValidationResult.Untrusted](../windows.security.cryptography.certificates/chainvalidationresult.md) error when you are connecting to a server that uses a self-signed certificate. The code adds the appropriate value to the IgnorableServerCertificateErrors list before calling [ConnectAsync](messagewebsocket_connectasync_682685111.md) on the web socket. The server's self-signed certificate will not cause validation to fail, but other errors in validating the server certificate would still result in [ConnectAsync](messagewebsocket_connectasync_682685111.md) failing.

```csharp
            private async void CreateAndConnectWebSocket()
            {
                var myWebSocket = new MessageWebSocket();
                myWebSocket.Information.IgnorableServerCertificateErrors.Add(ChainValidationResult.Untrusted);
                
                ...
                
                await myWebSocket.ConnectAsync(new Uri("wss://contoso.com/wsendpoint1"));

            }

```



## -see-also
