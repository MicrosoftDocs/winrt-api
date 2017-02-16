---
-api-id: M:Windows.ApplicationModel.Email.EmailMailbox.TryForwardMeetingAsync(Windows.ApplicationModel.Email.EmailMessage,Windows.Foundation.Collections.IIterable{Windows.ApplicationModel.Email.EmailRecipient},System.String,Windows.ApplicationModel.Email.EmailMessageBodyKind,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TryForwardMeetingAsync(Windows.ApplicationModel.Email.EmailMessage meeting, Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Email.EmailRecipient> recipients, System.String subject, Windows.ApplicationModel.Email.EmailMessageBodyKind forwardHeaderType, System.String forwardHeader, System.String comment)
-->

# Windows.ApplicationModel.Email.EmailMailbox.TryForwardMeetingAsync

## -description
Asynchronously attempts to forward a meeting request.

## -parameters
### -param meeting
The meeting to forward.

### -param recipients
The list of new recipients.

### -param subject
The subject of the email.

### -param forwardHeaderType
The email message format, HTML or plain text.

### -param forwardHeader
The email forward header.

### -param comment
The body of the message.

## -returns
A Boolean value indicating if the meeting was successfully forwarded.

## -remarks

## -examples

## -see-also
