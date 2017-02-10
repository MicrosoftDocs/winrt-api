---
-api-id: P:Windows.Media.Core.MediaStreamSourceSampleRenderedEventArgs.SampleLag
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.TimeSpan SampleLag { get; }
-->

# Windows.Media.Core.MediaStreamSourceSampleRenderedEventArgs.SampleLag

## -description
Gets a time span representing the lag with which a sample was rendered.

## -property-value
The lag with which a sample was rendered.

## -remarks
If the value of this property is greater than 0, then the sample was rendered late. In this case, depending on the size of the lag, you may choose to switch to a lower bandwidth stream in order to reduce lag.

## -examples

## -see-also
