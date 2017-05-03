---
-api-id: M:Windows.ApplicationModel.Chat.ChatMessageChangeTracker.Reset
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void Reset()
-->

# Windows.ApplicationModel.Chat.ChatMessageChangeTracker.Reset

## -description
Resets change tracking for the messages in the message store. The first revision begins with the next message change.

## -remarks
The following example resets change tracking when the revision change type indicates [ChatMessageChangeType](chatmessagechangetype.md).ChangeTrackingLost:

```
switch (messageChange.ChangeType)
{
    case ChatMessageChangeType.MessageCreated:
    case ChatMessageChangeType.MessageDeleted:
    case ChatMessageChangeType.MessageModified:
        messageStore.ChangeTracker.GetChangeReader.AcceptChanges();
        break;
    case ChatMessageChangeType.ChangeTrackingLost:
        messageStore.ChangeTracker.Reset();
        break;
    default:
        break
}


```



## -examples

## -see-also


## -capabilities
blockedChatMessages