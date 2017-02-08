---
-api-id: M:Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService.UnregisterCorrelationGroup(Windows.Devices.Perception.Provider.IPerceptionFrameProviderManager,Windows.Devices.Perception.Provider.PerceptionCorrelationGroup)
-api-type: winrt method
---

<!-- Method syntax
public void UnregisterCorrelationGroup(Windows.Devices.Perception.Provider.IPerceptionFrameProviderManager manager, Windows.Devices.Perception.Provider.PerceptionCorrelationGroup correlationGroup)
-->

# Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService.UnregisterCorrelationGroup

## -description
Unregisters a PerceptionCorrelationGroup associated with the IPerceptionFrameProviderManager.

## -parameters
### -param manager
The manager that owns the lifetime of the group.

### -param correlationGroup
The PerceptionCorrelationGroup to unregister.

## -remarks
The IPerceptionFrameProviders in the list no longer will have any correlation with each other. The group or any subset may be registered again after Unregistration completes.

## -examples

## -see-also
