---
-api-id: T:Windows.Devices.Sms.SmsMessageRegistration
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class SmsMessageRegistration : Windows.Devices.Sms.ISmsMessageRegistration
-->

# Windows.Devices.Sms.SmsMessageRegistration

## -description
Class used to represent registered message filters.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

## -remarks
Your code does not instantiate this class directly. A newly-created instance of the class is returned by the [SmsMessageRegistration.Register](smsmessageregistration_register_1493443681.md) method, and you can retrieve a collection of instances representing existing registrations using the static [SmsMessageRegistration.AllRegistrations](smsmessageregistration_allregistrations.md) property.

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
