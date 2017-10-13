---
-api-id: M:Windows.System.UserProfile.UserProfilePersonalizationSettings.TrySetWallpaperImageAsync(Windows.Storage.StorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TrySetWallpaperImageAsync(Windows.Storage.StorageFile imageFile)
-->

# Windows.System.UserProfile.UserProfilePersonalizationSettings.TrySetWallpaperImageAsync

## -description
Attempts to set the specified image file as the desktop wallpaper image.

## -parameters
### -param imageFile
The image to set as the desktop background.

## -returns
The result of the async operation.
**true** if the background image was set successfully; otherwise, **false**.

## -remarks



> [!NOTE]
> When you set an image more than once, the new image file must have a different name than the previously set image. If you set a new image using a file with the same name as the previous image, it will fail.

## -examples
```csharp
using Windows.System.UserProfile; 

// Pass in a relative path to a file inside the local appdata folder 
async Task<bool> SetWallpaperAsync(string localAppDataFileName) 
{ 
   bool success = false; 
   if (UserProfilePersonalizationSettings.IsSupported())       
   {
       var uri = new Uri("ms-appx:///Local/" + localAppDataFileName);
       StorageFile file = await StorageFile.GetFileFromApplicationUriAsync(uri);
       UserProfilePersonalizationSettings profileSettings = UserProfilePersonalizationSettings.Current;
       success = await profileSettings.TrySetWallpaperImageAsync(file);
   }
}

```



## -see-also
