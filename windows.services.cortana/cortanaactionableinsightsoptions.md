---
-api-id: T:Windows.Services.Cortana.CortanaActionableInsightsOptions
-api-type: winrt class
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

The [CortanaActionableInsightsOptions](cortanaactionableinsightsoptions.md) properties are used to identify the contextual metadata for the specified text and image content.

The [CortanaActionableInsights](cortanaactionableinsights.md) class requires the following be added to the Package.appxmanifest:

- To \<Package\>
  - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
  - `IgnorableNamespaces="rescap"`
- Under \<Capabilities\>
  - `<rescap:capability name="cortanaSurface"/>`

The [CortanaActionableInsights](cortanaactionableinsights.md) API is a limited access feature. Developers must request access and be granted an unlock token by Microsoft before they can use the API.

## -see-also

[ShowInsightsForTextAsync(String text, CortanaActionableInsightsOptions options)](cortanaactionableinsights_showinsightsfortextasync_41641920.md), [ShowInsightsForImageAsync(Windows.Storage.Streams.IRandomAccessStreamReference,Windows.Services.Cortana.CortanaActionableInsightsOptions)](cortanaactionableinsights_showinsightsforimageasync_751542345.md), [ShowInsightsAsync(DataPackage datapackage, CortanaActionableInsightsOptions options)](cortanaactionableinsights_showinsightsasync_1937115755.md)

## -examples