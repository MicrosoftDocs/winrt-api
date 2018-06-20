---
-api-id: P:Windows.Networking.Sockets.StreamSocketControl.MinProtectionLevel
-api-type: winrt property
---

<!-- Property syntax.
public SocketProtectionLevel MinProtectionLevel { get;  set; }
-->

# Windows.Networking.Sockets.StreamSocketControl.MinProtectionLevel

## -description
Constrains the TLS protocol version that will be negotiated when the developer uses the ConnectAsync() or UpgradeToSslAsync() methods that require TLS.

## -property-value
A [SocketProtectionLevel](socketprotectionlevel.md) enumeration member indicating the socket protection level.

## -remarks
 When the server does not meet the TLS version specified by MinProtectionLevel, the corresponding ConnectAsync() and/or UpgradeToSslAsnc() execution will behave just as if the server does not support SSL or TLS. 

## -see-also
[StreamSocket](streamsocket.md), [SocketProtectionLevel](socketprotectionlevel.md)

## -examples
