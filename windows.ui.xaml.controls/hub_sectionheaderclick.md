---
-api-id: E:Windows.UI.Xaml.Controls.Hub.SectionHeaderClick
-api-type: winrt event
---

<!-- Event syntax
public event Windows.UI.Xaml.Controls.HubSectionHeaderClickEventHandler SectionHeaderClick
-->

# Windows.UI.Xaml.Controls.Hub.SectionHeaderClick

## -description
Occurs when a section header is clicked and the section's [IsHeaderInteractive](hubsection_isheaderinteractive.md) property is **true**.



## -xaml-syntax
```xaml
<Hub SectionHeaderClick="eventhandler" />
```


## -remarks
You can make a section header interactive by setting the [IsHeaderInteractive](hubsection_isheaderinteractive.md) property to **true**. Typically, the user can tap an interactive header to navigate to the corresponding app section page.

You get the section that was clicked from the [SectionHeaderClickEventArgs.Section](hubsectionheaderclickeventargs_section.md) property of the event data.

When its [IsHeaderInteractive](hubsection_isheaderinteractive.md) property is **true**, the default header includes a chevron glyph, and "Hover" and "Pressed" visual states. If you use a custom [HeaderTemplate](hubsection_headertemplate.md), you should provide similar visual cues to indicate that the header is interactive.

## -examples

## -see-also
