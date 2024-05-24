---
-api-id: P:Windows.Devices.Sensors.HumanPresenceFeatures.IsAttentionAwareDimmingSupported
-api-type: winrt property
---

# Windows.Devices.Sensors.HumanPresenceFeatures.IsAttentionAwareDimmingSupported

<!--
public bool IsAttentionAwareDimmingSupported { get; }
-->

## -description

This property is obsolete. For more information, see **Remarks**.

Gets whether the human presence sensor can dim the screen of the PC when user interaction is not detected for a period of time.

## -property-value

True, if supported. Otherwise, false. The default is false.

## -remarks

> **Obsolete as of the May Moment update for Windows 11, Version 22H2, Build 22621.**
>
> We recommend using the AdaptiveDimming APIs instead of the AttentionAwareDimming APIs ([IsAttentionAwareDimmingSupported](humanpresencefeatures_isattentionawaredimmingsupported.md), [IsAttentionAwareDimmingEnabled](humanpresencesettings_isattentionawaredimmingenabled.md)), which are now obsolete.

The user can specify their preferred dimming behavior in the System settings (see [Launch the Windows Settings app](/windows/uwp/launch-resume/launch-settings-app#system)).

## -see-also

[HumanPresenceSettings.IsAttentionAwareDimmingEnabled](humanpresencesettings_isattentionawaredimmingenabled.md), [Device experiences - Adaptive dimming](/windows-hardware/design/device-experiences/sensors-presence-adaptive-dimming)

## -examples
