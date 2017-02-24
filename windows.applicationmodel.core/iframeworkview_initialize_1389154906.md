---
-api-id: M:Windows.ApplicationModel.Core.IFrameworkView.Initialize(Windows.ApplicationModel.Core.CoreApplicationView)
-api-type: winrt method
---

<!-- Method syntax
public void Initialize(Windows.ApplicationModel.Core.CoreApplicationView applicationView)
-->

# Windows.ApplicationModel.Core.IFrameworkView.Initialize

## -description
Initializes the app view. Called when an app object is launched.

## -parameters
### -param applicationView
The default view provided by the app object. You can use this instance in your implementation to obtain the [CoreWindow](coreapplicationview_corewindow.md) created by the app object, and register callbacks for the [Activated](coreapplicationview_activated.md) event.

## -remarks
This method is called by [CoreApplication.Run](coreapplication_run.md) on the view object that implements this interface. It is the first method called on the view implementation when the app object is activated.

## -examples

## -see-also
