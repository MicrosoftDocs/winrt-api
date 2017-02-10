---
-api-id: M:Windows.System.UserProfile.LockScreen.RequestSetImageFeedAsync(Windows.Foundation.Uri)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.System.UserProfile.SetImageFeedResult> RequestSetImageFeedAsync(Windows.Foundation.Uri syndicationFeedUri)
-->

# Windows.System.UserProfile.LockScreen.RequestSetImageFeedAsync

## -description
Registers an RSS image feed to be used as a lock screen slideshow. (Windows 8.1 only)

## -parameters
### -param syndicationFeedUri
The Uniform Resource Identifier (URI) of the RSS image feed.

## -returns
One of the [SetImageFeedResult](setimagefeedresult.md) values.

## -remarks
The slideshow can be stopped by calling [TryRemoveImageFeed](lockscreen_tryremoveimagefeed.md).



> [!IMPORTANT]
> Using a Really Simple Syndication (RSS) feed as a lock screen image source is not supported on Windows 10. The method returns an expected result, but the lock screen slide show does not work due to changes to the Really Simple Syndication (RSS) feature in Windows 10.

## -examples

## -see-also
