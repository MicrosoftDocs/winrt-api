---
-api-id: T:Windows.UI.Xaml.Controls.SwipeBehaviorOnInvoked
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum SwipeBehaviorOnInvoked : int 
-->

# Windows.UI.Xaml.Controls.SwipeBehaviorOnInvoked

## -description

Defines constants that specify how a [SwipeControl](swipecontrol.md) behaves after a command is invoked.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.SwipeBehaviorOnInvoked](/windows/winui/api/microsoft.ui.xaml.controls.swipebehavioroninvoked) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -enum-fields

### -field RemainOpen:2

The SwipeControl remains open after an item is invoked.

### -field Close:1

The SwipeControl closes after an item is invoked.

### -field Auto:0

In **Reveal** mode, the SwipeControl closes after an item is invoked. In **Execute** mode, the SwipeControl remains open.

## -remarks

## -see-also

[SwipeMode enumeration](swipemode.md), [SwipeItems.Mode property](swipeitems_mode.md), [SwipeItem.Invoked event](swipeitem_invoked.md), [SwipeControl class](swipecontrol.md)

## -examples
