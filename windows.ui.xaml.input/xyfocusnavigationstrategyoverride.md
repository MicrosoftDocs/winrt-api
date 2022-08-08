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

Overrides [XYFocusKeyboardNavigationStrategyMode](xyfocuskeyboardnavigationmode.md).


## -enum-fields
### -field None:0
No navigation override is applied. 

### -field Auto:1
Indicates that navigation strategy is inherited from the element's ancestors. If all ancestors have a value of **Auto**, the fallback strategy is **Projection**. 

### -field Projection:2
Indicates that focus moves to the first element encountered when projecting the edge of the currently focused element in the  direction of navigation.

> [!NOTE]
> Other factors, such as the previously focused element and proximity to the axis of the navigation direction, can influence the result.

<img alt="Focus navigation - projection" src="images/projection.png" />

*Focus moves from A to D on down navigation based on projection of the bottom edge of A*

### -field NavigationDirectionDistance:3
Indicates that focus moves to the element closest to the axis of the navigation direction.

The edge of the bounding rect corresponding to the navigation direction is extended and projected to identify candidate targets. The first element encountered is identified as the target. In the case of multiple candidates, the closest element is identified as the target. If there are still multiple candidates, the topmost/leftmost element is identified as the candidate.

<img alt="Focus navigation - distance" src="images/navigation-direction-distance.png" />

*Focus moves from A to C and then from C to B on down navigation*

### -field RectilinearDistance:4
Indicates that focus moves to the closest element based on the shortest 2D distance (Manhattan metric). 

This distance is calculated by adding the primary distance and the secondary distance of each potential candidate. In the case of a tie:
- The first element to the left is selected if the navigation direction is up or down
- The first element to the top is selected if the navigation direction is left or right

Here we show how focus moves from A to B based on rectilinear distance.

-   Distance (A, B, Down) = 10 + 0 = 10
-   Distance (A, C, Down) = 0 + 30 = 30
-   Distance (A, D, Down) 30 + 0 = 30

<img alt="Focus navigation - rectilinear distance" src="images/rectilinear-distance.png" />

*Focus moves from A to B based on rectilinear distance*

## -remarks
XY navigation is used to navigate a user interface (UI) with a gamepad, remote control, or keyboard directional arrows. For more info, see [Gamepad and remote control interactions](/windows/uwp/input-and-devices/gamepad-and-remote-interactions)

## -see-also

[XYFocusNavigationStrategy](xyfocusnavigationstrategy.md), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic), [Desiging for Xbox - XY focus navigation and interaction](/windows/uwp/input-and-devices/designing-for-tv)

## -examples
