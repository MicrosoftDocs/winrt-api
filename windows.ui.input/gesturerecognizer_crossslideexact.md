---
-api-id: P:Windows.UI.Input.GestureRecognizer.CrossSlideExact
-api-type: winrt property
---

<!-- Property syntax
public bool CrossSlideExact { get;  set; }
-->

# Windows.UI.Input.GestureRecognizer.CrossSlideExact

## -description
Gets or sets a value that indicates whether the exact distance from initial contact to end of the cross-slide interaction is reported.By default, a small distance threshold is subtracted from the first position reported by the system for cross-slide interactions. If this flag is set, the distance threshold is not subtracted from the initial position.

> [!NOTE]
> This distance threshold is intended to account for any slight movement of the contact after initial detection. It helps the system differentiate between cross-sliding and panning, and helps ensure that a tap gesture is not interpreted as either.

## -property-value
True if the distance threshold is not subtracted; otherwise false. The default value is false.

## -remarks

## -examples

## -see-also
