---
-api-id: T:Windows.UI.Notifications.ToastNotification
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class ToastNotification : Windows.UI.Notifications.IToastNotification, Windows.UI.Notifications.IToastNotification2, Windows.UI.Notifications.IToastNotification3, Windows.UI.Notifications.IToastNotification4
-->

# Windows.UI.Notifications.ToastNotification

## -description
Defines the content, associated metadata and events, and expiration time of a toast notification.

## -remarks

For how-to guidance for implementing toast notifications in your app, see [Send a local toast notification from C# apps](/windows/apps/design/shell/tiles-and-notifications/send-local-toast).

Guidance for handling app activation for toast notifications:

- UWP Applications should use the [OnActivated](../windows.ui.xaml/application_onactivated_603737819.md) for handling toast activations.
- Starting with WinRT Build 19041, packaged apps (including packaged apps with external location) are able to use [ToastNotificationActionTrigger](../windows.applicationmodel.background/toastnotificationactiontrigger.md) for handling activations [for more details](/windows/uwp/launch-resume/create-and-register-a-winmain-background-task#add-the-support-code-to-instantiate-the-com-class).
- Desktop apps can use COM activation by following [Desktop - Send Local Toast](/windows/uwp/design/shell/tiles-and-notifications/send-local-toast-desktop?tabs=msix-sparse#step-1-install-the-notifications-library).
- If none of the activation options fit your application, follow the example in this document for properly using event handlers.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | NotificationMirroring |
| 1607 | 14393 | RemoteId |
| 1703 | 15063 | Data |
| 1703 | 15063 | Priority |
| 1903 | 18362 | ExpiresOnReboot |

## -see-also
[Toast notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Toast%20notifications%20sample), [Sending toast notifications from desktop apps sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Toast%20notifications%20sample), [Toast XML schema](/uwp/schemas/tiles/toastschema/schema-root), [Tiles, badges, and notifications](/windows/uwp/controls-and-patterns/tiles-badges-notifications), [Quickstart: Sending a toast notification](/previous-versions/windows/apps/hh465448(v=win.10)), [Quickstart: Sending a toast push notification](/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast notification from the desktop](/previous-versions/windows/desktop/legacy/hh802768(v=vs.85)), [Guidelines and checklist for toast notifications](/windows/uwp/controls-and-patterns/tiles-badges-notifications), [How to handle activation from a toast notification](/previous-versions/windows/apps/hh761468(v=win.10)), [How to opt in for toast notifications](/previous-versions/windows/apps/hh781238(v=win.10)), [How to schedule a toast notification](/previous-versions/windows/apps/hh465417(v=win.10)), [How to enable desktop toast notifications through an AppUserModelID](/previous-versions/windows/desktop/legacy/hh802762(v=vs.85)), [The toast template catalog](/previous-versions/windows/apps/hh761494(v=win.10)), [Toast audio options](/previous-versions/windows/apps/hh761492(v=win.10))
