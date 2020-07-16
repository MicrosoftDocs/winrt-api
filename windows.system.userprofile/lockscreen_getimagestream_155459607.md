---
-api-id: M:Windows.System.UserProfile.LockScreen.GetImageStream
-api-type: winrt method
---

<!-- Method syntax
public Windows.Storage.Streams.IRandomAccessStream GetImageStream()
-->

# Windows.System.UserProfile.LockScreen.GetImageStream

## -description
Gets the current lock screen image as a data stream.

## -returns
The stream that contains the lock screen image data.

## -remarks
This method can be called only by apps that have set the "Picture Library Access" capability in the package manifest or by the app that set this image on the lock screen.

## -examples
The following example demonstrates this method being used to retrieve the current lock screen image. For a full sample, see the [Personalization app sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/blob/master/Official%20Windows%20Platform%20Sample/Windows%208%20app%20samples/%5BC%23%5D-Windows%208%20app%20samples/C%23/Windows%208%20app%20samples/Lock%20screen%20personalization%20sample%20(Windows%208)/C%23/Package.appxmanifest).

```csharp
IRandomAccessStream imageStream = LockScreen.GetImageStream();
```

```cppwinrt
Windows::Storage::Streams::IRandomAccessStream imageStream{
    Windows::System::UserProfile::LockScreen::GetImageStream()
};
```

```cppcx
auto imageStream = Windows::System::UserProfile::LockScreen::GetImageStream();
```

## -see-also
[LockScreen.originalImageFile](lockscreen_originalimagefile.md), [LockScreen.setImageFileAsync](lockscreen_setimagefileasync_1369237904.md), [LockScreen.setImageStreamAsync](lockscreen_setimagestreamasync_1444410973.md), [Lock screen overview](https://docs.microsoft.com/previous-versions/windows/apps/hh779720(v=win.10))
