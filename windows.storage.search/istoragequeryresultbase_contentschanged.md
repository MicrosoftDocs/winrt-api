---
-api-id: E:Windows.Storage.Search.IStorageQueryResultBase.ContentsChanged
-api-type: winrt event
---

<!-- Event syntax
abstract public event Windows.Foundation.TypedEventHandler ContentsChanged<Windows.Storage.Search.IStorageQueryResultBase,  object>
-->

# Windows.Storage.Search.IStorageQueryResultBase.ContentsChanged

## -description
Fires when an item is added, deleted or modified in the folder being queried.

## -remarks
If you register a handler for this event, keep that handler registered while you suspend your app (in response to [oncheckpoint](http://msdn.microsoft.com/library/a7620c81-f769-46e5-b030-dde21b8c2d5b) or [Suspending](../windows.ui.xaml/application_suspending.md)). Your app will not receive [ContentsChanged](istoragequeryresultbase_contentschanged.md) events while it is suspended and when your app resumes it will receive a single event that aggregates all of the changes if any occurred.

Additionally, keep in mind that registering and removing event handlers are synchronous operations and might cause your app to stop responding briefly if you execute them on your app's UI thread. Wherever possible, use a thread other than your app's UI thread to register and unregister these event handlers.

## -examples

## -see-also
