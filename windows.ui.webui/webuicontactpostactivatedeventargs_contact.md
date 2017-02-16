---
-api-id: P:Windows.UI.WebUI.WebUIContactPostActivatedEventArgs.Contact
-api-type: winrt property
---

<!-- Property syntax
public Windows.ApplicationModel.Contacts.Contact Contact { get; }
-->

# Windows.UI.WebUI.WebUIContactPostActivatedEventArgs.Contact

## -description
Gets the contact for the post.

## -property-value
The contact for the post.

## -remarks
Use the [Contact](webuicontactpostactivatedeventargs_contact.md) property to collect additional info about the contact that is being posted to. The contact can have a name and thumbnail that can be used to represent it in your app’s UI. Or, the contact can have alternative user ids that can be used in case the primary user id is unavailable. The [ConnectedServiceAccounts](../windows.applicationmodel.contacts/contact_connectedserviceaccounts.md) property contains a list of all services available for the contact. You can use the [ContactConnectedServiceAccount.Id](../windows.applicationmodel.contacts/contactconnectedserviceaccount_id.md) property on each service to retrieve alternative user ids.

> [!NOTE]
> For post activations, the [ConnectedServiceAccounts](../windows.applicationmodel.contacts/contact_connectedserviceaccounts.md) property is only populated with services that match the primary service that the activation was originally invoked for.


Here are possible [Contact](../windows.applicationmodel.contacts/contact.md) properties that can be populated during a post activation:

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
