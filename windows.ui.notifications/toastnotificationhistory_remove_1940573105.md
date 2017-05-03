---
-api-id: M:Windows.UI.Notifications.ToastNotificationHistory.Remove(System.String,System.String,System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Remove(System.String tag, System.String group, System.String applicationId)
-->

# Windows.UI.Notifications.ToastNotificationHistory.Remove

## -description
Removes an individual toast notification from action center, identified by the combination of tag label, group label and app ID.

## -parameters
### -param tag
The tag label of the toast notification to be removed.

### -param group
The group label of the toast notification to be removed.

### -param applicationId
The app ID of the app that sent the specified toast notification. This app must be part of the same app package as the app making this remove request.

## -remarks
You should use this overload to remove notifications for a specific app in your app package, as specified by the *applicationId* parameter. If your app only uses tags, you can pass in an empty string for the *group* parameter.

## -examples

## -see-also
[Remove(String, String)](toastnotificationhistory_remove_363671345.md), [Remove(String)](toastnotificationhistory_remove_1498489487.md)