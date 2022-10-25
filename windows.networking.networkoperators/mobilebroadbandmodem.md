---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandModem
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class MobileBroadbandModem : Windows.Networking.NetworkOperators.IMobileBroadbandModem
-->

# Windows.Networking.NetworkOperators.MobileBroadbandModem

## -description
Represents a mobile broadband modem.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | GetIsPassthroughEnabledAsync |
| 1709 | 16299 | SetIsPassthroughEnabledAsync |
| 1803 | 17134 | IsInEmergencyCallMode |
| 1803 | 17134 | IsInEmergencyCallModeChanged |
| 1803 | 17134 | TryGetPcoAsync |

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
