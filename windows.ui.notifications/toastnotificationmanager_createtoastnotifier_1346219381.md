---
-api-id: M:Windows.UI.Notifications.ToastNotificationManager.CreateToastNotifier
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.UI.Notifications.ToastNotifier CreateToastNotifier()
-->

# Windows.UI.Notifications.ToastNotificationManager.CreateToastNotifier

## -description
Creates and initializes a new instance of the [ToastNotification](toastnotification.md), bound to the calling application, that lets you raise a toast notification to that app.

## -returns
The object you will use to send the toast notification to the app.

## -remarks
Do not use this overload when creating a toast notifier for a desktop app. Use [CreateToastNotifier(appID)](toastnotificationmanager_createtoastnotifier_163337301.md) to supply the required [AppUserModelID](https://docs.microsoft.com/windows/desktop/shell/appids).

If your app uses a background voice-over-Internet protocol (VOIP) agent, it must specify the app ID to show a toast. Use the [CreateToastNotifier(appID)](toastnotificationmanager_createtoastnotifier_163337301.md) method overload.

## -examples
The following example shows how to create and send a toast notification that includes text and images, including the use of the CreateToastNotifier method.

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
[CreateToastNotifier(String)](toastnotificationmanager_createtoastnotifier_163337301.md), [Toast notifications sample](http://code.msdn.microsoft.com/windowsapps/toast-notifications-sample-52eeba29), [Sending toast notifications from desktop apps sample](http://code.msdn.microsoft.com/windowsapps/toast-notifications-sample-52eeba29), [Toast XML schema](https://docs.microsoft.com/uwp/schemas/tiles/toastschema/schema-root), [Toast notification overview](https://docs.microsoft.com/previous-versions/windows/apps/hh779727(v=win.10)), [Quickstart: Sending a toast notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465448(v=win.10)), [Quickstart: Sending a toast push notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast notification from the desktop](https://docs.microsoft.com/previous-versions/windows/desktop/legacy/hh802768(v=vs.85)), [Guidelines and checklist for toast notifications](https://docs.microsoft.com/windows/uwp/controls-and-patterns/tiles-badges-notifications), [How to handle activation from a toast notification](https://docs.microsoft.com/previous-versions/windows/apps/hh761468(v=win.10)), [How to opt in for toast notifications](https://docs.microsoft.com/previous-versions/windows/apps/hh781238(v=win.10)), [How to schedule a toast notification](https://docs.microsoft.com/previous-versions/windows/apps/hh465417(v=win.10)), [How to enable desktop toast notifications through an AppUserModelID](https://docs.microsoft.com/previous-versions/windows/desktop/legacy/hh802762(v=vs.85)), [The toast template catalog](https://docs.microsoft.com/previous-versions/windows/apps/hh761494(v=win.10)), [Toast audio options](https://docs.microsoft.com/previous-versions/windows/apps/hh761492(v=win.10))
