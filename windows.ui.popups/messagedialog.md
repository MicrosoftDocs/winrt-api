---
-api-id: T:Windows.UI.Popups.MessageDialog
-api-type: winrt class
---

<!-- Class syntax.
public class MessageDialog : Windows.UI.Popups.IMessageDialog
-->

# Windows.UI.Popups.MessageDialog

## -description
Represents a dialog for showing messages to the user. 

## -remarks
> [!IMPORTANT]
> You should use MessageDialog only when you are upgrading a Universal Windows 8 app that uses MessageDialog, and need to minimize changes. For new apps in Windows 10, we recommend using the [ContentDialog](./../windows.ui.xaml.controls/contentdialog.md) control instead.

> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](http://go.microsoft.com/fwlink/p/?linkid=258275) and [Using Windows Runtime objects in a multithreaded environment (.NET)](http://go.microsoft.com/fwlink/p/?linkid=258277).

The dialog has a command bar that can support up to 3 commands in desktop apps, or 2 commands in mobile apps. If you don't specify any commands, then a default command is added to close the dialog.

The dialog dims the screen behind it and blocks touch events from passing to the app's canvas until the user responds.

Message dialogs should be used sparingly, and only for critical messages or simple questions that must block the user's flow.

Here's an example of a dialog created by the code in the Examples section.

<img src="images/MessageDialogWithTwoCommands.png" alt="Message dialog with two commands" />

## -examples
The following example shows how to add commands to a message dialog and display it. For the full code example, see [Message dialog sample](http://go.microsoft.com/fwlink/p/?linkid=231551).

```cpp
#include "pch.h"
#include "CancelCommand.xaml.h"

using namespace MessageDialogSample;

using namespace Windows::UI::Popups;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Navigation;

void MessageDialogSample::CancelCommand::CancelCommandButton_Click(Platform::Object^ sender,
    Windows::UI::Xaml::RoutedEventArgs^ e)
{
    // Create the message dialog and set its content
    MessageDialog^ msg = ref new MessageDialog("No internet connection has been found.");

    // Add commands and set their callbacks.
    // Both commands use the same callback function instead of inline event handlers.
    UICommand^ continueCommand = ref new UICommand(
        "Try again", 
        ref new UICommandInvokedHandler(this, &CancelCommand::CommandInvokedHandler));
    UICommand^ upgradeCommand = ref new UICommand(
        "Close", 
        ref new UICommandInvokedHandler(this, &CancelCommand::CommandInvokedHandler));

    // Add the commands to the dialog
    msg->Commands->Append(continueCommand);
    msg->Commands->Append(upgradeCommand);

    // Set the command that will be invoked by default
    msg->DefaultCommandIndex = 0;

    // Set the command to be invoked when escape is pressed
    msg->CancelCommandIndex = 1;

    // Show the message dialog
    msg->ShowAsync();
}

void CancelCommand::CommandInvokedHandler(Windows::UI::Popups::IUICommand^ command)
{
    // Display message
    rootPage->NotifyUser("The '" + command->Label + "' command has been selected.", 
        NotifyType::StatusMessage);
}
```

```csharp

using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using SDKTemplate;
using System;

private async void CancelCommandButton_Click(object sender, RoutedEventArgs e)
{
    // Create the message dialog and set its content
    var messageDialog = new MessageDialog("No internet connection has been found.");

    // Add commands and set their callbacks; both buttons use the same callback function instead of inline event handlers
    messageDialog.Commands.Add(new UICommand(
        "Try again", 
        new UICommandInvokedHandler(this.CommandInvokedHandler)));
    messageDialog.Commands.Add(new UICommand(
        "Close", 
        new UICommandInvokedHandler(this.CommandInvokedHandler)));

    // Set the command that will be invoked by default
    messageDialog.DefaultCommandIndex = 0;

    // Set the command to be invoked when escape is pressed
    messageDialog.CancelCommandIndex = 1;

    // Show the message dialog
    await messageDialog.ShowAsync();
}

private void CommandInvokedHandler(IUICommand command)
{
    // Display message showing the label of the command that was invoked
    rootPage.NotifyUser("The '" + command.Label + "' command has been selected.", 
        NotifyType.StatusMessage);
}
```

```vbnet
Imports Windows.UI.Popups
Imports Windows.UI.Xaml
Imports Windows.UI.Xaml.Controls
Imports Windows.UI.Xaml.Navigation
Imports SDKTemplate

Partial Public NotInheritable Class CloseCommand
    Inherits SDKTemplate.Common.LayoutAwarePage

    ' A pointer back to the main page.  This is needed if you want to call methods in MainPage such
    ' as NotifyUser()
    Private rootPage As MainPage = MainPage.Current

    Public Sub New()
        Me.InitializeComponent()
    End Sub

    Private Async Sub CloseCommandLaunch_Click(sender As Object, e As RoutedEventArgs)
        ' Create the message dialog and set its content and title
        Dim messageDialog = New MessageDialog("No internet connection has been found.")

        ' Add buttons and set their callbacks
        messageDialog.Commands.Add(New UICommand("Try again", Sub(command)
            rootPage.NotifyUser("The '" & command.Label & "' button has been selected.", _ 
                NotifyType.StatusMessage)
                                                              End Sub))

        messageDialog.Commands.Add(New UICommand("Close", Sub(command) 
            rootPage.NotifyUser("The '" & command.Label & "' button has been selected.", _
                NotifyType.StatusMessage)
                                                          End Sub))

        ' Set the command that will be invoked by default
        messageDialog.DefaultCommandIndex = 0

        ' Set the command to be invoked when escape is pressed
        messageDialog.CancelCommandIndex = 1

        ' Show the message dialog
        Await messageDialog.ShowAsync
    End Sub
End Class

```

```javascript
(function () {
    "use strict";
    var page = WinJS.UI.Pages.define("/html/cancelcommand.html", {
        ready: function (element, options) {
            element.querySelector("#cancelCommand").addEventListener(
                "click", 
                cancelCommand_Click, false);
        }
    });

    // Click handler for the 'cancelCommand' button.
    // Demonstrates setting the command to be invoked when the 'escape' key is pressed.
    // Also demonstrates retrieval of the label of the chosen command and setting a 
    // callback to a function.
    // A message will be displayed indicating which command was invoked.
    // In this scenario, 'Try again' is selected as the default choice, and the 
    // 'escape' key will invoke the command named 'Close'
    function cancelCommand_Click() {
        // Create the message dialog and set its content
        var msg = new Windows.UI.Popups.MessageDialog(
            "No internet connection has been found.");

        // Add commands and set their command handlers
        msg.commands.append(new Windows.UI.Popups.UICommand(
            "Try again", 
            commandInvokedHandler));
        msg.commands.append(
            new Windows.UI.Popups.UICommand("Close", commandInvokedHandler));

        // Set the command that will be invoked by default
        msg.defaultCommandIndex = 0;

        // Set the command to be invoked when escape is pressed
        msg.cancelCommandIndex = 1;

        // Show the message dialog
        msg.showAsync();
    }

    function commandInvokedHandler(command) {
        // Display message
        WinJS.log && WinJS.log("The '" + command.label + "' command has been selected.", 
        "sample", "status");
    }
})();
```



## -see-also
[Message dialog sample](http://go.microsoft.com/fwlink/p/?linkid=231551), [Message dialog sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620570)