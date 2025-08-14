---
-api-id: M:Windows.ApplicationModel.DataTransfer.DataPackageView.GetStorageItemsAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Foundation.Collections.IVectorView<Windows.Storage.IStorageItem>> GetStorageItemsAsync()
-->

# Windows.ApplicationModel.DataTransfer.DataPackageView.GetStorageItemsAsync

## -description

Gets the files and folders stored in a [DataPackageView](datapackageview.md) object.

## -returns

An array of files and folders stored in a [DataPackageView](datapackageview.md).

## -remarks

## -examples

The following example shows how to receive files and folders shared with your app as a collection of objects implementing [IStorageItem](../windows.storage/istorageitem.md).

[!code-csharp[HowToReceiveFiles](../windows.applicationmodel.datatransfer.sharetarget/code/ShareTargetBeta/cs/MainPage.xaml.cs#Snippetcs_HandleSharedStorageItems)]

## -see-also
