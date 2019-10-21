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
A desktop app must subscribe to at least the [Activated](toastnotification_activated.md) event to handle activation.

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



## -see-also
[Toast notifications sample](https://go.microsoft.com/fwlink/p/?linkid=231503), [Sending toast notifications from desktop apps sample](https://go.microsoft.com/fwlink/p/?linkid=231503), [Toast XML schema](https://docs.microsoft.com/uwp/schemas/tiles/toastschema/schema-root), [Tiles, badges, and notifications](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-badges-notifications), [Quickstart: Sending a toast notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465448(v=win.10)), [Quickstart: Sending a toast push notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast notification from the desktop](https://docs.microsoft.com/previous-versions/windows/desktop/legacy/hh802768(v=vs.85)), [Guidelines and checklist for toast notifications](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-badges-notifications), [How to handle activation from a toast notification](https://docs.microsoft.com/previous-versions/windows/apps/hh761468(v=win.10)), [How to opt in for toast notifications](https://docs.microsoft.com/previous-versions/windows/apps/hh781238(v=win.10)), [How to schedule a toast notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465417(v=win.10)), [How to enable desktop toast notifications through an AppUserModelID](https://docs.microsoft.com/previous-versions/windows/desktop/legacy/hh802762(v=vs.85)), [The toast template catalog](https://docs.microsoft.com/previous-versions/windows/apps/hh761494(v=win.10)), [Toast audio options](https://docs.microsoft.com/previous-versions/windows/apps/hh761492(v=win.10))
