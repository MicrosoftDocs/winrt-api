---
-api-id: P:Windows.ApplicationModel.Email.DataProvider.EmailDataProviderTriggerDetails.Connection
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Email.DataProvider.EmailDataProviderConnection Connection { get; }
-->

# Windows.ApplicationModel.Email.DataProvider.EmailDataProviderTriggerDetails.Connection

## -description
Gets the [EmailDataProviderConnection](emaildataproviderconnection.md) to be used to communicate with an email client app.

This event is triggered when an email data client app has instantiated the background task that runs your email data provider. Your code should respond to this event by using the connection to register an event handler for data provider request events.

## -property-value
The connection your email data provider uses to communicate with an email client app. When you handler is triggered, your code should register event handlers on this connection for the email data provider events included in the [EmailDataProviderConnection](emaildataproviderconnection.md) class.

## -remarks

## -examples

## -see-also

## -capabilities
email, emailSystem
