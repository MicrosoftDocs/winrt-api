---
-api-id: P:Windows.Media.SpeechSynthesis.SpeechSynthesisStream.Markers
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Media.IMediaMarker> Markers { get; }
-->

# Windows.Media.SpeechSynthesis.SpeechSynthesisStream.Markers

## -description

Gets the collection of timeline markers associated with the [SpeechSynthesisStream](speechsynthesisstream.md).

> [!NOTE] 
> SpeechSynthesisStream.Markers is deprecated. We recommend using the [MediaPlayerElement](../windows.ui.xaml.controls/mediaplayerelement.md) and [MediaPlaybackItem](../windows.media.playback/mediaplaybackitem.md) objects instead (in conjunction with the [IncludeSentenceBoundaryMetadata](speechsynthesizeroptions_includesentenceboundarymetadata.md) and [IncludeWordBoundaryMetadata](speechsynthesizeroptions_includewordboundarymetadata.md) properties of a [SpeechSynthesizerOptions](speechsynthesizeroptions.md) object).

## -property-value

When this method completes successfully, it returns a collection of [IMediaMarker](../windows.media/imediamarker.md) objects that represent the timeline markers in the stream.

## -remarks

## -examples

## -see-also

[Speech interactions](/windows/uwp/design/input/speech-interactions), [Speech recognition and speech synthesis sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SpeechRecognitionAndSynthesis)
