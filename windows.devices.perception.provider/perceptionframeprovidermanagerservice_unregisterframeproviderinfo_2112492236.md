---
-api-id: M:Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService.UnregisterFrameProviderInfo(Windows.Devices.Perception.Provider.IPerceptionFrameProviderManager,Windows.Devices.Perception.Provider.PerceptionFrameProviderInfo)
-api-type: winrt method
---

<!-- Method syntax
public void UnregisterFrameProviderInfo(Windows.Devices.Perception.Provider.IPerceptionFrameProviderManager manager, Windows.Devices.Perception.Provider.PerceptionFrameProviderInfo frameProviderInfo)
-->

# Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService.UnregisterFrameProviderInfo

## -description
Unregisters the PerceptionFrameProviderInfo in association with the given IPerceptionProviderManager.

## -parameters
### -param manager
The manager which previously registered this info.

### -param frameProviderInfo
The PerceptionFrameProviderInfo which identifies the IPerceptionFrameProvider.

## -remarks
After this function returns, the service no longer calls the IPerceptionFrameProviderManager::GetFrameProvider() method with the provided PerceptionFrameProviderInfo. Unregistering a PerceptionFrameProviderInfo that is not registered, because it was never registered or because it's already unregistered, raises an InvalidArgumentException.

## -examples

## -see-also
