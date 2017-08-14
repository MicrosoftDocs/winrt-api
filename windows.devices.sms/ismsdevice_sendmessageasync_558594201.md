---
-api-id: M:Windows.Devices.Sms.ISmsDevice.SendMessageAsync(Windows.Devices.Sms.ISmsMessage)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Devices.Sms.SendSmsMessageOperation SendMessageAsync(Windows.Devices.Sms.ISmsMessage message)
-->

# Windows.Devices.Sms.ISmsDevice.SendMessageAsync

## -description
Asynchronously sends a message using the SMS device. The method is asynchronous because the send operation might not occur instantaneously. The asynchronous operation object is returned immediately.

## -parameters
### -param message
A reference to an SmsMessage object. The message can be in text or binary format.

## -returns
A reference to an [SendSmsMessageOperation](sendsmsmessageoperation.md) object that supports asynchronous message sending.

## -remarks

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
