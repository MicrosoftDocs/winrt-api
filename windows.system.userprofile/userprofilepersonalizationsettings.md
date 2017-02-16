---
-api-id: T:Windows.System.UserProfile.UserProfilePersonalizationSettings
-api-type: winrt class
---

<!-- Class syntax.
public class UserProfilePersonalizationSettings : Windows.System.UserProfile.IUserProfilePersonalizationSettings
-->

# Windows.System.UserProfile.UserProfilePersonalizationSettings

## -description
Provides properties and methods to manage the user's desktop wallpaper and lock screen background image.

## -remarks
To get an instance of this class, call the [Current](userprofilepersonalizationsettings_current.md) method.

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
