---
-api-id: M:Windows.Services.Store.StoreContext.GetAppAndOptionalStorePackageUpdatesAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Services.Store.StorePackageUpdate>> GetAppAndOptionalStorePackageUpdatesAsync()
-->

# Windows.Services.Store.StoreContext.GetAppAndOptionalStorePackageUpdatesAsync

## -description
Gets the collection of packages for the current app that have updates available for download from the Microsoft Store, including optional packages for the app.

## -returns
An asynchronous operation that, on successful completion, returns a collection of [StorePackageUpdate](storepackageupdate.md) objects that represent the packages that have updates available.

## -exceptions
### T:System.Runtime.InteropServices.COMException

If the **ErrorCode** property of the exception has the value 0x80070578 (ERROR_INVALID_WINDOW_HANDLE), this indicates that the method was not called on the UI thread. If you are calling this method in a desktop application that uses the Desktop Bridge, this can also indicate that you did not configure the [StoreContext](storecontext.md) object to specify which application window is the owner window for modal dialogs shown by this method. For more information, see [this article](/windows/uwp/monetize/in-app-purchases-and-trials#desktop).

### T:System.Exception

The method may throw exceptions when the Microsoft Store service is unavailable or not properly configured. Common scenarios include:

- **"Object server is stopping when OLE service contacts it"**: This error typically occurs when the Microsoft Store service is not running, is shutting down, or when there are issues with the Windows Store infrastructure. This can happen if:
  - The Windows Store app is not installed or is corrupted
  - The Microsoft Store service is disabled or not running
  - There are permission issues accessing the Store service
  - The system is in an inconsistent state during shutdown or startup

- **Service unavailable errors**: Network connectivity issues or Microsoft Store service outages can cause the operation to fail.

## -remarks
For more information about using this method, including a code example, see [Download and install package updates for your app](/windows/uwp/packaging/self-install-package-updates).

There is a latency of up to a day between the time when a package passes the certification process and when the GetAppAndOptionalStorePackageUpdatesAsync method recognizes that the package update is available to the app.

After you call GetAppAndOptionalStorePackageUpdatesAsync to determine which packages have updates available, you can call [RequestDownloadStorePackageUpdatesAsync](storecontext_requestdownloadstorepackageupdatesasync_889669938.md) to download the updated packages or you can call [RequestDownloadAndInstallStorePackageUpdatesAsync](storecontext_requestdownloadandinstallstorepackageupdatesasync_1750789617.md) to download and install the updated packages.

### Prerequisites and Environment Requirements

For this method to work correctly, the following conditions must be met:

- **Microsoft Store app**: The Microsoft Store app must be installed and functional on the system.
- **Microsoft account**: While a signed-in Microsoft account is not strictly required to check for updates, certain scenarios may require authentication.
- **Store services**: The Microsoft Store licensing and update services must be running and accessible.
- **Network connectivity**: An active internet connection is required to communicate with the Microsoft Store service.

### Assigned Access Mode Compatibility

This method can be used in Assigned Access (kiosk) mode, but the following considerations apply:

- The assigned access account must have permission to access Microsoft Store services.
- Network access must be configured to allow communication with Microsoft Store endpoints.
- Some Store UI elements may be restricted depending on the assigned access configuration.

### Error Handling Recommendations

When calling this method, it's recommended to implement proper error handling:

```csharp
try
{
    var updates = await storeContext.GetAppAndOptionalStorePackageUpdatesAsync();
    // Process updates
}
catch (System.Runtime.InteropServices.COMException ex)
{
    // Handle COM-related errors (e.g., threading issues)
}
catch (System.Exception ex)
{
    // Handle Store service errors (e.g., service unavailable)
    // Log the error and implement appropriate retry logic
}
```

> [!IMPORTANT]
> Optional packages and downloadable content (DLC) packages are not available to all developer accounts.

## -examples

## -see-also
[Download and install package updates for your app](/windows/uwp/packaging/self-install-package-updates),[Optional packages and related set authoring](/windows/uwp/packaging/optional-packages)
