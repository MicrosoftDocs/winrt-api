---
-api-id: T:Windows.UI.Xaml.Input.XYFocusNavigationStrategy
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum XYFocusNavigationStrategy : int 
-->

# Windows.UI.Xaml.Input.XYFocusNavigationStrategy

## -description
Specifies the disambiguation strategy used for navigating between multiple candidate targets using [XYFocusDownNavigationStrategy](../windows.ui.xaml/uielement_xyfocusdownnavigationstrategy.md), [XYFocusLeftNavigationStrategy](../windows.ui.xaml/uielement_xyfocusleftnavigationstrategy.md), [XYFocusRightNavigationStrategy](../windows.ui.xaml/uielement_xyfocusrightnavigationstrategy.md), and [XYFocusUpNavigationStrategy](../windows.ui.xaml/uielement_xyfocusupnavigationstrategy.md). 

> [!NOTE]
> Other factors, such as the previously focused element or proximity to the axis of the navigation direction, can influence the navigation end result.


## -enum-fields
### -field Auto:0
Indicates that navigation strategy is inherited from the element's ancestors. If all ancestors have a value of **Auto**, the fallback strategy is **Projection**. 

### -field Projection:1
Indicates that focus moves to the first element encountered when projecting the edge of the currently focused element in the direction of navigation.

<img alt="Focus navigation - projection" src="images/projection.png" />

*Focus moves from A to D on down navigation based on projection of the bottom edge of A*

### -field NavigationDirectionDistance:2
Indicates that focus moves to the element closest to the axis of the navigation direction.

The edge of the bounding rect corresponding to the navigation direction is *extended* and *projected* to identify candidate targets. The first element encountered is identified as the target. In the case of multiple candidates, the closest element is identified as the target. If there are still multiple candidates, the topmost/leftmost element is identified as the candidate.

<img alt="Focus navigation - distance" src="images/navigation-direction-distance.png" />

*Focus moves from A to C and then from C to B on down navigation*

### -field RectilinearDistance:3
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

## -examples

## -see-also

[XYFocusNavigationStrategyOverride](xyfocusnavigationstrategyoverride.md), [Programmatic focus navigation](/windows/apps/design/input/focus-navigation-programmatic), [Desiging for Xbox - XY focus navigation and interaction](/windows/uwp/input-and-devices/designing-for-tv)
