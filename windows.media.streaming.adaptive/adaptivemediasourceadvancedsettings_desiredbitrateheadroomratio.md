---
-api-id: P:Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceAdvancedSettings.DesiredBitrateHeadroomRatio
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<double> DesiredBitrateHeadroomRatio { get;  set; }
-->

# Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceAdvancedSettings.DesiredBitrateHeadroomRatio

## -description
Gets or sets a value that specifies the minimum inbound bits per second required before the adaptive media source will switch up to one of the available encoded bitrates to download.

## -property-value
The minimum inbound bits per second before switching to another available encoded bitrate.

## -remarks
For example, if the bitrate for a particular HLS stream variant or DASH representation is 1000bps and the **DesiredBitrateHeadroomRatio** is 1.2, the adaptive media source will require at least 1200bps inbound bits per second.

Enforcement of this property is relaxed for the lowest bitrate that contains video in order to minimize selection of audio-only bitrates.

## -examples

## -see-also
