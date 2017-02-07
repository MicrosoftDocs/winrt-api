---
-api-id: T:Windows.UI.Xaml.Input.XYFocusNavigationStrategyMode
-api-type: winrt enumeration
---

<!-- Enumeration syntax.
public enum XYFocusNavigationStrategyMode : int {
	Auto = 0
	NavigationDirectionDistance = 2
	Projection = 1
	RectilinearDistance = 3
}
-->

# Windows.UI.Xaml.Input.XYFocusNavigationStrategyMode

## -description
Defines constants that specify how the XAML framework determines the target of an XY navigation.

## -enum-fields

### -field Auto:0
The strategy is inherited from the elements ancestors. If all ancestors have a value of **Auto**, the fallback strategy is **Projection**. 

### -field Projection:1
Focus moves to the element that has the highest score determined by factors such as the direction of navigation and nearness to the primary axis.

### -field NavigationDirectionDistance:2
Focus moves to the nearest element on the primary axis.

### -field RectilinearDistance:3
Focus moves to the nearest element determined by the shortest 2D distance.

## -remarks
This enumeration is used by these properties of [UIElement](../windows.ui.xaml/uielement.md):
- [XYFocusDownNavigationStrategy](../windows.ui.xaml/uielement_xyfocusdownnavigationstrategy.md)
- [XYFocusLeftNavigationStrategy](../windows.ui.xaml/uielement_xyfocusleftnavigationstrategy.md)
- [XYFocusRightNavigationStrategy](../windows.ui.xaml/uielement_xyfocusrightnavigationstrategy.md)
- [XYFocusUpNavigationStrategy](../windows.ui.xaml/uielement_xyfocusupnavigationstrategy.md)

XY navigation is used to navigate a user interface (UI) with a gamepad, remote control, or keyboard directional arrows. For more info, see [Gamepad and remote control interactions](https://msdn.microsoft.com/windows/uwp/input-and-devices/gamepad-and-remote-interactions)

## -see-also
[Desiging for Xbox - XY focus navigation and interaction](https://msdn.microsoft.com/windows/uwp/input-and-devices/designing-for-tv#xy-focus-navigation-and-interaction)

## -examples

