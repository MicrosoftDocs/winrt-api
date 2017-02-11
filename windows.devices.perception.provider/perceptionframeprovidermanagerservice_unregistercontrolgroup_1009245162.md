---
-api-id: M:Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService.UnregisterControlGroup(Windows.Devices.Perception.Provider.IPerceptionFrameProviderManager,Windows.Devices.Perception.Provider.PerceptionControlGroup)
-api-type: winrt method
---

<!-- Method syntax
public void UnregisterControlGroup(Windows.Devices.Perception.Provider.IPerceptionFrameProviderManager manager, Windows.Devices.Perception.Provider.PerceptionControlGroup controlGroup)
-->

# Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService.UnregisterControlGroup

## -description
Removes the registration of a previously registered PerceptionControlGroup.

## -parameters
### -param manager
The manager that owns the lifetime of the group.

### -param controlGroup
The group of IPerceptionFrameProvider(s) to prevent from being controlled.

## -remarks
The service will no longer call IPerceptionFrameProviders::SetProperty() for any Frame provider in the group. After unregistering one control group, the members may be reregistered via the same or different control group(s).

## -examples

## -see-also
