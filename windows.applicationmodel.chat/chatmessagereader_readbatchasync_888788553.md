---
-api-id: M:Windows.ApplicationModel.Chat.ChatMessageReader.ReadBatchAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Chat.ChatMessage>> ReadBatchAsync()
-->

# Windows.ApplicationModel.Chat.ChatMessageReader.ReadBatchAsync

## -description
Returns a batch list of chat messages from the message store.

## -returns
An asynchronous operation that returns a list of chat messages upon successful completion.

## -remarks
This method returns an [IReadOnlyList](https://msdn.microsoft.com/library/hh192385.aspx) of [ChatMessage class](chatmessage.md) objects. The method is invoked as an [IAsyncOperation](http://msdn.microsoft.com/library/a20e6057-c46a-4dbf-88b0-5dc954dc0362) as shown in the following example:

```
IReadOnlyList<ChatMessage> msgList = await messageStore.GetMessageReader.ReadBatchAsync();

```



## -examples

## -see-also
[ReadBatchAsync(Int32)](chatmessagereader_readbatchasync_1346490639.md)

## -capabilities
chatSystem, smsSend, chat
blockedChatMessages
