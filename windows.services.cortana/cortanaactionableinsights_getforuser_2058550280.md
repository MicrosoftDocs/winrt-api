---
-api-id: M:Windows.Services.Cortana.CortanaActionableInsights.GetForUser(Windows.System.User)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public CortanaActionableInsights CortanaActionableInsights.GetForUser(User user)
-->

# Windows.Services.Cortana.CortanaActionableInsights.GetForUser

## -description

Retrieves a [CortanaActionableInsights](cortanaactionableinsights.md) object for the specified user.


## -parameters

### -param user

The user.

## -returns

The insights for the specified user.

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

[GetDefault](cortanaactionableinsights_getdefault_846721868.md)

## -examples
