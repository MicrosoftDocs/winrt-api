---
-api-id: T:Windows.UI.Xaml.Controls.SplitView
-api-type: winrt class
---

<!-- Class syntax.
public class SplitView : Windows.UI.Xaml.Controls.Control, Windows.UI.Xaml.Controls.ISplitView, Windows.UI.Xaml.Controls.ISplitView2
-->

# Windows.UI.Xaml.Controls.SplitView

## -description
Represents a container with two views; one view for the main content and another view that is typically used for navigation commands.

## -xaml-syntax
```xaml
<SplitView>
  <SplitView.Content>
    singleObject
  </SplitView.Content>
  <SplitView.Pane>
    singleObject
  </SplitView.Pane>
</SplitView>

```


## -remarks
[SplitView](splitview.md)The [SplitView](splitview.md) control presents two areas of content: a [Pane](splitview_pane.md) and the main [Content](splitview_content.md). You typically use a [SplitView](splitview.md) to create a top-level navigation experience that adapts to different screen widths following the [nav pane pattern](http://msdn.microsoft.com/library/8fb52f5e-8e72-4604-9222-0b0ec6a97541), but it's not strictly limited to use for navigation.


<!--{annotation author="jimwalk" time="5/21/2015 1:43:08 PM"}We might want a How to or sample that shows how to do this. (Make this the root, and put your Frame in the Content panel.)-->
The XAML for this [SplitView](splitview.md) is shown in the Examples section.

<img alt="Split view control" src="images/controls/SplitViewBasic.png" />
The [Content](splitview_content.md) area is always present and can contain a single child element, which is typically a [Panel](panel.md) derived container that contains additional child elements. Although the [Content](splitview_content.md) is always present, it can be completely covered by the [Pane](splitview_pane.md).

There are several properties you can set to control the appearance and behavior of the [Pane](splitview_pane.md). Set the [IsPaneOpen](splitview_ispaneopen.md) property to open or close the [Pane](splitview_pane.md). The [SplitView](splitview.md) does not include a built-in affordance for users to toggle the state of the [Pane](splitview_pane.md), like a menu (or “hamburger”) button. You must provide this affordance and the code to toggle the [IsPaneOpen](splitview_ispaneopen.md) property.

To specify the length of the open pane, set the [OpenPaneLength](splitview_openpanelength.md) property. You can set the [PanePlacement](splitview_paneplacement.md) property to have the [Pane](splitview_pane.md) appear on either the left or right side of the [Content](splitview_content.md).

Although the appearance of the control is largely based on the elements assigned to the [Pane](splitview_pane.md) and [Content](splitview_content.md), you can change the default background color of the [Pane](splitview_pane.md) by setting the [PaneBackground](splitview_panebackground.md).

Set the [DisplayMode](splitview_displaymode.md) property to configure the interaction of the [Pane](splitview_pane.md) with the [Content](splitview_content.md). By default, the [Pane](splitview_pane.md) overlays the [Content](splitview_content.md) and disappears completely when closed. You can use one of the "inline" modes to show the [Pane](splitview_pane.md) side-by-side with the [Content](splitview_content.md). You can use the "compact" modes to make a narrow section of the [Pane](splitview_pane.md) remain visible even when the [Pane](splitview_pane.md) is closed. See the [SplitViewDisplayMode](splitviewdisplaymode.md) enumeration for more info about the supported modes.
<!--<termdeflist><label><xref targtype="enum_winrt" rid="w_ui_xaml_ctrl.splitviewdisplaymode">DisplayMode</xref></label><termdef><name>Overlay</name><desc>This is the default mode.<list><item>When the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_pane">Pane</xref> is closed it does not appear onscreen.</item><item>When the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_pane">Pane</xref> is open, it appears layered over the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_content">Content</xref>.</item><item>The <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_pane">Pane</xref> responds to a light-dismiss, which means it closes automatically when the user taps outside of it.</item></list></desc></termdef><termdef><name>CompactOverlay</name><desc><list><item>When the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_pane">Pane</xref> is closed, a portion  of it remains visible.  The amount that remains visible is determined by the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_compactpanelength">CompactPaneLength</xref> property.</item><item>When the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_pane">Pane</xref> is open, the remaining part of the  <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_pane">Pane</xref> appears layered over the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_content">Content</xref>.</item><item>The <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_pane">Pane</xref> responds to a light-dismiss.</item></list></desc></termdef><termdef><name>Inline</name><desc><list><item>The <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_pane">Pane</xref> does not overlay the content area.  The <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_pane">Pane</xref> and <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_content">Content</xref> areas divide the available width of the control.</item><item>When the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_pane">Pane</xref> is closed, the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_content">Content</xref> occupies the full length of the control.</item><item>When the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_pane">Pane</xref> is open, it occupies the portion of the control specified by the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_openpanelength">OpenPaneLength</xref> property, and  the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_content">Content</xref> occupies the remaining space.</item><item>The <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_pane">Pane</xref> does not respond to a  light-dismiss, which means it remains open when a user taps outside of it.</item></list></desc></termdef><termdef><name>CompactInline</name><desc><list><item>The <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_pane">Pane</xref> does not overlay the content area.  The <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_pane">Pane</xref> and <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_content">Content</xref> areas divide the available width of the control.</item><item>When the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_pane">Pane</xref> is closed, a portion  of it remains visible.  The amount that remains visible is determined by the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_compactpanelength">CompactPaneLength</xref> property. The <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_content">Content</xref> occupies the remaining space.</item><item>When the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_pane">Pane</xref> is open, it occupies the portion of the control specified by the <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_openpanelength">OpenPaneLength</xref> property. The <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_content">Content</xref> occupies the remaining space.</item><item>The <xref targtype="property_winrt" rid="w_ui_xaml_ctrl.splitview_pane">Pane</xref> does not respond to a  light-dismiss.</item></list></desc></termdef></termdeflist>-->

For design guidance, see [Guidelines for the split view control](http://msdn.microsoft.com/library/e9e4537f-1160-4183-9a83-26602fcfdc9a).

For more info and examples on building a top-level navigation experience, see [Guidelines for navigation panes](http://msdn.microsoft.com/library/8fb52f5e-8e72-4604-9222-0b0ec6a97541) and the [XAML Navigation Menu sample](http://go.microsoft.com/fwlink/p/?LinkId=619902&amp;amp;clcid=0x409).


<!--{annotation author="jimwalk" time="5/21/2015 4:00:11 PM"}Putting this sample link here for doc review. Should update to FW link before release.-->

## -examples
Here's a [SplitView](splitview.md) control with an open [Pane](splitview_pane.md) appearing inline next to the [Content](splitview_content.md).

```xaml
<SplitView IsPaneOpen="True"
           DisplayMode="Inline"
           OpenPaneLength="296">
    <SplitView.Pane>
        <TextBlock Text="Pane"
                   FontSize="24"
                   VerticalAlignment="Center"
                   HorizontalAlignment="Center"/>
    </SplitView.Pane>

    <Grid>
        <TextBlock Text="Content"
                   FontSize="24"
                   VerticalAlignment="Center"
                   HorizontalAlignment="Center"/>
    </Grid>
</SplitView>
```



## -see-also
[Control](control.md), [Guidelines for the split view control](http://msdn.microsoft.com/library/e9e4537f-1160-4183-9a83-26602fcfdc9a), [Guidelines for navigation panes](http://msdn.microsoft.com/library/8fb52f5e-8e72-4604-9222-0b0ec6a97541), [Navigation menu (XAML) sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=619902), [Tailored multiple views sample (Windows 10)](http://go.microsoft.com/fwlink/p/?LinkId=620636)