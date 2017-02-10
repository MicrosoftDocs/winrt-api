---
-api-id: P:Windows.Media.Effects.VideoTransformEffectDefinition.ProcessingAlgorithm
-api-type: winrt property
---

<!-- Property syntax
public Windows.Media.Transcoding.MediaVideoProcessingAlgorithm ProcessingAlgorithm { get;  set; }
-->

# Windows.Media.Effects.VideoTransformEffectDefinition.ProcessingAlgorithm

## -description
Gets or sets the media processing algorithm that is used for the video transform.

## -property-value
The media processing algorithm that is used for the video transform.

## -remarks
Set this value to [MrfCrf444](../windows.media.transcoding/mediavideoprocessingalgorithm.md) to cause the video transform to use a high-quality resampler so that all operations are done using 4:4:4 sampling for the highest video quality. The algorithm applies to all transform properties except for [PaddingColor](videotransformeffectdefinition_paddingcolor.md).

## -examples

## -see-also
