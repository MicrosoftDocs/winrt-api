---
-api-id: T:Windows.UI.Input.Spatial.SpatialGestureSettings
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Spatial.SpatialGestureSettings : uint
-->

# SpatialGestureSettings

## -description
This enumeration represents the set of gestures that may be recognized by a [SpatialGestureRecognizer](spatialgesturerecognizer.md).

## -enum-fields
### -field None:0
Disable support for gestures.

### -field Tap:1
Enable support for the tap gesture.

This represents either an air tap with a hand (finger press followed by finger release), saying the word "Select" with your voice, or pressing and releasing the Select trigger or button on a controller.

This gesture can be used to activate the hologram or other object that the user is looking at.

Handle the Tapped event to react to this gesture.

### -field DoubleTap:2
Enable support for the double-tap gesture.

This represents two quick air taps with a hand (finger press followed by finger release) or two quick presses and releases of the Select trigger or button on a controller.

Handle the Tapped event and check that TapCount is 2 to react to this gesture.

### -field Hold:4
Enable support for the hold gesture.

This represents the user holding down either their finger or the Select trigger or button on a spatial controller for longer than the system's hold threshold.

This gesture can be used to take a secondary action, such as showing a menu.

Handle the HoldStarted, HoldCompleted and/or HoldCanceled events to react to this gesture.

### -field ManipulationTranslate:8
Enable support for the manipulation gesture, tracking changes to the hand's position.

This represents the user holding down their finger and moving their hand around in the world.

This gesture can be used to move, resize or rotate a hologram when you want the hologram to react 1:1 to the user's hand movements. This can also be used to draw new holograms in the world.

Handle the ManipulationStarted, ManipulationUpdated, ManipulationCompleted and/or ManipulationCanceled events to react to this gesture.

### -field NavigationX:16
Enable support for the navigation gesture, in the horizontal axis.

This represents the user holding down their finger and moving their hand or a spatial controller within a normalized cube with coordinates from -1.0 to 1.0. These are normalized values and do not represent any physical unit, such as meters.

This gesture can be used to navigate UI widgets, such as radial menus. This can also be used to build velocity-based continuous scrolling or zooming gestures, similar to scrolling a 2D UI by clicking the middle mouse button and then moving the mouse up and down.

Handle the NavigationStarted, NavigationUpdated, NavigationCompleted and/or NavigationCanceled events to react to this gesture.

### -field NavigationY:32
Enable support for the navigation gesture, in the vertical axis.

This represents the user holding down their finger and moving their hand or a spatial controller within a normalized cube with coordinates from -1.0 to 1.0. These are normalized values and do not represent any physical unit, such as meters.

This gesture can be used to navigate UI widgets, such as radial menus. This can also be used to build velocity-based continuous scrolling or zooming gestures, similar to scrolling a 2D UI by clicking the middle mouse button and then moving the mouse up and down.

Handle the NavigationStarted, NavigationUpdated, NavigationCompleted and/or NavigationCanceled events to react to this gesture.

### -field NavigationZ:64
Enable support for the navigation gesture, in the depth axis.

This represents the user holding down their finger and moving their hand or a spatial controller within a normalized cube with coordinates from -1.0 to 1.0. These are normalized values and do not represent any physical unit, such as meters.

This gesture can be used to navigate UI widgets, such as radial menus. This can also be used to build velocity-based continuous scrolling or zooming gestures, similar to scrolling a 2D UI by clicking the middle mouse button and then moving the mouse up and down.

Handle the NavigationStarted, NavigationUpdated, NavigationCompleted and/or NavigationCanceled events to react to this gesture.

### -field NavigationRailsX:128
Enable support for the navigation gesture, in the horizontal axis using rails (guides).

This represents the user holding down their finger and moving their hand or a spatial controller within a normalized cube with coordinates from -1.0 to 1.0. These are normalized values and do not represent any physical unit, such as meters.

This gesture can be used to build velocity-based scrolling or zooming that locks to an axis if the user initiates the gesture primarily in that direction.

Handle the NavigationStarted, NavigationUpdated, NavigationCompleted and/or NavigationCanceled events to react to this gesture.

### -field NavigationRailsY:256
Enable support for the navigation gesture, in the vertical axis using rails (guides).

This represents the user holding down their finger and moving their hand or a spatial controller within a normalized cube with coordinates from -1.0 to 1.0. These are normalized values and do not represent any physical unit, such as meters.

This gesture can be used to build velocity-based scrolling or zooming that locks to an axis if the user initiates the gesture primarily in that direction.

Handle the NavigationStarted, NavigationUpdated, NavigationCompleted and/or NavigationCanceled events to react to this gesture.

### -field NavigationRailsZ:512
Enable support for the navigation gesture, in the depth axis using rails (guides).

This represents the user holding down their finger and moving their hand or a spatial controller within a normalized cube with coordinates from -1.0 to 1.0. These are normalized values and do not represent any physical unit, such as meters.

This gesture can be used to build velocity-based scrolling or zooming that locks to an axis if the user initiates the gesture primarily in that direction.

Handle the NavigationStarted, NavigationUpdated, NavigationCompleted and/or NavigationCanceled events to react to this gesture.


## -remarks
[SpatialGestureRecognizer](spatialgesturerecognizer.md) performs only the minimal disambiguation between the set of gestures that you request. For example, if you request just Tap, the user may hold their finger down as long as they like and a Tap will still occur when the user releases their finger. If you request both Tap and Hold, after about a second of holding down their finger, the gesture will resolve to a Hold and a Tap will no longer occur.

Manipulation settings may not be combined with Navigation settings.

## -examples

## -see-also