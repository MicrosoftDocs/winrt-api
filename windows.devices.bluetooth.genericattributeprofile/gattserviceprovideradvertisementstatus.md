---
-api-id: T:Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProviderAdvertisementStatus
-api-type: winrt enum
ms.custom: 19H1
---

<!-- Enumeration syntax.
public enum GattServiceProviderAdvertisementStatus : int 
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattServiceProviderAdvertisementStatus

## -description
This enumeration defines the advertisement status of a [GattServiceProvider](gattserviceprovider.md).

## -enum-fields
### -field Stopped:1
The GATT service is not advertising.

### -field Started:2
The GATT service advertising has started.

### -field Created:0
The GATT service was created.

### -field Aborted:3
The GATT service was aborted.

### -field StartedWithoutAllAdvertisementData:4
Indicates that the system was successfully able to issue the advertisement request, but not all of the requested data could be included in the advertisement.

## -remarks

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1903 | 18362 | StartedWithoutAllAdvertisementData |

## -see-also

## -examples


## -capabilities
bluetooth

