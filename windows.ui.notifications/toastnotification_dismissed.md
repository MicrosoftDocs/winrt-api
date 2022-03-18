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
The following example shows how to listen for and handle the Dismissed event.

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
[ToastDismissedEventArgs](toastdismissedeventargs.md), [Toast notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Toast%20notifications%20sample), [Sending toast notifications from desktop apps sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Toast%20notifications%20sample), [Toast XML schema](/uwp/schemas/tiles/toastschema/schema-root), [Tiles, badges, and notifications](/windows/uwp/controls-and-patterns/tiles-badges-notifications), [Quickstart: Sending a toast notification](/previous-versions/windows/apps/hh465448(v=win.10)), [Quickstart: Sending a toast push notification](/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast notification from the desktop](/previous-versions/windows/desktop/legacy/hh802768(v=vs.85)), [Guidelines and checklist for toast notifications](/windows/uwp/controls-and-patterns/tiles-badges-notifications), [How to handle activation from a toast notification](/previous-versions/windows/apps/hh761468(v=win.10)), [How to opt in for toast notifications](/previous-versions/windows/apps/hh781238(v=win.10)), [How to schedule a toast notification](/previous-versions/windows/apps/hh465417(v=win.10)), [How to enable desktop toast notifications through an AppUserModelID](/previous-versions/windows/desktop/legacy/hh802762(v=vs.85)), [The toast template catalog](/previous-versions/windows/apps/hh761494(v=win.10)), [Toast audio options](/previous-versions/windows/apps/hh761492(v=win.10))
