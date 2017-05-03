---
-api-id: M:Windows.ApplicationModel.DataTransfer.ShareTarget.ShareOperation.ReportCompleted
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void ReportCompleted()
-->

# Windows.ApplicationModel.DataTransfer.ShareTarget.ShareOperation.ReportCompleted

## -description
Specifies that the sharing operation is complete.

## -remarks
When your app acts as a target for a share operation, it should call **reportComplete** after it has processed the data being shared. This method closes the app window and returns the user to the source app.

## -examples
The following example shows how a target app might respond to a share operation. Notice the use of **reportComplete** when the target app has finished processing the data.



[!code-js[ShareTargetBasic](../windows.applicationmodel.datatransfer.sharetarget/code/ShareMain/javascript/ShareMain/ShareMain/js/target.js#SnippetShareTargetBasic)]

## -see-also
[ReportCompleted(QuickLink)](shareoperation_reportcompleted_840474235.md)
