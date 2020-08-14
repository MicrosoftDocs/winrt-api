---
-api-id: M:Windows.Storage.Streams.DataReader.LoadAsync(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Streams.DataReaderLoadOperation LoadAsync(System.UInt32 count)
-->

# Windows.Storage.Streams.DataReader.LoadAsync

## -description
Loads data from the input stream.

## -parameters
### -param count
The count of bytes to load into the intermediate buffer.

## -returns
The asynchronous load data request.

## -remarks
The read operation can get more or fewer bytes depending on how the [InputStreamOptions](datareader_inputstreamoptions.md) property is set.

You will need to call this method to load the data before the data can be read from DataReader.

## -examples

Sample applications that use this method include [Serializing and deserializing data sample](/samples/microsoft/windows-universal-samples/datareaderwriter/), [3D Printing Sample](/samples/microsoft/windows-universal-samples/3dprinting/), [Bluetooth RFCOMM chat sample](/samples/microsoft/windows-universal-samples/bluetoothrfcommchat/), and [Compression sample](/samples/microsoft/windows-universal-samples/compression/).


## -see-also
[InputStreamOptions](inputstreamoptions.md), [Serializing and deserializing data sample](/samples/microsoft/windows-universal-samples/datareaderwriter/)