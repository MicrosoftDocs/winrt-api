---
-api-id: T:Windows.System.UserProfile.SetAccountPictureResult
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.System.UserProfile.SetAccountPictureResult : int
-->

# SetAccountPictureResult

## -description
A result that is returned when you try to set the image for a user account.

This object is returned when you call [SetAccountPictureAsync](userinformation_setaccountpictureasync.md), [SetAccountPictureFromStreamAsync](userinformation_setaccountpicturefromstreamasync.md), [SetAccountPicturesAsync](userinformation_setaccountpicturesasync.md), and [SetAccountPicturesFromStreamAsync.](windows_system_userprofile.md)

## -enum-fields
### -field Success:0
Indicates the picture was successfully set.

### -field ChangeDisabled:1
Indicates that the picture was not set because the [AccountPictureChangeEnabled](userinformation_accountpicturechangeenabled.md) property is disabled, or the user cancelled the consent prompt.

### -field LargeOrDynamicError:2
Indicates that the picture was not set because the picture was too large.

### -field VideoFrameSizeError:3
Indicates that the video was not set because of its frame size was too large.

### -field FileSizeError:4
Indicates the picture was not set because the file size was too large.

### -field Failure:5
Indicates the picture or video was not set.


## -remarks

## -examples

## -see-also