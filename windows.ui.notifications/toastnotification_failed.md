---
-api-id: E:Windows.UI.Notifications.ToastNotification.Failed
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Failed<Windows.UI.Notifications.ToastNotification,  Windows.UI.Notifications.ToastFailedEventArgs>
-->

# Windows.UI.Notifications.ToastNotification.Failed

## -description
Occurs when an error is caused when Windows attempts to raise a toast notification. Apps that are running subscribe to this event.

## -remarks
The reason for the toast's failure can be found in the [ErrorCode](toastfailedeventargs_errorcode.md) property of the [ToastFailedEventArgs](toastfailedeventargs.md) parameter.

The most common failure that you'll see when you raise a toast is a [settings](notificationsetting.md) error, for instance a block on toast notifications for this user. We recommend that you call [ToastNotifier.Setting](toastnotifier_setting.md) before you call [Show](toastnotifier_show_184420709.md) instead of handling that situation through this event.

## -examples

## -see-also
[ToastFailedEventArgs](toastfailedeventargs.md), [Toast notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Toast%20notifications%20sample), [Sending toast notifications from desktop apps sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Toast%20notifications%20sample), [Toast XML schema](/uwp/schemas/tiles/toastschema/schema-root), [Tiles, badges, and notifications](/windows/uwp/controls-and-patterns/tiles-badges-notifications), [Quickstart: Sending a toast notification](/previous-versions/windows/apps/hh465448(v=win.10)), [Quickstart: Sending a toast push notification](/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast notification from the desktop](/previous-versions/windows/desktop/legacy/hh802768(v=vs.85)), [Guidelines and checklist for toast notifications](/windows/uwp/controls-and-patterns/tiles-badges-notifications), [How to handle activation from a toast notification](/previous-versions/windows/apps/hh761468(v=win.10)), [How to opt in for toast notifications](/previous-versions/windows/apps/hh781238(v=win.10)), [How to schedule a toast notification](/previous-versions/windows/apps/hh465417(v=win.10)), [How to enable desktop toast notifications through an AppUserModelID](/previous-versions/windows/desktop/legacy/hh802762(v=vs.85)), [The toast template catalog](/previous-versions/windows/apps/hh761494(v=win.10)), [Toast audio options](/previous-versions/windows/apps/hh761492(v=win.10))
