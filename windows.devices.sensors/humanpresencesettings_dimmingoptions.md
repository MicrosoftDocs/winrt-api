---
-api-id: P:Windows.Devices.Sensors.HumanPresenceSettings.DimmingOptions
-api-type: winrt property
---

# Windows.Devices.Sensors.HumanPresenceSettings.DimmingOptions

<!--
public Windows.Devices.Sensors.AdaptiveDimmingOptions DimmingOptions { get; }
-->

## -description

Gets the adaptive dimming options for the human presence sensor.

## -property-value

The adaptive dimming options for the human presence sensor.

## -remarks

**Introduced in the May Moment update for Windows 11, Version 22H2, Build 22621.**

The user can specify their preferred dimming behavior in the System settings (see [Launch the Windows Settings app](/windows/uwp/launch-resume/launch-settings-app#system)).

We recommend using the AdaptiveDimming APIs instead of the AttentionAwareDimming APIs ([IsAttentionAwareDimmingSupported](humanpresencefeatures_isattentionawaredimmingsupported.md), [IsAttentionAwareDimmingEnabled](humanpresencesettings_isattentionawaredimmingenabled.md)).

## -see-also

[WakeOptions](humanpresencesettings_wakeoptions.md), [LockOptions](humanpresencesettings_lockoptions.md)

## -examples
