---
-api-id: M:Windows.Services.Cortana.CortanaActionableInsights.ShowInsightsForTextAsync(System.String)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncAction CortanaActionableInsights.ShowInsightsForTextAsync(String text)
-->

# Windows.Services.Cortana.CortanaActionableInsights.ShowInsightsForTextAsync

## -description

Asynchronously retrieves and displays insights based on the specified text content.


## -parameters

### -param text

The text that defines the scope of the insights returned.

## -returns

Returns an [IAsyncAction](../windows.foundation/iasyncaction.md) object that is used to control asynchronous execution. If the system does not support showing insights, the method has no effect. An app can check for this case using the [IsAvailableAsync](cortanaactionableinsights_isavailableasync_962669120.md) method.

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

[ShowInsightsForTextAsync(String text, CortanaActionableInsightsOptions options)](cortanaactionableinsights_showinsightsfortextasync_41641920.md)

## -examples
