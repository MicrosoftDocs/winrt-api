---
-api-id: M:Windows.UI.Popups.MessageDialog.ShowAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.UI.Popups.IUICommand> ShowAsync()
-->

# Windows.UI.Popups.MessageDialog.ShowAsync

## -description
Begins an asynchronous operation showing a dialog.

## -returns
An object that represents the asynchronous operation. For more on the async pattern, see [Asynchronous programming](/windows/uwp/threading-async/asynchronous-programming-universal-windows-platform-apps).

## -remarks
In some cases, the system may close the dialog, like when people invoke an app contract when the dialog is showing. [IAsyncOperation(IUICommand).GetResults](../windows.foundation/iasyncoperation_1_getresults_732303200.md) returns either the command selected which destroyed the dialog, or an empty command.

To launch subsequent dialogs or other modal UI such as file pickers after a dialog has been closed, use the [then](/previous-versions/windows/apps/br229728(v=win.10)) or [done](/previous-versions/windows/apps/hh701079(v=win.10)) functions of the [Promise](/previous-versions/windows/apps/br211867(v=win.10)) object. You cannot launch modal UI from within a [UICommand](uicommand.md) callback.

### Calling showAsync while the splash screen is being displayed

<!--This section was added for Windows Blue Bug 466096.-->
+ **In :** Your app can call showAsync from within the **activated** handler (the [onactivated event](/previous-versions/windows/apps/br212679(v=win.10)) or the [CoreApplicationView.Activated event](../windows.applicationmodel.core/coreapplicationview_activated.md)), and paint operations then occur behind the app's splash screen.
+ **Beginning in :**  Windows suppresses painting while the app is behind the splash screen to reduce wasteful operations. Your app should not call showAsync from within the **activated** handler, but should instead wait for the **visibility changed** notification (the [visibilitychange event](XREF:TODO:wwa.MSHTMLDocumentExtensions_msvisibilitychanged) or the [CoreWindow.VisibilityChanged event](../windows.ui.core/corewindow_visibilitychanged.md)).


## -examples

## -see-also
