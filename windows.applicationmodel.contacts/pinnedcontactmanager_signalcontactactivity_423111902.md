---
-api-id: M:Windows.ApplicationModel.Contacts.PinnedContactManager.SignalContactActivity(Windows.ApplicationModel.Contacts.Contact)
-api-type: winrt method
---

<!-- Method syntax.
public void PinnedContactManager.SignalContactActivity(Contact contact)
-->

# Windows.ApplicationModel.Contacts.PinnedContactManager.SignalContactActivity


## -description

Indicates to Windows when activity that is related to a pinned contact occurs.

## -parameters

### -param contact

The contact that is exhibits activity.

## -remarks

Activity could be any interesting event related to a contact that occurs in your app. For example, if your app receives a message or mail for a contact, your app could call the SignalContactActivity to report that event.
Windows indicates this reported activity to the user. Windows does not indicate anything to the user if the contact is not pinned. If you call this method for a contact that is not pinned, no error will occur.  

Your app can call this method from a background thread.

## -see-also

## -examples

## -capabilities

contactsSystem

