---
-api-id: P:Windows.Networking.Sockets.WebSocketClosedEventArgs.Code
-api-type: winrt property
---

<!-- Property syntax
public ushort Code { get; }
-->

# Windows.Networking.Sockets.WebSocketClosedEventArgs.Code

## -description
Gets information about the reason that a WebSocket object was closed.

## -property-value
Status code indicating the reason for closure.

## -remarks
Status codes in the range 0-999 are not used.

Status codes in the range 1000-2999 are reserved for definition by the [WebSocket protocol](https://tools.ietf.org/html/rfc6455#section-7.4).

Status codes in the range 3000-3999 are reserved for use by libraries, frameworks, and applications. These status codes are registered directly with IANA. The interpretation of these codes is undefined by the WebSocket protocol.

Status codes in the range 4000-4999 are reserved for private use and cannot be registered. Such codes can be used by prior agreements between WebSocket applications. The interpretation of these codes is undefined by the WebSocket protocol.

## -examples

## -see-also
[WebSocketClosedEventArgs.Reason](websocketclosedeventargs_reason.md)
