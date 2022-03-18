---
-api-id: M:Windows.UI.Notifications.ToastNotificationManager.CreateToastNotifier(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Notifications.ToastNotifier CreateToastNotifier(System.String applicationId)
-->

# Windows.UI.Notifications.ToastNotificationManager.CreateToastNotifier

## -description
Creates and initializes a new instance of the [ToastNotification](toastnotification.md), bound to a specified app, usually another app in the same package.

## -parameters
### -param applicationId
The unique ID of the app.

> [!NOTE]
> You can't send a toast notification to a secondary tile, so this must be the ID of an app tile.

## -returns
The object you will use to send the toast notification to the tile.

## -remarks
The app identified by *applicationId* must belong to the same package as the caller.

Use this form of the method if your app uses a background voice-over-Internet protocol (VOIP) agent, to specify the app ID required to show a toast in that case.

### Sending toast notifications from desktop apps

Generally, sending a toast notification from a desktop app is the same as sending it from a UWP app. However, you should be aware of these differences and requirements: 
+ For a desktop app to display a toast, the app must have a shortcut on the Start screen.
+ The shortcut must have an [AppUserModelID](/windows/desktop/shell/appids).
+ Desktop apps cannot schedule a toast.


For more information, see these topics: 
+ [How to enable desktop toast notifications through an AppUserModelID](/previous-versions/windows/desktop/legacy/hh802762(v=vs.85))
+ [Quickstart: Sending a toast notification from the desktop](/previous-versions/windows/desktop/legacy/hh802768(v=vs.85))


## -examples

## -see-also
[CreateToastNotifier](toastnotificationmanager_createtoastnotifier_1346219381.md), [Toast notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Toast%20notifications%20sample), [Sending toast notifications from desktop apps sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Toast%20notifications%20sample), [Toast XML schema](/uwp/schemas/tiles/toastschema/schema-root), [Toast notification overview](/previous-versions/windows/apps/hh779727(v=win.10)), [Quickstart: Sending a toast notification](/previous-versions/windows/apps/hh465448(v=win.10)), [Quickstart: Sending a toast push notification](/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast notification from the desktop](/previous-versions/windows/desktop/legacy/hh802768(v=vs.85)), [Guidelines and checklist for toast notifications](/windows/uwp/controls-and-patterns/tiles-badges-notifications), [How to handle activation from a toast notification](/previous-versions/windows/apps/hh761468(v=win.10)), [How to opt in for toast notifications](/previous-versions/windows/apps/hh781238(v=win.10)), [How to schedule a toast notification](/previous-versions/windows/apps/hh465417(v=win.10)), [How to enable desktop toast notifications through an AppUserModelID](/previous-versions/windows/desktop/legacy/hh802762(v=vs.85)), [The toast template catalog](/previous-versions/windows/apps/hh761494(v=win.10)), [Toast audio options](/previous-versions/windows/apps/hh761492(v=win.10))
