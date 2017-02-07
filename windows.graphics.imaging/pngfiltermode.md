---
-api-id: T:Windows.Graphics.Imaging.PngFilterMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Graphics.Imaging.PngFilterMode : int
-->

# PngFilterMode

## -description
Specifies the filter used to optimize the image prior to image compression in PNG images.

## -enum-fields
### -field Automatic:0
The filter type will be chosen automatically.

### -field None:1
The image is unmodified.

### -field Sub:2
The Sub type filter is applied.

### -field Up:3
The Up filter type is applied.

### -field Average:4
The Average type filter is applied.

### -field Paeth:5
The Paeth type filter is applied.

### -field Adaptive:6
The Adaptive type filter is applied.


## -remarks
The PNG filter modes only affect compression efficiency and not image quality. **None** does not perform any filtering and is typically the fastest but consumes the most space. **Sub**, **Up**, **Average** and **Paeth** filtering perform differently across various images. **Adaptive** filtering attempts to select the most efficient of the previous filter modes for each scanline in the image. This typically performs the slowest but consumes the least space.

## -examples

## -see-also