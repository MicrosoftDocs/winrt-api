---
-api-id: P:Windows.ApplicationModel.Chat.ChatMessageAttachment.MimeType
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public string MimeType { get;  set; }
-->

# Windows.ApplicationModel.Chat.ChatMessageAttachment.MimeType

## -description
Gets or sets the MIME type of the attachment.

## -property-value
The MIME type of the attachment.

## -remarks
A chat application handles an attachment based on the MIME type set in this property. Attachments for outgoing messages have [MimeType](chatmessageattachment_mimetype.md) set to a type string for recipient handling, such as “image/jpeg”.

## -examples

## -see-also

## -capabilities
chatSystem, smsSend, chat
