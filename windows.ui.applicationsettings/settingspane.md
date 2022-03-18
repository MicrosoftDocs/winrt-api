---
-api-id: T:Windows.UI.ApplicationSettings.SettingsPane
-api-type: winrt class
---

<!-- Class syntax.
public class SettingsPane : Windows.UI.ApplicationSettings.ISettingsPane
-->

# Windows.UI.ApplicationSettings.SettingsPane

## -description
> [!NOTE]
> SettingsPane is deprecated, and might not work on all versions of Windows 10. Instead of using a SettingsPane, integrate settings options into the app experience. For more info, see [Guidelines for app settings](/windows/uwp/app-settings/guidelines-for-app-settings).

A static class that enables the app to control the Settings Charm pane. The app can add or remove commands, receive a notification when the user opens the pane, or open the pane programmatically.

## -remarks

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

## -examples
The following code shows how to add app commands by using the SettingsPane and [SettingsCommand](settingscommand.md) classes. For the full example, see [App settings sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/App%20settings%20sample).

```csharp
using Windows.UI.ApplicationSettings;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;
using System;

// This is the click handler for the 'addSettingsScenarioAdd' button.  
// Replace this with your own handler if you have a button or buttons on this page.
void addSettingsScenarioAdd_Click(object sender, RoutedEventArgs e)
{
    Button b = sender as Button;
    if (b != null)
    {
        rootPage.NotifyUser(
            "You selected the " + b.Content + " button", 
            NotifyType.StatusMessage);

        if (!this.isEventRegistered)
        {
            SettingsPane.GetForCurrentView().CommandsRequested += onCommandsRequested;
            this.isEventRegistered = true;
        }
    }
}

void onSettingsCommand(IUICommand command)
{
    SettingsCommand settingsCommand = (SettingsCommand)command;
    rootPage.NotifyUser(
        "You selected the " + settingsCommand.Label + " settings command from the " + 
        SettingsPane.Edge.ToString(), NotifyType.StatusMessage);

}

void onCommandsRequested(
    SettingsPane settingsPane, 
    SettingsPaneCommandsRequestedEventArgs eventArgs)
{
    UICommandInvokedHandler handler = new UICommandInvokedHandler(onSettingsCommand);

    SettingsCommand generalCommand = new SettingsCommand(
        "generalSettings", "General", handler);
    eventArgs.Request.ApplicationCommands.Add(generalCommand);

    SettingsCommand helpCommand = new SettingsCommand("helpPage", "Help", handler);
    eventArgs.Request.ApplicationCommands.Add(helpCommand);
}
```

```vb
Imports Windows.UI.ApplicationSettings
Imports Windows.UI.Popups
Imports Windows.UI.Xaml
Imports Windows.UI.Xaml.Controls
Imports Windows.UI.Xaml.Navigation
Imports System

    '' This is the click handler for the 'addSettingsScenarioAdd' button.  
    '' Replace this with your own handler if you have a button or buttons on this page.
    Private Sub addSettingsScenarioAdd_Click(sender As Object, e As RoutedEventArgs)
        Dim b As Button = TryCast(sender, Button)
        If b IsNot Nothing Then
            rootPage.NotifyUser("You selected the " & b.Content & " button", _
                NotifyType.StatusMessage)
            If Not Me.isEventRegistered Then
                AddHandler SettingsPane.GetForCurrentView.CommandsRequested, _
                    AddressOf onCommandsRequested
                Me.isEventRegistered = True
            End If
        End If
    End Sub

    Private Sub onSettingsCommand(command As IUICommand)
        Dim settingsCommand As SettingsCommand = DirectCast(command, SettingsCommand)
        rootPage.NotifyUser( _
        "You selected the " & settingsCommand.Label & " command from the " & SettingsPane.Edge.ToString(), _
        NotifyType.StatusMessage)
    End Sub

    Private Sub onCommandsRequested(settingsPane As SettingsPane, _
        eventArgs As SettingsPaneCommandsRequestedEventArgs)
        Dim handler As New UICommandInvokedHandler(AddressOf onSettingsCommand)

        Dim generalCommand As New SettingsCommand("generalSettings", "General", handler)
        eventArgs.Request.ApplicationCommands.Add(generalCommand)

        Dim helpCommand As New SettingsCommand("helpPage", "Help", handler)
        eventArgs.Request.ApplicationCommands.Add(helpCommand)
    End Sub


    '' This is the click handler for the 'addSettingsScenarioShow' button.  
    '' Replace this with your own handler if you have a button or buttons on this page.
    Private Sub addSettingsScenarioShow_Click(sender As Object, e As RoutedEventArgs)
        Dim b As Button = TryCast(sender, Button)
        If b IsNot Nothing Then
            rootPage.NotifyUser("You selected the " & b.Content & " button", _
                NotifyType.StatusMessage)
            SettingsPane.Show()
        End If
    End Sub

```

```cppcx
#include "pch.h"
#include "AddSettingsScenario.xaml.h"

using namespace ApplicationSettings;

using namespace Windows::Foundation;
using namespace Windows::UI::Xaml;
using namespace Windows::UI::Xaml::Controls;
using namespace Windows::UI::Xaml::Navigation;
using namespace Windows::UI::ApplicationSettings;
using namespace Windows::UI::Popups;

void ApplicationSettings::AddSettingsScenario::addSettingsScenarioAdd_Click(
    Platform::Object^ sender, Windows::UI::Xaml::RoutedEventArgs^ e)
{
    Button^ b = safe_cast<Button^>(sender);
    if (b != nullptr)
    {
        rootPage->NotifyUser("You selected the " + b->Content + " button", 
            NotifyType::StatusMessage);
        if (!this->isEventRegistered)
        {
            this->commandsRequestedEventRegistrationToken = 
                SettingsPane::GetForCurrentView()->CommandsRequested += 
                    ref new TypedEventHandler<SettingsPane^, 
                    SettingsPaneCommandsRequestedEventArgs^>(this, 
                        &AddSettingsScenario::onCommandsRequested);
            this->isEventRegistered = true;
        }
    }
}

void ApplicationSettings::AddSettingsScenario::onSettingsCommand(
    Windows::UI::Popups::IUICommand^ command)
{
    SettingsCommand^ settingsCommand = safe_cast<SettingsCommand^>(command);
    rootPage->NotifyUser(
        "You selected the " + settingsCommand->Label + " settings command from the " + 
        SettingsPane::Edge.ToString(), NotifyType::StatusMessage);
}

void ApplicationSettings::AddSettingsScenario::onCommandsRequested(
    Windows::UI::ApplicationSettings::SettingsPane^ settingsPane,
    Windows::UI::ApplicationSettings::SettingsPaneCommandsRequestedEventArgs^ eventArgs)
{
    UICommandInvokedHandler^ handler = ref new UICommandInvokedHandler(
        this, &AddSettingsScenario::onSettingsCommand);

    SettingsCommand^ generalCommand = ref new SettingsCommand(
        "generalSettings", "General", handler);
    eventArgs->Request->ApplicationCommands->Append(generalCommand);

    SettingsCommand^ helpCommand = ref new SettingsCommand("helpPage", "Help", handler);
    eventArgs->Request->ApplicationCommands->Append(helpCommand);
}
```

## -see-also
[SettingsCommand](settingscommand.md), [App settings sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/411c271e537727d737a53fa2cbe99eaecac00cc0/Official%20Windows%20Platform%20Sample/App%20settings%20sample)