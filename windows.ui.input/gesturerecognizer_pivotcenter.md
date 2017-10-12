---
-api-id: P:Windows.UI.Input.GestureRecognizer.PivotCenter
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Point PivotCenter { get;  set; }
-->

# Windows.UI.Input.GestureRecognizer.PivotCenter

## -description
Gets or sets the center point for a rotation interaction when single pointer input is detected.




<!--•	GestureRecognizer.PivotRadius/Center properties: “rotation manipulation”  single finger rotation manipulation (especially in “Setting the value of PivotRadius to 0 disables support for the rotation manipulation”)-->

<!--•	GestureRecognizer.PivotCenter – This is just to support single input rotation.  Should also set PivotRadius too and have ManipulationRotations enabled.  This value needs to be constantly updated during a manipulation to give the updated center of the manipulated UI.  Units are in PointerPoint values being sent to the GestureRecognizer.
•	GestureRecognizer.PivotRadius – Again this is just used to support single input rotation manipulations.  Units are in the PointerPoint DIP values.
-->

<!--•	GestureRecognizer.PivotCenter – This is for single-finger rotation support only.  It doesn’t affect 2+ finger manipulations.  Same with PivotRadius.-->

## -property-value
The screen location for the center of rotation, in device-independent pixel (DIP).

## -remarks

## -examples

## -see-also
