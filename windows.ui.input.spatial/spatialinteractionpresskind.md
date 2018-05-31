---
-api-id: T:Windows.UI.Input.Spatial.SpatialInteractionPressKind
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum SpatialInteractionPressKind : int 
-->

# Windows.UI.Input.Spatial.SpatialInteractionPressKind

## -description

Specifies the kind of press represented by a [SourcePressed](spatialinteractionmanager_sourcepressed.md) or [SourceReleased](spatialinteractionmanager_sourcereleased.md) event.

## -enum-fields

### -field None:0

This is a SourceDetected, SourceLost or SourceUpdated event, which does not represent a press or a release.

### -field Select:1

Select represents the primary press for a spatial interaction source:

* For hands, a Select press represents the user's index finger in the down position.
* For motion controllers, a Select press represents the controller's index-finger trigger (or primary face button, if no trigger) being fully pressed.
* For voice, a Select press represents the user saying the system keyword "Select".

### -field Menu:2

For motion controllers, a Menu press represents the controller's Menu button being pressed.

### -field Grasp:3

For motion controllers, a grasp represents the user squeezing their fist tightly.  This may be detected by grip buttons or a palm trigger.

### -field Touchpad:4

For motion controllers, a touchpad press represents the user clicking down on the touchpad.

### -field Thumbstick:5

For motion controllers, a thumbstick press represents the user clicking down on the thumbstick.

## -remarks

## -see-also

[Spatial interaction source sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpatialInteractionSource)

## -examples
