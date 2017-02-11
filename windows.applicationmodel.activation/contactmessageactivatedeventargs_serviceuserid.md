---
-api-id: P:Windows.ApplicationModel.Activation.ContactMessageActivatedEventArgs.ServiceUserId
-api-type: winrt property
---

<!-- Property syntax
public string ServiceUserId { get; }
-->

# Windows.ApplicationModel.Activation.ContactMessageActivatedEventArgs.ServiceUserId

## -description
Gets the user identifier of the service used for the message.

## -property-value
The user identifier of the service used for the message.

## -remarks
For standard text messaging, the [ServiceUserId](contactmessageactivatedeventargs_serviceuserid.md) property is set to the mobile number for the contact. For web-based services, the [ServiceUserId](contactmessageactivatedeventargs_serviceuserid.md) property is set to the contact’s user id for that particular service.

For info about how to handle app activation through contact actions, see [Quickstart: Handling contact actions ](http://msdn.microsoft.com/library/397d8b2a-6255-4f37-8556-449a3be2ef3f) and [Quickstart: Handling contact actions ](http://msdn.microsoft.com/library/61bacc8a-24c9-4b3d-b77b-e0822467700c).

## -examples

## -see-also
[Handling Contact Actions sample](http://go.microsoft.com/fwlink/p/?LinkID=320151)