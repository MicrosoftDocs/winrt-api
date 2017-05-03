---
-api-id: M:Windows.System.UserProfile.UserProfilePersonalizationSettings.TrySetLockScreenImageAsync(Windows.Storage.StorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TrySetLockScreenImageAsync(Windows.Storage.StorageFile imageFile)
-->

# Windows.System.UserProfile.UserProfilePersonalizationSettings.TrySetLockScreenImageAsync

## -description
Attempts to set the specified image file as the lock screen background image.

## -parameters
### -param imageFile
The image to set as the lock screen background.

## -returns
The result of the async operation.
**true** if the background image was set successfully; otherwise, **false**.

## -remarks
> [!NOTE]
> For the mobile device family, you can only set a lock screen image that is smaller than 2 megabyte (MB). Attempting to set a lock screen image that is larger fails, even though the async operation returns **true**.


<!--{annotation author="jimwalk" time="10/29/2015 3:12:04 PM"}This is the result of a bug, which might be fixed after TH2.-->


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
        success = await profileSettings.TrySetLockScreenImageAsync(file);
    }
    return success;
} 

```



## -see-also
