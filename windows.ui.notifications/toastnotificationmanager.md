---
-api-id: T:Windows.UI.Notifications.ToastNotificationManager
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class ToastNotificationManager 
-->

# Windows.UI.Notifications.ToastNotificationManager

## -description
Creates [ToastNotifier](toastnotifier.md) objects that you use to raise toast notifications. This class also provides access to the XML content of the system-provided toast templates so that you can customize that content for use in your notifications.

## -remarks
### Sending toast notifications from desktop apps

Generally, sending a toast notification from a desktop app is the same as sending it from a UWP app. However, you should be aware of these differences and requirements: 
+ For a desktop app to display a toast, the app must have a shortcut on the Start screen.
+ The shortcut must have an [AppUserModelID](/windows/desktop/shell/appids).
+ Desktop apps cannot schedule a toast.

For more information, see these topics: 
+ [How to enable desktop toast notifications through an AppUserModelID](/previous-versions/windows/desktop/legacy/hh802762(v=vs.85))
+ [Quickstart: Sending a toast notification from the desktop](/previous-versions/windows/desktop/legacy/hh802768(v=vs.85))

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | ConfigureNotificationMirroring |
| 1607 | 14393 | GetForUser |
| 1703 | 15063 | GetDefault |

## -examples
The following example shows how to create and send a toast notification that includes text and images, including the use of the [GetTemplateContent](toastnotificationmanager_gettemplatecontent_687642458.md) and [CreateToastNotifier](toastnotificationmanager_createtoastnotifier_1346219381.md) methods.

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



## -see-also
[Toast notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Toast%20notifications%20sample), [Sending toast notifications from desktop apps sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Toast%20notifications%20sample), [Toast XML schema](/uwp/schemas/tiles/toastschema/schema-root), [Toast notification overview](/previous-versions/windows/apps/hh779727(v=win.10)), [Quickstart: Sending a toast notification](/previous-versions/windows/apps/hh465448(v=win.10)), [Quickstart: Sending a toast push notification](/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast notification from the desktop](/previous-versions/windows/desktop/legacy/hh802768(v=vs.85)), [Guidelines and checklist for toast notifications](/windows/uwp/controls-and-patterns/tiles-badges-notifications), [How to handle activation from a toast notification](/previous-versions/windows/apps/hh761468(v=win.10)), [How to opt in for toast notifications](/previous-versions/windows/apps/hh781238(v=win.10)), [How to schedule a toast notification](/previous-versions/windows/apps/hh465417(v=win.10)), [How to enable desktop toast notifications through an AppUserModelID](/previous-versions/windows/desktop/legacy/hh802762(v=vs.85)), [The toast template catalog](/previous-versions/windows/apps/hh761494(v=win.10)), [Toast audio options](/previous-versions/windows/apps/hh761492(v=win.10))
