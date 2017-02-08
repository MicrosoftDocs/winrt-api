---
-api-id: M:Windows.Storage.PathIO.WriteLinesAsync(System.String,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction WriteLinesAsync(System.String absolutePath, Windows.Foundation.Collections.IIterable<System.String> lines)
-->

# Windows.Storage.PathIO.WriteLinesAsync

## -description
Writes lines of text to the file at the specified path or Uniform Resource Identifier (URI).

## -parameters
### -param absolutePath
The path of the file that the lines are written to.

### -param lines
The list of text strings to append as lines.

## -returns
No object or value is returned when this method completes.

## -remarks
This method attempts to automatically detect the encoding of a file based on the presence of byte order marks. If an encoding cannot be detected, the encoding specified by the caller in the method overload is used.

## -examples

## -see-also
[WriteLinesAsync(String, IIterable(String), UnicodeEncoding)](pathio_writelinesasync_520140059.md)