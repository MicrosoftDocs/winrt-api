---
-api-id: P:Windows.UI.Notifications.ToastNotification.ExpirationTime
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.Foundation.DateTime> ExpirationTime { get;  set; }
-->

# Windows.UI.Notifications.ToastNotification.ExpirationTime

## -description
Gets or sets the time after which a toast notification should not be displayed.

## -property-value
The date and time after which the toast is no longer considered current or valid and should not be displayed.

## -remarks
Windows attempts to raise toast notifications immediately after you call [Show](toastnotifier_show_184420709.md), so this property is rarely used.

> For Windows Phone 8.x app: this property also causes the toast notification to be removed from the action center once the specified date and time is reached.

## -examples

## -see-also
[Toast notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Toast%20notifications%20sample), [Sending toast notifications from desktop apps sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Toast%20notifications%20sample), [Toast XML schema](/uwp/schemas/tiles/toastschema/schema-root), [Tiles, badges, and notifications](/windows/uwp/controls-and-patterns/tiles-badges-notifications), [Quickstart: Sending a toast notification](/previous-versions/windows/apps/hh465448(v=win.10)), [Quickstart: Sending a toast push notification](/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast notification from the desktop](/previous-versions/windows/desktop/legacy/hh802768(v=vs.85)), [Guidelines and checklist for toast notifications](/windows/uwp/controls-and-patterns/tiles-badges-notifications), [How to handle activation from a toast notification](/previous-versions/windows/apps/hh761468(v=win.10)), [How to opt in for toast notifications](/previous-versions/windows/apps/hh781238(v=win.10)), [How to schedule a toast notification](/previous-versions/windows/apps/hh465417(v=win.10)), [How to enable desktop toast notifications through an AppUserModelID](/previous-versions/windows/desktop/legacy/hh802762(v=vs.85)), [The toast template catalog](/previous-versions/windows/apps/hh761494(v=win.10)), [Toast audio options](/previous-versions/windows/apps/hh761492(v=win.10))
