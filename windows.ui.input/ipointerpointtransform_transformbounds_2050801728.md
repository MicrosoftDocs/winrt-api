---
-api-id: M:Windows.UI.Input.IPointerPointTransform.TransformBounds(Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Rect TransformBounds(Windows.Foundation.Rect rect)
-->

# Windows.UI.Input.IPointerPointTransform.TransformBounds

## -description
Transforms the specified bounding rectangle.

## -parameters
### -param rect
The bounding rectangle to transform.

## -returns
The smallest, axis-aligned bounding box that encloses *rect* after the transformation. (An axis-aligned bounding box is one which has all sides parallel to the coordinate axes.)

## -remarks
*rect* is typically the [ContactRect](pointerpointproperties_contactrect.md) associated with the input point that is transformed through the [TryTransform](ipointerpointtransform_trytransform.md) method. *rect* must be recalculated as it does not change with the transformation of the input point.

This method should return an [HResult](../windows.foundation/hresult.md) that identifies whether the transformation was successful.

## -examples

## -see-also
