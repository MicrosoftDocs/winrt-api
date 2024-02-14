---
-api-id: P:Windows.System.UserProfile.LockScreen.OriginalImageFile
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Uri OriginalImageFile { get; }
-->

# Windows.System.UserProfile.LockScreen.OriginalImageFile

## -description
Gets the current lock screen image.

## -property-value
The Uniform Resource Identifier (URI) of the lock screen image.

## -remarks
This property retrieves only files. If the image was set through a stream, this call will return E_FILE_NOT_FOUND.

## -examples

## -see-also
[LockScreen.getImageStream](lockscreen_getimagestream_155459607.md), [LockScreen.setImageFileAsync](lockscreen_setimagefileasync_1369237904.md), [LockScreen.setImageStreamAsync](lockscreen_setimagestreamasync_1444410973.md), [Lock screen overview](/previous-versions/windows/apps/hh779720(v=win.10)), [Lock screen personalization sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620585)
