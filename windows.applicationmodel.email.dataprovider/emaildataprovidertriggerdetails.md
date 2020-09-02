---
-api-id: T:Windows.ApplicationModel.Email.DataProvider.EmailDataProviderTriggerDetails
-api-type: winrt class
---

<!-- Class syntax.
public class EmailDataProviderTriggerDetails : Windows.ApplicationModel.Email.DataProvider.IEmailDataProviderTriggerDetails
-->

# Windows.ApplicationModel.Email.DataProvider.EmailDataProviderTriggerDetails

## -description
Contains details about the event that triggered your email data provider background task.

This event is triggered when an email data client app has instantiated the background task that runs your email data provider. Your code should respond to this event by using the connection to register event handlers for data provider request events.

## -remarks
Your background task code is passed an instance of this class in the [IBackgroundTaskInstance.TriggerDetails](/uwp/api/Windows.ApplicationModel.Background.IBackgroundTaskInstance.TriggerDetails) property.

## -examples

## -see-also

## -capabilities
email, emailSystem
