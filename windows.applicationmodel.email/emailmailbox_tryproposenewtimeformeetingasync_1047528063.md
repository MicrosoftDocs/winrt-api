---
-api-id: M:Windows.ApplicationModel.Email.EmailMailbox.TryProposeNewTimeForMeetingAsync(Windows.ApplicationModel.Email.EmailMessage,Windows.Foundation.DateTime,Windows.Foundation.TimeSpan,System.String,System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TryProposeNewTimeForMeetingAsync(Windows.ApplicationModel.Email.EmailMessage meeting, Windows.Foundation.DateTime newStartTime, Windows.Foundation.TimeSpan newDuration, System.String subject, System.String comment)
-->

# Windows.ApplicationModel.Email.EmailMailbox.TryProposeNewTimeForMeetingAsync

## -description
Asynchronously attempts to send a meeting request proposing a new time.

## -parameters
### -param meeting
The meeting for which to propose a new time.

### -param newStartTime
The proposed new time for the meeting to start.

### -param newDuration
The proposed duration of the meeting.

### -param subject
The subject of the meeting email.

### -param comment
The body of the message.

## -returns
A Boolean value indicating if the proposed meeting message was successfully sent.

## -remarks

## -examples

## -see-also

## -capabilities
email, emailSystem
