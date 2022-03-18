---
-api-id: M:Windows.ApplicationModel.Store.Preview.StoreConfiguration.FilterUnsupportedSystemFeaturesAsync(Windows.Foundation.Collections.IIterable{Windows.ApplicationModel.Store.Preview.StoreSystemFeature})
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.ApplicationModel.Store.Preview.StoreSystemFeature>> FilterUnsupportedSystemFeaturesAsync(Windows.Foundation.Collections.IIterable<Windows.ApplicationModel.Store.Preview.StoreSystemFeature> systemFeatures)
-->

# Windows.ApplicationModel.Store.Preview.StoreConfiguration.FilterUnsupportedSystemFeaturesAsync

## -description
Given a list of hardware features, this method returns a modified list that contains only the hardware features that are supported on the current device.

## -parameters
### -param systemFeatures
A list of [StoreSystemFeature](storesystemfeature.md) objects that represent the hardware features to be queried on the current device.

## -returns
An asynchronous operation that, on successful completion, returns a list of hardware features that are supported on the current device. If you use [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps), the result type is a read-only list/vector of [StoreSystemFeature](storesystemfeature.md) items. (You can use APIs of [IVectorView<StoreSystemFeature>](../windows.foundation.collections/ivectorview_1.md) for C++ or JavaScript, APIs of [IReadOnlyList&lt;StoreSystemFeature&gt;](/dotnet/api/system.collections.generic.ireadonlylist-1?view=dotnet-uwp-10.0&preserve-view=true) for .NET.)

## -remarks

## -examples

## -see-also
