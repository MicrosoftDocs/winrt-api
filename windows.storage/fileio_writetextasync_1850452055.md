---
-api-id: M:Windows.Storage.FileIO.WriteTextAsync(Windows.Storage.IStorageFile,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction WriteTextAsync(Windows.Storage.IStorageFile file, System.String contents)
-->

# Windows.Storage.FileIO.WriteTextAsync

## -description
Writes text to the specified file.

## -parameters
### -param file
The file that the text is written to.

### -param contents
The text to write.

## -returns
No object or value is returned when this method completes.

## -remarks
This method attempts to automatically detect the encoding of a file based on the presence of byte order marks. If an encoding cannot be detected, the encoding specified by the caller is used.

## -examples

## -see-also
[WriteTextAsync(IStorageFile, String, UnicodeEncoding)](fileio_writetextasync_857032733.md)