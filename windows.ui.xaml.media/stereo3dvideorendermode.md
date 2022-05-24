---
-api-id: T:Windows.UI.Xaml.Media.Stereo3DVideoRenderMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Media.Stereo3DVideoRenderMode : int
-->

# Stereo3DVideoRenderMode

## -description
Describes the stereo 3-D video render mode for the current media source.


## -xaml-syntax
```xaml
<object property="enumMemberName"/>
```


## -enum-fields
### -field Mono:0
Regular 2-D video.

### -field Stereo:1
Stereo 3-D video.


## -remarks
Setting the attribute to **stereo** enables stereo display mode. A value of **mono** disables it. The default is **mono**.

## -examples
This example creates a [MediaElement](mediaelementstate.md) with Stereo3DVideoRenderMode set.

```xaml
<MediaElement Stereo3DVideoRenderMode="Stereo"/>
```



## -see-also
