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
The following example shows how to create and send a toast notification that includes text and images, including use of the Show method.



```csharp
var notificationManager = ToastNotificationManager;
var template = ToastTemplateType.ToastImageAndText01;
var toastXml = notificationManager.GetTemplateContent(template);

var images = toastXml.GetElementsByTagName("image");
images[0].SetAttribute("src", "images/toastImageAndText.png");

var textNodes = toastXml.GetElementsByTagName("text");
textNodes[0].AppendChild(toastXml.CreateTextNode("Text input 1"));

var toast = new ToastNotification(toastXml);
notificationManager.CreateToastNotifier().Show(toast);
```



## -see-also

