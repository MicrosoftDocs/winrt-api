---
-api-id: M:Windows.Devices.Sms.SmsDeviceMessageStore.DeleteMessagesAsync(Windows.Devices.Sms.SmsMessageFilter)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction DeleteMessagesAsync(Windows.Devices.Sms.SmsMessageFilter messageFilter)
-->

# Windows.Devices.Sms.SmsDeviceMessageStore.DeleteMessagesAsync

## -description
Deletes the messages to which the filter applies. The filter can be used to delete all messages, or only messages that are read, unread, sent, or in a draft state. Because the operation might not be instantaneous, it executes asynchronously. The asynchronous operation object returns immediately.

## -parameters
### -param messageFilter
A search filter that specifies which messages to delete.

## -returns
A new message operation object that is used to start and track the asynchronous operation.

## -remarks

## -examples

## -see-also


## -capabilities
sms, cellularMessaging