---
-api-id: M:Windows.ApplicationModel.Chat.ChatMessageStore.SendMessageAsync(Windows.ApplicationModel.Chat.ChatMessage)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction SendMessageAsync(Windows.ApplicationModel.Chat.ChatMessage chatMessage)
-->

# Windows.ApplicationModel.Chat.ChatMessageStore.SendMessageAsync

## -description
Attempts to send a chat message. The message is saved to the message store as part of the send operation.

## -parameters
### -param chatMessage
The chat message to be sent.

## -returns
An asynchronous action.

## -remarks
Once the send is attempted, the message is assigned an identifier and the [Id](chatmessage_id.md) property is set to this value. If the send operation fails, the application can try sending the message again later with [RetrySendMessageAsync](chatmessagestore_retrysendmessageasync.md) method using the assigned identifier.

## -examples

## -see-also
