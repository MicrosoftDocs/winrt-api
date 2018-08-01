---
-api-id: M:Windows.Services.Cortana.CortanaActionableInsightsOptions.#ctor
-api-type: winrt method
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

The [CortanaActionableInsights](cortanaactionableinsights.md) API is a limited access feature. Developers must request access and be granted an unlock token by Microsoft before they can use the API.

## -see-also

## -examples