---
-api-id: T:Windows.Networking.NetworkOperators.NetworkRegistrationState
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Networking.NetworkOperators.NetworkRegistrationState : int
-->

# NetworkRegistrationState

## -description
Describes the network registration state of a mobile broadband device.

> [!NOTE]
> This functionality is only available to mobile operator apps and Windows Store app given privileged access by mobile network operators.

For permission to use this API, please reach out to [Network Operators API Permissions](mailto:netopperm@microsoft.com).

For technical help with this API, please reach out to [Network Operators API Help](mailto:netophelp@microsoft.com)

## -enum-fields
### -field None:0
No connectivity.

### -field Deregistered:1
The device is not registered and is not searching for a network provider.

### -field Searching:2
The device is not registered and is searching for a network provider.

### -field Home:3
The device is on a home network provider.

### -field Roaming:4
The device is on a roaming network provider.

### -field Partner:5
The device is on a roaming partner network provider.

### -field Denied:6
The device was denied registration. Emergency voice calls may be made. This applies to voice and not data.


## -remarks

## -examples

## -see-also