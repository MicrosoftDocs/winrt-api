---
-api-id: M:Windows.ApplicationModel.Background.BackgroundExecutionManager.RequestAccessKindForModernStandbyAsync(Windows.ApplicationModel.Background.BackgroundAccessRequestKind,System.String)
-api-type: winrt method
---

# Windows.ApplicationModel.Background.BackgroundExecutionManager.RequestAccessKindForModernStandbyAsync(Windows.ApplicationModel.Background.BackgroundAccessRequestKind,System.String)

<!--
public static Windows.Foundation.IAsyncOperation<bool> RequestAccessKindForModernStandbyAsync (Windows.ApplicationModel.Background.BackgroundAccessRequestKind requestedAccess, string reason);
-->


## -description

Requests user consent to allow the app to perform the specified level of background activity in the background while the device is in connected standby mode. On the Desktop OS Edition this may present a prompt to the user for their consent.

## -parameters

### -param requestedAccess

A value from the [BackgroundAccessRequestKind](backgroundaccessrequestkind.md) enumeration specifying the requested type of background access.

### -param reason

The string to display in the prompt that the system will raise to the user to describe why the app is requesting to run in the background. For example, the string that appears after "The app says:"

## -returns

An asynchronous operation that returns a boolean value on completion. The value is true if the request was granted; otherwise, false.

## -remarks

## -see-also

## -examples


