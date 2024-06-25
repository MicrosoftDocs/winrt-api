---
-api-id: P:Windows.Devices.Sensors.HumanPresenceFeatures.IsAdaptiveDimmingSupported
-api-type: winrt property
---

# Windows.Devices.Sensors.HumanPresenceFeatures.IsAdaptiveDimmingSupported

<!--
public bool IsAdaptiveDimmingSupported { get; }
-->

## -description

Gets whether the human presence sensor can dim the PC screen based on if a user is present, absent, or interacting with their device.

## -property-value

True, if adaptive dimming is supported. Otherwise, false.

## -remarks

**Introduced in the May Moment update for Windows 11, Version 22H2, Build 22621.**

We recommend using the AdaptiveDimming APIs instead of the AttentionAwareDimming APIs ([IsAttentionAwareDimmingSupported](humanpresencefeatures_isattentionawaredimmingsupported.md), [IsAttentionAwareDimmingEnabled](humanpresencesettings_isattentionawaredimmingenabled.md)), which are now obsolete.

The user can specify their preferred dimming behavior in the System settings (see [Launch the Windows Settings app](/windows/uwp/launch-resume/launch-settings-app#system)).

## -see-also

[AdaptiveDimmingOptions](adaptivedimmingoptions.md), [IsAdaptiveDimmingEnabled](humanpresencesettings_isadaptivedimmingenabled.md), [Device experiences - Adaptive dimming](/windows-hardware/design/device-experiences/sensors-presence-adaptive-dimming)

## -examples
