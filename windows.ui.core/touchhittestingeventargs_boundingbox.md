---
-api-id: P:Windows.UI.Core.TouchHitTestingEventArgs.BoundingBox
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Rect BoundingBox { get; }
-->

# Windows.UI.Core.TouchHitTestingEventArgs.BoundingBox

## -description
Gets the bounding rectangle of the touch contact area.

## -property-value
Bounding rectangle of the touch contact area.

## -remarks
The bounding rectangle is the area in which valid touch targets will be identified and ranked.

> [!NOTE]
> This bounding box may differ from the contact area reported by the digitizer when: + The digitizer reports a touch contact area that is outside the maximum or minimum size threshold recognized by [Touch Hit Testing](https://msdn.microsoft.com/library/bdd7630c-b2d8-4080-a149-efec018f697d).
+ A portion of the touch contact area is occluded by another object higher in the z-order.


## -examples

## -see-also
