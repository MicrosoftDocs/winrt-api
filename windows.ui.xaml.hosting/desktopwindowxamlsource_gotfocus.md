---
-api-id: E:Windows.UI.Xaml.Hosting.DesktopWindowXamlSource.GotFocus
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler GotFocus<DesktopWindowXamlSource, DesktopWindowXamlSourceGotFocusEventArgs>
-->

# Windows.UI.Xaml.Hosting.DesktopWindowXamlSource.GotFocus

## -description
Occurs when the **DesktopWindowXamlSource** gets focus in the desktop application (for example, the user presses the **Tab** key while focus is on the element just before the **DesktopWindowXamlSource**).

## -remarks
When you add a **DesktopWindowXamlSource** to your desktop application, by default the **DesktopWindowXamlSource** does not automatically handle focus navigation via keyboard events such as the Tab or arrow keys. Handle this event in conjunction with the [NavigateFocus](desktopwindowxamlsource_navigatefocus.md) method to programmatically give focus when the user navigates to the **DesktopWindowXamlSource**. 

## -see-also

## -examples
