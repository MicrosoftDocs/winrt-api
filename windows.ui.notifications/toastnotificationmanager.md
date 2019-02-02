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
+ The shortcut must have an [AppUserModelID](https://msdn.microsoft.com/library/ebce2d99-6f20-4545-9f12-d79cd8d0828f).
+ Desktop apps cannot schedule a toast.


For more information, see these topics: 
+ [How to enable desktop toast notifications through an AppUserModelID](https://msdn.microsoft.com/library/bb32cd0a-99e6-47dc-a913-39a7b3027314)
+ [Quickstart: Sending a toast notification from the desktop](https://msdn.microsoft.com/library/1d20ed75-e24a-4e60-91ab-cfcbe902a68e)


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
[Toast notifications sample](https://go.microsoft.com/fwlink/p/?linkid=231503), [Sending toast notifications from desktop apps sample](https://go.microsoft.com/fwlink/p/?linkid=231503), [Toast XML schema](https://docs.microsoft.com/uwp/schemas/tiles/toastschema/schema-root), [Toast notification overview](https://msdn.microsoft.com/library/14a07fce-d631-4bad-ab99-305b703713e6), [Quickstart: Sending a toast notification](https://msdn.microsoft.com/library/098df37c-4d40-4499-b809-ccb651da1cba), [Quickstart: Sending a toast push notification](https://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [Quickstart: Sending a toast notification from the desktop](https://msdn.microsoft.com/library/1d20ed75-e24a-4e60-91ab-cfcbe902a68e), [Guidelines and checklist for toast notifications](https://msdn.microsoft.com/library/002951e3-3d2d-454a-a0b7-daa5c1e7178a), [How to handle activation from a toast notification](https://msdn.microsoft.com/library/74ba3513-0a52-46a0-8769-ed58abe7c05a), [How to opt in for toast notifications](https://msdn.microsoft.com/library/809cdd36-6de1-4de0-88b2-62b46cafdb28), [How to schedule a toast notification](https://msdn.microsoft.com/library/18a09413-1679-4606-8175-346f4fe6a4f8), [How to enable desktop toast notifications through an AppUserModelID](https://msdn.microsoft.com/library/bb32cd0a-99e6-47dc-a913-39a7b3027314), [The toast template catalog](https://msdn.microsoft.com/library/1a437614-4259-426b-8e3f-ca57368b2e7a), [Toast audio options](https://msdn.microsoft.com/library/12185879-1f9b-4bdc-99e7-a6f2f62806cb)
