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
> This functionality is only available to mobile operator apps and UWP apps given privileged access by mobile network operators, mobile broadband adapter IHV, or OEM. For more information, see [Mobile Broadband:  device apps](http://msdn.microsoft.com/library/windows/hardware/hh852368.aspx).

## -enum-fields
### -field AcceptImmediately:0
The first action type to be taken. Messages filtered on this action type are delivered to your application and are not delivered to the messaging application to be shown to the user. Note that if multiple applications register the same filter with this action type, each application gets its own copy of the message.

### -field Drop:1
Filters with this action type are applied after **AcceptImmediately** filters. Messages filtered on this action type are dropped, and neither your app nor the messaging app receive the message or any notification that a message arrived and was dropped.

### -field Peek:2
Filters with this action type are applied after **Drop** filters. This action type allows your app to inspect each message and decide which are dropped and which continue on to be processed or shown to the user.

Note that your code is required to process each filtered message by calling either [Drop](smsmessagereceivedtriggerdetails_drop_1201404469.md) or [Accept](smsmessagereceivedtriggerdetails_accept_1944939200.md) within a maximum timeout period of 60 seconds.

### -field Accept:3
Filters with this action type are applied after **Peek** filters. Messages filtered on this action type are delivered to your app. A copy of the message can also be delivered to the messaging application to be shown to the user if appropriate. Note that if multiple applications register the same filter with this action type, each application gets its own copy of the message.

Note that the messaging app shows only text and broadcast messages to the user. So registering an Accept filter on a message that is neither text nor broadcast would not cause that message to be shown to the user.


## -remarks

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
