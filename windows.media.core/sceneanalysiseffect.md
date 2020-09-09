---
-api-id: T:Windows.Media.Core.SceneAnalysisEffect
-api-type: winrt class
---

<!-- Class syntax.
public class SceneAnalysisEffect : Windows.Media.Core.ISceneAnalysisEffect, Windows.Media.IMediaExtension
-->

# Windows.Media.Core.SceneAnalysisEffect

## -description
Represents an effect that analyzes video frames to determine if any of the supported variable photo sequence capture techniques may produce a higher-quality captured image.

## -remarks
Get an instance of this class by passing a [SceneAnalysisEffectDefinition](sceneanalysiseffectdefinition.md) object into [MediaCapture.AddVideoEffectAsync](../windows.media.capture/mediacapture_addvideoeffectasync_1410216019.md).

Just like other effects, the scene analyzer effect is added to the capture pipeline by calling [AddEffectAsync](../windows.media.capture/mediacapture_addeffectasync_262788603.md). After capture is started, the [SceneAnalyzed](sceneanalysiseffect_sceneanalyzed.md) event is raised. In the handler for this event, you can get access to the output object that indicates the likelihood that a particular technique will improve the captured image. The output object also provides a set of [FrameController](highdynamicrangeoutput_framecontrollers.md) objects with recommended settings that can be assigned directly to the [VariablePhotoSequenceController.DesiredFrameControllers](../windows.media.devices.core/variablephotosequencecontroller_desiredframecontrollers.md) collection to enable the capture technique.

In the current release, the only analyzer supported is the High Dynamic Range (HDR) analyzer.

For how-to guidance on using the **SceneAnalysisEffect**, see [Scene anlysis for MediaCapture](/windows/uwp/audio-video-camera/scene-analysis-for-media-capture).

## -examples

## -see-also
[IMediaExtension](../windows.media/imediaextension.md), [VariablePhotoSequenceController](../windows.media.devices.core/variablephotosequencecontroller.md), [MediaCapture.AddEffectAsync](../windows.media.capture/mediacapture_addeffectasync_262788603.md), [Scene anlysis for MediaCapture](/windows/uwp/audio-video-camera/scene-analysis-for-media-capture)