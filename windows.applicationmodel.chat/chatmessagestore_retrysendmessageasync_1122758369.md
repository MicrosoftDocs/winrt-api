---
-api-id: M:Windows.ApplicationModel.Chat.ChatMessageStore.RetrySendMessageAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction RetrySendMessageAsync(System.String localChatMessageId)
-->

# Windows.ApplicationModel.Chat.ChatMessageStore.RetrySendMessageAsync

## -description
Attempts a retry of sending a specified message from the message store.

## -parameters
### -param localChatMessageId
The local ID of the message to be retried.

## -returns
An asynchronous action.

## -remarks
The message contents including its attachments are downloaded. An application will call this method it if it chooses to retry sending the message when the message status is [ChatMessageStatus](chatmessagestatus.md).SendFailed.

## -examples

## -see-also
