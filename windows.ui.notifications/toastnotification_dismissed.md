---
-api-id: E:Windows.UI.Notifications.ToastNotification.Dismissed
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Dismissed<Windows.UI.Notifications.ToastNotification,  Windows.UI.Notifications.ToastDismissedEventArgs>
-->

# Windows.UI.Notifications.ToastNotification.Dismissed

## -description
Occurs when a toast notification leaves the screen, either by expiring or being explicitly dismissed by the user. Apps that are running subscribe to this event.

## -remarks
The [ToastDismissalReason](toastdismissalreason.md) is included in the [ToastDismissedEventArgs](toastdismissedeventargs.md) parameter.

## -examples
The following example shows how to listen for and handle the [Dismissed](toastnotification_dismissed.md) event.

```javascript

var notifications = Windows.UI.Notifications;

yourToastNotification.addEventListener("dismissed", function (e) {
    switch (e.reason) {
        case notifications.ToastDismissalReason.applicationHidden:
            // The application hid the toast using ToastNotifier.hide.
            break;
        case notifications.ToastDismissalReason.userCanceled:
            // The user dismissed the toast.
            break;
        case notifications.ToastDismissalReason.timedOut:
            // The toast has expired.
            break;
    }
}
```



## -see-also
[ToastDismissedEventArgs](toastdismissedeventargs.md), [Toast notifications sample](https://go.microsoft.com/fwlink/p/?linkid=231503), [Sending toast notifications from desktop apps sample](https://go.microsoft.com/fwlink/p/?linkid=231503), [Toast XML schema](https://docs.microsoft.com/uwp/schemas/tiles/toastschema/schema-root), [Tiles, badges, and notifications](https://msdn.microsoft.com/library/48ee4328-7999-40c2-9354-7ea7d488c538), [Quickstart: Sending a toast notification](https://msdn.microsoft.com/library/098df37c-4d40-4499-b809-ccb651da1cba), [Quickstart: Sending a toast push notification](https://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [Quickstart: Sending a toast notification from the desktop](https://msdn.microsoft.com/library/1d20ed75-e24a-4e60-91ab-cfcbe902a68e), [Guidelines and checklist for toast notifications](https://msdn.microsoft.com/library/002951e3-3d2d-454a-a0b7-daa5c1e7178a), [How to handle activation from a toast notification](https://msdn.microsoft.com/library/74ba3513-0a52-46a0-8769-ed58abe7c05a), [How to opt in for toast notifications](https://msdn.microsoft.com/library/809cdd36-6de1-4de0-88b2-62b46cafdb28), [How to schedule a toast notification](https://msdn.microsoft.com/library/18a09413-1679-4606-8175-346f4fe6a4f8), [How to enable desktop toast notifications through an AppUserModelID](https://msdn.microsoft.com/library/bb32cd0a-99e6-47dc-a913-39a7b3027314), [The toast template catalog](https://msdn.microsoft.com/library/1a437614-4259-426b-8e3f-ca57368b2e7a), [Toast audio options](https://msdn.microsoft.com/library/12185879-1f9b-4bdc-99e7-a6f2f62806cb)
