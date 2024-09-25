---
-api-id: T:Windows.Graphics.Printing3D.Printing3DCompositeMaterial
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class Printing3DCompositeMaterial : Windows.Graphics.Printing3D.IPrinting3DCompositeMaterial
-->

# Windows.Graphics.Printing3D.Printing3DCompositeMaterial

## -description
Represents a composite material that's defined by a mixture of base materials.

## -remarks
Each composite material is defined by a mixture of base materials that are listed in the specified base material group ([MaterialGroupId](printing3dcompositematerialgroup_materialgroupid.md)). The index values of possible base materials from that material group are specified in [MaterialIndices](printing3dcompositematerialgroup_materialindices.md). Each mixture is defined by listing the proportion of the overall mixture for each base material (values between 0 and 1). The mixtures of base materials are specified in [Composites](printing3dcompositematerialgroup_composites.md), where the proportion values are specified in the same order as the base materials in [MaterialIndices](printing3dcompositematerialgroup_materialindices.md).

This class corresponds to the `<composite>` element in the 3D Manufacturing Format (3MF) specification. For more info, see the [3MF Specification](https://3mf.io/spec/).

## -examples

## -see-also
