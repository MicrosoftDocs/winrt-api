---
-api-id: P:Windows.ApplicationModel.Chat.ChatMessageValidationResult.Status
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.ApplicationModel.Chat.ChatMessageValidationStatus Status { get; }
-->

# Windows.ApplicationModel.Chat.ChatMessageValidationResult.Status

## -description
Gets the message validation status code.

## -property-value
The status of the validation.

## -remarks
When Status is not [ChatMessageValidationStatus](chatmessagevalidationstatus.md).Valid, the status result indicates the first error condition found. A message may have additional errors, and a second validation will return the next error found if the previous error is resolved.

## -examples

## -see-also

## -capabilities
chatSystem, smsSend, chat
