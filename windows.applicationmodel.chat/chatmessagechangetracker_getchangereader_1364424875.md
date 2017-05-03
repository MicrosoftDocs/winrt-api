---
-api-id: M:Windows.ApplicationModel.Chat.ChatMessageChangeTracker.GetChangeReader
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.ApplicationModel.Chat.ChatMessageChangeReader GetChangeReader()
-->

# Windows.ApplicationModel.Chat.ChatMessageChangeTracker.GetChangeReader

## -description
Returns a [ChatMessageChangeReader class](chatmessagechangereader.md) object which provides a collection of message revisions from the message store.

## -returns
The change reader associated with the change tracker.

## -remarks
The following example uses the message change reader to find the message revision total:

```
async int GetMessageRevisionCount(ChatMesssage messageStore)
{
    ChatMessageChangeTracker tracker = messageStore.ChangeTracker;
    IReadOnlyList<ChatMessageChange> changeList = await tracker.GetChangeReader().ReadBatchAsync();

    return changeList.Count;
}

```



## -examples

## -see-also


## -capabilities
blockedChatMessages