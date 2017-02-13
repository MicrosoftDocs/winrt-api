---
-api-id: M:Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService.RegisterControlGroup(Windows.Devices.Perception.Provider.IPerceptionFrameProviderManager,Windows.Devices.Perception.Provider.PerceptionControlGroup)
-api-type: winrt method
---

<!-- Method syntax
public void RegisterControlGroup(Windows.Devices.Perception.Provider.IPerceptionFrameProviderManager manager, Windows.Devices.Perception.Provider.PerceptionControlGroup controlGroup)
-->

# Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService.RegisterControlGroup

## -description
Registers a PerceptionControlGroup associated with the IPerceptionFrameProviderManager.

## -parameters
### -param manager
The manager that owns the lifetime of the group.

### -param controlGroup
The group of IPerceptionFrameProvider(s) to control atomically.

## -remarks
The PerceptionControlGroup's ids used to create it can't appear in a PerceptionControlGroup which is already registered. Doing so raises an InvalidArgumentException.

The PerceptionControlGroup specifies which IPerceptionFrameProvider(s) will be arbitrated for control together when control is successfully requested by an app and revoked when control is revoked from the app.

When a PerceptionControlSession is acquired for a PerceptionControlGroup, that app may set properties on each provider in the group. Before the IPerceptionFrameProvider is registered in a control group, attempts to control it will fail and properties can't be set.

## -examples

## -see-also
