---
-api-id: P:Windows.UI.Input.Inking.InkStroke.Id
-api-type: winrt property
---

<!-- Property syntax
public uint Id { get; }
-->

# Windows.UI.Input.Inking.InkStroke.Id

## -description
Gets the the ink stroke identifier.

A unique identifier is assigned to each ink stroke managed by the [InkPresenter](inkpresenter.md).

## -property-value
The identifier for the ink stroke.

## -remarks
This identifier does not persist through serialization/deserialization of the ink stroke. After deserialization, a new identifer is assigned.

Calling the **[Clone](https://docs.microsoft.com/uwp/api/Windows.UI.Input.Inking.InkStroke.Clone)** method also generates a new identifier for the cloned stroke.

## -examples

## -see-also
- [InkStrokeContainer.GetStrokeById](inkstrokecontainer_getstrokebyid_91415375.md)
