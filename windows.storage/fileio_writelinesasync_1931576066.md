---
-api-id: M:Windows.Storage.FileIO.WriteLinesAsync(Windows.Storage.IStorageFile,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction WriteLinesAsync(Windows.Storage.IStorageFile file, Windows.Foundation.Collections.IIterable<System.String> lines)
-->

# Windows.Storage.FileIO.WriteLinesAsync

## -description
Writes lines of text to the specified file.

## -parameters
### -param file
The file that the lines are written to.

### -param lines
The list of text strings to write as lines.

## -returns
No object or value is returned when this method completes.

## -remarks
This method attempts to automatically detect the encoding of a file based on the presence of byte order marks. If an encoding cannot be detected, the encoding specified by the caller is used.

## -examples

## -see-also
[WriteLinesAsync(IStorageFile, IIterable(String), UnicodeEncoding)](fileio_writelinesasync_780100426.md)