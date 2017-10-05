---
-api-id: P:Windows.ApplicationModel.Chat.ChatMessageChange.ChangeType
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.ApplicationModel.Chat.ChatMessageChangeType ChangeType { get; }
-->

# Windows.ApplicationModel.Chat.ChatMessageChange.ChangeType

## -description
Gets the type of change made to a chat message, such as created, modified, etc.

## -property-value
The type of change represented by the object.

## -remarks
An application can check the change type when deciding to accept message changes or to update its private message store. The following example checks for acceptable changes.

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
chatSystem, smsSend, chat
