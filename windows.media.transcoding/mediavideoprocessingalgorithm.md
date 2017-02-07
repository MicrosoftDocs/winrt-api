---
-api-id: T:Windows.Media.Transcoding.MediaVideoProcessingAlgorithm
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Media.Transcoding.MediaVideoProcessingAlgorithm : int
-->

# MediaVideoProcessingAlgorithm

## -description
Defines the available algorithms used by the Transcode Video Processor (XVP).

## -enum-fields
### -field Default:0
Default video processing algorithm. This algorithm prefers performance, speed, and space over quality. This algorithm will makes use of hardware.

### -field MrfCrf444:1
Prefers quality over performance. This mode always runs in software and insures that hardware implementations, which may differ from the XVP are not used.


## -remarks
The **MrfCrf444** algorithm uses larger filters, full precision for color conversions, prefers higher quality color formats, and enables a high quality MRF deinterlacer. Developers who want their apps to produce the best quality output regardless of the hardware, time, or power consumption, may want to enable this algorithm for transcoding.

## -examples

## -see-also