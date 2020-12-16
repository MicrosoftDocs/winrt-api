---
-api-id: M:Windows.Storage.FileIO.ReadLinesAsync(Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVector<string>> ReadLinesAsync(Windows.Storage.IStorageFile file)
-->

# Windows.Storage.FileIO.ReadLinesAsync

## -description
Reads the contents of the specified file and returns lines of text.

## -parameters
### -param file
The file to read.

## -returns
When this method completes successfully, it returns the contents of the file as a list (type [IVector](../windows.foundation.collections/ivector_1.md)) of lines of text. Each line of text in the list is represented by a [String](/dotnet/api/system.string?view=dotnet-uwp-10.0&preserve-view=true) object.

## -remarks
This method uses the character encoding of the specified file. If you want to specify different encoding, call [ReadLinesAsync(IStorageFile, UnicodeEncoding)](fileio_readlinesasync_584387765.md) instead.

## -examples

## -see-also
[ReadLinesAsync(IStorageFile, UnicodeEncoding)](fileio_readlinesasync_584387765.md)