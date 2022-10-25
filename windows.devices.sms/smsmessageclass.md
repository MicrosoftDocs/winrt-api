---
-api-id: T:Windows.Devices.Sms.SmsMessageClass
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.Sms.SmsMessageClass : int
-->

# SmsMessageClass

## -description
This enumerated type specifies the message class of a message. The message class typically originates on the network, not the mobile device.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

## -enum-fields
### -field None:0
No class was specified.

### -field Class0:1
Message should be immediately displayed.

### -field Class1:2
Mobile equipment (ME) specific message.

### -field Class2:3
SIM specific message.

### -field Class3:4
Terminal equipment (TE) specific message. Note that this message type is not currently supported.


## -remarks

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
