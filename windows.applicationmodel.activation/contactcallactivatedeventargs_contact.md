---
-api-id: P:Windows.ApplicationModel.Activation.ContactCallActivatedEventArgs.Contact
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Contacts.Contact Contact { get; }
-->

# Windows.ApplicationModel.Activation.ContactCallActivatedEventArgs.Contact

## -description
Gets the contact for the call.

## -property-value
The contact for the call.

## -remarks
Use the Contact property to collect additional info about the contact that is being called. The contact can have a name and thumbnail that can be used to represent it in your app’s UI. Or, the contact can have alternative user ids that can be used in case the primary user id is unavailable. The [ConnectedServiceAccounts](../windows.applicationmodel.contacts/contact_connectedserviceaccounts.md) property contains a list of all services available for the contact. You can use the [ContactConnectedServiceAccount.ServiceName](../windows.applicationmodel.contacts/contactconnectedserviceaccount_servicename.md) and [ContactConnectedServiceAccount.Id](../windows.applicationmodel.contacts/contactconnectedserviceaccount_id.md) properties on each service to retrieve alternative services and user ids respectively.


Here are possible [Contact](../windows.applicationmodel.contacts/contact.md) properties that can be populated during a call activation:

+ [DisplayName](../windows.applicationmodel.contacts/contact_displayname.md)
+ [FirstName](../windows.applicationmodel.contacts/contact_firstname.md)
+ [LastName](../windows.applicationmodel.contacts/contact_lastname.md)
+ [MiddleName](../windows.applicationmodel.contacts/contact_middlename.md)
+ [HonorificNamePrefix](../windows.applicationmodel.contacts/contact_honorificnameprefix.md)
+ [HonorificNameSuffix](../windows.applicationmodel.contacts/contact_honorificnamesuffix.md)
+ [YomiDisplayName](../windows.applicationmodel.contacts/contact_yomidisplayname.md)
+ [YomiFamilyName](../windows.applicationmodel.contacts/contact_yomifamilyname.md)
+ [YomiGivenName](../windows.applicationmodel.contacts/contact_yomigivenname.md)
+ [Thumbnail](../windows.applicationmodel.contacts/contact_thumbnail.md)
+ [ConnectedServiceAccounts](../windows.applicationmodel.contacts/contact_connectedserviceaccounts.md)


## -examples

## -see-also
