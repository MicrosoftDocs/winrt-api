---
-api-id: M:Windows.Devices.Perception.Provider.IPerceptionFrameProviderManager.GetFrameProvider(Windows.Devices.Perception.Provider.PerceptionFrameProviderInfo)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Perception.Provider.IPerceptionFrameProvider GetFrameProvider(Windows.Devices.Perception.Provider.PerceptionFrameProviderInfo frameProviderInfo)
-->

# Windows.Devices.Perception.Provider.IPerceptionFrameProviderManager.GetFrameProvider

## -description
The method to request an IPerceptionFrameProvider associated with a registered PerceptionFrameProviderInfo.

## -parameters
### -param frameProviderInfo
The info specifying the desired IPerceptionFrameProvider.

## -returns
The associated IPerceptionFrameProvider, or nullptr if there is no such registerd provider.

## -remarks
A request with a registered info is expected to return S_OK and a valid IPerceptionFrameProvider, or the appropriate error code. Any requests with a PerceptionFrameProviderInfo which has not been registered or has since been unregistered are expected to return S_OK and nullptr.

## -examples

## -see-also
