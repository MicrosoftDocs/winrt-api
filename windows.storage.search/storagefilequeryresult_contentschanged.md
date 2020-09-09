---
-api-id: E:Windows.Storage.Search.StorageFileQueryResult.ContentsChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ContentsChanged<Windows.Storage.Search.IStorageQueryResultBase,  object>
-->

# Windows.Storage.Search.StorageFileQueryResult.ContentsChanged

## -description
Fires when a file is added to, deleted from, or modified in the folder being queried. This event only fires after [GetFilesAsync](storagefilequeryresult_getfilesasync_1261374131.md) has been called at least once.

## -remarks
If you register a handler for this event, keep that handler registered while you suspend your app (in response to [oncheckpoint](/previous-versions/windows/apps/br229839(v=win.10)) or [Suspending](../windows.ui.xaml/application_suspending.md)). Your app will not receive ContentsChanged events while it is suspended and when your app resumes it will receive a single event that aggregates all of the changes if any occurred.

Additionally, keep in mind that registering and removing event handlers are synchronous operations and might cause your app to stop responding briefly if you execute them on your app's UI thread. Wherever possible, use a thread other than your app's UI thread to register and unregister these event handlers.

## -examples

## -see-also
