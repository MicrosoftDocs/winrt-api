---
-api-id: M:Windows.Media.Effects.AcousticEchoCancellationConfiguration.SetEchoCancellationRenderEndpoint(System.String)
-api-type: winrt method
---

# Windows.Media.Effects.AcousticEchoCancellationConfiguration.SetEchoCancellationRenderEndpoint(System.String)

<!--
public void SetEchoCancellationRenderEndpoint (string deviceId);
-->


## -description

Sets the endpoint that should be used as the loopback reference by the Acoustic Echo Cancellation (AEC) effect.  

## -parameters

### -param deviceId

The device ID of the device to use as the loopback reference.

## -remarks

Passing in a null string as the deviceId parameter will result in the loopback endpoint being reset to its default value. 

## -see-also

## -examples


