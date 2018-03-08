---
-api-id: M:Windows.ApplicationModel.Email.EmailManager.ShowComposeNewEmailAsync(Windows.ApplicationModel.Email.EmailMessage)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ShowComposeNewEmailAsync(Windows.ApplicationModel.Email.EmailMessage message)
-->

# Windows.ApplicationModel.Email.EmailManager.ShowComposeNewEmailAsync

## -description
Launches the email application with a new message displayed.

## -parameters
### -param message
The email message that is displayed when the email application is launched.

## -returns
An asynchronous action used to indicate when the operation has completed.

## -remarks
Call this method from the main UI thread.

>[!NOTE]
This method only sends plain text messages. You can't set the body of the message to the HTML format.

## -examples

## -see-also

## -capabilities
email, emailSystem
