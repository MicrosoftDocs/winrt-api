---
-api-id: T:Windows.Graphics.Imaging.JpegSubsamplingMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Graphics.Imaging.JpegSubsamplingMode : int
-->

# JpegSubsamplingMode

## -description
Specifies which chroma subsampling mode will be used for image compression in JPEG images.

## -enum-fields
### -field Default:0
The default mode will be used.

### -field Y4Cb2Cr0:1
4:2:0 (2x2) chroma subsampling will be used.

### -field Y4Cb2Cr2:2
4:2:2 (2x1) chroma subsampling will be used.

### -field Y4Cb4Cr4:3
4:4:4 (1x1) chroma subsampling will be used.


## -remarks
**Y4Cb2Cr0** has the lowest space usage and lowest image quality. **Y4Cb2Cr2** provides medium space usage and image quality. **Y4Cb4Cr4** has the highest space usage and highest image quality.

## -examples

## -see-also