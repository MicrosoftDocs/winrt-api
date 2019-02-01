---
-api-id: T:Windows.Storage.Streams.DataWriter
-api-type: winrt class
---

<!-- Class syntax.
public class DataWriter : Windows.Foundation.IClosable, Windows.Storage.Streams.IDataWriter
-->

# Windows.Storage.Streams.DataWriter

## -description

Writes data to an output stream.

## -remarks

Instances of DataWriter objects do not support concurrent writes. If an application concurrently writes or detaches a stream from a DataWriter instance that is being written to the call to the object will fail with the error HRESULT_FROM_WIN32(ERROR_INVALID_OPERATION).

## -examples

See the code example in the [DataReader](datareader.md) topic.

## -see-also

[Reading and writing data sample](https://go.microsoft.com/fwlink/p/?linkid=231581), [StreamSocket sample](https://go.microsoft.com/fwlink/p/?linkid=231543), [DataReader](datareader.md), [DataWriterStoreOperation](datawriterstoreoperation.md), [Serializing and deserializing data sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620535), [File access sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=619995), [DatagramSocket sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620534), [StreamSocket sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620609), [Custom USB device sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620530)
