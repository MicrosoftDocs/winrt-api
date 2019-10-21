---
-api-id: P:Windows.ApplicationModel.Chat.ChatMessageAttachment.DataStreamReference
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Storage.Streams.IRandomAccessStreamReference DataStreamReference { get;  set; }
-->

# Windows.ApplicationModel.Chat.ChatMessageAttachment.DataStreamReference

## -description
Gets or sets a stream reference for a message attachment.

## -property-value
The data stream for the attachment.

## -remarks
The data source for an attachment is accessed through a [IRandomAccessStreamReference](../windows.storage.streams/irandomaccessstreamreference.md) interface. The DataStreamReference property is set to the stream reference that encapsulates the attachment data.

## -examples

## -see-also

## -capabilities
chatSystem, smsSend, chat
