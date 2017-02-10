---
-api-id: M:Windows.Storage.FileIO.ReadTextAsync(Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> ReadTextAsync(Windows.Storage.IStorageFile file)
-->

# Windows.Storage.FileIO.ReadTextAsync

## -description
Reads the contents of the specified file and returns text.

## -parameters
### -param file
The file to read.

## -returns
When this method completes successfully, it returns the contents of the file as a text string.

## -remarks
Any object that implements the [IStorageFile](istoragefile.md) interface may be passed to this method or its overload through the *file* parameter.

This method uses the character encoding of the specified file. If you want to specify different encoding, call [ReadTextAsync(IStorageFile, UnicodeEncoding)](fileio_readtextasync_1063800.md) instead.

## -examples

## -see-also
[ReadTextAsync(IStorageFile, UnicodeEncoding)](fileio_readtextasync_1063800.md)