---
-api-id: M:Windows.Storage.StorageFolder.GetThumbnailAsync(Windows.Storage.FileProperties.ThumbnailMode)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Storage.FileProperties.StorageItemThumbnail> GetThumbnailAsync(Windows.Storage.FileProperties.ThumbnailMode mode)
-->

# Windows.Storage.StorageFolder.GetThumbnailAsync

## -description
Gets a thumbnail image for the current folder, sized for the specified purpose of the thumbnail.

## -parameters
### -param mode
A value from the enumeration that describes the purpose of the thumbnail and determines how the thumbnail image is adjusted.

For guidance about choosing the best thumbnail mode, see [Guidelines and checklist for thumbnails](/windows/uwp/files/index).

## -returns
When this method completes successfully, it returns a [StorageItemThumbnail](../windows.storage.fileproperties/storageitemthumbnail.md) that represents the thumbnail image, or **null** if there is no thumbnail image associated with the folder.

## -remarks
For a sample that demonstrates the **GetThumbnailAsync** method, see [File and folder thumbnail sample](https://github.com/microsoft/Windows-universal-samples/tree/master/Samples/FileThumbnails).

For guidance about choosing the best thumbnail mode, see [Guidelines and checklist for thumbnails](/windows/uwp/files/index).

> The [StorageFolder.GetThumbnailAsync](storagefolder_getthumbnailasync_1511435522.md) method sometimes returns the default image of a folder. For Windows Phone 8.x app, this method ignores the current theme when it returns this default image. The image returned is always the image for the dark theme; that is, the folder is transparent with a white border. If you want to return the image for the light theme, you have to create your own image that's visible on a light background. Then you have to use conditional logic to check the active theme. If the active theme is the light theme, use a method other than [GetThumbnailAsync](storagefile_getthumbnailasync_1575071988.md) to retrieve your custom image.

## -examples
The following example gets a thumbnail image for the user's Pictures folder and displays the thumbnail in an [Image](../windows.ui.xaml.controls/image.md) control. This example also requests an image whose longest side is 64 pixels, and requests the image only if it's already cached on the device. The example assumes that there's an Image control named ImageControl on the current page.

Before you run the following example, enable the **Pictures Library** capability in the app manifest file.

```csharp
using Windows.Storage;
using Windows.Storage.FileProperties;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging; // For the Bitmap object.

// Get the user's Pictures folder.
// Enable the corresponding capability in the app manifest file.
StorageFolder picturesFolder = KnownFolders.PicturesLibrary;

// Get a thumbnail for the current folder.
StorageItemThumbnail thumb =
    await picturesFolder.GetThumbnailAsync(ThumbnailMode.SingleItem,
    64, ThumbnailOptions.ReturnOnlyIfCached);

// Display the thumbnail in an Image control
// named ImageControl on the current page.
BitmapImage bitmapImage = new BitmapImage();
bitmapImage.SetSource(thumb);
ImageControl.Source = bitmapImage;
```



## -see-also
[GetThumbnailAsync(ThumbnailMode, UInt32)](storagefolder_getthumbnailasync_1511435522.md), [GetThumbnailAsync(ThumbnailMode, UInt32, ThumbnailOptions)](storagefolder_getthumbnailasync_91362086.md)