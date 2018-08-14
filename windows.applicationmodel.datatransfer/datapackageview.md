---
-api-id: T:Windows.ApplicationModel.DataTransfer.DataPackageView
-api-type: winrt class
---

<!-- Class syntax.
public class DataPackageView : Windows.ApplicationModel.DataTransfer.IDataPackageView, Windows.ApplicationModel.DataTransfer.IDataPackageView2, Windows.ApplicationModel.DataTransfer.IDataPackageView3, Windows.ApplicationModel.DataTransfer.IDataPackageView4
-->

# Windows.ApplicationModel.DataTransfer.DataPackageView

## -description

A read-only version of a [DataPackage](datapackage.md). Apps that receive shared content get this object when acquiring content.

## -remarks

During a share operation, the source app puts the data being shared in a **DataPackage** object and sends that object to the target app for processing. The **DataPackage** class includes a number of methods to support the following default formats: [text](standarddataformats_text.md), [Rtf](standarddataformats_rtf.md), [Html](standarddataformats_html.md), [Bitmap](standarddataformats_bitmap.md), and [StorageItems](standarddataformats_storageitems.md). It also has methods to support custom data formats. To use these formats, both the source app and target app must already be aware that the custom format exists.

Target apps can use the [DataPackageView](datapackageview.md) object to acquire the data being shared. In addition, these apps can use the [AvailableFormats](datapackageview_availableformats.md) property to identify what formats the [DataPackageView](datapackageview.md) supports, or the [Contains](datapackageview_contains_1741733936.md) method to query for a specific format.

Source apps have the option of using the [SetDataProvider](datapackage_setdataprovider_375548563.md) to assign a delegate to a **DataPackage**, instead of providing the data immediately. This process is useful in situations where the source app supports a given format but does not want to generate the data unless the target app requests it. For example, a source app might support a variety of image formats for sharing photos. Instead of creating multiple copies of each image using these formats, the source app can use a delegate that is called when the target app requests a specific format type.

## -examples

The following code shows how you can use the DataPackageView to get the text being shared. For this example to work properly, you need to add code that detects if your app was launched in response to a share operation. See our topic, [How to receive text](http://msdn.microsoft.com/library/50ec164f-80eb-4b56-858b-caac47475c13) to learn more.

[!code-js[HowToReceiveSharedText](../windows.applicationmodel.datatransfer.sharetarget/code/ShareTargetBeta/javascript/js/ReceivedShardText.js#SnippetHowToReceiveSharedText)]

## -see-also

[Sharing content target app sample](http://go.microsoft.com/fwlink/p/?linkid=231519), [Quickstart: Sharing content ( using JavaScript)](http://msdn.microsoft.com/library/594cd09c-19d4-4f7e-996a-e8e2489170dd), [Share data](http://msdn.microsoft.com/library/32287f5e-eb86-4b98-97ff-8f6228d06782), [Quickstart: Receiving shared content ( using  JavaScript)](http://msdn.microsoft.com/library/84d45bb6-2784-4b5f-8b13-debf786a0304), [Receive data](http://msdn.microsoft.com/library/0aff9e0d-dff4-4018-b393-a26b11afdb41), [Sharing content target app sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620597), [Sharing content source app sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620596), [App package information sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620581)
