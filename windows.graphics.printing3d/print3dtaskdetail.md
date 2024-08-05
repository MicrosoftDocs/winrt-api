---
-api-id: T:Windows.Graphics.Printing3D.Print3DTaskDetail
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Graphics.Printing3D.Print3DTaskDetail : int
-->

# Print3DTaskDetail

## -description
Specifies the type of errors encountered during a 3D print request.

## -enum-fields
### -field Unknown:0
No additional information is available.

### -field ModelExceedsPrintBed:1
The 3D model exceeds the print bed.

### -field UploadFailed:2
The upload of the 3D print package failed.

### -field InvalidMaterialSelection:3
An invalid printing material has been selected.

### -field InvalidModel:4
The 3D model is not valid.

### -field ModelNotManifold:5
The 3d model does not have manifold edges.

### -field InvalidPrintTicket:6
The print ticket is not valid.


## -remarks
This API is designed for use with 3D Manufacturing Format (3MF) packages. For more info about 3MF, see the [3MF Specification](https://3mf.io/spec/).

## -examples

## -see-also
