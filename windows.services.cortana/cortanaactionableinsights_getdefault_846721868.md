---
-api-id: M:Windows.Services.Cortana.CortanaActionableInsights.GetDefault
-api-type: winrt method
---

<!-- Method syntax.
public CortanaActionableInsights CortanaActionableInsights.GetDefault()
-->

# Windows.Services.Cortana.CortanaActionableInsights.GetDefault

## -description

Retrieves a [CortanaActionableInsights](cortanaactionableinsights.md) object for the current user.

## -returns

The insights for the current user.

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

[GetForUser(User user)](cortanaactionableinsights_getforuser_2058550280.md)

## -examples