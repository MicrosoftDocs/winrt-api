---
-api-id: T:Windows.UI.Xaml.Controls.HubSection
-api-type: winrt class
---

<!-- Class syntax.
public class HubSection : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.IHubSection
-->

# Windows.UI.Xaml.Controls.HubSection

## -description
Represents a single group of content in a [Hub](hub.md).



## -xaml-syntax
```xaml
<HubSection .../>
-or-
<HubSection ...>
  oneOrMoreComponents
</HubSection>
```


## -remarks
You put the content of your [Hub](hub.md) in various HubSection elements. Like the [Hub](hub.md), each HubSection has a [Header](hubsection_header.md) and [HeaderTemplate](hubsection_headertemplate.md) property that you can use to set an optional header for the section. You can also make the section header interactive. Typically, the user can tap an interactive header to navigate to the corresponding app section page. When its [IsHeaderInteractive](hubsection_isheaderinteractive.md) property is **true**, the default header includes a chevron glyph, and "Hover" and "Pressed" visual states, and it raises a [SectionHeaderClick](hub_sectionheaderclick.md) event.

You don't add content directly to a hub section; instead, you define the content of your HubSection in a [DataTemplate](../windows.ui.xaml/datatemplate.md). Content can be defined inline, or bound to a data source. Any valid XAML can be used in a hub section.

### Control style and template

You can modify the default [Style](../windows.ui.xaml/style.md) and [ControlTemplate](controltemplate.md) to give the control a unique appearance. For information about modifying a control's style and template, see [XAML styles](/windows/apps/design/style/xaml-styles). The default style, template, and resources that define the look of the control are included in the `generic.xaml` file. For design purposes, generic.xaml is available in the `\(Program Files)\Windows Kits\10\DesignTime\CommonConfiguration\Neutral\UAP\<SDK version>\Generic` folder from a Windows SDK installation. Styles and resources from different versions of the SDK might have different values.

XAML also includes resources that you can use to modify the colors of a control in different visual states without modifying the control template. Modifying these resources is preferred to setting properties such as [Background](control_background.md) and [Foreground](control_foreground.md). For more info, see the [Light-weight styling](/windows/apps/design/style/xaml-styles#lightweight-styling) section of the [XAML styles](/windows/apps/design/style/xaml-styles) article. Light-weight styling resources are available starting in Windows 10, version 1607 (SDK 14393).

## -examples
This example shows the basic XAML used to create a [Hub](hub.md) with 3 HubSection s.

```xaml
<Hub Header="News" SectionHeaderClick="SectionHeader_Click">
    <HubSection MinWidth="600" Header="Latest">
        <DataTemplate>
            <Grid>   
                <TextBlock Text="The most recent news will be here." 
                           Style="{ThemeResource BodyTextBlockStyle}"/>
            </Grid>
        </DataTemplate>
    </HubSection>

    <HubSection Header="Tech" IsHeaderInteractive="True"  
                Background="#222222" MinWidth="250">
        <DataTemplate>
            <StackPanel>
                <TextBlock Text="Tech news goes here."
                           Style="{ThemeResource BodyTextBlockStyle}"/>
                <TextBlock Text="Click the header to go to the Tech page."
                           Style="{ThemeResource BodyTextBlockStyle}"/>
            </StackPanel>
        </DataTemplate>
    </HubSection>

    <HubSection Header="Sports" IsHeaderInteractive="True" 
                Background="#444444" MinWidth="250">
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



## -see-also
[Control](control.md), [Hub](hub.md), [HubSectionCollection](hubsectioncollection.md), [HubSectionHeaderClickEventArgs](hubsectionheaderclickeventargs.md), [ISemanticZoomInformation](isemanticzoominformation.md), [XAML Hub control sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20Hub%20control%20sample)
