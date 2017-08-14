---
-api-id: M:Windows.Devices.Sms.SmsDeviceMessageStore.DeleteMessageAsync(System.UInt32)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction DeleteMessageAsync(System.UInt32 messageId)
-->

# Windows.Devices.Sms.SmsDeviceMessageStore.DeleteMessageAsync

## -description
Deletes the message with the specified ID. Because the device might be busy, the operation executes asynchronously. The asynchronous operation object returns immediately.

## -parameters
### -param messageId
Integer ID of the message to delete, which was previously read from an SmsTextMessage object obtained from the device message store.

## -returns
A new message operation object that is used to start and track the asynchronous operation.

## -remarks

## -examples

## -see-also


## -capabilities
cellularMessaging, sms
