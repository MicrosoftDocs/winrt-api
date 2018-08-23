---
-api-id: M:Windows.UI.Notifications.ToastNotifier.Hide(Windows.UI.Notifications.ToastNotification)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Hide(Windows.UI.Notifications.ToastNotification notification)
-->

# Windows.UI.Notifications.ToastNotifier.Hide

## -description
Removes the specified toast notification from the screen.

## -parameters
### -param notification
The object that specifies the toast to hide.

## -remarks
Call [Hide](toastnotifier_hide_1807990681.md) if the situation or action that caused the app to raise the toast is no longer an issue. This method should only be called when the app is in the foreground.

> For Windows Phone 8.x app: this method also removes the toast notification from the action center.

## -examples

## -see-also