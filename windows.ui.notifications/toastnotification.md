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
- Handling activation guidance
    - UWP Applications should use the [OnActivated](../windows.ui.xaml/application_onactivated_603737819.md) for handling toast activations.
    - Staring WinRT Build 19041, MSIX and Sparsed Sign Packaged applications are able to use [ToastNotificationActionTrigger](../windows.applicationmodel.background/toastnotificationactiontrigger.md) for handling activations [for more details](/windows/uwp/launch-resume/create-and-register-a-winmain-background-task#add-the-support-code-to-instantiate-the-com-class).
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

## -examples
The following example shows how to create and send a toast notification that includes text and images, including use of the [ToastNotification](toastnotification_toastnotification_93177318.md) constructor.

```javascript

var notifications = Windows.UI.Notifications;

// Get the toast notification manager for the current app.
var notificationManager = notifications.ToastNotificationManager;

// The getTemplateContent method returns a Windows.Data.Xml.Dom.XmlDocument object
// that contains the toast notification XML content.
var template = notifications.toastTemplateType.toastImageAndText01;
var toastXml = notificationManager.getTemplateContent(notifications.ToastTemplateType[template]);

// You can use the methods from the XML document to specify the required elements for the toast.
var images = toastXml.getElementsByTagName("image");
images[0].setAttribute("src", "images/toastImageAndText.png");

var textNodes = toastXml.getElementsByTagName("text");
textNodes.forEach(function (value, index) {
    var textNumber = index + 1;
    var text = "";
    for (var j = 0; j < 10; j++) {
        text += "Text input " + /*@static_cast(String)*/textNumber + " ";
    }
    value.appendChild(toastXml.createTextNode(text));
});

// Create a toast notification from the XML, then create a ToastNotifier object
// to send the toast.
var toast = new notifications.ToastNotification(toastXml);

notificationManager.createToastNotifier().show(toast);
```

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
**Using Event Handlers**

The following example shows how to add an event handler for toast activation on running desktop apps. ToastNotifications need to be persisted in a list to maintain a reference to the toast for later callbacks. A similar pattern can be followed for dismissed and expired toast events.
> [!IMPORTANT]
> Ensure event handlers are unsubscribed to when no longer needed to avoid memory leaks.

```csharp
class AppNotification
{
    protected List<ToastNotification> toastNotificationList = new List<ToastNotification>();

    public void SendToastNotification()
    {
        // Constructs the content
        ToastContent content = new ToastContentBuilder()
            .AddText("Firing Toast")
            .GetToastContent();

        // Creates the notification
        ToastNotification notification = new ToastNotification(content.GetXml());

        //Add an in memory event handler
        notification.Activated += ToastNotificationCallback_Activated;

        //Adds toast notification to list to persist toast
        toastNotificationList.Add(notification);

        //Sends the notification
        ToastNotificationManager.CreateToastNotifier().Show(notification);
    }

    private void ToastNotificationCallback_Activated(ToastNotification sender, object args)
    {
        //Handle Activation Here
    }

    ~AppNotification()
    {
        foreach(ToastNotification tn in toastNotificationList)
        {
            //Unsubscribe
            tn.Activated -= ToastNotificationCallback_Activated;
        }
        toastNotificationList.Clear();
    }
}
```


## -see-also
[Toast notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Toast%20notifications%20sample), [Sending toast notifications from desktop apps sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Toast%20notifications%20sample), [Toast XML schema](/uwp/schemas/tiles/toastschema/schema-root), [Tiles, badges, and notifications](/windows/uwp/controls-and-patterns/tiles-badges-notifications), [Quickstart: Sending a toast notification](/previous-versions/windows/apps/hh465448(v=win.10)), [Quickstart: Sending a toast push notification](/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast notification from the desktop](/previous-versions/windows/desktop/legacy/hh802768(v=vs.85)), [Guidelines and checklist for toast notifications](/windows/uwp/controls-and-patterns/tiles-badges-notifications), [How to handle activation from a toast notification](/previous-versions/windows/apps/hh761468(v=win.10)), [How to opt in for toast notifications](/previous-versions/windows/apps/hh781238(v=win.10)), [How to schedule a toast notification](/previous-versions/windows/apps/hh465417(v=win.10)), [How to enable desktop toast notifications through an AppUserModelID](/previous-versions/windows/desktop/legacy/hh802762(v=vs.85)), [The toast template catalog](/previous-versions/windows/apps/hh761494(v=win.10)), [Toast audio options](/previous-versions/windows/apps/hh761492(v=win.10))
