---
-api-id: E:Windows.ApplicationModel.Chat.ChatMessageStore.MessageChanged
-api-type: winrt event
-api-device-family-note: xbox
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler MessageChanged<Windows.ApplicationModel.Chat.ChatMessageStore,  Windows.ApplicationModel.Chat.ChatMessageChangedEventArgs>
-->

# Windows.ApplicationModel.Chat.ChatMessageStore.MessageChanged

## -description
An event that occurs when a message in the message store is changed.

## -remarks
The following simple example demonstrates how to declare and enable change tracking for message changes.

```
void ChatMessageStore_MessageChanged(ChatMessageStore store, ChatMessageChangedEventArgs changeArgs)
{
    // Act on the event…
}

void SetStoreProperties(ChatMessageStore store)
{
    store.MessageChanged += ChatMessageStore_MessageChanged;
    store.ChangeTracker.Enable();
}
```



## -examples

## -see-also


## -capabilities
blockedChatMessages