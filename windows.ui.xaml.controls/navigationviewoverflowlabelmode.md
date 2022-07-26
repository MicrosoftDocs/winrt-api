---
-api-id: T:Windows.UI.Xaml.Controls.NavigationViewOverflowLabelMode
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum NavigationViewOverflowLabelMode : int 
-->

# Windows.UI.Xaml.Controls.NavigationViewOverflowLabelMode

## -description

Defines constants that specify the label for the overflow button in a NavigationView.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.NavigationViewOverflowLabelMode](/windows/winui/api/microsoft.ui.xaml.controls.navigationviewoverflowlabelmode) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -enum-fields

### -field NoLabel:1

No text label is shown, only a chevron.

### -field MoreLabel:0

The text label "More" is shown next to the chevron.

## -remarks

The overflow menu is shown only when [NavigationView.PaneDisplayMode](navigationviewpanedisplaymode.md) is **Top** and the window is not wide enough to show all navigation menu items.

## -see-also

## -examples

