---
-api-id: M:Windows.ApplicationModel.Core.IFrameworkView.Uninitialize
-api-type: winrt method
---

<!-- Method syntax
public void Uninitialize()
-->

# Windows.ApplicationModel.Core.IFrameworkView.Uninitialize

## -description

Uninitializes the app view and releases external resources.

## -remarks

Your implementation of this method should clean up any external resources created during the previous call to [Load](iframeworkview_load_1077941801.md) when you created the app view.

This method is called when the app view is being terminated, and it provides an opportunity to release any resources that were allocated for the view. You should ensure that all resources are properly released to avoid memory leaks or other issues. It is not intended to be used to clean up resources when exiting the app. You can clean up app resources when exiting with [CoreApplication.Suspending](coreapplication_suspending.md) or [CoreApplication.Exiting](coreapplication_exiting.md) event handlers.

## -examples

## -see-also
