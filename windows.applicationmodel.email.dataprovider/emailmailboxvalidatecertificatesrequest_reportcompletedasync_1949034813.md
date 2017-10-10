---
-api-id: M:Windows.ApplicationModel.Email.DataProvider.EmailMailboxValidateCertificatesRequest.ReportCompletedAsync(Windows.Foundation.Collections.IIterable{Windows.ApplicationModel.Email.EmailCertificateValidationStatus})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ReportCompletedAsync(Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Email.EmailCertificateValidationStatus> validationStatuses)
-->

# Windows.ApplicationModel.Email.DataProvider.EmailMailboxValidateCertificatesRequest.ReportCompletedAsync

## -description
Informs the email client that the request was processed successfully. Note that success does not mean that all certificates validated successfully. Rather, it means that all certificates' validation status was assessed.

## -parameters
### -param validationStatuses
A list of [EmailCertificateValidationStatus](../windows.applicationmodel.email/emailcertificatevalidationstatus.md) values. The first status value in this list is the status of the first certificate in the [Certificates](emailmailboxvalidatecertificatesrequest_certificates.md) property of the original request.

## -returns
An asynchronous validation operation on an [EmailMailboxValidateCertificatesRequest](emailmailboxvalidatecertificatesrequest.md).

## -remarks

## -examples

## -see-also

## -capabilities
email, emailSystem
