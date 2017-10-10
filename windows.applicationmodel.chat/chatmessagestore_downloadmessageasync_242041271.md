---
-api-id: M:Windows.ApplicationModel.Chat.ChatMessageStore.DownloadMessageAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction DownloadMessageAsync(System.String localChatMessageId)
-->

# Windows.ApplicationModel.Chat.ChatMessageStore.DownloadMessageAsync

## -description
Downloads a message specified by the identifier to the message store.

## -parameters
### -param localChatMessageId
The local ID of the message to be downloaded.

## -returns
An asynchronous action.

## -remarks
The message contents including its attachments are downloaded. An application will call this method when the message status is [ChatMessageStatus](chatmessagestatus.md).ReceiveDownloadNeeded.

## -examples

## -see-also

## -capabilities
chatSystem, smsSend, chat
