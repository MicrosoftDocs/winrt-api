---
-api-id: P:Windows.Networking.Sockets.DatagramSocketControl.MulticastOnly
-api-type: winrt property
---

<!-- Property syntax
public bool MulticastOnly { get;  set; }
-->

# Windows.Networking.Sockets.DatagramSocketControl.MulticastOnly

## -description
Gets or sets a Boolean value that specifies whether the [DatagramSocket](datagramsocket.md) is able to coexist with other Win32 or WinRT multicast sockets bound to the same address/port.

## -property-value
Setting this property to **true** enables the [DatagramSocket](datagramsocket.md) instance to share its local port with any Win32 sockets that are bound using **SO_REUSEADDR/SO_REUSE_MULTICASTPORT**, and with any other **DatagramSocket** instances that have **MulticastOnly** set to true.

## -remarks

## -examples

## -see-also
[DatagramSocket sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DatagramSocket)
