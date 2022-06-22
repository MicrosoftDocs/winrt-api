---
-api-id: T:Windows.UI.Xaml.Controls.Primitives.Popup
-api-type: winrt class
---

<!-- Class syntax.
public class Popup : Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.Controls.Primitives.IPopup, Windows.UI.Xaml.Controls.Primitives.IPopup2
-->

# Windows.UI.Xaml.Controls.Primitives.Popup

## -description

Displays content on top of existing content.



## -xaml-syntax

```xaml
<Popup .../>
```

## -remarks

Do not use a Popup if a [Flyout](../windows.ui.xaml.controls/flyout.md), [MenuFlyout](../windows.ui.xaml.controls/menuflyout.md), [ToolTip](../windows.ui.xaml.controls/tooltip.md) or [ContentDialog](../windows.ui.xaml.controls/contentdialog.md) ([MessageDialog](/uwp/api/windows.ui.popups.messagedialog) for a Windows 8 app) is more appropriate.

<!--For more info, see Displaying popups. (Add this when the topic is created.)-->

Popup is a general purpose container for hosting [UIElement](../windows.ui.xaml/uielement.md)s on top of existing content. You typically use a Popup to temporarily display content that accomplishes a particular task. The Popup does not have a default visual template. Instead, you must set the content yourself by specifying a single [Child](popup_child.md) element as content. You can define the Popup content inline, but it's common to define the content as a [UserControl](../windows.ui.xaml.controls/usercontrol.md), and then set the [UserControl](../windows.ui.xaml.controls/usercontrol.md) as the [Child](popup_child.md) of the Popup.

You position the Popup by setting the [HorizontalOffset](popup_horizontaloffset.md) and [VerticalOffset](popup_verticaloffset.md) properties. The Popup is offset relative to its immediate parent container. A Popup is not modal, so input to the screen behind it is not blocked. If the [ShouldConstrainToRootBounds](popup_shouldconstraintorootbounds.md) property is `false`, the Popup may be positioned such that it is not inside the bounds of the root of the content.

To show a Popup, set its [IsOpen](popup_isopen.md) property to **true**. To hide the Popup, set [IsOpen](popup_isopen.md) to **false**. You can set [IsLightDismissEnabled](popup_islightdismissenabled.md) to make the Popup hide automatically when a user taps anywhere away from it.

The Popup can host input controls. When hosting input controls like [TextBox](../windows.ui.xaml.controls/textbox.md), the touch keyboard might slide into view when the user touches the input control. If the Popup's parent container is already in the visual tree, the Popup automatically repositions itself when the touch keyboard is in view. Otherwise, the Popup is not repositioned and the touch keyboard can cover it. This can happen if you create the Popup in code and set [IsOpen](popup_isopen.md) to true without adding the Popup as a child of an element in the visual tree.

The Popup doesn't fire [RoutedEvents](../windows.ui.xaml/routedevent.md), for example KeyDown and PointerPressed. You can wire an event handler for these [RoutedEvents](../windows.ui.xaml/routedevent.md) on the child of the Popup.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1607 | 14393 | LightDismissOverlayMode |
| 1903 | 18362 | IsConstrainedToRootBounds |
| 1903 | 18362 | ShouldConstrainToRootBounds |

## -examples

This example shows a simple Popup with content defined inline.

```xaml
<Grid x:Name="Output" HorizontalAlignment="Left" VerticalAlignment="Top" Grid.Row="1">
    <StackPanel>
        <Button Content="Show Popup (using Offset)" Click="ShowPopupOffsetClicked"/>
    </StackPanel>
    <Popup VerticalOffset="10" HorizontalOffset="200" x:Name="StandardPopup">
        <Border BorderBrush="{StaticResource ApplicationForegroundThemeBrush}" 
                Background="{StaticResource ApplicationPageBackgroundThemeBrush}"
                BorderThickness="2" Width="200" Height="200">
            <StackPanel HorizontalAlignment="Center" VerticalAlignment="Center">
                <TextBlock Text="Simple Popup" FontSize="24.667" HorizontalAlignment="Center"/>
                <Button Content="Close" Click="ClosePopupClicked" HorizontalAlignment="Center"/>
            </StackPanel>
        </Border>
    </Popup>
</Grid>
```

```csharp
// Handles the Click event on the Button inside the Popup control and 
// closes the Popup. 
private void ClosePopupClicked(object sender, RoutedEventArgs e)
{
    // if the Popup is open, then close it 
    if (StandardPopup.IsOpen) { StandardPopup.IsOpen = false; }
}

// Handles the Click event on the Button on the page and opens the Popup. 
private void ShowPopupOffsetClicked(object sender, RoutedEventArgs e)
{
    // open the Popup if it isn't open already 
    if (!StandardPopup.IsOpen) { StandardPopup.IsOpen = true; }
} 
```

This example shows a Popup that has a [UserControl](../windows.ui.xaml.controls/usercontrol.md) set as its [Child](popup_child.md) element. The [UserControl](../windows.ui.xaml.controls/usercontrol.md) defines the content of the Popup.

```xaml
<Popup x:Name="ParentedPopup" HorizontalOffset="200" VerticalOffset="200">
    <local:PopupInputContent/>
</Popup>
```

```xaml
<UserControl
    x:Class="XAMLPopup.PopupInputContent"
    xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
    xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
    xmlns:local="using:PopupExample"
    xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
    xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
    mc:Ignorable="d"
    d:DesignHeight="300"
    d:DesignWidth="400">
    <Grid>
        <StackPanel>
            <TextBlock Text="Type some input" FontSize="24.667"/>
            <TextBox Width="300" Height="55"/>
            <Button Content="Save" Click="SimulateSaveClicked"/>
        </StackPanel>
    </Grid>
</UserControl>
```

```csharp
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace XAMLPopup
{
    public sealed partial class PopupInputContent : UserControl
    {
        public PopupInputContent()
        {
            this.InitializeComponent();
        }

        // Handles the Click event of the 'Save' button simulating a save and close 
        private void SimulateSaveClicked(object sender, RoutedEventArgs e)
        {
            // in this example we assume the parent of the UserControl is a Popup 
            Popup p = this.Parent as Popup;

            // close the Popup
            if (p != null) { p.IsOpen = false; }  
        } 
    }
}
```

## -see-also

[FrameworkElement](../windows.ui.xaml/frameworkelement.md), [Notifications sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/Notifications)
