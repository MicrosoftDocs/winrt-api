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
An object that represents the asynchronous operation. For more on the async pattern, see [Asynchronous programming](http://msdn.microsoft.com/library/23fe28f1-89c5-4a17-a732-a722648f9c5e).

## -remarks
In some cases, the system may close the dialog, like when people invoke an app contract when the dialog is showing. [IAsyncOperation(IUICommand).GetResults](../windows.foundation/iasyncoperation_1_getresults_732303200.md) returns either the command selected which destroyed the dialog, or an empty command.

To launch subsequent dialogs or other modal UI such as file pickers after a dialog has been closed, use the [then](http://msdn.microsoft.com/library/c63904fc-465b-4fd5-a1d6-e4fb200248e7) or [done](http://msdn.microsoft.com/library/9a5e6877-a2cf-421f-a91e-37d84ccb40da) functions of the [Promise](http://msdn.microsoft.com/library/df6a1939-0c42-4079-a9d5-ab49488d0375) object. You cannot launch modal UI from within a [UICommand](uicommand.md) callback.

### Calling showAsync while the splash screen is being displayed

<!--This section was added for Windows Blue Bug 466096.-->
+ **In :** Your app can call [showAsync](messagedialog_showasync_1714076542.md) from within the **activated** handler (the [onactivated event](http://msdn.microsoft.com/library/8b1cf913-a914-47d1-a690-bc3f0931e9d4) or the [CoreApplicationView.Activated event](../windows.applicationmodel.core/coreapplicationview_activated.md)), and paint operations then occur behind the app's splash screen.
+ **Beginning in :**  Windows suppresses painting while the app is behind the splash screen to reduce wasteful operations. Your app should not call [showAsync](messagedialog_showasync_1714076542.md) from within the **activated** handler, but should instead wait for the **visibility changed** notification (the [visibilitychange event](XREF:TODO:wwa.MSHTMLDocumentExtensions_msvisibilitychanged) or the [CoreWindow.VisibilityChanged event](../windows.ui.core/corewindow_visibilitychanged.md)).


## -examples

## -see-also
