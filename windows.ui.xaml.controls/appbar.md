---
-api-id: T:Windows.UI.Xaml.Controls.AppBar
-api-type: winrt class
---

<!-- Class syntax.
public class AppBar : Windows.UI.Xaml.Controls.ContentControl, Windows.UI.Xaml.Controls.IAppBar, Windows.UI.Xaml.Controls.IAppBar2, Windows.UI.Xaml.Controls.IAppBar3, Windows.UI.Xaml.Controls.IAppBar4, Windows.UI.Xaml.Controls.IAppBarOverrides, Windows.UI.Xaml.Controls.IAppBarOverrides3
-->

# Windows.UI.Xaml.Controls.AppBar

## -description
Represents the container control that holds app UI components for commanding and experiences.

> [!IMPORTANT]
> You should use the [AppBar](appbar.md) only when you are upgrading a Universal Windows 8 app that uses the [AppBar](appbar.md), and need to minimize changes. For new apps in Windows 10, we recommend using the [CommandBar](commandbar.md) control instead.

## -xaml-syntax
```xaml
<AppBar .../>
-or-
<AppBar>
  content
</AppBar>
```


## -remarks
> [!IMPORTANT]
> You should use the [AppBar](appbar.md) only when you are upgrading a Universal Windows 8 app that uses the [AppBar](appbar.md), and need to minimize changes. For new apps in Windows 10, we recommend using the [CommandBar](commandbar.md) control instead.

An app bar is a UI element that's typically used to present commands and tools to the user, but can also be used for navigation. An app bar can appear at the top of the page, at the bottom of the page, or both. By default, its shown in a minimal state. Its content is shown or hidden when the user presses the ellipsis [•••], or performs a right-click that is not otherwise handled by the app.

Here's an app bar in it's minimal state.

<img alt="A closed app bar control" src="images/AppBar_Closed_10.png" />

Here's the app bar when it's open.

<img alt="An open app bar control" src="images/AppBar_Open_10.png" />

You can open and close the app bar programmatically by setting the [IsOpen](appbar_isopen.md) property. You can use the [Opening](appbar_opening.md), [Opened](appbar_opened.md), [Closing](appbar_closing.md), and [Closed](appbar_closed.md) events to respond to the app bar being opened or closed.

By default, the app bar is dismissed (closed) when the user interacts with the app anywhere outside of the app bar. Closing the app bar this way is called *light dismiss*. You can control how the app bar is dismissed by setting the [IsSticky](appbar_issticky.md) property. When the app bar is *sticky*, it's not closed by a *light dismiss* gesture. The app bar remains visible until the user right clicks or presses the ellipsis [•••].

To add an app bar in Extensible Application Markup Language (XAML), you assign an [AppBar](appbar.md) control to a [Page](page.md) 's [ TopAppBar](page_topappbar.md) or [BottomAppBar](page_bottomappbar.md) property. A single app bar can be shared across multiple pages. You can add and remove commands programmatically based on the page context.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls). The default style, template, and resources that define the look of the control are included in the generic.xaml file. For design purposes, generic.xaml is available in the \(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\&lt;SDK version&gt;\Generic folder from a Windows Software Development Kit (SDK) installation. Styles and resources from different versions of the SDK might have different values.

Starting in Windows 10, version 1607 (Windows Software Development Kit (SDK) version 10.0.14393.0), generic.xaml includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. In apps that target this software development kit (SDK) or later, modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) section of the [Styling controls](https://msdn.microsoft.com/windows/uwp/controls-and-patterns/styling-controls) article.

This table shows the resources used by the [AppBar](appbar.md) control.

<table>
   <tr><th>Resource key</th><th>Description</th></tr>
   <tr><td>AppBarBackground</td><td>Background color at rest</td></tr>
   <tr><td>AppBarForeground</td><td>Text color at rest</td></tr>
   <tr><td>AppBarHighContrastBorder</td><td>Border color for high-contrast</td></tr>
   <tr><td>AppBarEllipsisButtonBackground</td><td>Background color of ellipsis at rest</td></tr>
   <tr><td>AppBarEllipsisButtonBackgroundPointerOver</td><td>Background color of ellipsis on hover</td></tr>
   <tr><td>AppBarEllipsisButtonBackgroundPressed</td><td>Background color of ellipsis when pressed</td></tr>
   <tr><td>AppBarEllipsisButtonBackgroundDisabled</td><td>Background color of ellipsis when disabled</td></tr>
   <tr><td>AppBarEllipsisButtonForeground</td><td>Foreground color of ellipsis at rest</td></tr>
   <tr><td>AppBarEllipsisButtonForegroundPointerOver</td><td>Foreground color of ellipsis on hover</td></tr>
   <tr><td>AppBarEllipsisButtonForegroundPressed</td><td>Foreground color of ellipsis when pressed</td></tr>
   <tr><td>AppBarEllipsisButtonForegroundDisabled</td><td>Foreground color of ellipsis when disabled</td></tr>
   <tr><td>AppBarEllipsisButtonBorderBrush</td><td>Border color of ellipsis at rest</td></tr>
   <tr><td>AppBarEllipsisButtonBorderBrushPointerOver</td><td>Border color of ellipsis on hover</td></tr>
   <tr><td>AppBarEllipsisButtonBorderBrushPressed</td><td>Border color of ellipsis when pressed</td></tr>
   <tr><td>AppBarEllipsisButtonBorderBrushDisabled</td><td>Border color of ellipsis when disabled</td></tr>
</table>

## -examples
This example shows a top app bar with a group of navigation buttons and a search box.

```xaml
<Page.TopAppBar>
    <AppBar>
        <Grid>
            <Grid.ColumnDefinitions>
                <ColumnDefinition/>
                <ColumnDefinition/>
            </Grid.ColumnDefinitions>
            <StackPanel Orientation="Horizontal">
                <Button Content="Home" Width="140" Height="80" Click="AppBarButton_Click"/>
                <Button Content="Page 1" Width="140" Height="80" Click="AppBarButton_Click"/>
                <Button Content="Page 2" Width="140" Height="80" Click="AppBarButton_Click"/>
            </StackPanel>
            <AutoSuggestBox Grid.Column="1" Width="300" Height="50" HorizontalAlignment="Right"/>
        </Grid>
    </AppBar>
</Page.TopAppBar>
```


<!--<auto_snippet sample_id="BasicControlSnippets" snippet_id="BasicAppBarXAML"/>-->

## -see-also
[Control](control.md), [AppBar styles and templates](http://msdn.microsoft.com/library/2e029026-a6c0-4833-a274-cc033802c1b5), [Page.BottomAppBar](page_bottomappbar.md), [Page.TopAppBar](page_topappbar.md), [AppBarButton](appbarbutton.md), [AppBarSeparator](appbarseparator.md), [AppBarToggleButton](appbartogglebutton.md), [CommandBar](commandbar.md), [Controls list](http://msdn.microsoft.com/library/11172840-a63d-4f48-9db4-7baca06308ee), [Controls by function](http://msdn.microsoft.com/library/8db4347b-91d6-4659-91f2-80ecf7bbb596)