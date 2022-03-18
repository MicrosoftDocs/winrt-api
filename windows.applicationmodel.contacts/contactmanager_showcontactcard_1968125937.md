---
-api-id: M:Windows.ApplicationModel.Contacts.ContactManager.ShowContactCard(Windows.ApplicationModel.Contacts.Contact,Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax
public void ShowContactCard(Windows.ApplicationModel.Contacts.Contact contact, Windows.Foundation.Rect selection)
-->

# Windows.ApplicationModel.Contacts.ContactManager.ShowContactCard

## -description
Queries the operating system for a user’s contact and shows the contact data in a contact card.

## -parameters
### -param contact
The object that represents the contact that the app wants to display the contact card for.*contact* must contain at least an [Id](contact_id.md), [Emails](contact_emails.md), or a phone number from a [Phones](contact_phones.md) list to query the user’s contact database to retrieve a matching contact to display. [Id](contact_id.md) has higher priority for querying. If an [Id](contact_id.md) matches, the rest of query parameters will be ignored for matching purposes. If an [Id](contact_id.md) does not find a match, the query uses the rest of query parameters. [Emails](contact_emails.md) and [Phones](contact_phones.md) have equal priority for matching. If multiple email addresses, or phone numbers, or both are provided, the query first performs an exact match, requiring all query parameters to match a system contact record. If this results in no matches, the query uses "best effort" match, in which a match of any query parameters is sufficient.

If no matches occur, the data in the input contact displays in the contact card. If a match occurs, only system contact data displays, and the data in the input contact is discarded.

### -param selection
The [Rect](../windows.foundation/rect.md) is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the contact card, not within that rectangular area. For example, if an app uses a button to show the contact card, pass the [Rect](../windows.foundation/rect.md) of the button so the contact card displays around the button, not overlapping it.

## -remarks
> [!NOTE]
> Source apps must be running in the foreground to call this method. An app that runs in the background will get an "Access Denied" exception if it calls this method.

Most typical operations will result in displaying a UI.

+ **If there is one exact match for the requested  contact:** Shows the contact card UI with information from the contacts store in the operating system. 
+ **If there are multiple matches:** Shows the contact card UI for the first matching contact found.
+ **If there is no match:** Shows the contact card UI, where the contact info comes from the input *contact* object.


If there's an error, such as an invalid input for the *contact* parameter, no UI is displayed.

For querying purposes, phone numbers support characters 0-9 and a-z/A-Z. If you put any other characters in a phone number, they are ignored when you query the contact.

For info about how to manage contacts, see [Contacts and calendar](/windows/uwp/contacts-and-calendar/).

For querying purposes, phone numbers support characters 0-9 and a-z/A-Z. If you put any other characters in a phone number, they are ignored when you query the contact.



## -examples

## -see-also
[ShowContactCard(Contact, Rect, Placement)](contactmanager_showcontactcard_2144545901.md)
## -capabilities
contactsSystem
