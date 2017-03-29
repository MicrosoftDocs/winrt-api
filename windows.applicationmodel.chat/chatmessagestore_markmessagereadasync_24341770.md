---
-api-id: M:Windows.ApplicationModel.Chat.ChatMessageStore.MarkMessageReadAsync(System.String)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction MarkMessageReadAsync(System.String localChatMessageId)
-->

# Windows.ApplicationModel.Chat.ChatMessageStore.MarkMessageReadAsync

## -description
Marks a specified message in the store as already read.

## -parameters
### -param localChatMessageId
The local ID of the message to be marked as read.

## -returns
An asynchronous action.

## -remarks
The [IsRead](chatmessage_isread.md) property of the [ChatMessage class](chatmessage.md) matching the *localMessageId* parameter is set to "true" when this method completes.

## -examples

## -see-also


## -capabilities
blockedChatMessages