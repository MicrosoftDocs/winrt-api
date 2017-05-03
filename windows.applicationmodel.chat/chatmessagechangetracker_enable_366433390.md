---
-api-id: M:Windows.ApplicationModel.Chat.ChatMessageChangeTracker.Enable
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Enable()
-->

# Windows.ApplicationModel.Chat.ChatMessageChangeTracker.Enable

## -description
Enables change tracking for the messages in the message store.

## -remarks
Change tracking for messages in the message store is enabled from the [ChangeTracker](chatmessagestore_changetracker.md) property of the [ChatMessageStore](chatmessagestore.md) object. This is accomplished as shown in the following example:

```
void TurnOnChangeTracking(ChatMessageStore messageStore)
{
    messageStore.ChangeTracker.Enable();
}


```



## -examples

## -see-also


## -capabilities
blockedChatMessages