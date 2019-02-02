---
-api-id: T:Windows.Devices.Sms.SmsDeviceStatusChangedEventHandler
-api-type: winrt delegate
---
<!-- Delegate syntax.
public delegate void SmsDeviceStatusChangedEventHandler(Windows.Devices.Sms.SmsDevice sender)
-->
# Windows.Devices.Sms.SmsDeviceStatusChangedEventHandler

## -description
This handler is called when the status on the SMS device changes. Callers should implement this when they want to be notified when a significant state change occurs on the device. For example, the caller might want to know when the device is ready to send and receive messages.

> [!NOTE]
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband:  device apps](https://msdn.microsoft.com/library/windows/hardware/hh852368.aspx).

## -parameters
### -param sender
A reference to the device object that sent the event.


## -remarks

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
