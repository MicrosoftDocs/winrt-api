---
-api-id: M:Windows.ApplicationModel.Store.Preview.StorePreview.LoadAddOnProductInfosAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Store.Preview.StorePreviewProductInfo>> LoadAddOnProductInfosAsync()
-->

# Windows.ApplicationModel.Store.Preview.StorePreview.LoadAddOnProductInfosAsync

## -description
Retrieves the in-app products available for the current app asynchronously, including the available SKUs for each product.

## -returns
An asynchronous operation that, on successful completion, returns the collection of in-app products for the current app (including the available SKUs for each product). If you use [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a read-only list/vector of [StorePreviewProductInfo](storepreviewproductinfo.md) items. (You can use APIs of [IVectorView<StorePreviewProductInfo>](../windows.foundation.collections/ivectorview_1.md) for C++ or JavaScript, APIs of [IReadOnlyList&lt;StorePreviewProductInfo&gt;](/dotnet/api/system.collections.generic.ireadonlylist-1?view=dotnet-uwp-10.0&preserve-view=true) for .NET.)

## -remarks

## -examples

## -see-also

## -capabilities
previewStore
