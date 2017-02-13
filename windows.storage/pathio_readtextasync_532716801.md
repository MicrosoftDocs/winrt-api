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
This example shows you how to use [readTextAsync(absolutePath)](pathio_readtextasync_532716801.md) to read text from the file at the path in `absoluteFilePath` like this:

```javascript
Windows.Storage.PathIO.readTextAsync(absoluteFilePath).then(function (contents) {
    // Add code to process the text read from the file
});
```

You can use [then](http://msdn.microsoft.com/library/c63904fc-465b-4fd5-a1d6-e4fb200248e7) or [done](http://msdn.microsoft.com/library/9a5e6877-a2cf-421f-a91e-37d84ccb40da) to declare a function to capture and process the text that was read from the file. After the [readTextAsync](pathio_readtextasync.md) method completes, the text will be passed to this function as a [string](https://msdn.microsoft.com/library/system.string.aspx) object (`contents` in the example).

## -see-also
[ReadTextAsync(String, UnicodeEncoding)](pathio_readtextasync_829418789.md)