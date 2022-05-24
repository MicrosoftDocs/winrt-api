---
-api-id: T:Windows.UI.Xaml.Media.Stereo3DVideoPackingMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Media.Stereo3DVideoPackingMode : int
-->

# Stereo3DVideoPackingMode

## -description
Describes the frame-packing mode for stereo 3-D video content.


## -xaml-syntax
```xaml
<object property="enumMemberName"/>
```


## -enum-fields
### -field None:0
Regular 2-D video.

### -field SideBySide:1
Stereo 3-D content packing with components side-by-side.

### -field TopBottom:2
Stereo 3-D content packing with components top and bottom.


## -remarks
The default is to allow the system to determine the packing mode from the metadata of the video content.

In order to reset this value once it has been set, use the [ClearValue](../windows.ui.xaml/dependencyobject_clearvalue_1095854009.md) API.

This API is used in conjunction with [Stereo3DVideoRenderMode](stereo3dvideorendermode.md) to display 3-D content.

Returns or sets **topbottom** or **sidebyside** for stereo 3-D content packing, or **none** for regular 2-D video.

## -examples
This example creates a [MediaElement](mediaelementstate.md) with Stereo3DVideoPackingMode and [Stereo3DVideoRenderMode](stereo3dvideorendermode.md) set.

```xaml
<MediaElement Stereo3DVideoPackingMode="TopBottom" 
              Stereo3DVideoRenderMode="Stereo"/>
```



## -see-also
