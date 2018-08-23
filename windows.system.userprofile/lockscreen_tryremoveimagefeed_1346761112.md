---
-api-id: M:Windows.System.UserProfile.LockScreen.TryRemoveImageFeed
-api-type: winrt method
---

<!-- Method syntax
public bool TryRemoveImageFeed()
-->

# Windows.System.UserProfile.LockScreen.TryRemoveImageFeed

## -description
Unregisters the image feed being used in the lock screen slideshow, stopping the slideshow. (Windows 8.1 only)

## -returns
**true** if the image feed was disabled; otherwise, **false**.

## -remarks
This image feed was registered through the [RequestSetImageFeedAsync](lockscreen_requestsetimagefeedasync_841630601.md) method.



> [!IMPORTANT]
> Using a Really Simple Syndication (RSS) feed as a lock screen image source is not supported on Windows 10. The method returns an expected result, but the lock screen slide show does not work due to changes to the Really Simple Syndication (RSS) feature in Windows 10.

## -examples

## -see-also
