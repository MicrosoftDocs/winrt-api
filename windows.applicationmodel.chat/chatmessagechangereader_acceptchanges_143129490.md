---
-api-id: M:Windows.ApplicationModel.Chat.ChatMessageChangeReader.AcceptChanges
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void AcceptChanges()
-->

# Windows.ApplicationModel.Chat.ChatMessageChangeReader.AcceptChanges

## -description
Accepts all the changes up to and including the latest change to the message.

## -remarks
The AcceptChanges method accepts all the message changes currently tracked by the change tracker. Calling AcceptChanges will cause change tracking to reset and tracking will begin again with the next message change.

## -examples

## -see-also


## -capabilities
chatSystem, smsSend, chat
blockedChatMessages
