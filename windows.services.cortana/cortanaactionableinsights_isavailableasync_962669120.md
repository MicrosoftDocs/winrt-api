---
-api-id: M:Windows.Services.Cortana.CortanaActionableInsights.IsAvailableAsync
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<bool> CortanaActionableInsights.IsAvailableAsync()
-->

# Windows.Services.Cortana.CortanaActionableInsights.IsAvailableAsync

## -description

Asynchronously retrieves whether insights can be generated on the user's current system.

> [!IMPORTANT]
> The [CortanaActionableInsights](cortanaactionableinsights.md) APIs are a limited access feature. Please contact [InsightsAPISupport@microsoft.com](mailto://InsightsAPISupport@microsoft.com) for more info, or to request an unlock token.

## -returns

An IAsyncOperation object used to control asynchronous execution. The IAsyncOperation will contain **true** if insights can be generated. Otherwise, **false**.

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

## -examples
