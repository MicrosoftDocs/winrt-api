---
-api-id: P:Windows.Services.Cortana.CortanaSettings.HasUserConsentToVoiceActivation
-api-type: winrt property
---

<!-- Property syntax.
public bool HasUserConsentToVoiceActivation { get; }
-->

# Windows.Services.Cortana.CortanaSettings.HasUserConsentToVoiceActivation

## -description
Gets whether the user has consented to voice activation.

## -property-value
**true** if the user has consented. Otherwise, **false**.

## -remarks
The [CortanaSettings](cortanasettings.md) class requires the following be added to the Package.appmanifest:

- `<iot:Capability Name="systemManagement"/>`
- "iot" to the list of **IgnorableNamespaces**

## -see-also

## -examples

