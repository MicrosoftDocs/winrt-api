---
-api-id: E:Windows.Services.Store.StoreContext.OfflineLicensesChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler OfflineLicensesChanged<Windows.Services.Store.StoreContext,  object>
-->

# Windows.Services.Store.StoreContext.OfflineLicensesChanged

## -description
Raised when the status of the app's license changes (for example, the trial period has expired).

## -remarks
When the [OfflineLicensesChanged](storecontext_offlinelicenseschanged.md) event is raised, you can get the latest license from the Windows Store by calling the [GetAppLicenseAsync](storecontext_getapplicenseasync.md) method. For more information about this event, including a code example, see [Implement a trial version of your app](https://msdn.microsoft.com/windows/uwp/monetize/implement-a-trial-version-of-your-app).

## -examples

## -see-also
[Implement a trial version of your app](https://msdn.microsoft.com/windows/uwp/monetize/implement-a-trial-version-of-your-app)