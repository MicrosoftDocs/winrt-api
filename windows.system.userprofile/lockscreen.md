---
-api-id: T:Windows.System.UserProfile.LockScreen
-api-type: winrt class
---

<!-- Class syntax.
public class LockScreen 
-->

# Windows.System.UserProfile.LockScreen

## -description

Provides properties and methods to manage the full-screen image used as the lock screen background.

## -remarks

## -examples

This example uses the [SetImageFileAsync](lockscreen_setimagefileasync_1369237904.md) method of this class to set the lock screen image. The variable *file* is assumed to be a previously assigned image.

```csharp
Windows.System.UserProfile.LockScreen.SetImageFileAsync(file);
```

```cppwinrt
Windows::Foundation::IAsyncAction MainPage::ExampleCoroutineAsync(Windows::Storage::StorageFile const& file)
{
    co_await Windows::System::UserProfile::LockScreen::SetImageFileAsync(file);
}
```

```cpp
using namespace Windows::System::UserProfile;
LockScreen::SetImageFileAsync(file)
```

```javascript
Windows.System.UserProfile.LockScreen.setImageFileAsync(file);
```

This example uses the [GetImageStream](lockscreen_getimagestream_155459607.md) method of this class to retrieve the lock screen image.

```csharp
IRandomAccessStream imageStream = LockScreen.GetImageStream();
```

```cppwinrt
Windows::Storage::Streams::IRandomAccessStream imageStream{
    Windows::System::UserProfile::LockScreen::GetImageStream()
};
```

```cpp
auto imageStream = Windows::System::UserProfile::LockScreen::GetImageStream();
```

## -see-also

[Lock screen overview](http://msdn.microsoft.com/library/07fefb48-f55c-4ab7-8b68-a8aed11074fd), [Personalization app sample](http://go.microsoft.com/fwlink/p/?linkid=231592), [Lock screen personalization sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620585)