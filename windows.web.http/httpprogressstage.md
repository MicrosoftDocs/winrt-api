---
-api-id: T:Windows.Web.Http.HttpProgressStage
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Web.Http.HttpProgressStage : int
-->

# HttpProgressStage

## -description
Indicates the step in the progress for an HTTP connection.

## -enum-fields
### -field None:0
A default value that should not be encountered.

### -field DetectingProxy:10
The system starts to detect a proxy.

This step may not occur depending on the system configuration.

### -field ResolvingName:20
The system is resolving the hostname for the HTTP connection.

This step may not occur if the hostname doesn't need to be resolved.

### -field ConnectingToServer:30
The socket used for the HTTP connection is connecting to the server.

### -field NegotiatingSsl:40
The HTTP connection to the server is negotiating SSL.

If the SSL negotiation fails, then this will be the last step that occurs on the HTTP connection.

### -field SendingHeaders:50
HTTP headers are being sent to the server.

### -field SendingContent:60
HTTP content is being sent to the server.

This step may not occur if there is no content to send.

### -field WaitingForResponse:70
The HTTP client is waiting for a response from the server.

### -field ReceivingHeaders:80
The HTTP client is receiving headers from the server.

### -field ReceivingContent:90
The HTTP client is receiving content from the server.


## -remarks
This enumeration value is a member of the [HttpProgress](httpprogress.md) structure returned by many of the asynchronous methods in the [Windows.Web.Http](windows_web_http.md) namespace. The enumeration values indicates steps in the progress for an HTTP connection.

Some steps are not taken depending on the system configuration and other factors.

## -examples

## -see-also