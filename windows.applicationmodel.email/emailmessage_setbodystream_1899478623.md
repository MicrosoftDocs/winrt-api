---
-api-id: M:Windows.ApplicationModel.Email.EmailMessage.SetBodyStream(Windows.ApplicationModel.Email.EmailMessageBodyKind,Windows.Storage.Streams.IRandomAccessStreamReference)
-api-type: winrt method
---

<!-- Method syntax
public void SetBodyStream(Windows.ApplicationModel.Email.EmailMessageBodyKind type, Windows.Storage.Streams.IRandomAccessStreamReference stream)
-->

# Windows.ApplicationModel.Email.EmailMessage.SetBodyStream

## -description
Sets the value of the specified body stream in an email message.

## -parameters
### -param type
Indicates which body stream, plain text or HTML.

### -param stream
The message for the specified body stream.

>[!Note]
The [EmailManager.ShowComposeNewEmailAsync](emailmanager_showcomposenewemailasync_1879015237.md), and [EmailManagerForUser.ShowComposeNewEmailAsync](emailmanagerforuser_showcomposenewemailasync_1879015237.md) methods won't recognize an HTML formatted body. You can only use those methods to send email in plain text.

## -remarks

## -examples

## -see-also

## -capabilities
email, emailSystem
