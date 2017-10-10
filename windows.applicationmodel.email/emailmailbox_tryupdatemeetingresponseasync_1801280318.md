---
-api-id: M:Windows.ApplicationModel.Email.EmailMailbox.TryUpdateMeetingResponseAsync(Windows.ApplicationModel.Email.EmailMessage,Windows.ApplicationModel.Email.EmailMeetingResponseType,System.String,System.String,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TryUpdateMeetingResponseAsync(Windows.ApplicationModel.Email.EmailMessage meeting, Windows.ApplicationModel.Email.EmailMeetingResponseType response, System.String subject, System.String comment, System.Boolean sendUpdate)
-->

# Windows.ApplicationModel.Email.EmailMailbox.TryUpdateMeetingResponseAsync

## -description
Asynchronously attempts to respond to a meeting request.

## -parameters
### -param meeting
The meeting request.

### -param response
The response to the meeting request, accept, decline, or tentative.

### -param subject
The subject of the response email message.

### -param comment
The body of the response email message.

### -param sendUpdate
A Boolean indicating whether or not to send a response to the meeting originator.

## -returns
A Boolean value indicating if the response was sent successfully.

## -remarks

## -examples

## -see-also

## -capabilities
email, emailSystem
