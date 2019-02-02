---
-api-id: P:Windows.UI.Xaml.Controls.Image.PlayToSource
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.PlayTo.PlayToSource PlayToSource { get; }
-->

# Windows.UI.Xaml.Controls.Image.PlayToSource

## -description
Gets the information that is transmitted if the [Image](image.md) is used for a Play To scenario.

## -property-value
A reference object that carries the Play To source information.

## -remarks
You can use Play To to enable users to easily stream audio, video, or images from their computer to devices in their home network. [Image.PlayToSource](image_playtosource.md) is specifically for the XAML images version of this scenario.

Play To is part of the Devices charm. Users open the Devices charm to select devices from their home network that they can stream the media content to. When a user selects a Play To target from the Devices charm, Play To fires the [SourceRequested](../windows.media.playto/playtomanager_sourcerequested.md) event. Play To then streams the media element that was passed to the [SetSource](../windows.media.playto/playtosourcerequest_setsource_1024738425.md) method to the target device that the user has selected. [Image.PlayToSource](image_playtosource.md) provides the [PlayToSource](../windows.media.playto/playtosource.md) controller object that the [PlayToManager](../windows.media.playto/playtomanager.md) can use in this scenario. For an example of how to use Play To in an application, see [PlayReady DRM](https://msdn.microsoft.com/library/dd8ffa8c-dff0-41e3-8f7a-345c5a248fc2).

## -examples

## -see-also
[PlayToManager](../windows.media.playto/playtomanager.md), [PlayReady DRM](https://msdn.microsoft.com/library/dd8ffa8c-dff0-41e3-8f7a-345c5a248fc2), [Play To sample](https://go.microsoft.com/fwlink/p/?linkid=245166)
