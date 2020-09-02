---
-api-id: M:Windows.ApplicationModel.Chat.ChatMessageChangeReader.ReadBatchAsync
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Chat.ChatMessageChange>> ReadBatchAsync()
-->

# Windows.ApplicationModel.Chat.ChatMessageChangeReader.ReadBatchAsync

## -description
Returns a batch list of chat message change objects from the message store’s change tracker.

## -returns
An asynchronous operation that returns a list of changes.

## -remarks
This method returns an IReadOnlyList of [ChatMessageChange class](chatmessagechange.md) objects. The method is invoked as an [IAsyncOperation](/previous-versions/bb776309(v=vs.85)) as shown in the following example:

```
ChatMessageChangeTracker tracker = messageStore.ChangeTracker;
IReadOnlyList<ChatMessageChange> changeList = await tracker.GetChangeReader.ReadBatchAsync();

```



## -examples

## -see-also


## -capabilities
chatSystem, smsSend, chat
blockedChatMessages
