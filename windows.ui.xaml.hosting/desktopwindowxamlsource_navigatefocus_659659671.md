---
-api-id: M:Windows.UI.Xaml.Hosting.DesktopWindowXamlSource.NavigateFocus(Windows.UI.Xaml.Hosting.XamlSourceFocusNavigationRequest)
-api-type: winrt method
ms.custom: RS5, 19H1
---

<!-- Method syntax.
public XamlSourceFocusNavigationResult DesktopWindowXamlSource.NavigateFocus(XamlSourceFocusNavigationRequest request)
-->

# Windows.UI.Xaml.Hosting.DesktopWindowXamlSource.NavigateFocus

## -description
Attempts to programmatically give focus to the [DesktopWindowXamlSource](desktopwindowxamlsource.md) in the desktop application.


## -parameters
### -param request
An object that specifies the reason and other optional info for the focus navigation.

## -returns
An object that provides data for the focus navigation request.

## -remarks
When you add a **DesktopWindowXamlSource** to your desktop application, by default the **DesktopWindowXamlSource** does not automatically handle focus navigation via keyboard events such as the **Tab** or arrow keys. Use this method in conjunction with the [GotFocus](desktopwindowxamlsource_gotfocus.md) event to programmatically give focus when the user navigates to the **DesktopWindowXamlSource**.

## -see-also

## -examples
