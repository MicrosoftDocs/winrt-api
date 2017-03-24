---
-api-id: P:Windows.ApplicationModel.DataTransfer.ShareTarget.ShareOperation.Data
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.ApplicationModel.DataTransfer.DataPackageView Data { get; }
-->

# Windows.ApplicationModel.DataTransfer.ShareTarget.ShareOperation.Data

## -description
Contains a DataPackage object with the data that the user wants to share.

## -property-value
Contains the data that the user wants to share.

## -remarks

## -examples
The following example shows how to get the [DataPackageView](../windows.applicationmodel.datatransfer/datapackageview.md) object from the **data** property. To use the code in this example, add event listener to your app to handle the [activated](../windows.applicationmodel.core/coreapplicationview_activated.md) event. Then put this code in the function that this event listener calls.



[!code-js[ShareTargetBasic](../windows.applicationmodel.datatransfer.sharetarget/code/ShareMain/javascript/ShareMain/ShareMain/js/target.js#SnippetShareTargetBasic)]

## -see-also
