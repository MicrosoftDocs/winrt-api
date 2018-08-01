---
-api-id: M:Windows.Services.Cortana.CortanaActionableInsights.ShowInsightsAsync(Windows.ApplicationModel.DataTransfer.DataPackage)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction CortanaActionableInsights.ShowInsightsAsync(DataPackage datapackage)
-->

# Windows.Services.Cortana.CortanaActionableInsights.ShowInsightsAsync

## -description

Asynchronously retrieves and displays insights based on the specified text and image content.

## -parameters

### -param datapackage

The text and image content that defines the scope of the insights returned.

## -returns

Returns an [IAsyncAction](../windows.foundation/iasyncaction.md) object that is used to control asynchronous execution. If the system does not support showing insights, the method has no effect. An app can check for this case using the [IsAvailableAsync](cortanaactionableinsights_issupported.md) method.

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

[ShowInsightsAsync(DataPackage datapackage, CortanaActionableInsightsOptions options)](cortanaactionableinsights_showinsightsasync_1937115755.md)

## -examples