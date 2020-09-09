---
-api-id: M:Windows.Services.Store.StoreContext.GetAppLicenseAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Services.Store.StoreAppLicense> GetAppLicenseAsync()
-->

# Windows.Services.Store.StoreContext.GetAppLicenseAsync

## -description
Gets license info for the current app, including licenses for add-ons for the current app.

## -returns
An asynchronous operation that, on successful completion, returns a [StoreAppLicense](storeapplicense.md) object that contains license info for the current app, including add-on licenses.

## -remarks
The [StoreAppLicense](storeapplicense.md) object returned by this method provides access to licenses for add-ons and other info, such as whether the license is active. If this method is called while the device is offline, it returns the cached value of the current licenses on the device. The [OfflineLicensesChanged](storecontext_offlinelicenseschanged.md) event is raised when the status of the app's license changes.

For more information about using this method, including code examples, see [Get license info for apps and add-ons](/windows/uwp/monetize/get-license-info-for-apps-and-add-ons) and [Implement a trial version of your app](/windows/uwp/monetize/implement-a-trial-version-of-your-app).

## -examples

## -see-also
[StoreAppLicense](storeapplicense.md), [Get license info for apps and add-ons](/windows/uwp/monetize/get-license-info-for-apps-and-add-ons), [Implement a trial version of your app](/windows/uwp/monetize/implement-a-trial-version-of-your-app), [Store sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Store)