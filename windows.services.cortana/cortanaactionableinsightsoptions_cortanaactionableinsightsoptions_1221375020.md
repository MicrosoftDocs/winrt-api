---
-api-id: M:Windows.Services.Cortana.CortanaActionableInsightsOptions.#ctor
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public CortanaActionableInsightsOptions.CortanaActionableInsightsOptions()
-->

# Windows.Services.Cortana.CortanaActionableInsightsOptions.CortanaActionableInsightsOptions

## -description

Creates a [CortanaActionableInsightsOptions](cortanaactionableinsightsoptions.md) object.


## -capabilities

cortanaSurface

## -remarks

The [CortanaActionableInsights](cortanaactionableinsights.md) class requires the following be added to the Package.appxmanifest:

- To \<Package\>
  - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
  - `IgnorableNamespaces="rescap"`
- Under \<Capabilities\>
  - `<rescap:capability name="cortanaSurface"/>`

## -see-also

## -examples
