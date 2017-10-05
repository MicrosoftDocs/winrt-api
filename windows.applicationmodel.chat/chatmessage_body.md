---
-api-id: P:Windows.ApplicationModel.Chat.ChatMessage.Body
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string Body { get;  set; }
-->

# Windows.ApplicationModel.Chat.ChatMessage.Body

## -description
Gets or sets the body of the chat message.

## -property-value
The body of the chat message.

## -remarks
When an application invokes the compose task, the [Body](chatmessage_body.md) property can contain an initialized string value to appear when the compose task is launched.

If a message has more than one recipient and group text is enabled, the default case, the message is sent as an MMS message. In this situation, the message text is included as the first attachment and not in the [Body](chatmessage_body.md). For a message with a single recipient, the [Body](chatmessage_body.md) is used for an SMS message and [Subject](chatmessage_subject.md) property is valid for an MMS message.

## -examples

## -see-also

## -capabilities
chatSystem, smsSend, chat
