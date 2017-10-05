---
-api-id: M:Windows.ApplicationModel.Chat.ChatMessageStore.GetMessageAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Chat.ChatMessage> GetMessageAsync(System.String localChatMessageId)
-->

# Windows.ApplicationModel.Chat.ChatMessageStore.GetMessageAsync

## -description
Retrieves a message specified by an identifier from the message store.

## -parameters
### -param localChatMessageId
The local ID of the chat message to be retrieved.

## -returns
An asynchronous operation that returns a chat message upon successful completion.

## -remarks
The message corresponding to the specified identifier is returned. An application can use this method to display a message or store messages in its own private cache.

## -examples

## -see-also


## -capabilities
chatSystem, smsSend, chat
blockedChatMessages
