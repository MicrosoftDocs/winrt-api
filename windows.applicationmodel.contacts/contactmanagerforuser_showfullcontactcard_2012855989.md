---
-api-id: M:Windows.ApplicationModel.Contacts.ContactManagerForUser.ShowFullContactCard(Windows.ApplicationModel.Contacts.Contact,Windows.ApplicationModel.Contacts.FullContactCardOptions)
-api-type: winrt method
---

<!-- Method syntax.
public void ContactManagerForUser.ShowFullContactCard(Contact contact, FullContactCardOptions fullContactCardOptions)
-->

# Windows.ApplicationModel.Contacts.ContactManagerForUser.ShowFullContactCard


## -description

Queries the operating system for a user’s contact and shows the contact data in a full contact card.

## -parameters

### -param contact

The object that represents the contact that the app wants to display the contact card for.*contact* must contain at least an [Id](contact_id.md), [Emails](contact_emails.md), or a phone number from a [Phones](contact_phones.md) list to query the user’s contact database to retrieve a matching contact to display. [Id](contact_id.md) has higher priority for querying. If an [Id](contact_id.md) matches, the rest of query parameters will be ignored for matching purposes. If an [Id](contact_id.md) does not find a match, the query uses the rest of query parameters. [Emails](contact_emails.md) and [Phones](contact_phones.md) have equal priority for matching. If multiple email addresses, or phone numbers, or both are provided, the query first performs an exact match, requiring all query parameters to match a system contact record. If this results in no matches, the query uses "best effort" match, in which a match of any query parameters is sufficient.

If no matches occur, the data in the input contact displays in the contact card. If a match occurs, only system contact data displays, and the data in the input contact is discarded.

### -param fullContactCardOptions

Specifies how to display the full contact card.

## -remarks

This method must be called from the main UI thread.

## -see-also

[ContactManager](contactmanager.md), [Contact cards sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/ContactCards)

## -examples

## -capabilities

contactsSystem

