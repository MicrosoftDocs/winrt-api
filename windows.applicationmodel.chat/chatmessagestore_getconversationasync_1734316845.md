---
-api-id: M:Windows.ApplicationModel.Chat.ChatMessageStore.GetConversationAsync(System.String,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Chat.ChatConversation> GetConversationAsync(System.String conversationId, Windows.Foundation.Collections.IIterable<System.String> transportIds)
-->

# Windows.ApplicationModel.Chat.ChatMessageStore.GetConversationAsync

## -description
Asynchronously gets a [ChatConversation](chatconversation.md) by ID using the specified transports.

## -parameters
### -param conversationId
The ID of the conversation to retrieve.

### -param transportIds
The IDs of the transports to use to retrieve the [ChatConversation](chatconversation.md).

## -returns
The [ChatConversation](chatconversation.md) specified by the *conversationId* parameter.

## -remarks

## -examples

## -see-also
[GetConversationAsync(String)](chatmessagestore_getconversationasync_2049140047.md)