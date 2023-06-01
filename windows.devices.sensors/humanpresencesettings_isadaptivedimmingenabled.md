---
-api-id: P:Windows.Devices.Sensors.HumanPresenceSettings.IsAdaptiveDimmingEnabled
-api-type: winrt property
---

# Windows.Devices.Sensors.HumanPresenceSettings.IsAdaptiveDimmingEnabled

<!--
public bool IsAdaptiveDimmingEnabled { get; set; }
-->

## -description

Gets or sets whether adaptive dimming is enabled.

## -property-value

True, if adaptive dimming is enabled. Otherwise, false. The default is false.

## -remarks

**Introduced in the May Moment update for Windows 11, Version 22H2, Build 22621.**

We recommend using the AdaptiveDimming APIs instead of the AttentionAwareDimming APIs ([IsAttentionAwareDimmingSupported](humanpresencefeatures_isattentionawaredimmingsupported.md), [IsAttentionAwareDimmingEnabled](humanpresencesettings_isattentionawaredimmingenabled.md)), which are now obsolete.

The user can specify their preferred dimming behavior in the System settings (see [Launch the Windows Settings app](/windows/uwp/launch-resume/launch-settings-app#system)).

## -see-also

[AdaptiveDimmingOptions](adaptivedimmingoptions.md), [IsAdaptiveDimmingSupported](humanpresencefeatures_isadaptivedimmingsupported.md)

## -examples
