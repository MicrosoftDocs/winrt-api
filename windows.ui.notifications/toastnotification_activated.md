---
-api-id: E:Windows.UI.Notifications.ToastNotification.Activated
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler Activated<Windows.UI.Notifications.ToastNotification,  object>
-->

# Windows.UI.Notifications.ToastNotification.Activated

## -description
Occurs when user activates a toast notification through a click or touch. Apps that are running subscribe to this event.

## -remarks
In the case of toast raised by a desktop app, that app must subscribe to at least the Activated event so that it can handle the expected activation of the app from the toast when the user selects it.

## -examples

## -see-also
[Toast notifications sample](http://code.msdn.microsoft.com/windowsapps/toast-notifications-sample-52eeba29), [Sending toast notifications from desktop apps sample](http://code.msdn.microsoft.com/windowsapps/toast-notifications-sample-52eeba29), [Toast XML schema](https://docs.microsoft.com/uwp/schemas/tiles/toastschema/schema-root), [Tiles, badges, and notifications](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-badges-notifications), [Quickstart: Sending a toast notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465448(v=win.10)), [Quickstart: Sending a toast push notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast notification from the desktop](https://docs.microsoft.com/previous-versions/windows/desktop/legacy/hh802768(v=vs.85)), [Guidelines and checklist for toast notifications](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-badges-notifications), [How to handle activation from a toast notification](https://docs.microsoft.com/previous-versions/windows/apps/hh761468(v=win.10)), [How to opt in for toast notifications](https://docs.microsoft.com/previous-versions/windows/apps/hh781238(v=win.10)), [How to schedule a toast notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465417(v=win.10)), [How to enable desktop toast notifications through an AppUserModelID](https://docs.microsoft.com/previous-versions/windows/desktop/legacy/hh802762(v=vs.85)), [The toast template catalog](https://docs.microsoft.com/previous-versions/windows/apps/hh761494(v=win.10)), [Toast audio options](https://docs.microsoft.com/previous-versions/windows/apps/hh761492(v=win.10))
