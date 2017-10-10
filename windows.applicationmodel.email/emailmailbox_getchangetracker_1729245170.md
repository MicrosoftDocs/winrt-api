---
-api-id: M:Windows.ApplicationModel.Email.EmailMailbox.GetChangeTracker(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public EmailMailboxChangeTracker EmailMailbox.GetChangeTracker(String identity)
-->

# Windows.ApplicationModel.Email.EmailMailbox.GetChangeTracker

## -description
Gets a [EmailMailboxChangeTracker](emailmailboxchangetracker.md) that provides functionality for monitoring changes to items in the [EmailMailbox](emailmailbox.md).
## -parameters
### -param identity
A string that identifies the [EmailMailboxChangeTracker](emailmailboxchangetracker.md) instance in the [EmailMailbox](emailmailbox.md).
## -returns
A [EmailMailboxChangeTracker](emailmailboxchangetracker.md) that provides functionality for monitoring changes to items in the [EmailMailbox](emailmailbox.md).
## -remarks
You can create multiple [EmailMailboxChangeTracker](emailmailboxchangetracker.md) instances by using this method. If you pass in a string that identifies a [EmailMailboxChangeTracker](emailmailboxchangetracker.md) that already exists in the [EmailMailbox](emailmailbox.md), this method returns that instance. If the string that you pass into this method does not identify an existing an existing [EmailMailboxChangeTracker](emailmailboxchangetracker.md), this method returns a new [EmailMailboxChangeTracker](emailmailboxchangetracker.md).

You can use the [IsTracking](emailmailboxchangetracker_istracking.md) property of the [EmailMailboxChangeTracker](emailmailboxchangetracker.md) to determine whether change tracking is enabled for the [EmailMailboxChangeTracker](emailmailboxchangetracker.md).

## -see-also

## -examples

## -capabilities
email, emailSystem
