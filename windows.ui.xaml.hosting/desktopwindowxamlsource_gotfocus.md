---
-api-id: E:Windows.UI.Xaml.Hosting.DesktopWindowXamlSource.GotFocus
-api-type: winrt event
ms.custom: RS5
---

<!-- Event syntax.
public event TypedEventHandler GotFocus<DesktopWindowXamlSource, DesktopWindowXamlSourceGotFocusEventArgs>
-->

# Windows.UI.Xaml.Hosting.DesktopWindowXamlSource.GotFocus

## -description
Occurs when the [DesktopWindowXamlSource](desktopwindowxamlsource.md) gets focus in the desktop application (for example, the user presses the **Tab** key while focus is on the element just before the **DesktopWindowXamlSource**).

> [!NOTE]
> This API is currently available as a developer preview. Although we encourage you to try out this API in your own prototype code now, we do not recommend that you use it in production code at this time. This API will continue to mature and stabilize in future Windows releases. Microsoft makes no warranties, express or implied, with respect to the information provided here.

## -remarks
When you add a **DesktopWindowXamlSource** to your desktop application, by default the **DesktopWindowXamlSource** does not automatically handle focus navigation via keyboard events such as the **Tab** or arrow keys. Call the [NavigateFocus](desktopwindowxamlsource_navigatefocus_659659671.md) method to programmatically give focus when the user navigates to the **DesktopWindowXamlSource**.

Handle **GotFocus** event to be notified when user enters the **DesktopWindowXamlSource** via some non-keyboard event, such as a mouse click, and you want to keep the state of the UI in the host desktop application up to date.

## -see-also

## -examples
