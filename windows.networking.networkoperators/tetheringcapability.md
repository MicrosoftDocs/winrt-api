---
-api-id: T:Windows.Networking.NetworkOperators.TetheringCapability
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Networking.NetworkOperators.TetheringCapability : int
-->

# TetheringCapability

## -description
Defines values that can be returned after calling [NetworkOperatorTetheringManager.GetTetheringCapability](networkoperatortetheringmanager_gettetheringcapability_1651407752.md) to indicate the tethering capabilities of a network account.

## -enum-fields
### -field Enabled:0
Tethering is enabled.

### -field DisabledByGroupPolicy:1
Tethering is disabled according to the current group policy.

### -field DisabledByHardwareLimitation:2
Tethering not available due to hardware limitations.

### -field DisabledByOperator:3
Tethering operations disabled for this account by the network operator.

### -field DisabledBySku:4
Tethering is not supported by the current account services.

### -field DisabledByRequiredAppNotInstalled:5
An application required for tethering operations is not available.

### -field DisabledDueToUnknownCause:6
Tethering is disabled for unknown reasons.

### -field DisabledBySystemCapability:7
Tethering has been disabled by the system because the app lacks the necessary **DeviceCapability** entry in its manifest. See [CreateFromConnectionProfile](/uwp/api/windows.networking.networkoperators.networkoperatortetheringmanager.createfromconnectionprofile) for more information about manifest requirements.

## -remarks

## -examples

## -see-also

## -capabilities
cellularDeviceIdentity, cellularDeviceControl
