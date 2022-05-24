---
-api-id: T:Windows.UI.Xaml.Media.MediaElementState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Media.MediaElementState : int
-->

# MediaElementState

## -description
Defines the potential states of a [MediaElement](../windows.ui.xaml.controls/mediaelement.md) object.


## -xaml-syntax
```xaml
<object property="enumMemberName"/>
```


## -enum-fields
### -field Closed:0
The [MediaElement](../windows.ui.xaml.controls/mediaelement.md) contains no media. The [MediaElement](../windows.ui.xaml.controls/mediaelement.md) displays a transparent frame.

### -field Opening:1
The [MediaElement](../windows.ui.xaml.controls/mediaelement.md) is validating and attempting to load the specified source.

### -field Buffering:2
The [MediaElement](../windows.ui.xaml.controls/mediaelement.md) is loading the media for playback. Its [Position](../windows.ui.xaml.controls/mediaelement_position.md) does not advance during this state. If the [MediaElement](../windows.ui.xaml.controls/mediaelement.md) was already playing video, it continues to display the last displayed frame.

### -field Playing:3
The [MediaElement](../windows.ui.xaml.controls/mediaelement.md) is playing the current media source.

### -field Paused:4
The [MediaElement](../windows.ui.xaml.controls/mediaelement.md) does not advance its [Position](../windows.ui.xaml.controls/mediaelement_position.md). If the [MediaElement](../windows.ui.xaml.controls/mediaelement.md) was playing video, it continues to display the current frame.

### -field Stopped:5
The [MediaElement](../windows.ui.xaml.controls/mediaelement.md) contains media but is not playing or paused. Its [Position](../windows.ui.xaml.controls/mediaelement_position.md) is 0 and does not advance. If the loaded media is video, the [MediaElement](../windows.ui.xaml.controls/mediaelement.md) displays the first frame.


## -remarks

## -examples

## -see-also
[MediaElement.CurrentState](../windows.ui.xaml.controls/mediaelement_currentstate.md)
