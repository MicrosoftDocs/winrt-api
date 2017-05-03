---
-api-id: P:Windows.ApplicationModel.Chat.ChatMessageValidationResult.RemainingCharacterCountInPart
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Foundation.IReference<uint> RemainingCharacterCountInPart { get; }
-->

# Windows.ApplicationModel.Chat.ChatMessageValidationResult.RemainingCharacterCountInPart

## -description
Gets the number of characters not used in the final message fragments. This value has meaning when the SMS text portion of a message is validated.

## -property-value
The remaining characters in the part.

## -remarks
The SMS text portion of a message is divided in to multiple parts if necessary. The [RemainingCharacterCountInPart](chatmessagevalidationresult_remainingcharactercountinpart.md) value is the number of character positions that remain unused in the final message fragment.

## -examples

## -see-also
