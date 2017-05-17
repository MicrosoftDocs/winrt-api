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

## -see-also
[InputStreamOptions](inputstreamoptions.md)