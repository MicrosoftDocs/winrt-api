---
-api-id: M:Windows.Services.Cortana.CortanaSettings.IsSupported
-api-type: winrt method
---

<!-- Method syntax.
public bool CortanaSettings.IsSupported()
-->

# Windows.Services.Cortana.CortanaSettings.IsSupported

## -description

Retrieves whether Cortana settings are supported.

## -returns

**true** if Cortana settings are supported. Otherwise, **false**.

## -remarks

The [CortanaSettings](cortanasettings.md) class requires the following be added to the Package.appmanifest:

- To \<Package\>
  - `IgnorableNamespaces="iot"`
- Under \<Capabilities\>
  - `<iot:Capability Name="systemManagement"/>`

## -see-also

## -examples