---
-api-id: P:Windows.UI.Xaml.Controls.HubSection.IsHeaderInteractive
-api-type: winrt property
---

<!-- Property syntax
public bool IsHeaderInteractive { get;  set; }
-->

# Windows.UI.Xaml.Controls.HubSection.IsHeaderInteractive

## -description
Gets or sets a value that indicates whether the section header raises a [SectionHeaderClick](hub_sectionheaderclick.md) event on its containing [Hub](hub.md).



## -xaml-syntax
```xaml
<HubSection IsHeaderInteractive="bool" />
```


## -property-value
**true** if the section header raises a [SectionHeaderClick](hub_sectionheaderclick.md) event; otherwise, **false**. The default is **false**.

## -remarks
You can make a section header interactive by setting the IsHeaderInteractive property to **true**. Typically, the user can tap an interactive header to navigate to the corresponding app section page.

You can respond to a tapped header by handling the [Hub.SectionHeaderClick](hub_sectionheaderclick.md) event. You get the section that was clicked from the [SectionHeaderClickEventArgs.Section](hubsectionheaderclickeventargs_section.md) property of the event data.

When its IsHeaderInteractive property is **true**, the default header includes the text, **See more**. When a user taps the **See more** text, the [SectionHeaderClick](hub_sectionheaderclick.md) event is raised. The text is rendered as a hyperlink, which uses the user selected system accent color by default.

### Notes for previous versions

> Windows 8.x
> When its IsHeaderInteractive property is **true**, the default header includes a chevron glyph, and "Hover" and "Pressed" visual states. If you use a custom [HeaderTemplate](hubsection_headertemplate.md), you should provide similar visual cues to indicate that the header is interactive.

## -examples

## -see-also
[Header](hub_header.md), [HeaderTemplate](hubsection_headertemplate.md), [Hub.SectionHeaderClick](hub_sectionheaderclick.md)
