---
-api-id: M:Windows.ApplicationModel.Contacts.ContactManager.ShowDelayLoadedContactCard(Windows.ApplicationModel.Contacts.Contact,Windows.Foundation.Rect,Windows.UI.Popups.Placement,Windows.ApplicationModel.Contacts.ContactCardOptions)
-api-type: winrt method
---

<!-- Method syntax
public Windows.ApplicationModel.Contacts.ContactCardDelayedDataLoader ShowDelayLoadedContactCard(Windows.ApplicationModel.Contacts.Contact contact, Windows.Foundation.Rect selection, Windows.UI.Popups.Placement preferredPlacement, Windows.ApplicationModel.Contacts.ContactCardOptions contactCardOptions)
-->

# Windows.ApplicationModel.Contacts.ContactManager.ShowDelayLoadedContactCard

## -description
Shows a contact card that can be updated later if the contact does not exist in the user’s contact database.

## -parameters
### -param contact
The object that represents the contact that the app wants to display the contact card for.*contact* must contain at least an [Id](contact_id.md), [Emails](contact_emails.md), or a phone number from a [Phones](contact_phones.md) list to query the user’s contact database to retrieve a matching contact to display. [Id](contact_id.md) has higher priority for querying. If an [Id](contact_id.md) matches, the rest of query parameters will be ignored for matching purposes. If an [Id](contact_id.md) does not find a match, the query uses the rest of query parameters. [Emails](contact_emails.md) and [Phones](contact_phones.md) have equal priority for matching. If multiple email addresses, or phone numbers, or both are provided, the query first performs an exact match, requiring all query parameters to match a system contact record. If this results in no matches, the query uses "best effort" match, in which a match of any query parameters is sufficient.

If no matches occur, the data in the input contact displays in the contact card. If a match occurs, only system contact data displays, and the data in the input contact is discarded.

### -param selection
The [Rect](../windows.foundation/rect.md) is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the contact card, not within that rectangular area. For example, if an app uses a button to show the contact card, pass the [Rect](../windows.foundation/rect.md) of the button so the contact card displays around the button, not overlapping it.

### -param preferredPlacement
The [Placement](../windows.ui.popups/placement.md) that describes the preferred placement of the contact card.

### -param contactCardOptions
Specifies how to display the contact card, such as which tab to start on if you are displaying a mini contact card, or what header type to use if you are showing a full contact card.

## -returns
Returns the [ContactCardDelayedDataLoader](contactcarddelayeddataloader.md) object that can be used to update the contact card.

## -remarks

## -examples

## -see-also
[ShowDelayLoadedContactCard(Contact, Rect, Placement)](contactmanager_showdelayloadedcontactcard_750536243.md)