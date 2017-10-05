---
-api-id: P:Windows.ApplicationModel.Chat.ChatMessage.TransportId
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string TransportId { get;  set; }
-->

# Windows.ApplicationModel.Chat.ChatMessage.TransportId

## -description
Gets or sets the transport ID of the message.

## -property-value
The transport ID of the message.

## -remarks
Setting this property assigns the transport, SIM slot, to use for sending the chat message. Querying this property will identify the transport that the message was received on or is currently set for sending.

The value for [TransportId](chatmessage_transportid.md) is the string representation of the SIM slot number.

## -examples

## -see-also

## -capabilities
chatSystem, smsSend, chat
