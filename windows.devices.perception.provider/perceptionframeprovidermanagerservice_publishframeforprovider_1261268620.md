---
-api-id: M:Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService.PublishFrameForProvider(Windows.Devices.Perception.Provider.IPerceptionFrameProvider,Windows.Devices.Perception.Provider.PerceptionFrame)
-api-type: winrt method
---

<!-- Method syntax
public void PublishFrameForProvider(Windows.Devices.Perception.Provider.IPerceptionFrameProvider provider, Windows.Devices.Perception.Provider.PerceptionFrame frame)
-->

# Windows.Devices.Perception.Provider.PerceptionFrameProviderManagerService.PublishFrameForProvider

## -description
Sends the PerceptionFrame to the service to tell any apps listening for frames for the provided provider. Frames aren't expected to be published before IPerceptionFrameProvider::Start() is called or after IPerceptionFrameProvider::Stop() is called.

## -parameters
### -param provider
The IPerceptionFrameProvider which produced the frame.

### -param frame
The PerceptionFrame that was produced and should be sent to apps.

## -remarks

## -examples

## -see-also
