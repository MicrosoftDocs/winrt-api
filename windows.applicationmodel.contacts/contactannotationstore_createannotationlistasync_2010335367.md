---
-api-id: M:Windows.ApplicationModel.Contacts.ContactAnnotationStore.CreateAnnotationListAsync(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.ApplicationModel.Contacts.ContactAnnotationList> CreateAnnotationListAsync(System.String userDataAccountId)
-->

# Windows.ApplicationModel.Contacts.ContactAnnotationStore.CreateAnnotationListAsync

## -description
Asynchronously creates a [ContactAnnotationList](contactannotationlist.md) and associates it with the specified user data account ID.

## -parameters
### -param userDataAccountId
The ID for the user data account with which to associate the new [ContactAnnotationList](contactannotationlist.md). The user data account must be owned by this app.

## -returns
The newly created [ContactAnnotationList](contactannotationlist.md).

## -remarks
The user data account specified in *userDataAccountId* must be owned this app.

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
[RequestAnnotationStoreAsync](contactmanager_requestannotationstoreasync_2147083254.md), [ContactAnnotationList](contactannotationlist.md), [CreateAnnotationListAsync](contactannotationstore_createannotationlistasync_777171367.md), [GetAnnotationListAsync](contactannotationstore_getannotationlistasync_1462689163.md), [FindAnnotationListsAsync](contactannotationstore_findannotationlistsasync_660284737.md), [DeleteAsync](contactannotationlist_deleteasync_1247887881.md)
## -capabilities
contactsSystem
