---
-api-id: M:Windows.ApplicationModel.Background.GattCharacteristicNotificationTrigger.#ctor(Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic)
-api-type: winrt method
---

<!-- Method syntax
public GattCharacteristicNotificationTrigger(Windows.Devices.Bluetooth.GenericAttributeProfile.GattCharacteristic characteristic)
-->

# Windows.ApplicationModel.Background.GattCharacteristicNotificationTrigger.GattCharacteristicNotificationTrigger

## -description
Initializes a new instance of the [GattCharacteristicNotificationTrigger](gattcharacteristicnotificationtrigger.md) class.

## -parameters
### -param characteristic
The GATT characteristic for which value change notifications are desired.

## -remarks
To register for notifications when the value of a GATT characteristic changes, an app does the following:

1. Create an instance of the [GattCharacteristicNotificationTrigger](gattcharacteristicnotificationtrigger.md) object.

2. Create an instance of the [BackgroundTaskBuilder](backgroundtaskbuilder.md) object, and call [SetTrigger](backgroundtaskbuilder_settrigger_2125876510.md) to attach the GattCharacteristicNotificationTrigger.

3. Call [Register](backgroundtaskbuilder_register_292201929.md) on the BackgroundTaskBuilder object.

Note that this can only be done for Bluetooth LE devices, and only for characteristics for which the device is willing to generate notifications or indications. The system will attempt to keep the specified Bluetooth LE device in a connected state as long as at least one of the notification triggers is outstanding.

## -examples

## -see-also
