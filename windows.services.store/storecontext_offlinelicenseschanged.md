---
-api-id: E:Windows.Services.Store.StoreContext.OfflineLicensesChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler OfflineLicensesChanged<Windows.Services.Store.StoreContext,  object>
-->

# Windows.Services.Store.StoreContext.OfflineLicensesChanged

## -description
Raised when the status of the app's license changes (for example, the trial period has expired or the user has purchased the full version of the app).

## -remarks
When this event is raised, you can get the latest app license from the Microsoft Store by calling the [GetAppLicenseAsync](storecontext_getapplicenseasync_1472711008.md) method. The [StoreAppLicense](storeapplicense.md) object returned by this method also contains the latest add-on licenses for the app in the [AddOnLicenses](storeapplicense_addonlicenses.md) property. 

For more information about the OfflineLicensesChanged event, including a code example, see [Implement a trial version of your app](/windows/uwp/monetize/implement-a-trial-version-of-your-app).

> [!NOTE]
> This event is the equivalent of the [LicenseChanged](../windows.applicationmodel.store/licenseinformation_licensechanged.md) event in the [Windows.ApplicationModel.Store](../windows.applicationmodel.store/windows_applicationmodel_store.md) namespace.

## -examples

## -see-also
[Implement a trial version of your app](/windows/uwp/monetize/implement-a-trial-version-of-your-app), [Store sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Store)
