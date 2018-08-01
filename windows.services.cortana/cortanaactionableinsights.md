---
-api-id: T:Windows.Services.Cortana.CortanaActionableInsights
-api-type: winrt class
---

<!-- Class syntax.
public class CortanaActionableInsights 
-->

# Windows.Services.Cortana.CortanaActionableInsights

## -description

Derives contextual insights from images or text that let the user learn more about the content, or perform an action based on it.

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

[CortanaActionableInsightsOptions](cortanaactionableinsightsoptions.md)

## -examples
