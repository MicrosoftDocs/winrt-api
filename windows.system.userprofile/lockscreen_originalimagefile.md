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
[LockScreen.getImageStream](lockscreen_getimagestream.md), [LockScreen.setImageFileAsync](lockscreen_setimagefileasync.md), [LockScreen.setImageStreamAsync](lockscreen_setimagestreamasync.md), [Lock screen overview](http://msdn.microsoft.com/library/07fefb48-f55c-4ab7-8b68-a8aed11074fd), [Personalization app sample](http://go.microsoft.com/fwlink/p/?linkid=231592)