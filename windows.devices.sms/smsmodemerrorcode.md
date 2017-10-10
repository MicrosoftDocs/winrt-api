---
-api-id: T:Windows.Devices.Sms.SmsModemErrorCode
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.Devices.Sms.SmsModemErrorCode : int
-->

# SmsModemErrorCode

## -description
Values that describe error codes from the SMS modem in an [SmsSendMessageResult](smssendmessageresult.md).

## -enum-fields
### -field Other:0
An unknown error.

### -field MessagingNetworkError:1
A network error.

### -field SmsOperationNotSupportedByDevice:2
SMS is not supported by the device.

### -field SmsServiceNotSupportedByNetwork:3
SMS is not supported by the network.

### -field DeviceFailure:4
The device failed.

### -field MessageNotEncodedProperly:5
The message was not encoded properly.

### -field MessageTooLarge:6
The message was too large.

### -field DeviceNotReady:7
The device was not ready to send SMS.

### -field NetworkNotReady:8
The network was not ready to send SMS.

### -field InvalidSmscAddress:9
The SMSC address was not valid.

### -field NetworkFailure:10
There was a network failure.

### -field FixedDialingNumberRestricted:11
The device is restricted to a fixed dialing number list, and the number used was not in the list.


## -remarks

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
