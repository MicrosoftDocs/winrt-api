---
-api-id: M:Windows.Services.Cortana.CortanaActionableInsights.GetDefault
-api-type: winrt method
ms.custom: RS5
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

## -see-also

[GetForUser(User user)](cortanaactionableinsights_getforuser_2058550280.md)

## -examples
