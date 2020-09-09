---
-api-id: M:Windows.Storage.PathIO.WriteTextAsync(System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction WriteTextAsync(System.String absolutePath, System.String contents)
-->

# Windows.Storage.PathIO.WriteTextAsync

## -description
Writes text to the file at the specified path or Uniform Resource Identifier (URI).

## -parameters
### -param absolutePath
The path of the file that the text is written to.

### -param contents
The text to write.

## -returns
No object or value is returned when this method completes.

## -remarks
This method attempts to automatically detect the encoding of a file based on the presence of byte order marks. If an encoding cannot be detected, the encoding specified by the caller in the method overload is used.

## -examples
This example shows you how to use [writeTextAsync(absolutePath, contents) to write some arbitrary text to a file at the path in `absoluteFilePath`, like this:

```javascript
Windows.Storage.FileIO.writeTextAsync(absoluteFilePath, "Swift as a shadow").then(function () {
    // Add code to do something after the text is written to the file
});
```

Although the writeTextAsync methods don't have a return value, you can still use [then](/previous-versions/windows/apps/br229728(v=win.10)) or [done](/previous-versions/windows/apps/hh701079(v=win.10)) to declare a function and perform additional tasks after the text is written to the file, as the sample shows.

## -see-also
[WriteTextAsync(String, String, UnicodeEncoding)](pathio_writetextasync_40541776.md)
