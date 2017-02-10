---
-api-id: M:Windows.Storage.StorageFile.GetFileFromApplicationUriAsync(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.StorageFile> GetFileFromApplicationUriAsync(Windows.Foundation.Uri uri)
-->

# Windows.Storage.StorageFile.GetFileFromApplicationUriAsync

## -description
Gets a [StorageFile](storagefile.md) object to represent the specified Uniform Resource Identifier (URI) app resource. For examples of sample URIs see [How to load file resources](http://msdn.microsoft.com/library/2fc07702-7022-44b7-8471-8d477a105fc5).

## -parameters
### -param uri
The Uniform Resource Identifier (URI) of the app resource to get a [StorageFile](storagefile.md) to represent.

## -returns
When this method completes, it returns a [StorageFile](storagefile.md) object that represents the Uniform Resource Identifier (URI) resource.

## -remarks
You can use this method to access your app's resources using either "ms-appx://" or "ms-appdata://"  Uniform Resource Identifier (URI).

## -examples
```javascript
var uri = new Windows.Foundation.Uri("ms-appx:///datafile.xml")
Windows.Storage.StorageFile.getFileFromApplicationUriAsync(uri).done( /* Your success and error handlers */ );
```



## -see-also
[How to load file resources](http://msdn.microsoft.com/library/2fc07702-7022-44b7-8471-8d477a105fc5)