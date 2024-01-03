---
-api-id: P:Windows.UI.Xaml.Controls.HubSection.Header
-api-type: winrt property
---

<!-- Property syntax
public object Header { get;  set; }
-->

# Windows.UI.Xaml.Controls.HubSection.Header

## -description
Gets or sets the content for the hub section header.



## -xaml-syntax
```xaml
<HubSection Header="headerString"/>
- or -
<HubSection>
  <HubSection.Header>
    headerObject
  </HubSection.Header>
</HubSection>

```


## -xaml-values
<dl><dt>headerString</dt><dd>headerStringA text string that serves as header content.</dd>
<dt>headerObject</dt><dd>headerObjectAn single object element that serves as header content. Use discretion when using objects as header content; not all objects are suitable for use within the limited presentation surface that appears for headers.</dd>
</dl>
## -property-value
The content of the section header. The default is **null**.

## -remarks
Add a header to let users know the context of your [Hub](hub.md) section. It's important to remember that although you can use arbitrary content in the header, the height of the header affects the amount of vertical space available for your hub section content. The section header scrolls with the hub section.

You can use a data template for the header by setting the [HeaderTemplate](hubsection_headertemplate.md) property.

You can make a section header interactive by setting the [IsHeaderInteractive](hubsection_isheaderinteractive.md) property to **true**. Typically, the user can tap an interactive header to navigate to the corresponding app section page.

You can respond to a tapped header by handling the [Hub.SectionHeaderClick](hub_sectionheaderclick.md) event. You get the section that was clicked from the [SectionHeaderClickEventArgs.Section](hubsectionheaderclickeventargs_section.md) property of the event data.

When its [IsHeaderInteractive](hubsection_isheaderinteractive.md) property is **true**, the default header includes the text, **See more**. When a user taps the **See more** text, the [SectionHeaderClick](hub_sectionheaderclick.md) event is raised. The text is rendered as a hyperlink, which uses the user selected system accent color by default.

### Notes for previous versions

>Windows 8.x
> When its [IsHeaderInteractive](hubsection_isheaderinteractive.md) property is **true**, the default header includes a chevron glyph, and "Hover" and "Pressed" visual states. If you use a custom [HeaderTemplate](hubsection_headertemplate.md), you should provide similar visual cues to indicate that the header is interactive.

## -examples

## -see-also
[HeaderTemplate](hubsection_headertemplate.md), [IsHeaderInteractive](hubsection_isheaderinteractive.md)
