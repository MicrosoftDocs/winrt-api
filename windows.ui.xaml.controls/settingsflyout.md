---
-api-id: T:Windows.UI.Xaml.Controls.SettingsFlyout
-api-type: winrt class
---

<!-- Class syntax.
public class SettingsFlyout : Windows.UI.Xaml.Controls.ContentControl, Windows.UI.Xaml.Controls.ISettingsFlyout
-->

# Windows.UI.Xaml.Controls.SettingsFlyout

## -description
> [!NOTE]
> [SettingsFlyout](settingsflyout.md) is not supported for use in Universal Windows Platform (UWP) app for Windows 10. Instead, use a [Flyout](flyout.md).

> [!NOTE]
> [SettingsFlyout](settingsflyout.md) is supported only for use with the [SettingsPane](../windows.ui.applicationsettings/settingspane.md) in Windows 8. While the [SettingsFlyout](settingsflyout.md) type is visible in Windows Phone projects, [SettingsPane](../windows.ui.applicationsettings/settingspane.md) is not present on Windows Phone, so use of [SettingsFlyout](settingsflyout.md) is not supported.

Represents a control that provides in-context access to settings that affect the current app. (Not recommended for Universal Windows Platform (UWP) app.)

## -xaml-syntax
```xaml

<SettingsFlyout ...>
  singleRootElement
</SettingsFlyout>
```


## -remarks
A [SettingsFlyout](settingsflyout.md) control isn't intended to be a composite part of a page or general app UI. Instead, a [SettingsFlyout](settingsflyout.md) control is typically defined as a separate XAML file, where the class you're defining is a [SettingsFlyout](settingsflyout.md) subclass that's unique to your project, using a [SettingsFlyout](settingsflyout.md) object element as a XAML file root. In Microsoft Visual Studio, you can use the **Add New Item** menu options for a project to add the files to your project using a basic starting template. This starting template sets styles for items contained by the [SettingsFlyout](settingsflyout.md) control that reference existing pre-defined styles. For example, there's a style for a section header that references the `TitleTextBlockStyle` style that's defined by the Windows Runtime as a XAML resource. The generated XAML also provides some initial attribute values that are intended to be replaced. For example it sets the initial [Title](settingsflyout_title.md) value to use the class name. You'll also want to add controls or other UI to the content section to replace the templated UI it starts with.

### Showing and dismissing a Settings flyout

Users can access your [SettingsFlyout](settingsflyout.md) control through the **Settings** charm. You can programmatically show a [SettingsFlyout](settingsflyout.md) control by calling the [Show](settingsflyout_show.md) or [ShowIndependent](settingsflyout_showindependent.md) methods, and dismiss it by calling [Hide](settingsflyout_hide.md). A [SettingsFlyout](settingsflyout.md) always includes a back button in its header area that uses the typical arrow glyph (this button isn't part of the adjustable XAML template, it's always there and is added by default control logic). By default, the back button dismisses the flyout.

If a [SettingsFlyout](settingsflyout.md) control is shown by calling [Show](settingsflyout_show.md), clicking the back button dismisses the flyout and reopens the settings pane. If a [SettingsFlyout](settingsflyout.md) is shown by calling [ShowIndependent](settingsflyout_showindependent.md), clicking the back button dismisses the flyout and returns the user to the app. For example, if you open a [SettingsFlyout](settingsflyout.md) control from a "Settings" button in your app, you will typically call [ShowIndependent](settingsflyout_showindependent.md) so users are returned directly to your app when they dismiss the flyout.

Only one [SettingsFlyout](settingsflyout.md) control can be shown at a time. Calling [Show](settingsflyout_show.md) on any [SettingsFlyout](settingsflyout.md) instance hides any other [SettingsFlyout](settingsflyout.md) instance currently shown.

You can override the default back button behavior by handling the [BackClick](settingsflyout_backclick.md) event. This event is raised whenever the user clicks the back button. To override the default behavior, wire an event handler for the event and set the [BackClickEventArgs.Handled](backclickeventargs_handled.md) property to **true**. This is useful when you have a [SettingsFlyout](settingsflyout.md) that opens a second [SettingsFlyout](settingsflyout.md). By default, when the user taps the Back button on the second flyout, it will open the [SettingsPane](../windows.ui.applicationsettings/settingspane.md). You should handle the [BackClick](settingsflyout_backclick.md) event and open the first flyout instead.

### Connecting to the **SettingsPane**

You must manually associate the [SettingsFlyout](settingsflyout.md) control with the app’s [SettingsPane](../windows.ui.applicationsettings/settingspane.md) object. Do this by handling the [SettingsPane.CommandsRequested](../windows.ui.applicationsettings/settingspane_commandsrequested.md) event and adding a [SettingsCommand](../windows.ui.applicationsettings/settingscommand.md) to the [ApplicationCommands](../windows.ui.applicationsettings/settingspanecommandsrequest_applicationcommands.md) collection. The [SettingsCommand](../windows.ui.applicationsettings/settingscommand.md) has a label for your [SettingsFlyout](settingsflyout.md) control that’s shown in the **Settings** charm, and specifies a method that's executed when a user selects the command in the **Settings** charm. In this method, you create an instance of the [SettingsFlyout](settingsflyout.md) control and show it.

We recommend that you add the [CommandsRequested](../windows.ui.applicationsettings/settingspane_commandsrequested.md) event handler in the overridden [OnWindowCreated](../windows.ui.xaml/application_onwindowcreated.md) method, and remove it in the[ Application.Suspending](../windows.ui.xaml/application_suspending.md) event handler method. See the examples section for more info.

### Defining a Settings flyout

To add a [SettingsFlyout](settingsflyout.md) control to an app project in Microsoft Visual Studio:

1. Right-click your project in **Solution Explorer**. Select **Project &gt; Add New Item**.
1. In the **Add New Item** dialog, select **Settings Flyout** from the middle pane.
1. Type a name for the [SettingsFlyout](settingsflyout.md) control subclass in the **Name** field and click **Add**.


> [!NOTE]
> When you add a [SettingsFlyout](settingsflyout.md) control, you're creating a new class with a name you choose. When you look at the generated code-behind file, you'll see that the class you define is subclassing from [SettingsFlyout](settingsflyout.md).

To instantiate your [SettingsFlyout](settingsflyout.md) control, use the class name you specified and the default constructor for it. For example, if you named your [SettingsFlyout](settingsflyout.md) class as `UpdateSettingsFlyout`, you'd call `new UpdateSettingsFlyout()`.

For more information and detailed steps, see [Quickstart: Add app settings](http://msdn.microsoft.com/library/9651582e-56bb-4e14-ae99-9d0ff8cae104) and [Quickstart: Add app help](http://msdn.microsoft.com/library/770b546b-c909-4ecb-8a1f-c2f6b3e573b7).

## -examples
This example shows the result of adding a templated item for **Settings Flyout** and naming the class `UpdateSettingsFlyout`. Then, the `SettingsFlyoutSectionStyle` resource is redefined, and appropriate strings and controls are added to the XAML composition of the [SettingsFlyout](settingsflyout.md) XAML so that the user can adjust the settings.

```xaml
<SettingsFlyout
    x:Class="SettingsFlyoutExample.UpdateSettingsFlyout"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:SettingsFlyoutExample"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    mc:Ignorable="d"
    IconSource="Assets/SmallLogo.png"
    Title="App Updates"
    d:DesignWidth="346"
    Width="346" 
    HeaderBackground="#FF2B4A80">
    <SettingsFlyout.Resources>
        <Style x:Key="SettingsFlyoutSectionStyle" TargetType="StackPanel">
            <Setter Property="Margin" Value="0,0,0,39"/>
        </Style>
    </SettingsFlyout.Resources>

    <!-- This stack panel acts as a root panel for vertical layout of the content sections. -->
    <StackPanel VerticalAlignment="Stretch" HorizontalAlignment="Stretch" >

        <!-- The stack panels below define individual content sections. -->

        <!-- Content Section 1-->
        <StackPanel Style="{StaticResource SettingsFlyoutSectionStyle}">

            <!-- Section 1 header -->
            <TextBlock Style="{StaticResource TitleTextBlockStyle}"
                                 Text="Automatic updates"/>

            <!-- Section 1 body -->
            <TextBlock Style="{StaticResource BodyTextBlockStyle}" Margin="0,0,0,25" TextWrapping="Wrap">
                <TextBlock.Text>
                    Turn automatic updating on or off.
                </TextBlock.Text>
            </TextBlock>
            <ToggleSwitch Header="Download updates automatically"/>
            <ToggleSwitch Header="Install updates automatically"/>

        </StackPanel>

        <!-- Define more Content Sections below as necessary. -->

    </StackPanel>
</SettingsFlyout>
```

Here's how this [SettingsFlyout](settingsflyout.md) control can be associated with the app's [SettingsPane](../windows.ui.applicationsettings/settingspane.md) and [ApplicationCommands](../windows.ui.applicationsettings/settingspanecommandsrequest_applicationcommands.md). These methods are in App.xaml.cs.

```csharp

// Add the CommandsRequested handler when the window is created.
protected override void OnWindowCreated(WindowCreatedEventArgs args)
{
    SettingsPane.GetForCurrentView().CommandsRequested += OnCommandsRequested;
}

// Commands are requested when the Settings charm is used to open the SettingsPane.
private void OnCommandsRequested(SettingsPane sender, SettingsPaneCommandsRequestedEventArgs args)
{
    args.Request.ApplicationCommands.Add(new SettingsCommand(
    "AppUpdateSettings", "App updates", (handler) => ShowAppUpdatesSettingFlyout()));
}

// This code is executed when the user taps the "App updates" command in the SettingsPane.
public void ShowAppUpdatesSettingFlyout()
{
    UpdateSettingsFlyout updatesFlyout = new UpdateSettingsFlyout();
    updatesFlyout.Show();
}

// Remove the CommandsRequested handler when the app is suspending.
private async void OnSuspending(object sender, SuspendingEventArgs e)
{
    SettingsPane.GetForCurrentView().CommandsRequested -= App_CommandsRequested;

    var deferral = e.SuspendingOperation.GetDeferral();
    await SuspensionManager.SaveAsync();
    deferral.Complete();
}
```

Alternatively, the[SettingsFlyout](settingsflyout.md) can be shown independently:

```xaml
<Button Content="App update settings" Click="UpdateSettingsButton_Click"/>

```

```csharp
private void UpdateSettingsButton_Click(object sender, RoutedEventArgs e)
{
    UpdateSettingsFlyout updatesFlyout = new UpdateSettingsFlyout();
    updatesFlyout.ShowIndependent();
}
```

For more code in context, see the [App settings sample](http://go.microsoft.com/fwlink/p/?LinkID=310073).

## -see-also
[ContentControl](contentcontrol.md), [Quickstart: Add app settings](http://msdn.microsoft.com/library/9651582e-56bb-4e14-ae99-9d0ff8cae104), [Quickstart: Add app help](http://msdn.microsoft.com/library/770b546b-c909-4ecb-8a1f-c2f6b3e573b7), [App settings sample](http://go.microsoft.com/fwlink/p/?LinkID=310073)