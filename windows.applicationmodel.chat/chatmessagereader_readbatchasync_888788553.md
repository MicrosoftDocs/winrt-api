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
This method returns an [IReadOnlyList](/dotnet/api/system.collections.generic.ireadonlylist-1?view=dotnet-uwp-10.0&preserve-view=true) of [ChatMessage class](chatmessage.md) objects. The method is invoked as an [IAsyncOperation](/previous-versions/bb776309(v=vs.85)) as shown in the following example:

```
IReadOnlyList<ChatMessage> msgList = await messageStore.GetMessageReader.ReadBatchAsync();

```



## -examples

## -see-also
[ReadBatchAsync(Int32)](chatmessagereader_readbatchasync_1346490639.md)

## -capabilities
chatSystem, smsSend, chat
blockedChatMessages
