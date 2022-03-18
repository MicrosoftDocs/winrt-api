---
-api-id: T:Windows.Storage.FileProperties.PhotoOrientation
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Storage.FileProperties.PhotoOrientation : int
-->

# PhotoOrientation

## -description
Indicates the Exchangeable Image File (EXIF) orientation flag of the photo. This flag describes how to rotate the photo to display it correctly.

## -enum-fields
### -field Unspecified:0
An orientation flag is not set.

### -field Normal:1
No rotation needed. The photo can be displayed using its current orientation.

### -field FlipHorizontal:2
Flip the photo horizontally.

### -field Rotate180:3
Rotate the photo 180 degrees.

### -field FlipVertical:4
Flip the photo vertically.

### -field Transpose:5
Rotate the photo counter-clockwise 270 degrees and then flip it horizontally.

### -field Rotate270:6
Rotate the photo counter-clockwise 270 degrees.

### -field Transverse:7
Rotate the photo counter-clockwise 90 degrees and then flip it horizontally.

### -field Rotate90:8
Rotate the photo counter-clockwise 90 degrees.


## -remarks

## -examples

## -see-also
[ImageProperties.Orientation](imageproperties_orientation.md)