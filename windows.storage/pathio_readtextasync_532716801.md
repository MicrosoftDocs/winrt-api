---
-api-id: M:Windows.Storage.PathIO.ReadTextAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<string> ReadTextAsync(System.String absolutePath)
-->

# Windows.Storage.PathIO.ReadTextAsync

## -description
Reads the contents of the file at the specified path or Uniform Resource Identifier (URI) and returns text.

## -parameters
### -param absolutePath
The path of the file to read.

## -returns
When this method completes successfully, it returns the contents of the file as a text string.

## -remarks

## -examples
This example shows you how to use readTextAsync(absolutePath) to read text from the file at the path in `absoluteFilePath` like this:

```javascript
Windows.Storage.PathIO.readTextAsync(absoluteFilePath).then(function (contents) {
    // Add code to process the text read from the file
});
```

You can use [then](https://docs.microsoft.com/previous-versions/windows/apps/br229728(v=win.10)) or [done](https://docs.microsoft.com/previous-versions/windows/apps/hh701079(v=win.10)) to declare a function to capture and process the text that was read from the file. After the readTextAsync method completes, the text will be passed to this function as a [string](https://docs.microsoft.com/dotnet/api/system.string?redirectedfrom=MSDN) object (`contents` in the example).

## -see-also
[ReadTextAsync(String, UnicodeEncoding)](pathio_readtextasync_829418789.md)
