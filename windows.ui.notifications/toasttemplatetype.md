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
[The toast template catalog](/previous-versions/windows/apps/hh761494(v=win.10)), [ToastNotificationManager.getTemplateContent](toastnotificationmanager_gettemplatecontent_687642458.md), [Toast notifications sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Toast%20notifications%20sample), [Sending toast notifications from desktop apps sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/Toast%20notifications%20sample), [Toast XML schema](/uwp/schemas/tiles/toastschema/schema-root), [Toast notification overview](/previous-versions/windows/apps/hh779727(v=win.10)), [Quickstart: Sending a toast notification](/previous-versions/windows/apps/hh465448(v=win.10)), [Quickstart: Sending a toast push notification](/previous-versions/windows/apps/hh465450(v=win.10)), [Quickstart: Sending a toast notification from the desktop](/previous-versions/windows/desktop/legacy/hh802768(v=vs.85)), [Guidelines and checklist for toast notifications](/windows/uwp/controls-and-patterns/tiles-badges-notifications), [How to handle activation from a toast notification](/previous-versions/windows/apps/hh761468(v=win.10)), [How to opt in for toast notifications](/previous-versions/windows/apps/hh781238(v=win.10)), [How to schedule a toast notification](/previous-versions/windows/apps/hh465417(v=win.10)), [How to enable desktop toast notifications through an AppUserModelID](/previous-versions/windows/desktop/legacy/hh802762(v=vs.85)), [Toast audio options](/previous-versions/windows/apps/hh761492(v=win.10)), [Tile and toast image sizes](/previous-versions/windows/apps/hh781198(v=win.10))
