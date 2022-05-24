---
-api-id: P:Windows.UI.Xaml.Controls.MediaElement.Stereo3DVideoPackingMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Stereo3DVideoPackingMode Stereo3DVideoPackingMode { get;  set; }
-->

# Windows.UI.Xaml.Controls.MediaElement.Stereo3DVideoPackingMode

## -description
Gets or sets an enumeration value that determines the stereo 3-D video frame-packing mode for the current media source.


## -xaml-syntax
```xaml
<MediaElement Stereo3DVideoPackingMode="stereo3DVideoPackingModeMemberName" .../>
```


## -property-value
A value of the enumeration. See Remarks.

## -remarks
The Stereo3DVideoPackingMode default is to allow the system to determine the packing mode from the metadata of the video content. In order to reset a Stereo3DVideoPackingMode value once it has been set, use [ClearValue](../windows.ui.xaml/dependencyobject_clearvalue_1095854009.md). Stereo3DVideoPackingMode is used in conjunction with [Stereo3DVideoRenderMode](mediaelement_stereo3dvideorendermode.md) to display 3-D content.

## -examples
```xaml
<MediaElement x:Name="me1" Stereo3DVideoPackingMode="TopBottom" Stereo3DVideoRenderMode="Stereo"/>
```



## -see-also
