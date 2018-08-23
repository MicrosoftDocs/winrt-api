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

### Windows Phone 8

You should not use [Uninitialize](iframeworkview_uninitialize_278000994.md) to exit an app.

## -examples

## -see-also
