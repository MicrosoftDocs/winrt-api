---
-api-id: T:Windows.Graphics.Printing3D.Printing3DMultiplePropertyMaterialGroup
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class Printing3DMultiplePropertyMaterialGroup : Windows.Graphics.Printing3D.IPrinting3DMultiplePropertyMaterialGroup
-->

# Windows.Graphics.Printing3D.Printing3DMultiplePropertyMaterialGroup

## -description
Represents a multi-property material group.

## -remarks
Each multi-property material is defined by a combination of properties and/or materials that are listed in the specified material groups ([MaterialGroupIndices](printing3dmultiplepropertymaterialgroup_materialgroupindices.md)). Each combination is defined by listing the index of an item from one material group with the index of an item from a secondary material group. The combinations are specified in [MultipleProperties](printing3dmultiplepropertymaterialgroup_multipleproperties.md), where the index values are specified in the same order as the material groups listed in [MaterialGroupIndices](printing3dmultiplepropertymaterialgroup_materialgroupindices.md).

The Printing3DMultiplePropertyMaterialGroup class corresponds to the `<multiproperties>` element in the 3D Manufacturing Format (3MF) specification. For more info, see the [3MF Specification](https://3mf.io/spec/).

## -examples

## -see-also
