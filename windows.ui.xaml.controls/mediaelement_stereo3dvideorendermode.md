---
-api-id: P:Windows.UI.Xaml.Controls.MediaElement.Stereo3DVideoRenderMode
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Stereo3DVideoRenderMode Stereo3DVideoRenderMode { get;  set; }
-->

# Windows.UI.Xaml.Controls.MediaElement.Stereo3DVideoRenderMode

## -description
Gets or sets an enumeration value that determines the stereo 3-D video render mode for the current media source.


## -xaml-syntax
```xaml
<MediaElement Stereo3DVideoRenderMode="stereo3DVideoRenderModeMemberName" .../>
```


## -property-value
A value of the enumeration.

## -remarks
[IsStereo3DVideo](mediaelement_isstereo3dvideo.md) is an evaluated read-only property that is based on Stereo3DVideoRenderMode.

Set Stereo3DVideoRenderMode to [Stereo](../windows.ui.xaml.media/stereo3dvideorendermode.md) when you want to enable the [MediaElement](mediaelement.md) to play 3D video. The API works in conjunction with [Stereo3DVideoPackingMode](mediaelement_stereo3dvideopackingmode.md), which lets you set the packing mode or allows the sub systems to infer it from the video file

## -examples
```xaml
<MediaElement x:Name="me1" Stereo3DVideoPackingMode="TopBottom" Stereo3DVideoRenderMode="Stereo"/>
```



## -see-also
