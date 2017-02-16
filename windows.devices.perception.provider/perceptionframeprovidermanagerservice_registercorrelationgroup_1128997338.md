---
-api-id: M:Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService.RegisterCorrelationGroup(Windows.Devices.Perception.Provider.IPerceptionFrameProviderManager,Windows.Devices.Perception.Provider.PerceptionCorrelationGroup)
-api-type: winrt method
---

<!-- Method syntax
public void RegisterCorrelationGroup(Windows.Devices.Perception.Provider.IPerceptionFrameProviderManager manager, Windows.Devices.Perception.Provider.PerceptionCorrelationGroup correlationGroup)
-->

# Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService.RegisterCorrelationGroup

## -description
Registers a PerceptionCorrelationGroup associated with the IPerceptionFrameProviderManager.

## -parameters
### -param manager
The manager that owns the lifetime of the group.

### -param correlationGroup
The group of PerceptionCorrelations(s) to control atomically.

## -remarks
This method enables finding correlated intrinsics and mappings to project and unproject frames between two correlated IPerceptionFrameProviders. Providers that aren't directly correlated together will not be correlatable with each other. An InvalidArgumentException is raised if a provider is in more than one registered PerceptionCorrelationGroup.

## -examples

## -see-also
