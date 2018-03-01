---
-api-id: M:Windows.ApplicationModel.Contacts.ContactChangeTracker.Reset
-api-type: winrt method
---

<!-- Method syntax
public void Reset()
-->

# Windows.ApplicationModel.Contacts.ContactChangeTracker.Reset

## -description
Clears all tracked changes from the [ContactChangeTracker](contactchangetracker.md) instance.

## -remarks
If your app receives [ContactChangeType.ChangeTrackingLost](contactchangetype.md), call the [Reset](contactchangetracker_reset_1636126115.md) method to reset the change tracker. This clears any pending changes, and indicates that your app is up-to-date. That way the  [ContactChangeType.ChangeTrackingLost](contactchangetype.md) event won't continue to be raised for previous changes.

Then, you can initialize your app with a fresh set of contact data. In fact, you should always call this method before you read the entire set of contacts from the contact database. If your app obtains a fresh copy of contact data, it doesn't have to be informed of any changes that have occurred to that data before the read.

## -examples

## -see-also

## -capabilities
contactsSystem
