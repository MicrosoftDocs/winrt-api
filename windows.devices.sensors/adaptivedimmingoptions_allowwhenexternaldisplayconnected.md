---
-api-id: P:Windows.Devices.Sensors.AdaptiveDimmingOptions.AllowWhenExternalDisplayConnected
-api-type: winrt property
---

# Windows.Devices.Sensors.AdaptiveDimmingOptions.AllowWhenExternalDisplayConnected

<!--
public bool AllowWhenExternalDisplayConnected { get; set; }
-->

## -description

Gets or sets whether screen dimming behavior, based on the user engagement state reported by the human presence sensor, is enabled when a user has connected an external monitor.

## -property-value

True, if screen dimming behavior is enabled. Otherwise, false.

## -remarks

**Introduced in the May Moment update for Windows 11, Version 22H2, Build 22621.**

We recommend using the AdaptiveDimming APIs instead of the AttentionAwareDimming APIs ([IsAttentionAwareDimmingSupported](humanpresencefeatures_isattentionawaredimmingsupported.md), [IsAttentionAwareDimmingEnabled](humanpresencesettings_isattentionawaredimmingenabled.md)), which are now obsolete.

The user can specify their preferred dimming behavior in the System settings (see [Launch the Windows Settings app](/windows/uwp/launch-resume/launch-settings-app#system)).

## -see-also

## -examples
