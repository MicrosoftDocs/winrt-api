---
-api-id: T:Windows.Devices.Sms.SmsStatusMessage
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class SmsStatusMessage : Windows.Devices.Sms.ISmsMessageBase, Windows.Devices.Sms.ISmsStatusMessage
-->

# Windows.Devices.Sms.SmsStatusMessage

## -description
Encapsulates an SMS status message.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

To access a received status message, create a background task that is triggered by the SmsMessageReceived event. In that task, first use [SmsMessageReceivedTriggerDetails.MessageType](smsmessagereceivedtriggerdetails_messagetype.md) to determine that the message is a status message, then use the [SmsMessageReceivedTriggerDetails.StatusMessage](smsmessagereceivedtriggerdetails_textmessage.md) property to access the instance of this class.

## -remarks

## -examples

## -see-also
[ISmsMessageBase](ismsmessagebase.md), [ISmsMessage](ismsmessage.md)

## -capabilities
cellularMessaging, sms
