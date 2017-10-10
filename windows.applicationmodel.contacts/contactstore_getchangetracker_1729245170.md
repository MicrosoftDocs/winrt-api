---
-api-id: M:Windows.ApplicationModel.Contacts.ContactStore.GetChangeTracker(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public ContactChangeTracker ContactStore.GetChangeTracker(String identity)
-->

# Windows.ApplicationModel.Contacts.ContactStore.GetChangeTracker

## -description
Gets a [ContactChangeTracker](contactchangetracker.md) that provides functionality for monitoring changes to [Contact](contact.md) objects in the [ContactStore](contactstore.md).
## -parameters
### -param identity
A string that identifies the [ContactChangeTracker](contactchangetracker.md) instance in the store.
## -returns
A [ContactChangeTracker](contactchangetracker.md) that provides functionality for monitoring changes to [Contact](contact.md) objects in the [ContactStore](contactstore.md).
## -remarks
You can create multiple [ContactChangeTracker](contactchangetracker.md) instances by using this method. If you pass in a string that identifies a [ContactChangeTracker](contactchangetracker.md) that already exists in the store, this method returns that instance. If the string that you pass into this method does not identify an existing an existing [ContactChangeTracker](contactchangetracker.md), this method returns a new [ContactChangeTracker](contactchangetracker.md).

You can use the [IsTracking](contactchangetracker_istracking.md) property of the [ContactChangeTracker](contactchangetracker.md) to determine whether change tracking is enabled for the [ContactChangeTracker](contactchangetracker.md).


## -see-also

## -examples

## -capabilities
contactsSystem
