---
-api-id: T:Windows.Graphics.Printing3D.Printing3DCompositeMaterialGroup
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class Printing3DCompositeMaterialGroup : Windows.Graphics.Printing3D.IPrinting3DCompositeMaterialGroup, Windows.Graphics.Printing3D.IPrinting3DCompositeMaterialGroup2
-->

# Windows.Graphics.Printing3D.Printing3DCompositeMaterialGroup

## -description
Represents a group of composite materials.

## -remarks
Each composite material is defined by a mixture of base materials that are listed in the specified base material group ([MaterialGroupId](printing3dcompositematerialgroup_materialgroupid.md)). The index values of possible base materials from that material group are specified in [MaterialIndices](printing3dcompositematerialgroup_materialindices.md). Each mixture is defined by listing the proportion of the overall mixture for each base material (values between 0 and 1). The mixtures of base materials are specified in [Composites](printing3dcompositematerialgroup_composites.md), where the proportion values are specified in the same order as the base materials in [MaterialIndices](printing3dcompositematerialgroup_materialindices.md).

This class corresponds to the `<compositematerials>` element in the 3D Manufacturing Format (3MF) specification. For more info, see the [3MF Specification](https://3mf.io/spec/).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | BaseMaterialGroup |

## -examples

## -see-also
