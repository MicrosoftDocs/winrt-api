---
-api-id: T:Windows.UI.Notifications.ToastDismissalReason
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.UI.Notifications.ToastDismissalReason : int
-->

# ToastDismissalReason

## -description
Specifies the reason that a toast notification is no longer being shown. Used with [ToastDismissedEventArgs.Reason](toastdismissedeventargs_reason.md).

## -enum-fields
### -field UserCanceled:0
The user dismissed the toast notification.

### -field ApplicationHidden:1
The app explicitly hid the toast notification by calling the [ToastNotifier.hide](toastnotifier_hide_1807990681.md) method.

### -field TimedOut:2
The toast notification had been shown for the maximum allowed time and was faded out. The maximum time to show a toast notification is 7 seconds except in the case of long-duration toasts, in which case it is 25 seconds.


## -remarks

## -examples

## -see-also
[ToastDismissedEventArgs.Reason](toastdismissedeventargs_reason.md), [Toast notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Toast%20notifications%20sample), [Sending toast notifications from desktop apps sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Toast%20notifications%20sample), [Toast XML schema](/uwp/schemas/tiles/toastschema/schema-root), [Toast notification overview](/previous-versions/windows/apps/hh779727(v=win.10)), [Quickstart: Sending a toast notification](/previous-versions/windows/apps/hh465448(v=win.10)), [Quickstart: Sending a toast push notification](/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast notification from the desktop](/previous-versions/windows/desktop/legacy/hh802768(v=vs.85)), [Guidelines and checklist for toast notifications](/windows/uwp/controls-and-patterns/tiles-badges-notifications), [How to handle activation from a toast notification](/previous-versions/windows/apps/hh761468(v=win.10)), [How to opt in for toast notifications](/previous-versions/windows/apps/hh781238(v=win.10)), [How to schedule a toast notification](/previous-versions/windows/apps/hh465417(v=win.10)), [How to enable desktop toast notifications through an AppUserModelID](/previous-versions/windows/desktop/legacy/hh802762(v=vs.85)), [The toast template catalog](/previous-versions/windows/apps/hh761494(v=win.10)), [Toast audio options](/previous-versions/windows/apps/hh761492(v=win.10))
