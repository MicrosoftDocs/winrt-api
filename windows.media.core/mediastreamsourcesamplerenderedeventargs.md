---
-api-id: T:Windows.Media.Core.MediaStreamSourceSampleRenderedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class MediaStreamSourceSampleRenderedEventArgs : Windows.Media.Core.IMediaStreamSourceSampleRenderedEventArgs
-->

# Windows.Media.Core.MediaStreamSourceSampleRenderedEventArgs

## -description
Provides data for the [MediaStreamSource.SampleRendered](mediastreamsource_samplerendered.md) event, which occurs when a sample from a [MediaStreamSource](mediastreamsource.md) is rendered. Use [SampleLag](mediastreamsourcesamplerenderedeventargs_samplelag.md) property to determine if there is a lag in the rendering of a sample, in which case you may decide to switch to a lower-bandwidth stream.

## -remarks
Get an instance of this class by handling the [MediaStreamSource.SampleRendered](mediastreamsource_samplerendered.md) event.

## -examples

## -see-also
