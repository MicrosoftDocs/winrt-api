---
-api-id: M:Windows.ApplicationModel.Chat.ChatMessageChangeReader.AcceptChangesThrough(Windows.ApplicationModel.Chat.ChatMessageChange)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void AcceptChangesThrough(Windows.ApplicationModel.Chat.ChatMessageChange lastChangeToAcknowledge)
-->

# Windows.ApplicationModel.Chat.ChatMessageChangeReader.AcceptChangesThrough

## -description
Accepts all the changes up to and including a specified change.

## -parameters
### -param lastChangeToAcknowledge
The last change to acknowledge.

## -remarks
The [AcceptChangesThrough](chatmessagechangereader_acceptchangesthrough.md) method accepts all the message changes currently tracked up to and including the change specified in *lastChangeToAcknowledge*. Calling [AcceptChangesThrough](chatmessagechangereader_acceptchangesthrough.md) will cause change tracking to reset and tracking will begin again with the next message change.

## -examples

## -see-also


## -capabilities
blockedChatMessages