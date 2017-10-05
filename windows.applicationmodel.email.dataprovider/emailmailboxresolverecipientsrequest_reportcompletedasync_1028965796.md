---
-api-id: M:Windows.ApplicationModel.Email.DataProvider.EmailMailboxResolveRecipientsRequest.ReportCompletedAsync(Windows.Foundation.Collections.IIterable{Windows.ApplicationModel.Email.EmailRecipientResolutionResult})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ReportCompletedAsync(Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Email.EmailRecipientResolutionResult> resolutionResults)
-->

# Windows.ApplicationModel.Email.DataProvider.EmailMailboxResolveRecipientsRequest.ReportCompletedAsync

## -description
Informs the email client that the request was processed successfully.

Successful completion of the asynchronous operation indicates that the recipient list was processed successfully. Note, though, that this does not mean that all of the names have been successfully resolved. Your code must check the status of each [EmailRecipientResolutionResult](../windows.applicationmodel.email/emailrecipientresolutionresult.md) item in the *resolutionResults* list to determine whether all of the names have been successfully resolved..

## -parameters
### -param resolutionResults
A list of [EmailRecipientResolutionResult](../windows.applicationmodel.email/emailrecipientresolutionresult.md) objects with details about resolution results.

## -returns
An asynchronous resolve operation on an [EmailMailboxResolveRecipientsRequest](emailmailboxresolverecipientsrequest.md).

## -remarks

## -examples

## -see-also

## -capabilities
email, emailSystem
