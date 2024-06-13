---
-api-id: T:Windows.Services.Cortana.CortanaActionableInsightsOptions
-api-type: winrt class
ms.custom: RS5
---

<!-- Class syntax.
public class CortanaActionableInsightsOptions 
-->

# Windows.Services.Cortana.CortanaActionableInsightsOptions

## -description

Specifies options for refining the insights retrieved through the [CortanaActionableInsights](cortanaactionableinsights.md) methods.


## -capabilities

cortanaSurface

## -remarks

The CortanaActionableInsightsOptions properties are used to identify the contextual metadata for the specified text and image content.

The [CortanaActionableInsights](cortanaactionableinsights.md) class requires the following be added to the Package.appxmanifest:

- To \<Package\>
  - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
  - `IgnorableNamespaces="rescap"`
- Under \<Capabilities\>
  - `<rescap:capability name="cortanaSurface"/>`

## -see-also

[ShowInsightsForTextAsync(String text, CortanaActionableInsightsOptions options)](cortanaactionableinsights_showinsightsfortextasync_41641920.md), [ShowInsightsForImageAsync(Windows.Storage.Streams.IRandomAccessStreamReference,Windows.Services.Cortana.CortanaActionableInsightsOptions)](cortanaactionableinsights_showinsightsforimageasync_751542345.md), [ShowInsightsAsync(DataPackage datapackage, CortanaActionableInsightsOptions options)](cortanaactionableinsights_showinsightsasync_1937115755.md)

## -examples
