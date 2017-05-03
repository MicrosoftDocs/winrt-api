---
-api-id: T:Windows.ApplicationModel.Chat.ChatStoreChangedEventKind
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.ApplicationModel.Chat.ChatStoreChangedEventKind : int
-->

# ChatStoreChangedEventKind

## -description
Specifies the type of change that occurred for a [ChatMessageStoreChanged](chatmessagestorechangedeventargs.md) event.

## -enum-fields
### -field NotificationsMissed:0
Notifications have been missed

### -field StoreModified:1
The chat store has been modified

### -field MessageCreated:2
A chat message has been created

### -field MessageModified:3
A chat message has been changed

### -field MessageDeleted:4
A chat message has been deleted

### -field ConversationModified:5
A chat conversation has been modified

### -field ConversationDeleted:6
A chat conversation has been deleted

### -field ConversationTransportDeleted:7
A chat conversation has been deleted of all messages from a transport.


## -remarks

## -examples

## -see-also