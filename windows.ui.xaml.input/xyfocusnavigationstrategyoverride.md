---
-api-id: T:Windows.UI.Xaml.Input.XYFocusNavigationStrategyOverride
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum XYFocusNavigationStrategyOverride : int 
-->

# Windows.UI.Xaml.Input.XYFocusNavigationStrategyOverride

## -description
Specifies how the XAML framework determines the target of an XY navigation.

Overrides [XYFocusNavigationStrategyMode](xyfocusnavigationstrategymode.md).

## -enum-fields
### -field None:0
No navigation override is applied. 

### -field Auto:1
The strategy is inherited from the elements ancestors. If all ancestors have a value of **Auto**, the fallback strategy is **Projection**. 

### -field Projection:2
Focus moves to the element that has the highest score determined by factors such as the direction of navigation and nearness to the primary axis.

### -field NavigationDirectionDistance:3
Focus moves to the nearest element on the primary axis.

### -field RectilinearDistance:4
Focus moves to the nearest element determined by the shortest 2D distance.

## -remarks
XY navigation is used to navigate a user interface (UI) with a gamepad, remote control, or keyboard directional arrows. For more info, see [Gamepad and remote control interactions](https://msdn.microsoft.com/windows/uwp/input-and-devices/gamepad-and-remote-interactions)

## -see-also
[Desiging for Xbox - XY focus navigation and interaction](https://msdn.microsoft.com/windows/uwp/input-and-devices/designing-for-tv#xy-focus-navigation-and-interaction)

## -examples

