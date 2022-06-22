---
-api-id: P:Windows.UI.Xaml.UIElement.ContextFlyout
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.Primitives.FlyoutBase ContextFlyout { get;  set; }
-->

# Windows.UI.Xaml.UIElement.ContextFlyout

## -description
Gets or sets the flyout associated with this element.



## -property-value
The flyout associated with this element, if any; otherwise, **null**. The default is **null**.

## -remarks

A context menu is attached to a single element and displays secondary commands. It's invoked by right clicking or an equivalent action, such as pressing and holding with your finger.

When you set the `ContextFlyout` property, the context menu is shown and hidden automatically, the [ContextRequested](uielement_contextrequested.md) event is marked as handled. You should only handle `ContextRequested` and `ContextCanceled` if you do not set `ContextFlyout`.

## -examples

This example shows how to attach a context menu with options Red and Green to a rectangle. The menu is shown when the user right-clicks or performs an equivalent action.

<img alt="A context menu showing the options red and green" src="images/context-menu-colors.png" />

```xaml
<Page
    ...>
    <Page.Resources>
        <MenuFlyout x:Key="colorMenuFlyout">
            <MenuFlyoutItem Text="Red" Tag="red" Click="MenuFlyoutItem_Click"/>
            <MenuFlyoutItem Text="Green" Tag="green" Click="MenuFlyoutItem_Click"/>
        </MenuFlyout>
    </Page.Resources>

    <Grid>
        <Rectangle Width="100" Height="100" Fill="Yellow"
                   ContextFlyout="{StaticResource colorMenuFlyout}">
        </Rectangle>
    </Grid>
</Page>
```


```csharp
private void MenuFlyoutItem_Click(object sender, RoutedEventArgs e)
{
    var colorMenuFlyout = Resources["colorMenuFlyout"] as MenuFlyout;
    var item = sender as MenuFlyoutItem;
    var target = colorMenuFlyout.Target;
    if (string.Equals(item.Tag.ToString(), "red"))
    {
        ((Rectangle)target).Fill = new SolidColorBrush(Windows.UI.Colors.Red);
    }
    else if (string.Equals(item.Tag.ToString(), "green"))
    {
        ((Rectangle)target).Fill = new SolidColorBrush(Windows.UI.Colors.Green);
    }
}
```

## -see-also
