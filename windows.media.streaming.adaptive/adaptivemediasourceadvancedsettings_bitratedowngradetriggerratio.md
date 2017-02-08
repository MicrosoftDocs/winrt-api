---
-api-id: P:Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceAdvancedSettings.BitrateDowngradeTriggerRatio
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<double> BitrateDowngradeTriggerRatio { get;  set; }
-->

# Windows.Media.Streaming.Adaptive.AdaptiveMediaSourceAdvancedSettings.BitrateDowngradeTriggerRatio

## -description
Gets or sets a value that specifies how low the inbound bits per second may drop before the adaptive media source will switch down to a different encoding bitrate to download.

## -property-value
A floating point value that is the ratio of actual inbound bitrate to the target bitrate.

## -remarks
For example, if the current downloading bitrate for a particular HLS stream variant or DASH representation is 1000bps and the **BitrateDowngradeTriggerRatio** is 1.0, the adaptive media source will allow the inbound bits per second to drop to 1000bps before attempting to switch to a lower encoding bitrate.

## -examples

## -see-also
