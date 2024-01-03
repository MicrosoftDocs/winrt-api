---
-api-id: T:Windows.UI.Xaml.Controls.Hub
-api-type: winrt class
---

<!-- Class syntax.
public class Hub : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IHub, Windows.UI.Xaml.Controls.ISemanticZoomInformation
-->

# Windows.UI.Xaml.Controls.Hub

## -description

Represents a control that displays groups of content in a panning view.



## -xaml-syntax
```xaml
<Hub .../>
-or-
<Hub ...>
  oneOrMoreComponents
</Hub>
```

## -remarks

**For Windows 10 and later: We recommend against using this control; use one of the other navigation controls instead. For a list, see the [Navigation basics](/windows/uwp/design/basics/navigation-basics) article.**

Use a Hub to show different collections of data, either from the same source or from different sources.

### Hub content

Add content to the Hub by adding [HubSection](hubsection.md) objects to the [Sections](hub_sections.md) collection. These sections use a [DataTemplate](../windows.ui.xaml/datatemplate.md) to define the content for the section, and a [Header](hubsection_header.md) property, which can be any content. If the [Header](hubsection_header.md) object is a complex data type as opposed to just a string, you can define the look of the header using the [HeaderTemplate](hubsection_headertemplate.md) property.

The Hub uses virtualization to load sections as the user pans. You can handle the [SectionsInViewChanged](hub_sectionsinviewchanged.md) event to respond to changes.

### Interactive section headers

You can set the [HubSectionHeader.IsHeaderInteractive](hubsection_isheaderinteractive.md) property is **true** to let a user navigate to the corresponding app section page. When its [IsHeaderInteractive](hubsection_isheaderinteractive.md) property is **true**, the default header includes the text, **See more**. When a user taps the **See more** text, the [SectionHeaderClick](hub_sectionheaderclick.md) event is raised. If you use a custom [HeaderTemplate](hubsection_headertemplate.md), you should provide similar visual cues to indicate that the header is interactive.



You can handle the [SectionHeaderClick](hub_sectionheaderclick.md) event to respond to a tapped header. You get the section that was clicked from the [SectionHeaderClickEventArgs.Section](hubsectionheaderclickeventargs_section.md) property of the event data.

### Hub and SemanticZoom

If you declare a Hub as the [ZoomedInView](semanticzoom_zoomedinview.md) of a [SemanticZoom](semanticzoom.md), the section headers change to [HyperlinkButton](hyperlinkbutton.md)s that invoke the [ZoomedOutView](semanticzoom_zoomedoutview.md) of the [SemanticZoom](semanticzoom.md) when they're clicked.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, generic.xaml is available in the `\(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic` folder from a Windows SDK installation. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393).

## -examples

This example shows the basic XAML used to create a Hub.

```xaml
<Hub Header="News" SectionHeaderClick="Hub_SectionHeaderClick">
    <HubSection MinWidth="600" Header="Latest">
        <DataTemplate>
            <Grid>
                <TextBlock Text="The most recent news will be here." 
                   Style="{ThemeResource BodyTextBlockStyle}"/>
            </Grid>
        </DataTemplate>
    </HubSection>

    <HubSection x:Name="Tech" Header="Tech" IsHeaderInteractive="True"  
        Background="#F4F4F4" MinWidth="250">
        <DataTemplate>
            <StackPanel>
                <TextBlock Text="Tech news goes here."
                   Style="{ThemeResource BodyTextBlockStyle}"/>
                <TextBlock Text="Click the header to go to the Tech page."
                   Style="{ThemeResource BodyTextBlockStyle}"/>
            </StackPanel>
        </DataTemplate>
    </HubSection>

    <HubSection x:Name="Sports" Header="Sports" IsHeaderInteractive="True" 
        Background="#F9F9F9" MinWidth="250">
        <DataTemplate>
            <StackPanel>
                <TextBlock Text="Sports news goes here."
                   Style="{ThemeResource BodyTextBlockStyle}"/>
                <TextBlock Text="Click the header to go to the Sports page." 
                   Style="{ThemeResource BodyTextBlockStyle}"/>
            </StackPanel>
        </DataTemplate>
    </HubSection>
</Hub>
```

```csharp
private void Hub_SectionHeaderClick(object sender, HubSectionHeaderClickEventArgs e)
{
    switch (e.Section.Name)
    {
        case "Sports":
            Frame.Navigate(typeof(SportsNewsPage));
            break;
        case "Tech":
            Frame.Navigate(typeof(TechNewsPage));
            break;
    }
}
```



## -see-also
[Navigation basics](/windows/uwp/design/basics/navigation-basics)
