---
-api-id: P:Windows.ApplicationModel.Core.CoreApplicationView.Dispatcher
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Core.CoreDispatcher Dispatcher { get; }
-->

# Windows.ApplicationModel.Core.CoreApplicationView.Dispatcher

## -description
Gets the event message dispatcher associated with the current view.

## -property-value
The event message dispatcher.

## -remarks

There's one `CoreDispatcher` per thread.  

The `Dispatcher` property of any class within the `CoreApplicationView` namespace will refer to the same object.

## -examples

## -see-also
