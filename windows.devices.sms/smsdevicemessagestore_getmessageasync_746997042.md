---
-api-id: M:Windows.Devices.Sms.SmsDeviceMessageStore.GetMessageAsync(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Devices.Sms.ISmsMessage> GetMessageAsync(System.UInt32 messageId)
-->

# Windows.Devices.Sms.SmsDeviceMessageStore.GetMessageAsync

## -description
Retrieves the message with the specified ID. The device might be busy, so the method executes asynchronously. The asynchronous operation object returns immediately.

## -parameters
### -param messageId
ID of the message to retrieve.

## -returns
Returns a new message operation object that is used to start and track the asynchronous operation.

## -remarks

## -examples

## -see-also


## -capabilities
sms, cellularMessaging