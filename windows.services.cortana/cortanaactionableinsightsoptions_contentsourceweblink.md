---
-api-id: P:Windows.Services.Cortana.CortanaActionableInsightsOptions.ContentSourceWebLink
-api-type: winrt property
---

<!-- Property syntax.
public Uri ContentSourceWebLink { get;  set; }
-->

# Windows.Services.Cortana.CortanaActionableInsightsOptions.ContentSourceWebLink

## -description

A URI that identifies where the specified text or image content originated.

## -property-value

The web link address. This value can be null.

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