---
-api-id: P:Windows.ApplicationModel.Chat.ChatMessageValidationResult.MaxPartCount
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<uint> MaxPartCount { get; }
-->

# Windows.ApplicationModel.Chat.ChatMessageValidationResult.MaxPartCount

## -description
Gets the maximum number of text fragments allowed for a message. This value has meaning when the SMS text portion of a message is validated.

## -property-value
The maximum number of parts.

## -remarks
The SMS text portion of a message is divided into multiple parts if necessary. The MaxPartCount value is the total count of parts allowed for any message.

## -examples

## -see-also

## -capabilities
chatSystem, smsSend, chat
