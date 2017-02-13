---
-api-id: M:Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService.RegisterFrameProviderInfo(Windows.Devices.Perception.Provider.IPerceptionFrameProviderManager,Windows.Devices.Perception.Provider.PerceptionFrameProviderInfo)
-api-type: winrt method
---

<!-- Method syntax
public void RegisterFrameProviderInfo(Windows.Devices.Perception.Provider.IPerceptionFrameProviderManager manager, Windows.Devices.Perception.Provider.PerceptionFrameProviderInfo frameProviderInfo)
-->

# Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService.RegisterFrameProviderInfo

## -description
Registers the PerceptionFrameProviderInfo in association with the given IPerceptionFrameProviderManager.

## -parameters
### -param manager
The manager which can provide the IPerceptionFrameProvider associated with the info.

### -param frameProviderInfo
The PerceptionFrameProviderInfo which identifies the available IPerceptionFrameProvider.

## -remarks
This method enables the service to request the IPerceptionFrameProvider associated with the PerceptionFrameProviderInfo. The IPerceptionFrameProviderManager will be queried via IPerceptionFrameProviderManager::GetFrameProvider() to get the associated IPerceptionFrameProvider.

## -examples

## -see-also
