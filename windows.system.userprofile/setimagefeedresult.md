---
-api-id: T:Windows.System.UserProfile.SetImageFeedResult
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.System.UserProfile.SetImageFeedResult : int
-->

# SetImageFeedResult

## -description
Specifies the result of a call to [LockScreen.RequestSetImageFeedAsync](lockscreen_requestsetimagefeedasync_841630601.md)

## -enum-fields
### -field Success:0
The image feed was set successfully.

### -field ChangeDisabled:1
The feed was not set because the lock screen image slide show is disabled by group policy.

### -field UserCanceled:2
The operation was canceled by the user.


## -remarks

## -examples

## -see-also
[LockScreen](lockscreen.md)