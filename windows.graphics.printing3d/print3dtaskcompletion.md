---
-api-id: T:Windows.Graphics.Printing3D.Print3DTaskCompletion
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Graphics.Printing3D.Print3DTaskCompletion : int
-->

# Print3DTaskCompletion

## -description
Specifies the completion status of a 3D print request.

## -enum-fields
### -field Abandoned:0
The request has been abandoned.

### -field Canceled:1
The request has been cancelled.

### -field Failed:2
The request has failed.

### -field Slicing:3
The driver is preparing layer by layer slices of the 3D model for the printer.

### -field Submitted:4
The request has been submitted successfully.


## -remarks
This API is designed for use with 3D Manufacturing Format (3MF) packages. For more info about 3MF, see the [3MF Specification](https://3mf.io/spec/).

## -examples

## -see-also
