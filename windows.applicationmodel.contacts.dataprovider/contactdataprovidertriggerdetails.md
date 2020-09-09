---
-api-id: T:Windows.ApplicationModel.Contacts.DataProvider.ContactDataProviderTriggerDetails
-api-type: winrt class
---

<!-- Class syntax.
public class ContactDataProviderTriggerDetails : Windows.ApplicationModel.Contacts.DataProvider.IContactDataProviderTriggerDetails
-->

# Windows.ApplicationModel.Contacts.DataProvider.ContactDataProviderTriggerDetails

## -description
Contains details about the event that triggered your contact data provider background task.

This event is triggered when a contact data client app has instantiated the background task that runs your contact data provider. Your code should respond to this event by using the Connection property to register event handlers for contact provider request events.

## -remarks
Your background task code is passed an instance of this class in the [IBackgroundTaskInstance.TriggerDetails](/uwp/api/Windows.ApplicationModel.Background.IBackgroundTaskInstance.TriggerDetails) property.

## -examples

## -see-also

## -capabilities
contactsSystem
