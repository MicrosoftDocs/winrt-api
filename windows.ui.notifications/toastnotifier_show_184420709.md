---
-api-id: M:Windows.UI.Notifications.ToastNotifier.Show(Windows.UI.Notifications.ToastNotification)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Show(Windows.UI.Notifications.ToastNotification notification)
-->

# Windows.UI.Notifications.ToastNotifier.Show

## -description
Displays the specified toast notification.

## -parameters
### -param notification
The object that contains the content of the toast notification to display.

## -remarks

## -examples
The following example shows how to create and send a toast notification that includes text and images, including use of the [Show](toastnotifier_show.md) method.

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