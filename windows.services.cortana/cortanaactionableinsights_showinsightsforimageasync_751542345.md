---
-api-id: M:Windows.Services.Cortana.CortanaActionableInsights.ShowInsightsForImageAsync(Windows.Storage.Streams.IRandomAccessStreamReference,Windows.Services.Cortana.CortanaActionableInsightsOptions)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncAction CortanaActionableInsights.ShowInsightsForImageAsync(IRandomAccessStreamReference imageStream, CortanaActionableInsightsOptions options)
-->

# Windows.Services.Cortana.CortanaActionableInsights.ShowInsightsForImageAsync

## -description

Asynchronously retrieves and displays insights based on the specified image content and options.

## -parameters

### -param imageStream

The image that defines the scope of the insights returned.

### -param options

The options that constrain the scope of the insights returned.

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

[ShowInsightsForImageAsync(IRandomAccessStreamReference imageStream)](cortanaactionableinsights_showinsightsforimageasync_1773404445.md)

## -examples