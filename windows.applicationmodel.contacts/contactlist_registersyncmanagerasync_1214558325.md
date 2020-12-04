---
-api-id: M:Windows.ApplicationModel.Contacts.ContactList.RegisterSyncManagerAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction RegisterSyncManagerAsync()
-->

# Windows.ApplicationModel.Contacts.ContactList.RegisterSyncManagerAsync

## -description
Adds a [SyncManager](contactlistsyncmanager.md) to the [ContactList](contactlist.md).

## -returns
An asynchronous registration operation that you can await.

## -remarks
The [SyncManager](contactlistsyncmanager.md) provides an entry point for other apps to call [ContactList.SyncManager.SyncAsync](contactlistsyncmanager_syncasync_2144191352.md). Calling [ContactList.SyncManager.SyncAsync](contactlistsyncmanager_syncasync_2144191352.md) will launch the provider app as a background task and fire a [IContactDataProviderConnection.SyncRequested](../windows.applicationmodel.contacts.dataprovider/contactdataproviderconnection_syncrequested.md) event. An app should only call this method if they are set up as contact provider.

## -examples

## -see-also

## -capabilities
contactsSystem
