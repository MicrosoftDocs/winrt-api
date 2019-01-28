---
-api-id: T:Windows.Services.Cortana.CortanaActionableInsights
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class CortanaActionableInsights 
-->

# Windows.Services.Cortana.CortanaActionableInsights

## -description

Derives contextual insights from images or text that let the user learn more about the content, or perform an action based on it.

> [!IMPORTANT]
> The [CortanaActionableInsights](cortanaactionableinsights.md) APIs are a limited access feature. Please contact [InsightsAPISupport@microsoft.com](mailto://InsightsAPISupport@microsoft.com) for more info, or to request an unlock token.

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

[CortanaActionableInsightsOptions](cortanaactionableinsightsoptions.md)

## -examples
