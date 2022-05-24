---
-api-id: E:Windows.UI.Xaml.Hosting.DesktopWindowXamlSource.TakeFocusRequested
-api-type: winrt event
ms.custom: RS5, 19H1
---

<!-- Event syntax.
public event TypedEventHandler TakeFocusRequested<DesktopWindowXamlSource, DesktopWindowXamlSourceTakeFocusRequestedEventArgs>
-->

# Windows.UI.Xaml.Hosting.DesktopWindowXamlSource.TakeFocusRequested

## -description
Occurs when the host desktop application receives a request take back focus from the [DesktopWindowXamlSource](desktopwindowxamlsource.md) object (for example, the user is on the last focusable element in the **DesktopWindowXamlSource** and presses **Tab**).


## -remarks
When you add a **DesktopWindowXamlSource** to your desktop application, by default the **DesktopWindowXamlSource** does not automatically handle focus navigation via keyboard events such as the **Tab** or arrow keys. Handle this event to programmatically give focus to the next focusable element in the host application when the user navigates away from the **DesktopWindowXamlSource**.

## -see-also

## -examples
