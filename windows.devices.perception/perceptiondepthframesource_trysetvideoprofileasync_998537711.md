---
-api-id: M:Windows.Devices.Perception.PerceptionDepthFrameSource.TrySetVideoProfileAsync(Windows.Devices.Perception.PerceptionControlSession,Windows.Devices.Perception.PerceptionVideoProfile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Perception.PerceptionFrameSourcePropertyChangeResult> TrySetVideoProfileAsync(Windows.Devices.Perception.PerceptionControlSession controlSession, Windows.Devices.Perception.PerceptionVideoProfile profile)
-->

# Windows.Devices.Perception.PerceptionDepthFrameSource.TrySetVideoProfileAsync

## -description
Attempts to set a video profile on this depth frame source. Requires an active Controller Mode control session on this frame source.

## -parameters
### -param controlSession
A PerceptionControlSession representing active control of this frame source.

### -param profile
The video profile to set.

## -returns
This method returns an PerceptionFrameSourcePropertyChangeResult object asynchronously. If the control session was still active when the video profile was set, and if the video profile is supported and can be activated, this will be a result indicating success.

## -remarks

## -examples

## -see-also
