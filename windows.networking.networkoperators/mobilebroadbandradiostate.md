---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandRadioState
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Networking.NetworkOperators.MobileBroadbandRadioState : int
-->

# MobileBroadbandRadioState

## -description
Describes radio states for a Mobile Broadband device.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
> 
> If you want to use this API and publish your app to the Microsoft Store, then you'll need special approval. For more information, see the **Restricted capabilities** section in the [App capability declarations](/windows/uwp/packaging/app-capability-declarations#restricted-capabilities) topic. 

## -enum-fields
### -field Off:0
The radio is off. This can be because it has been turned off using a physical switch on the device, or using a software mechanism such as **Airplane Mode** on the control panel.

### -field On:1
The radio is on.


## -remarks

## -examples

## -see-also
## -capabilities
cellularDeviceIdentity, cellularDeviceControl
