---
-api-id: P:Windows.UI.Input.Inking.InkStroke.Id
-api-type: winrt property
---

<!-- Property syntax
public uint Id { get; }
-->

# Windows.UI.Input.Inking.InkStroke.Id

## -description
Gets the identifier for the ink stroke.

An identifier is assigned to each ink stroke managed by the [InkPresenter](inkpresenter.md).

## -property-value
The unique identifier for the ink stroke.

## -remarks
This unique identifier persists through serialization/deserialization of the ink stroke.
A Clone() of an ink stroke will generate a new unique identifier.

## -examples

## -see-also
- [InkStrokeContainer.GetStrokeById](inkstrokecontainer_getstrokebyid_91415375.md)
