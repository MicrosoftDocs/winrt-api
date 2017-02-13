---
-api-id: M:Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService.UnregisterFaceAuthenticationGroup(Windows.Devices.Perception.Provider.IPerceptionFrameProviderManager,Windows.Devices.Perception.Provider.PerceptionFaceAuthenticationGroup)
-api-type: winrt method
---

<!-- Method syntax
public void UnregisterFaceAuthenticationGroup(Windows.Devices.Perception.Provider.IPerceptionFrameProviderManager manager, Windows.Devices.Perception.Provider.PerceptionFaceAuthenticationGroup faceAuthenticationGroup)
-->

# Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService.UnregisterFaceAuthenticationGroup

## -description
Unregisters a PerceptionFaceAuthenticationGroup in association with the given IPerceptionProviderManager.

## -parameters
### -param manager
The manager that owns the lifetime of the group.

### -param faceAuthenticationGroup
The PerceptionFaceAuthenticationGroup to unregister.

## -remarks
This stops the providers in the group from being requested to enter Face Authentication mode or being used for Face Authentication until it's registered again. The group or any subset of it may be registered again after being unregistered.

## -examples

## -see-also
