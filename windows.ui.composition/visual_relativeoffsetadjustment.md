---
-api-id: P:Windows.UI.Composition.Visual.RelativeOffsetAdjustment
-api-type: winrt property
---

<!-- Property syntax.
public Vector3 RelativeOffsetAdjustment { get;  set; }
-->

# Windows.UI.Composition.Visual.RelativeOffsetAdjustment

## -description
Specifies the offset of the visual with respect to the size of its parent visual.



## -property-value
The offset of the visual with respect to the size of its parent visual.

## -remarks
Value is normalized with respect to the size of the visual's parent. For example, a value of (0.0, 0.5, 0.0) means that the 
vertical position of the visual is at the midpoint between the top and bottom of its parent visual's bounds. This property is a Vector3 for consistency with the Offset property, however the Z component of the RelativeOffsetAdjustment property currently has no effect. 

## -see-also

## -examples

