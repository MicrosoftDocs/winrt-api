---
-api-id: T:Windows.UI.Xaml.Controls.ContentDialog
-api-type: winrt class
---

<!-- Class syntax.
public class ContentDialog : Windows.UI.Xaml.Controls.ContentControl, Windows.UI.Xaml.Controls.IContentDialog, Windows.UI.Xaml.Controls.IContentDialog2
-->

# Windows.UI.Xaml.Controls.ContentDialog

## -description
Represents a dialog box that can be customized to contain checkboxes, hyperlinks, buttons and any other XAML content.


## -xaml-syntax
```xaml
<ContentDialog .../>
-or-
<ContentDialog>
    singleObject
</ContentDialog>
-or-
<ContentDialog>stringContent</ContentDialog>
```

## -remarks

> [!TIP]
> For more info, design guidance, and code examples, see [Dialog controls](/windows/uwp/design/controls-and-patterns/dialogs-and-flyouts/dialogs
).

Use a ContentDialog to request input from the user, or to show information in a modal dialog. You can add a ContentDialog to an app page using code or XAML, or you can create a custom dialog class that's derived from ContentDialog. Both ways are shown in the examples section of this topic.

Use the [Title](contentdialog_title.md) property to put a title on the dialog. To add a complex title element with more than simple text, you can use the [TitleTemplate](contentdialog_titletemplate.md) property.

The ContentDialog has 3 built-in buttons that describe the actions that the user may take in response to the dialog's prompt. All dialogs should have a safe, non-destructive action. Dialogs may also optionally contain one or two specific "do it" actions in response to the prompt.  

Use the [CloseButtonText](contentdialog_closebuttontext.md) and property to set the display text for the safe, non-destructive button. The dialog's close button will also be invoked when the user performs a Cancel action, like pressing the ESC key or pressing the system back button.
Use the [PrimaryButtonText](contentdialog_primarybuttontext.md) and [SecondaryButtonText](contentdialog_secondarybuttontext.md) properties to display responses to the main question or action posed by the dialog.

The [CloseButtonText](contentdialog_closebuttontext.md) property is not available prior to Windows 10, version 1703. If your app's 'minimum platform version' setting in Microsoft Visual Studio is less than the 'introduced version' shown in the Requirements block later in this page, you should use the [SecondaryButtonText](contentdialog_secondarybuttontext.md) property instead. For more info, see [Version adaptive code](/windows/uwp/debug-test-perf/version-adaptive-code).

To show the dialog, call the [ShowAsync](contentdialog_showasync_1208475713.md) method. Use the result of this method to determine which of the buttons was clicked, if any button was clicked. If the user presses ESC, the system back arrow, or Gamepad B, the result of this method will be None.

You may optionally choose to differentiate one of the three buttons as the dialog's default button. Use the [DefaultButton](contentdialog_defaultbutton.md) property to differentiate one of the buttons. This button will receive the Accent Button visual treatment, respond to the ENTER key automatically, and receive focus when the Dialog is opened unless the dialog's content contains focusable elements.

You may wish to do some work before the dialog closes (for example, to verify that the user entered into form fields before submitting a request). You have two ways to do work before the dialog closes. You can handle the [PrimaryButtonClick](contentdialog_primarybuttonclick.md), [SecondaryButtonClick](contentdialog_secondarybuttonclick.md), or [CloseButtonClick](contentdialog_closebuttonclick.md) events to get the user's response when the user presses a button and verify the state of the dialog before it closes. You can also handle the [Closing](contentdialog_closing.md) event to do work before the dialog closes.

Only one ContentDialog can be shown at a time. To chain together more than one ContentDialog, handle the [Closing](contentdialog_closing.md) event of the first ContentDialog. In the [Closing](contentdialog_closing.md) event handler, call [ShowAsync](contentdialog_showasync_1208475713.md) on the second dialog to show it.

## Derived controls with WinUI styles

> NOTE: This section applies only to apps that use WinUI 2.2 or later..

The [Windows UI Library](/uwp/toolkits/winui/) 2.2 or later includes a new template for this control that uses updated styles. If you derive a custom control from an existing XAML control, it will not get the WinUI 2 styles by default. To apply the WinUI 2 styles:

- Create a new [Style](/uwp/api/windows.ui.xaml.style) with its [TargetType](/uwp/api/windows.ui.xaml.style.targettype) set to your custom control.
- Base the Style on the default style of the control you derived from.

One common scenario for this is to derive a new control from [ContentDialog](/uwp/api/windows.ui.xaml.controls.contentdialog). This example shows how to create a new Style that applies `DefaultContentDialogStyle` to your custom dialog. 

```xaml
<ContentDialog
    x:Class="ExampleApp.SignInContentDialog"
    ... >
    <ContentDialog.Resources>
        <Style TargetType="local:SignInContentDialog" BasedOn="{StaticResource DefaultContentDialogStyle}"/>
        ...
    </ContentDialog.Resources> 
    <!-- CONTENT -->
</ContentDialog>        
```

## ContentDialog in AppWindow or Xaml Islands

> NOTE: This section applies only to apps that target Windows 10, version 1903 or later. AppWindow and XAML Islands are not available in earlier versions. For more info about versioning, see [Version adaptive apps](/windows/uwp/debug-test-perf/version-adaptive-apps).

By default, content dialogs display modally relative to the root [ApplicationView](../windows.ui.viewmanagement/applicationview.md). When you use ContentDialog inside of either an [AppWindow](../windows.ui.windowmanagement/appwindow.md) or a [XAML Island](/windows/apps/desktop/modernize/xaml-islands), you need to manually set the [XamlRoot](../windows.ui.xaml/uielement_xamlroot.md) on the dialog to the root of the XAML host.

To do so, set the ContentDialog's XamlRoot property to the same XamlRoot as an element already in the AppWindow or XAML Island, as shown here.

```csharp
private async void DisplayNoWifiDialog()
{
    ContentDialog noWifiDialog = new ContentDialog
    {
        Title = "No wifi connection",
        Content = "Check your connection and try again.",
        CloseButtonText = "Ok"
    };

    // Use this code to associate the dialog to the appropriate AppWindow by setting
    // the dialog's XamlRoot to the same XamlRoot as an element that is already present in the AppWindow.
    if (ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 8))
    {
        noWifiDialog.XamlRoot = elementAlreadyInMyAppWindow.XamlRoot;
    }

    ContentDialogResult result = await noWifiDialog.ShowAsync();
}
```

> [!WARNING]
> There can only be one ContentDialog open per thread at a time. Attempting to open two ContentDialogs will throw an exception, even if they are attempting to open in separate AppWindows.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is available locally with the SDK or NuGet package installation.

- **[WinUI Styles (recommended)](/windows/apps/design/style/xaml-styles#winui-and-styles):** For updated styles from WinUI, see `\Users\<username>\.nuget\packages\microsoft.ui.xaml\<version>\lib\uap10.0\Microsoft.UI.Xaml\Themes\generic.xaml`.
- **Non-WinUI styles:** For built-in styles, see `%ProgramFiles(x86)%\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic\generic.xaml`.

Locations might be different if you customized the installation. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | CloseButtonClick |
| 1703 | 15063 | CloseButtonCommand |
| 1703 | 15063 | CloseButtonCommandParameter |
| 1703 | 15063 | CloseButtonStyle |
| 1703 | 15063 | CloseButtonText |
| 1703 | 15063 | DefaultButton |
| 1703 | 15063 | PrimaryButtonStyle |
| 1703 | 15063 | SecondaryButtonStyle |
| 1709 | 16299 | ShowAsync(ContentDialogPlacement) |

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Dialog controls](/windows/uwp/design/controls-and-patterns/dialogs-and-flyouts/dialogs
).
>
> If you have the **WinUI 2 Gallery** app installed, click here to [open the app and see the ContentDialog in action](winui2gallery:/item/ContentDialog).
> + [Get the WinUI 2 Gallery app (Microsoft Store)](https://www.microsoft.com/store/productId/9MSVH128X2ZT)
> + [Get the source code (GitHub)](https://github.com/Microsoft/WinUI-Gallery)

This example shows how to create and show a simple ContentDialog in code.

```csharp
private async void DisplayNoWifiDialog()
{
    ContentDialog noWifiDialog = new ContentDialog()
    {
        Title = "No wifi connection",
        Content = "Check connection and try again.",
        CloseButtonText = "Ok"
    };

    await noWifiDialog.ShowAsync();
}
```

This example shows how to create a ContentDialog in the XAML of an app page. Even though the dialog is defined in the app page, it's not shown until you call [ShowAsync](contentdialog_showasync_1208475713.md) in your code.

Here, the [IsPrimaryButtonEnabled](contentdialog_isprimarybuttonenabled.md) property is set to **false**. The primary button is enabled in code when the user checks the [CheckBox](checkbox.md) to confirm their age.

The [TitleTemplate](contentdialog_titletemplate.md) property is used to create a title that includes both a logo and text.

```xaml
<ContentDialog x:Name="termsOfUseContentDialog"
           PrimaryButtonText="Accept" IsPrimaryButtonEnabled="False"
           CloseButtonText="Cancel"
           Opened="TermsOfUseContentDialog_Opened">
    <ContentDialog.TitleTemplate>
        <DataTemplate>
            <StackPanel Orientation="Horizontal">
                <Image Source="ms-appx:///Assets/SmallLogo.png" Width="40" Height="40" Margin="10,0"/>
                <TextBlock Text="Terms of use"/>
            </StackPanel>
        </DataTemplate>
    </ContentDialog.TitleTemplate>
    <StackPanel>
        <TextBlock TextWrapping="WrapWholeWords">
        <Run>Lorem ipsum dolor sit amet, consectetuer adipiscing elit. Maecenas porttitor
             congue massa. Fusce posuere, magna sed pulvinar ultricies, purus lectus
             malesuada libero, sit amet commodo magna eros quis urna.</Run><LineBreak/>
        <Run>Nunc viverra imperdiet enim. Fusce est. Vivamus a tellus.</Run><LineBreak/>
        <Run>Pellentesque habitant morbi tristique senectus et netus et malesuada fames
             ac turpis egestas. Proin pharetra nonummy pede. Mauris et orci.</Run><LineBreak/>
        <Run>Suspendisse dui purus, scelerisque at, vulputate vitae, pretium mattis, nunc.
             Mauris eget neque at sem venenatis eleifend. Ut nonummy.</Run>
        </TextBlock>
        <CheckBox x:Name="ConfirmAgeCheckBox" Content="I am over 13 years of age."
              Checked="ConfirmAgeCheckBox_Checked" Unchecked="ConfirmAgeCheckBox_Unchecked"/>
    </StackPanel>
</ContentDialog>
```

```csharp
private async void ShowTermsOfUseContentDialogButton_Click(object sender, RoutedEventArgs e)
{
    ContentDialogResult result = await termsOfUseContentDialog.ShowAsync();
    if (result == ContentDialogResult.Primary)
    {
        // Terms of use were accepted.
    }
    else
    {
        // User pressed Cancel, ESC, or the back arrow.
        // Terms of use were not accepted.
    }
}

private void TermsOfUseContentDialog_Opened(ContentDialog sender, ContentDialogOpenedEventArgs args)
{
    // Ensure that the check box is unchecked each time the dialog opens.
    ConfirmAgeCheckBox.IsChecked = false;
}

private void ConfirmAgeCheckBox_Checked(object sender, RoutedEventArgs e)
{
    termsOfUseContentDialog.IsPrimaryButtonEnabled = true;
}

private void ConfirmAgeCheckBox_Unchecked(object sender, RoutedEventArgs e)
{
    termsOfUseContentDialog.IsPrimaryButtonEnabled = false;
}
```

This example shows how to create and use a custom dialog (`SignInContentDialog`) derived from ContentDialog. If you are using WinUI 2.2 or later, also see [Derived controls with WinUI styles](#derived_controls_with_winui_styles).

```xaml

<!-- SignInContentDialog.xaml -->
<ContentDialog
    x:Class="ExampleApp.SignInContentDialog"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:ExampleApp"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    mc:Ignorable="d"
    Title="SIGN IN"
    PrimaryButtonText="Sign In"  
    CloseButtonText="Cancel"
    PrimaryButtonClick="ContentDialog_PrimaryButtonClick"
    CloseButtonClick="ContentDialog_CloseButtonClick">

    <ContentDialog.Resources>
    <!-- Uncomment this Style if using WinUI 2.2 or later. -->
    <!-- <Style TargetType="local:SignInContentDialog" BasedOn="{StaticResource DefaultContentDialogStyle}"/> -->

    <!-- These flyouts or used for confirmation when the user changes
         the option to save their user name. -->
        <Flyout x:Key="DiscardNameFlyout" Closed="Flyout_Closed">
            <StackPanel>
                <TextBlock Text="Discard user name?"/>
                <Button Content="Discard" Click="DiscardButton_Click"/>
            </StackPanel>
        </Flyout>
        <Flyout x:Key="SaveNameFlyout" Closed="Flyout_Closed">
            <StackPanel>
                <TextBlock Text="Save user name?"/>
                <Button Content="Save" Click="SaveButton_Click"/>
            </StackPanel>
        </Flyout>
    </ContentDialog.Resources>

    <StackPanel VerticalAlignment="Stretch" HorizontalAlignment="Stretch">
        <TextBox Name="userNameTextBox" Header="User name"/>
        <PasswordBox Name="passwordTextBox" Header="Password" IsPasswordRevealButtonEnabled="True"/>
        <CheckBox Name="saveUserNameCheckBox" Content="Save user name"/>

        <TextBlock x:Name="errorTextBlock" Style="{StaticResource ControlContextualInfoTextBlockStyle}"/>

        <!-- Content body -->
        <TextBlock Name="body" Style="{StaticResource MessageDialogContentStyle}" TextWrapping="Wrap">
            <TextBlock.Text>
                Lorem ipsum dolor sit amet, consectetur adipisicing elit,
                    sed do eiusmod tempor incididunt ut labore et dolore magna aliqua.
            </TextBlock.Text>
        </TextBlock>
    </StackPanel>
</ContentDialog>
```

```csharp

// SignInContentDialog.xaml.cs
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace ExampleApp
{
    public enum SignInResult
    {
        SignInOK,
        SignInFail,
        SignInCancel,
        Nothing
    }

    public sealed partial class SignInContentDialog : ContentDialog
    {
        public SignInResult Result { get; private set; }

        public SignInContentDialog()
        {
            this.InitializeComponent();
            this.Opened += SignInContentDialog_Opened;
            this.Closing += SignInContentDialog_Closing;
        }

        private void ContentDialog_PrimaryButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            // Ensure the user name and password fields aren't empty. If a required field
            // is empty, set args.Cancel = true to keep the dialog open.
            if (string.IsNullOrEmpty(userNameTextBox.Text))
            {
                args.Cancel = true;
                errorTextBlock.Text = "User name is required.";
            }
            else if (string.IsNullOrEmpty(passwordTextBox.Password))
            {
                args.Cancel = true;
                errorTextBlock.Text = "Password is required.";
            }

            // If you're performing async operations in the button click handler,
            // get a deferral before you await the operation. Then, complete the
            // deferral when the async operation is complete.

            ContentDialogButtonClickDeferral deferral = args.GetDeferral();    
            if (await SomeAsyncSignInOperation())
            {
                this.Result = SignInResult.SignInOK;
            }
            else
            {
                this.Result = SignInResult.SignInFail;
            }
            deferral.Complete();
        }

        private void ContentDialog_CloseButtonClick(ContentDialog sender, ContentDialogButtonClickEventArgs args)
        {
            // User clicked Cancel, ESC, or the system back button.
            this.Result = SignInResult.SignInCancel;
        }

        void SignInContentDialog_Opened(ContentDialog sender, ContentDialogOpenedEventArgs args)
        {
            this.Result = SignInResult.Nothing;

            // If the user name is saved, get it and populate the user name field.
            Windows.Storage.ApplicationDataContainer roamingSettings = Windows.Storage.ApplicationData.Current.RoamingSettings;
            if (roamingSettings.Values.ContainsKey("userName"))
            {
                userNameTextBox.Text = roamingSettings.Values["userName"].ToString();
                saveUserNameCheckBox.IsChecked = true;
            }
        }

        void SignInContentDialog_Closing(ContentDialog sender, ContentDialogClosingEventArgs args)
        {
            // If sign in was successful, save or clear the user name based on the user choice.
            if (this.Result == SignInResult.SignInOK)
            {
                if (saveUserNameCheckBox.IsChecked == true)
                {
                    SaveUserName();
                }
                else
                {
                    ClearUserName();
                }
            }

            // If the user entered a name and checked or cleared the 'save user name' checkbox, then clicked the back arrow,
            // confirm if it was their intention to save or clear the user name without signing in.
            if (this.Result == SignInResult.Nothing && !string.IsNullOrEmpty(userNameTextBox.Text))
            {
                if (saveUserNameCheckBox.IsChecked == false)
                {
                    args.Cancel = true;
                    FlyoutBase.SetAttachedFlyout(this, (FlyoutBase)this.Resources["DiscardNameFlyout"]);
                    FlyoutBase.ShowAttachedFlyout(this);
                }
                else if (saveUserNameCheckBox.IsChecked == true && !string.IsNullOrEmpty(userNameTextBox.Text))
                {
                    args.Cancel = true;
                    FlyoutBase.SetAttachedFlyout(this, (FlyoutBase)this.Resources["SaveNameFlyout"]);
                    FlyoutBase.ShowAttachedFlyout(this);
                }
            }
        }

        private void SaveUserName()
        {
            Windows.Storage.ApplicationDataContainer roamingSettings = Windows.Storage.ApplicationData.Current.RoamingSettings;
            roamingSettings.Values["userName"] = userNameTextBox.Text;
        }

        private void ClearUserName()
        {
            Windows.Storage.ApplicationDataContainer roamingSettings = Windows.Storage.ApplicationData.Current.RoamingSettings;
            roamingSettings.Values["userName"] = null;
            userNameTextBox.Text = string.Empty;
        }

        // Handle the button clicks from the flyouts.
        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            SaveUserName();
            FlyoutBase.GetAttachedFlyout(this).Hide();
        }

        private void DiscardButton_Click(object sender, RoutedEventArgs e)
        {
            ClearUserName();
            FlyoutBase.GetAttachedFlyout(this).Hide();
        }

        // When the flyout closes, hide the sign in dialog, too.
        private void Flyout_Closed(object sender, object e)
        {
            this.Hide();
        }
    }
}

```

Here's code that shows the `SignInContentDialog` and uses its custom `SignInResult`.

```csharp

private async void ShowSignInDialogButton_Click(object sender, RoutedEventArgs e)
{
    SignInContentDialog signInDialog = new SignInContentDialog();
    await signInDialog.ShowAsync();

    if (signInDialog.Result == SignInResult.SignInOK)
    {
        // Sign in was successful.
    }
    else if (signInDialog.Result == SignInResult.SignInFail)
    {
        // Sign in failed.
    }
    else if (signInDialog.Result == SignInResult.SignInCancel)
    {
        // Sign in was cancelled by the user.
    }
}
```

## -see-also
[ContentControl](contentcontrol.md), [Dialogs and flyouts](/windows/uwp/design/controls-and-patterns/dialogs)
