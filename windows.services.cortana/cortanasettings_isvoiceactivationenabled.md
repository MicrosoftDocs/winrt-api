---
-api-id: P:Windows.Services.Cortana.CortanaSettings.IsVoiceActivationEnabled
-api-type: winrt property
---

<!-- Property syntax.
public bool IsVoiceActivationEnabled { get;  set; }
-->

# Windows.Services.Cortana.CortanaSettings.IsVoiceActivationEnabled

## -description

Gets or sets whether voice activation is enabled.

## -property-value

**true** if voice activation is enabled. Otherwise, **false**.

## -remarks

The [CortanaSettings](cortanasettings.md) class requires the following be added to the Package.appmanifest:

- To \<Package\>
  - `IgnorableNamespaces="iot"`
- Under \<Capabilities\>
  - `<iot:Capability Name="systemManagement"/>`

## -see-also

## -examples