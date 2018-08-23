---
-api-id: M:Windows.ApplicationModel.Chat.ChatMessageManager.ShowComposeSmsMessageAsync(Windows.ApplicationModel.Chat.ChatMessage)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ShowComposeSmsMessageAsync(Windows.ApplicationModel.Chat.ChatMessage message)
-->

# Windows.ApplicationModel.Chat.ChatMessageManager.ShowComposeSmsMessageAsync

## -description
Shows the compose SMS dialog, pre-populated with data from the supplied [ChatMessage](chatmessage.md) object, allowing the user to send an SMS message.

## -parameters
### -param message
The chat message.

## -returns
An asynchronous action.

## -remarks
The [TransportId](chatmessage_transportid.md) property of the message is set to the desired outgoing transport. The [ChatMessage.Body](chatmessage_body.md) property is optionally set to any initial text. The following example shows a call to [ShowComposeSmsMessageAsync](chatmessagemanager_showcomposesmsmessageasync_1632642119.md) with the transport and initial text for a message:

```
async void ComposeMessage()
{
    ChatMessage message;
    message.Body = "Sent from *SpiffyChat*: How’s your morning going?";
    message.TransportId = "0";
    message.Recipients.Add("+12065551234"); 

    await ChatMessageManager.ShowComposeSmsMessageAsync(message);
}

```



## -examples

## -see-also

## -capabilities
chatSystem, smsSend, chat
