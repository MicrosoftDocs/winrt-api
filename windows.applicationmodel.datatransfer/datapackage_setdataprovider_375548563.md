---
-api-id: M:Windows.ApplicationModel.DataTransfer.DataPackage.SetDataProvider(System.String,Windows.ApplicationModel.DataTransfer.DataProviderHandler)
-api-type: winrt method
---

<!-- Method syntax
public void SetDataProvider(System.String formatId, Windows.ApplicationModel.DataTransfer.DataProviderHandler delayRenderer)
-->

# Windows.ApplicationModel.DataTransfer.DataPackage.SetDataProvider

## -description
Sets a delegate to handle requests from the target app.

## -parameters
### -param formatId
Specifies the format of the data. We recommend that you set this value by using the [StandardDataFormats](standarddataformats.md) class.

### -param delayRenderer
A delegate that is responsible for processing requests from a target app.

## -remarks
Use the **SetDataProvider** method when your app supports a specific format, but does not want to supply the data until the target app requests it. We encourage you to use this method if your app shares content that can require significant processing time; for example, sharing a selection of photos, videos, or files.

When you use this method, you need to specify a format and a function. You can specify the format by using the [StandardDataFormats](standarddataformats.md) class, or you can use a string value for a custom format. The function must put data in the [DataPackage](datapackage.md) by using a method like [SetData](datapackage_setdata_2074524277.md).

You must specify the extension of the [StorageItems](standarddataformats_storageitems.md) being passed to the Share Target.

The **SetDataProvider** method is different from the [GetDeferral](datarequest_getdeferral_254836512.md) method of the [DataRequest](datarequest.md) class. With [GetDeferral](datarequest_getdeferral_254836512.md), a source app can call a function that immediately puts the data in the [DataPackage](datapackage.md) object. The **SetDataProvider** method is for more complex share operations where packaging the data to be shared is more time-intensive or resource-intensive.



## -examples


[!code-csharp[HowToShareFiles](../windows.applicationmodel.datatransfer/code/ShareMainBeta/cs/ShareFiles.xaml.cs#SnippetHowToShareFiles_CS)]

## -see-also
