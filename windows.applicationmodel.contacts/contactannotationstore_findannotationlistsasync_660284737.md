---
-api-id: M:Windows.ApplicationModel.Contacts.ContactAnnotationStore.FindAnnotationListsAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Contacts.ContactAnnotationList>> FindAnnotationListsAsync()
-->

# Windows.ApplicationModel.Contacts.ContactAnnotationStore.FindAnnotationListsAsync

## -description
Asynchronously gets the list of [ContactAnnotationList](contactannotationlist.md) objects for the app.

## -returns
The list of [ContactAnnotationList](contactannotationlist.md) objects.

## -remarks

## -examples
The following example provides reusable methods for creating an annotation list, deleting a specific annotation list, and deleting all annotation lists in a store.

```csharp
public async Task<ContactAnnotationList> CreateAnnotationList()
{
    // Get the data store.
    ContactAnnotationStore store = await ContactManager.RequestAnnotationStoreAsync(ContactAnnotationStoreAccessType.AppAnnotationsReadWrite);

    // Create a new list.
    ContactAnnotationList list = await store.CreateAnnotationListAsync();

    // Find the list to verify it was created.
    IReadOnlyList<ContactAnnotationList> lists = await store.FindAnnotationListsAsync();

    for (int i = 0; i < lists.Count; i++)
    {
        // Do the IDs match?
        if (list.Id == lists[i].Id)
        {
            // Found it! Return the new list.
            return(list);
        }
    }

    // List not created, return null.
    return(null);
}

public async Task<Boolean> DeleteAnnotationList(string listId)
{
    // Get the store.
    ContactAnnotationStore store = await ContactManager.RequestAnnotationStoreAsync(ContactAnnotationStoreAccessType.AppAnnotationsReadWrite);

    // Find the list.
    ContactAnnotationList list = await store.GetAnnotationListAsync(listId);

    // Make sure we got it.
    if (list.Id == listId)
    {
        // Delete the list.
        await list.DeleteAsync();
        return true;
    }

    return false;
}

public async Task<Boolean> DeleteAllAnnotationLists()
{
    // Get the store.
    ContactAnnotationStore store = await ContactManager.RequestAnnotationStoreAsync(ContactAnnotationStoreAccessType.AppAnnotationsReadWrite);

    IReadOnlyList<ContactAnnotationList> lists = await store.FindAnnotationListsAsync();

    // Make sure at least one annotation list exists.
    if (lists.Count > 0)
    {
        // Find the list.
        for (int i = 0; i < lists.Count; i++)
        {
            await lists[i].DeleteAsync();
        }

        return true;
    }

    return false;
}

```



## -see-also
[RequestAnnotationStoreAsync](contactmanager_requestannotationstoreasync_2147083254.md), [ContactAnnotationList](contactannotationlist.md), [CreateAnnotationListAsync](/uwp/api/windows.applicationmodel.contacts.contactannotationstore.createannotationlistasync), [GetAnnotationListAsync](contactannotationstore_getannotationlistasync_1462689163.md), [DeleteAsync](contactannotationlist_deleteasync_1247887881.md)
## -capabilities
contactsSystem
