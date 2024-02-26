---
-api-id: P:Windows.Services.Cortana.CortanaActionableInsights.User
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public User User { get; }
-->

# Windows.Services.Cortana.CortanaActionableInsights.User

## -description

Gets the user associated with the current [CortanaActionableInsights](cortanaactionableinsights.md) object.


## -property-value

The User associated with the current [CortanaActionableInsights](cortanaactionableinsights.md) object.

Might return **null** if the [CortanaActionableInsights](cortanaactionableinsights.md) object was created with the [GetDefault](cortanaactionableinsights_getdefault_846721868.md) method.

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

[CortanaActionableInsights](cortanaactionableinsights.md)

## -examples
