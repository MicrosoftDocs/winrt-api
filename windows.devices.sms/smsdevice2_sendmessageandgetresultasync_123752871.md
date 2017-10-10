---
-api-id: M:Windows.Devices.Sms.SmsDevice2.SendMessageAndGetResultAsync(Windows.Devices.Sms.ISmsMessageBase)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Sms.SmsSendMessageResult> SendMessageAndGetResultAsync(Windows.Devices.Sms.ISmsMessageBase message)
-->

# Windows.Devices.Sms.SmsDevice2.SendMessageAndGetResultAsync

## -description
Asynchronously sends a message using the SMS device. The method is asynchronous because the send operation might not occur instantaneously. The message operation object is returned immediately.

## -parameters
### -param message
A reference to an object that implements the [ISmsMessageBase](ismsmessagebase.md) interface. The message can be in text or binary format.

## -returns
The message operation object.

## -remarks

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
