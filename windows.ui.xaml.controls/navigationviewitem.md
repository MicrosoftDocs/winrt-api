---
-api-id: T:Windows.UI.Xaml.Controls.NavigationViewItem
-api-type: winrt class
---

<!-- Class syntax.
public class NavigationViewItem : ListViewItem, ListViewItem
-->

# Windows.UI.Xaml.Controls.NavigationViewItem

## -description

Represents the container for an item in a [NavigationView](navigationview.md) control.

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.NavigationViewItem](/windows/winui/api/microsoft.ui.xaml.controls.navigationviewitem) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -xaml-syntax

```xaml
<NavigationViewItem .../>
```

## -remarks
Note that prior to Windows 10, version 1809 (10.0; Build 17763) you could only place **NavigationViewItems** in **NavigationView.MenuItems**.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1809 | 17763 | SelectsOnInvoked |

## -see-also

## -examples
```xaml
<NavigationView x:Name="NavView"
    ItemInvoked="NavView_ItemInvoked"
    Loaded="NavView_Loaded">

    <NavigationView.MenuItems>
        <NavigationViewItem x:Uid="HomeNavItem" Content="Home" Tag="home">
            <NavigationViewItem.Icon>
                <FontIcon Glyph="&#xE10F;"/>
            </NavigationViewItem.Icon>
        </NavigationViewItem>
        <NavigationViewItemSeparator/>
        <NavigationViewItemHeader Content="Main pages"/>
        <NavigationViewItem x:Uid="AppsNavItem" Icon="AllApps" Content="Apps" Tag="apps"/>
        <NavigationViewItem x:Uid="GamesNavItem" Icon="Video" Content="Games" Tag="games"/>
        <NavigationViewItem x:Uid="MusicNavItem" Icon="Audio" Content="Music" Tag="music"/>
    </NavigationView.MenuItems>

    <Frame x:Name="ContentFrame" Margin="24">
        <Frame.ContentTransitions>
            <TransitionCollection>
                <NavigationThemeTransition/>
            </TransitionCollection>
        </Frame.ContentTransitions>
    </Frame>
</NavigationView>
```
```csharp
private void NavView_Loaded(object sender, RoutedEventArgs e)
{
    // you can also add items in code behind
    NavView.MenuItems.Add(new NavigationViewItemSeparator());
    NavView.MenuItems.Add(new NavigationViewItem()
    { Content = "My content", Icon = new SymbolIcon(Symbol.Folder), Tag = "content" });

    // set the initial SelectedItem 
    foreach (NavigationViewItemBase item in NavView.MenuItems)
    {
        if (item is NavigationViewItem && item.Tag.ToString() == "home")
        {
            NavView.SelectedItem = item;
            break;
        }
    }
}

private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
{  
    if (args.IsSettingsInvoked)
    {
        ContentFrame.Navigate(typeof(SettingsPage));
    }
    else
    {
        // find NavigationViewItem with Content that equals InvokedItem
        var item = sender.MenuItems.OfType<NavigationViewItem>().First(x => (string)x.Content == (string)args.InvokedItem);
        NavView_Navigate(item as NavigationViewItem);
    }
}

private void NavView_Navigate(NavigationViewItem item)
{
    switch (item.Tag)
    {
        case "home":
            ContentFrame.Navigate(typeof(HomePage));
            break;

        case "apps":
            ContentFrame.Navigate(typeof(AppsPage));
            break;

        case "games":
            ContentFrame.Navigate(typeof(GamesPage));
            break;

        case "music":
            ContentFrame.Navigate(typeof(MusicPage));
            break;

        case "content":
            ContentFrame.Navigate(typeof(MyContentPage));
            break;
    }           
}
```
