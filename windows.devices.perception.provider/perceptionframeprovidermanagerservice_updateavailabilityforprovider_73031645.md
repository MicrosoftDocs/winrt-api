---
-api-id: M:Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService.UpdateAvailabilityForProvider(Windows.Devices.Perception.Provider.IPerceptionFrameProvider,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public void UpdateAvailabilityForProvider(Windows.Devices.Perception.Provider.IPerceptionFrameProvider provider, System.Boolean available)
-->

# Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService.UpdateAvailabilityForProvider

## -description
Sets whether or not the IPerceptionFrameProvider is available.

## -parameters
### -param provider
The provider to set availability for.

### -param available
Whether or not the provider is available.

## -remarks
Available providers are expected to be able to provide frames while unavailable providers aren't. Before calling this method, a provider is assumed to be available if registered.

## -examples

## -see-also
