---
-api-id: M:Windows.Storage.StreamedFileDataRequest.WriteAsync(Windows.Storage.Streams.IBuffer)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperationWithProgress<uint, uint> WriteAsync(Windows.Storage.Streams.IBuffer buffer)
-->

# Windows.Storage.StreamedFileDataRequest.WriteAsync

## -description
Writes data from a buffer to the current stream.

## -parameters
### -param buffer
The buffer that contains the data to write.

## -returns
When this method completes, it returns the number of bytes (type [UInt32](/dotnet/api/system.uint32?view=dotnet-uwp-10.0&preserve-view=true)) that were written to the stream. If the app specifies a function to monitor progress, that function receives the number of bytes (type [UInt32](/dotnet/api/system.uint32?view=dotnet-uwp-10.0&preserve-view=true)) written so far.

## -remarks

## -examples

## -see-also
