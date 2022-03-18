---
-api-id: P:Windows.Networking.Sockets.StreamSocketControl.NoDelay
-api-type: winrt property
---

<!-- Property syntax
public bool NoDelay { get;  set; }
-->

# Windows.Networking.Sockets.StreamSocketControl.NoDelay

## -description
A value that indicates whether the Nagle algorithm is used on a [StreamSocket](streamsocket.md) object.

## -property-value
A value that indicates whether the Nagle algorithm is used on the TCP connection of a [StreamSocket](streamsocket.md) object

## -remarks
The NoDelay property controls whether Nagle's algorithm is enabled or disabled on a [StreamSocket](streamsocket.md) object. The default value for the NoDelay property is **true**.

Nagle's algorithm is a technique to improving the efficiency of TCP/IP networks by reducing the number of packets that are needed to be sent over the network. The algorithm tries to deal with problems caused by an application that repeatedly emits data in small chunks. A TCP packet has a 40-byte header (20 bytes for IP and 20 bytes for TCP). So if an app sends only 4 bytes in a packet, the overhead on the packet data is very large. This can occur for a remote access protocol (telnet or secure shell, for example) where most key presses may generate only a single byte or two of data that is transmitted immediately. Over a slow link, many of these packets may be in transit over the network at the same time. Nagle's algorithm works by combining a number of small outgoing messages, and sending them all at once. When there is a sent packet for which the sender has received no acknowledgment, the sender keeps buffering output until it has a full packet's worth of output. This allows the output to be sent all at once. The impact of applying Nagle's algorithm is to increase the bandwidth at the expense of latency. A well-written app that buffers sends internally should not need to use Nagle's algorithm.

When this property is **true**, the [StreamSocket](streamsocket.md) will disable Nagle's algorithm on the TCP connection. This setting reduces the potential delays when sending small messages. When a [StreamSocket](streamsocket.md) is created, the default value for this property is **true**.

When this property is **false**, the [StreamSocket](streamsocket.md) will enable Nagle's algorithm on the TCP connection. This setting can increase the bandwidth at the expense of latency, but should only be used with caution. There are some adverse side effects possible when Nagle's algorithm is enabled and certain other TCP optimizations are also used.

This property may be set before the [StreamSocket](streamsocket.md) is connected. After the [StreamSocket](streamsocket.md) is connected, setting the property will result in an error.

This property sets the value of the **TCP_NODELAY** socket option on the TCP socket used by the [StreamSocket](streamsocket.md).

## -examples

## -see-also
[How to use advanced socket controls](/previous-versions/windows/apps/jj150598(v=win.10)), [StreamSocket](streamsocket.md)

## -capabilities
ID_CAP_NETWORKING [Windows Phone]
