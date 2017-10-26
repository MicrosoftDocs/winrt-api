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
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband:  device apps](http://msdn.microsoft.com/library/windows/hardware/hh852368.aspx).

## -remarks
Your code does not instantiate this class directly. A newly-created instance of the class is returned by the [SmsMessageRegistration.Register](smsmessageregistration_register.md) method, and you can retrieve a collection of instances representing existing registrations using the static [SmsMessageRegistration.AllRegistrations](smsmessageregistration_allregistrations.md) property.

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
