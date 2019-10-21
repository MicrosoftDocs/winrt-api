---
-api-id: P:Windows.ApplicationModel.Chat.ChatMessageValidationResult.PartCount
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<uint> PartCount { get; }
-->

# Windows.ApplicationModel.Chat.ChatMessageValidationResult.PartCount

## -description
Gets the total number of text fragments needed for this message. This value has meaning when the SMS text portion of a message is validated.

## -property-value
The number of parts.

## -remarks
The SMS text portion of a message is divided into multiple parts if necessary. The PartCount value is the total count of parts required to contain this message.

## -examples

## -see-also

## -capabilities
chatSystem, smsSend, chat
