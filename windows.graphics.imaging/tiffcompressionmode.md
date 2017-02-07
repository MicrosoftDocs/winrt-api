---
-api-id: T:Windows.Graphics.Imaging.TiffCompressionMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Graphics.Imaging.TiffCompressionMode : int
-->

# TiffCompressionMode

## -description
Specifies the compression mode used for TIFF images.

## -enum-fields
### -field Automatic:0
The compression will be automatically selected.

### -field None:1
No compression will be applied.

### -field Ccitt3:2
CCITT3 compression will be applied.

### -field Ccitt4:3
CCITT4compression will be applied.

### -field Lzw:4
LZW compression will be applied.

### -field Rle:5
RLE compression will be applied.

### -field Zip:6
ZIP compression will be applied.

### -field LzwhDifferencing:7
LZWH Differencing compression will be applied.


## -remarks
The TIFF compression modes only effect compression efficiency and do not affect image quality.

## -examples

## -see-also