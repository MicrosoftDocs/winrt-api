---
-api-id: T:Windows.UI.Xaml.Hosting.XamlSourceFocusNavigationReason
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum XamlSourceFocusNavigationReason : int
-->

# Windows.UI.Xaml.Hosting.XamlSourceFocusNavigationReason

## -description
Defines values that represent the reasons that the [Windows.UI.Xaml.UIElement](../windows.ui.xaml/uielement.md) got focus in a desktop application that uses a [DesktopWindowXamlSource](desktopwindowxamlsource.md) object to host XAML-based UI. The [XamlSourceFocusNavigationRequest.Reason](xamlsourcefocusnavigationrequest_reason.md) property returns one of these values.


## -enum-fields
### -field Up:8
The focus was set in response to the user navigating up by using a 4-direction navigation experience (for example, by using keyboard arrow keys).

### -field Right:9
The focus was set in response to the user navigating right by using a 4-direction navigation experience (for example, by using keyboard arrow keys).

### -field Restore:1
The focus was restored after a task switch, such as pressing **Alt** + **Tab**.

### -field Programmatic:0
The focus was set programmatically.

### -field Left:7
The focus was set in response to the user navigating left by using a 4-direction navigation experience (for example, by using keyboard arrow keys).

### -field Last:4
The focus was set in response to the user navigating to the previous element by using a bidirectional navigation experience (for example, by pressing **Shift-Tab**).

### -field First:3
The focus was set in response to the user navigating to the next element by using a bidirectional navigation experience (for example, by pressing **Tab**).

### -field Down:10
The focus was set in response to the user navigating down by using a 4-direction navigation experience (for example, by using keyboard arrow keys).

## -remarks

## -see-also

## -examples
