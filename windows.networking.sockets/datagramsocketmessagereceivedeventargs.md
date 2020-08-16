---
-api-id: T:Windows.Networking.Sockets.DatagramSocketMessageReceivedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class DatagramSocketMessageReceivedEventArgs : Windows.Networking.Sockets.IDatagramSocketMessageReceivedEventArgs
-->

# Windows.Networking.Sockets.DatagramSocketMessageReceivedEventArgs

## -description

Provides data for a [MessageReceived](datagramsocket_messagereceived.md) event on a [DatagramSocket](datagramsocket.md).

## -remarks

The DatagramSocketMessageReceivedEventArgs is used to receive data on a [DatagramSocket](datagramsocket.md) object.

The [DatagramSocket.BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md) or [DatagramSocket.BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md) method is used to bind a [DatagramSocket](datagramsocket.md) to a local service name or UDP port if a [DatagramSocket](datagramsocket.md) instance wants to listen and receive data. These methods are not needed if the [DatagramSocket](datagramsocket.md) is to be used only for sending data.

A [DatagramSocket.MessageReceived](datagramsocket_messagereceived.md) event occurs on a [DatagramSocket](datagramsocket.md) that has been bound to a local service name or UDP port when a message is received. A DatagramSocketMessageReceivedEventArgs instance is created when the [DatagramSocket.MessageReceived](datagramsocket_messagereceived.md) event occurs.

There are two primary methods to read data when a message has been received:

+ The [GetDataStream](datagramsocketmessagereceivedeventargs_getdatastream_1357691687.md) method returns a [Streams.IInputStream](../windows.storage.streams/iinputstream.md) object that represents a sequential stream of bytes in the received message. The app must then parse the received stream of bytes.
+ The [GetDataReader](datagramsocketmessagereceivedeventargs_getdatareader_509392724.md) method returns a [Streams.DataReader](../windows.storage.streams/datareader.md) object to read incoming data. The [Streams.DataReader](../windows.storage.streams/datareader.md) object has separate methods to read the data in a variety of formats including bytes, signed and unsigned integers, boolean values, single and double floating point numbers, strings, date time and time span values, GUIDs, and buffers. These methods can be used directly to parse the received message.

## -examples

## -see-also

[DatagramSocket](datagramsocket.md), [DatagramSocket.BindServiceNameAsync](datagramsocket_bindservicenameasync_440542334.md), [DatagramSocket.BindEndpointAsync](datagramsocket_bindendpointasync_1396029045.md), [DatagramSocket.MessageReceived](datagramsocket_messagereceived.md), [Streams.DataReader](../windows.storage.streams/datareader.md), [Streams.IInputStream](../windows.storage.streams/iinputstream.md), [DatagramSocket sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DatagramSocket), [DatagramSocket sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/DatagramSocket)

## -capabilities

ID_CAP_NETWORKING [Windows Phone]
