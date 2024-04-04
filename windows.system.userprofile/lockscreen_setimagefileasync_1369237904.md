---
-api-id: M:Windows.System.UserProfile.LockScreen.SetImageFileAsync(Windows.Storage.IStorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SetImageFileAsync(Windows.Storage.IStorageFile value)
-->

# Windows.System.UserProfile.LockScreen.SetImageFileAsync

## -description
Sets the lock screen image from a [StorageFile](../windows.storage/storagefile.md) object.

## -parameters
### -param value
The [StorageFile](../windows.storage/storagefile.md) object that contains the new image for the lock screen.

## -returns
The object used to set the image for the lock screen.

## -remarks
The SetImageFileAsync API is not supported when called from x86 Console Apps on x64 machines.

## -examples

## -see-also

[Lock screen personalization sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=620585), [LockScreen.getImageStream](lockscreen_getimagestream_155459607.md), [LockScreen.originalImageFile](lockscreen_originalimagefile.md), [LockScreen.setImageStreamAsync](lockscreen_setimagestreamasync_1444410973.md), [Lock screen overview](/previous-versions/windows/apps/hh779720(v=win.10))
