---
-api-id: T:Windows.Devices.Sms.SmsFilterActionType
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.Sms.SmsFilterActionType : int
-->

# SmsFilterActionType

## -description
Values that describe the action to be taken on a message filter.

Messaging apps use SMS filters when they use SMS to communicate app-specific data that is not necessarily intended to be displayed to the user. Note that filters are processed in a fixed order, by filter action type. All **AcceptImmediately** filters are processed first, then all **Drop** filters, and so on.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband](/windows-hardware/drivers/mobilebroadband/index).

## -enum-fields
### -field AcceptImmediately:0
The first action type to be taken. Messages filtered on this action type are delivered to your application and are not delivered to the messaging application to be shown to the user. Note that if multiple applications register the same filter with this action type, each application gets its own copy of the message. To prevent the application from accidentally consuming all user text messages, there is an additional requirement for [SMS filter rule](smsfilterrule.md) with [SMS message type](smsmessagetype.md) Text and [SMS action type](smsfilteractiontype.md) **AcceptImmediately** to provide atleast one [TextMessagePrefixes](smsfilterrule_textmessageprefixes.md) with minimum 3 characters in the prefix.

> [!NOTE]
> In order to receive the next SMS message, you need to process each filtered message by calling [Accept](smsmessagereceivedtriggerdetails_accept_1944939200.md). Failure to accept the message is considered an exceptional case (such as battery removal, application stop, or crash), and in that case the message will be redelivered on restart.

### -field Drop:1
Filters with this action type are applied after **AcceptImmediately** filters. Messages filtered on this action type are dropped, and neither your app nor the messaging app receive the message or any notification that a message arrived and was dropped.

### -field Peek:2
Filters with this action type are applied after **Drop** filters. This action type allows your application to inspect each message, and decide which are dropped and which continue on to be processed or shown to the user.

> [!NOTE]
> You need to process each filtered message by calling either [Drop](smsmessagereceivedtriggerdetails_drop_1201404469.md) or [Accept](smsmessagereceivedtriggerdetails_accept_1944939200.md) within a maximum timeout period of 60 seconds. **Peek** filters are expected to be used by spam filters or virus scans which require dynamic code inspection that cannot be done using the existing filter mechanisms provided by the [SMS filter rule](smsfilterrule.md). Using this action type can slow down the SMS message delivery in the system so your application should process the message as quickly as possible.

### -field Accept:3
Filters with this action type are applied after **Peek** filters. Messages filtered on this action type are delivered to your app. A copy of the message can also be delivered to the messaging application to be shown to the user if appropriate. Note that if multiple applications register the same filter with this action type, each application gets its own copy of the message.

> [!NOTE]
> The messaging app shows only text and broadcast messages to the user. So registering an Accept filter on a message that is neither text nor broadcast would not cause that message to be shown to the user. In order to receive the next SMS message, you need to process each filtered message by calling [Accept](smsmessagereceivedtriggerdetails_accept_1944939200.md). Failure to accept the message is considered an exceptional case (such as battery removal, application stop, or crash), and in that case the message will be redelivered on restart.

## -remarks

## -examples
(SMS send and receive)[https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/SmsSendAndReceive]

## -see-also


## -capabilities
cellularMessaging, sms
