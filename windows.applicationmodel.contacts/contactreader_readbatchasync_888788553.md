---
-api-id: M:Windows.ApplicationModel.Contacts.ContactReader.ReadBatchAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Contacts.ContactBatch> ReadBatchAsync()
-->

# Windows.ApplicationModel.Contacts.ContactReader.ReadBatchAsync

## -description
Asynchronously reads a batch of [Contact](contact.md) objects from the [ContactStore](contactstore.md).

## -returns
The batch of contacts read from the [ContactStore](contactstore.md).

## -remarks
Call this method until you've retrieved all of the contacts that your app needs or until this method no longer returns contacts.

## -examples
This example calls the [ReadBatchAsync](contactreader_readbatchasync_888788553.md) until the batch returned from this call is empty. An empty batch indicates that you've retrieved all of the available contacts.

```csharp

private async void ReadContacts(object sender, RoutedEventArgs e)
{

    var contactReader = contactStore.GetContactReader();

    var contactBatch = await contactReader.ReadBatchAsync();

    while (contactBatch.Contacts.Count != 0)
    {
        foreach (Contact contact in contactBatch.Contacts)
        {
            //So, what do you want to do with these?
            Debug.WriteLine(contact.Id + ": " + contact.DisplayName);
        }

        contactBatch = await contactReader.ReadBatchAsync();
    }
}
```

## -see-also

## -capabilities
contactsSystem
