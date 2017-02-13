---
-api-id: M:Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.SearchForAllUpdatesAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallItem>> SearchForAllUpdatesAsync()
-->

# Windows.ApplicationModel.Store.Preview.InstallControl.AppInstallManager.SearchForAllUpdatesAsync

## -description
Searches for all available updates to apps installed on the current computer or device.

## -returns
An asynchronous operation that, on successful completion, returns the collection of apps that have available updates. If you use [Asynchronous programming](https://msdn.microsoft.com/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a read-only list/vector of [AppInstallItem](appinstallitem.md) items. (You can use APIs of [IVectorView&lt;AppInstallItem&gt;](../windows.foundation.collections/ivectorview_1.md) for C++ or JavaScript, APIs of [IReadOnlyList&lt;AppInstallItem&gt;](https://msdn.microsoft.com/library/hh192385.aspx) for .NET.)

## -remarks

## -examples

## -see-also
[SearchForAllUpdatesAsync(String)](appinstallmanager_searchforallupdatesasync_414510830.md)
