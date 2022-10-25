---
-api-id: T:Windows.Devices.Sms.SmsMessageReceivedTriggerDetails
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class SmsMessageReceivedTriggerDetails : Windows.Devices.Sms.ISmsMessageReceivedTriggerDetails
-->

# Windows.Devices.Sms.SmsMessageReceivedTriggerDetails

## -description
Contains event details for the event raised when an SMS message is received.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

## -remarks
You access an SmsMessageReceivedTriggerDetails object through the function that you implement to handle the [SmsMessageRegistration.MessageReceived](smsmessageregistration_messagereceived.md) event.

Your filtering code is required to acknowledge each filtered message by calling [Drop](smsmessagereceivedtriggerdetails_drop_1201404469.md) or [Accept](smsmessagereceivedtriggerdetails_accept_1944939200.md) before it can process the next message.

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
