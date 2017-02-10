---
-api-id: P:Windows.ApplicationModel.Contacts.DataProvider.ContactDataProviderTriggerDetails.Connection
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Contacts.DataProvider.ContactDataProviderConnection Connection { get; }
-->

# Windows.ApplicationModel.Contacts.DataProvider.ContactDataProviderTriggerDetails.Connection

## -description
Gets the [ContactDataProviderConnection](contactdataproviderconnection.md) object instance used to provide contact data to a client app.

This event is triggered when a contact data client app has instantiated the background task that runs your contact data provider. Your code should respond to this event my using the connection to register event handlers for data provider request events.

## -property-value
The [ContactDataProviderConnection](contactdataproviderconnection.md) object your contact data provider uses to communicate with a client app.

## -remarks

## -examples

## -see-also
