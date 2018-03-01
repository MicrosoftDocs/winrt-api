---
-api-id: M:Windows.ApplicationModel.Contacts.ContactChangeReader.ReadBatchAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Contacts.ContactChange>> ReadBatchAsync()
-->

# Windows.ApplicationModel.Contacts.ContactChangeReader.ReadBatchAsync

## -description
Asynchronously gets a list of [ContactChange](contactchange.md) objects.

## -returns
A list of [ContactChange](contactchange.md) objects.

## -remarks
Call this method until the batch returned by this call is empty.

## -examples
This example calls the [ReadBatchAsync](contactchangereader_readbatchasync_888788553.md) method until the batch returned by this call is empty.

```csharp
private async void ContactStore_ContactChanged(ContactStore sender, ContactChangedEventArgs args)
{
    var defferal = args.GetDeferral();

    ContactChangeReader reader = sender.ChangeTracker.GetChangeReader();
    IReadOnlyList<ContactChange> changes = await reader.ReadBatchAsync();

    while (changes.Count != 0)
    {
        foreach (ContactChange change in changes)
        {
            switch (change.ChangeType)
            {
                case ContactChangeType.Created:
                    Debug.WriteLine("[created]" + change.Contact.Id + ": " + change.Contact.DisplayName);
                    break;

                case ContactChangeType.Deleted:
                    Debug.WriteLine("[deleted]" + change.Contact.Id + ": " + change.Contact.DisplayName);
                    break;

                case ContactChangeType.Modified:
                    Debug.WriteLine("[modified]" + change.Contact.Id + ": " + change.Contact.DisplayName);
                    break;

                case ContactChangeType.ChangeTrackingLost:

                    MessageDialog lostChangeTrackingWarning =
                        new MessageDialog("The system has lost the change tracking information. " +
                            "This shouldn't happen very often, but you should handle the case. " +
                            "The expectation is that you'll re-read all of the contacts after this.",
                            "Change tracking lost");
                    await lostChangeTrackingWarning.ShowAsync();

                    defferal.Complete();
                    //Returning since changes are no longer going to be valid after resetting
                    //the change tracking
                    return;

                default:

                    break;
            }
        }
        changes = await reader.ReadBatchAsync();
    }

    defferal.Complete();
}
```

## -see-also

## -capabilities
contactsSystem
