---
-api-id: T:Windows.UI.Xaml.Controls.NavigationView
-api-type: winrt class
---

<!-- Class syntax.
public class NavigationView : ContentControl, ContentControl
-->

# Windows.UI.Xaml.Controls.NavigationView

## -description

Represents a container that enables navigation of app content. It has a header, a view for the main content, and a menu pane for navigation commands.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.NavigationView](/windows/winui/api/microsoft.ui.xaml.controls.navigationview) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<NavigationView .../>
```

## -remarks

### Access keys for built-in elements

To add access keys for the _back arrow_ and _settings_ buttons that are built-in to NavigationView, you have to use [VisualTreeHelper](/uwp/api/windows.ui.xaml.media.visualtreehelper) to get a reference to those controls, then set the properties in your code.

This example shows how to handle the [Loaded](/uwp/api/windows.ui.xaml.frameworkelement.loaded) event to find the elements in the visual tree and set the [AccessKey](/uwp/api/windows.ui.xaml.uielement.accesskey) and [KeyTipPlacementMode](/uwp/api/windows.ui.xaml.uielement.keytipplacementmode) properties. The NavigationView visual tree differs depending on the version being run, so the [ApiInformation.IsApiContractPresent](/uwp/api/windows.foundation.metadata.apiinformation.isapicontractpresent) method is used to determine the version at run-time, then the appropriate code runs to navigate the visual tree and find the _back_ and _settings_ elements.

```csharp
private void NavigationView_Loaded(object sender, RoutedEventArgs e)
{
    var navView = sender as NavigationView;
    var rootGrid = VisualTreeHelper.GetChild(navView, 0) as Grid;

    // SDK 18362 (1903)
    // SDK 17763 (1809)
    if (ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 7))
    {
        // Find the back button.
        var paneToggleButtonGrid = VisualTreeHelper.GetChild(rootGrid, 0) as Grid;
        var buttonHolderGrid = VisualTreeHelper.GetChild(paneToggleButtonGrid, 1) as Grid;
        var navigationViewBackButton = VisualTreeHelper.GetChild(buttonHolderGrid, 0) as Button;

        navigationViewBackButton.AccessKey = "A";

        if (navView.PaneDisplayMode == NavigationViewPaneDisplayMode.Top)
        {
            // Set back button key tip placement mode.
            navigationViewBackButton.KeyTipPlacementMode = Windows.UI.Xaml.Input.KeyTipPlacementMode.Bottom;

            // Find the settings item and set properties.
            var grid = VisualTreeHelper.GetChild(rootGrid, 1) as Grid;
            var topNavArea = VisualTreeHelper.GetChild(grid, 0) as StackPanel;
            var topNavGrid = VisualTreeHelper.GetChild(topNavArea, 1) as Grid;
            var settingsTopNavPaneItem = VisualTreeHelper.GetChild(topNavGrid, 7) as NavigationViewItem;

            settingsTopNavPaneItem.AccessKey = "S";
            settingsTopNavPaneItem.KeyTipPlacementMode = Windows.UI.Xaml.Input.KeyTipPlacementMode.Bottom;
        }
        else
        {
            // Set back button key tip placement mode.
            navigationViewBackButton.KeyTipPlacementMode = Windows.UI.Xaml.Input.KeyTipPlacementMode.Right;

            // Find the settings item and set properties.
            var grid = VisualTreeHelper.GetChild(rootGrid, 1) as Grid;
            var rootSplitView = VisualTreeHelper.GetChild(grid, 1) as SplitView;
            var grid2 = VisualTreeHelper.GetChild(rootSplitView, 0) as Grid;
            var paneRoot = VisualTreeHelper.GetChild(grid2, 0) as Grid;
            var border = VisualTreeHelper.GetChild(paneRoot, 0) as Border;
            var paneContentGrid = VisualTreeHelper.GetChild(border, 0) as Grid;
            var settingsNavPaneItem = VisualTreeHelper.GetChild(paneContentGrid, 6) as NavigationViewItem;

            settingsNavPaneItem.AccessKey = "S";
            settingsNavPaneItem.KeyTipPlacementMode = Windows.UI.Xaml.Input.KeyTipPlacementMode.Right;
        }
    }
    // SDK 17134 (1803)
    else if (ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 6))
    {
        // Find the back button and set properties.
        var paneToggleButtonGrid = VisualTreeHelper.GetChild(rootGrid, 0) as Grid;
        var buttonHolderGrid = VisualTreeHelper.GetChild(paneToggleButtonGrid, 1) as Grid;
        var navigationViewBackButton = VisualTreeHelper.GetChild(buttonHolderGrid, 0) as Button;

        navigationViewBackButton.AccessKey = "A";
        navigationViewBackButton.KeyTipPlacementMode = Windows.UI.Xaml.Input.KeyTipPlacementMode.Right;

        // Find the settings item and set properties.
        var rootSplitView = VisualTreeHelper.GetChild(rootGrid, 1) as SplitView;
        var grid = VisualTreeHelper.GetChild(rootSplitView, 0) as Grid;
        var paneRoot = VisualTreeHelper.GetChild(grid, 0) as Grid;
        var border = VisualTreeHelper.GetChild(paneRoot, 0) as Border;
        var paneContentGrid = VisualTreeHelper.GetChild(border, 0) as Grid;
        var settingsNavPaneItem = VisualTreeHelper.GetChild(paneContentGrid, 5) as NavigationViewItem;

        settingsNavPaneItem.AccessKey = "S";
        settingsNavPaneItem.KeyTipPlacementMode = Windows.UI.Xaml.Input.KeyTipPlacementMode.Right;
    }
    // SDK 16299 (Fall Creator's Update)
    else if (ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 5))
    {
        // Find the settings item and set properties.
        var rootSplitView = VisualTreeHelper.GetChild(rootGrid, 1) as SplitView;
        var grid = VisualTreeHelper.GetChild(rootSplitView, 0) as Grid;
        var paneRoot = VisualTreeHelper.GetChild(grid, 0) as Grid;
        var border = VisualTreeHelper.GetChild(paneRoot, 0) as Border;
        var paneContentGrid = VisualTreeHelper.GetChild(border, 0) as Grid;
        var settingsNavPaneItem = VisualTreeHelper.GetChild(paneContentGrid, 4) as NavigationViewItem;

        settingsNavPaneItem.AccessKey = "S";
        settingsNavPaneItem.KeyTipPlacementMode = Windows.UI.Xaml.Input.KeyTipPlacementMode.Right;
    }
}
```

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, `generic.xaml` is available locally with the SDK or NuGet package installation.

- **WinUI Styles (recommended):** Use [Microsoft.UI.Xaml.Controls.NavigationView](/windows/winui/api/microsoft.ui.xaml.controls.navigationview).
- **Non-WinUI styles:** For built-in styles, see `%ProgramFiles(x86)%\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic\generic.xaml`.

Locations might be different if you customized the installation. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393).

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1803 | 17134 | BackRequested |
| 1803 | 17134 | IsBackButtonVisible |
| 1803 | 17134 | IsBackEnabled |
| 1803 | 17134 | PaneClosed |
| 1803 | 17134 | PaneClosing |
| 1803 | 17134 | PaneOpened |
| 1803 | 17134 | PaneOpening |
| 1803 | 17134 | PaneTitle |
| 1809 | 17763 | ContentOverlay |
| 1809 | 17763 | IsPaneVisible |
| 1809 | 17763 | OverflowLabelMode |
| 1809 | 17763 | PaneCustomContent |
| 1809 | 17763 | PaneDisplayMode |
| 1809 | 17763 | PaneHeader |
| 1809 | 17763 | SelectionFollowsFocus |
| 1809 | 17763 | ShoulderNavigationEnabled |
| 1809 | 17763 | TemplateSettings |

## -see-also
[Guidelines for navigation view](/windows/uwp/controls-and-patterns/navigationview), [Back button in NavigationView](/windows/uwp/design/basics/navigation-history-and-backwards-navigation)

## -examples

> [!TIP]
> For more info, design guidance, and code examples, see [Navigation view](/windows/apps/design/controls/navigationview).

> [!div class="nextstepaction"]
> [Open the WinUI 2 Gallery app and see the NavigationView in action](winui2gallery:/item/NavigationView)

> The **WinUI 2 Gallery** app includes interactive examples of most WinUI 2 controls, features, and functionality. Get the app from the [Microsoft Store](https://www.microsoft.com/store/productId/9MSVH128X2ZT) or get the source code on [GitHub](https://github.com/Microsoft/WinUI-Gallery/tree/winui2).
