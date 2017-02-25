---
-api-id: T:Windows.UI.Notifications.ToastTemplateType
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Notifications.ToastTemplateType : int
-->

# ToastTemplateType

## -description
Specifies the template to use in a toast notification.

## -enum-fields
### -field ToastImageAndText01:0
A large image and a single string wrapped across three lines of text. <img src="images/toast_6.png" alt="ToastImageAndText01 example" />

### -field ToastImageAndText02:1
A large image, one string of bold text on the first line, one string of regular text wrapped across the second and third lines. <img src="images/toast_7.png" alt="ToastImageAndText02 example" />

### -field ToastImageAndText03:2
A large image, one string of bold text wrapped across the first two lines, one string of regular text on the third line. <img src="images/toast_8.png" alt="ToastImageAndText03 example" />

### -field ToastImageAndText04:3
A large image, one string of bold text on the first line, one string of regular text on the second line, one string of regular text on the third line. <img src="images/ToastImageAndText04.png" alt="ToastImageAndText04 example" />

### -field ToastText01:4
A single string wrapped across three lines of text. <img src="images/toast_1.png" alt="ToastText01 example" />

### -field ToastText02:5
One string of bold text on the first line, one string of regular text wrapped across the second and third lines. <img src="images/toast_2.png" alt="ToastText02 example" />

### -field ToastText03:6
One string of bold text wrapped across the first and second lines, one string of regular text on the third line. <img src="images/toast_4.png" alt="ToastText03 example" />

### -field ToastText04:7
One string of bold text on the first line, one string of regular text on the second line, one string of regular text on the third line. <img src="images/toast_5.png" alt="ToastText04 example" />


## -remarks
> You can send any toast template to Windows Phone 8.1, but it will be rendered as a modified version of ToastText02, with no image, two text strings (both on the same line, the first string in bold), and the app's Square 150x150 logo. An example is shown here <img src="images/ToastText02Phone.png" alt="Example phone toast" />

## -examples

## -see-also
[The toast template catalog](http://msdn.microsoft.com/library/1a437614-4259-426b-8e3f-ca57368b2e7a), [ToastNotificationManager.getTemplateContent](toastnotificationmanager_gettemplatecontent.md), [Toast notifications sample](http://go.microsoft.com/fwlink/p/?linkid=231503), [Sending toast notifications from desktop apps sample](http://go.microsoft.com/fwlink/p/?linkid=231503), [Toast XML schema](XREF:TODO:toast.Schema_Root), [Toast notification overview](http://msdn.microsoft.com/library/14a07fce-d631-4bad-ab99-305b703713e6), [Quickstart: Sending a toast notification](http://msdn.microsoft.com/library/098df37c-4d40-4499-b809-ccb651da1cba), [Quickstart: Sending a toast push notification](http://msdn.microsoft.com/library/bb962e30-6c95-4186-8a0e-6683140e17c7), [Quickstart: Sending a toast notification from the desktop](http://msdn.microsoft.com/library/1d20ed75-e24a-4e60-91ab-cfcbe902a68e), [Guidelines and checklist for toast notifications](http://msdn.microsoft.com/library/002951e3-3d2d-454a-a0b7-daa5c1e7178a), [How to handle activation from a toast notification](http://msdn.microsoft.com/library/74ba3513-0a52-46a0-8769-ed58abe7c05a), [How to opt in for toast notifications](http://msdn.microsoft.com/library/809cdd36-6de1-4de0-88b2-62b46cafdb28), [How to schedule a toast notification](http://msdn.microsoft.com/library/18a09413-1679-4606-8175-346f4fe6a4f8), [How to enable desktop toast notifications through an AppUserModelID](http://msdn.microsoft.com/library/bb32cd0a-99e6-47dc-a913-39a7b3027314), [Toast audio options](http://msdn.microsoft.com/library/12185879-1f9b-4bdc-99e7-a6f2f62806cb), [Tile and toast image sizes](http://msdn.microsoft.com/library/af16123d-09dc-4f13-ba41-bca7cfff7d61)