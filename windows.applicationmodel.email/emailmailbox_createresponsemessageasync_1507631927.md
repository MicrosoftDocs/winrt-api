---
-api-id: M:Windows.ApplicationModel.Email.EmailMailbox.CreateResponseMessageAsync(System.String,Windows.ApplicationModel.Email.EmailMessageResponseKind,System.String,Windows.ApplicationModel.Email.EmailMessageBodyKind,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Email.EmailMessage> CreateResponseMessageAsync(System.String messageId, Windows.ApplicationModel.Email.EmailMessageResponseKind responseType, System.String subject, Windows.ApplicationModel.Email.EmailMessageBodyKind responseHeaderType, System.String responseHeader)
-->

# Windows.ApplicationModel.Email.EmailMailbox.CreateResponseMessageAsync

## -description
Creates a new response email such as Reply, Reply All, Forward, and so on.

## -parameters
### -param messageId
The ID of the message to which to respond.

### -param responseType
The type of response such as Reply, Reply All, Forward, and so on.

### -param subject
The subject for the response message.

### -param responseHeaderType
The format of the email body such as plain text or HTML.

### -param responseHeader
The header for the response message.

## -returns
The newly created response email message.

## -remarks

## -examples

## -see-also

## -capabilities
email, emailSystem
