---
-api-id: P:Windows.UI.Xaml.FrameworkElement.FlowDirection
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.FlowDirection FlowDirection { get;  set; }
-->

# Windows.UI.Xaml.FrameworkElement.FlowDirection

## -description
Gets or sets the direction in which text and other UI elements flow within any parent element that controls their layout. This property can be set to either **LeftToRight** or **RightToLeft**. Setting FlowDirection to **RightToLeft** on any element sets the alignment to the right, the reading order to right-to-left and the layout of the control to flow from right to left.



## -xaml-syntax
```xaml
<frameworkElement FlowDirection="flowDirectionMemberName"/>

```


## -xaml-values
<dl><dt>flowDirectionMemberName</dt><dd>flowDirectionMemberNameA constant name from the FlowDirection enumeration, either LeftToRight or RightToLeft.</dd>
</dl>
## -property-value
The direction that text and other UI elements flow within their parent element, as a value of the enumeration. The default value is [LeftToRight](flowdirection.md).

## -remarks
FlowDirection is intended for support of right-to-left layout for apps. Basically, setting FlowDirection to **RightToLeft** should produce an appropriate right-to-left behavior and rendering of any XAML control that it is applied to. Specific XAML controls may have further handling within their templates or logic that responds to FlowDirection of **RightToLeft** that isn't noted in this topic, and this might be noted in the reference topics for those XAML controls.

An object inherits the FlowDirection value from its parent in the object tree. Any element can override the value it gets from its parent. If not specified, the default [FlowDirection](flowdirection.md) is **LeftToRight**.

If the FlowDirection value on an object is **RightToLeft**, certain values and behavior of the [FrameworkElement](frameworkelement.md) will change: 
+ Within the element, the coordinate frame of reference is flipped horizontally such that "(0, 0)" will be the top right corner. This affects the values returned by hit test API such as [FindElementsInHostCoordinates](../windows.ui.xaml.media/visualtreehelper_findelementsinhostcoordinates_1478853318.md).
+ If the [FrameworkElement](frameworkelement.md) is a [Path](../windows.ui.xaml.shapes/path.md) or other [Shape](../windows.ui.xaml.shapes/shape.md), its visual content is flipped horizontally.
+ For layout containers, the coordinate frame of reference changes. "(0, 0)" in a [Canvas](../windows.ui.xaml.controls/canvas.md) is the top right corner. The "0" column in a Grid for purposes of [Grid.Column](/uwp/api/windows.ui.xaml.controls.grid.column) is the rightmost column.
+ Within a control's template composition, the same layout changes apply. For example, if you set FlowDirection as **RightToLeft** for a [RadioButton](../windows.ui.xaml.controls/radiobutton.md), the clickable button graphic will appear to the right of the text label content, because the [Grid](../windows.ui.xaml.controls/grid.md) within the [RadioButton](../windows.ui.xaml.controls/radiobutton.md) template now treats "0" as the rightmost column, and the text label is right-aligned.
+ [Image](../windows.ui.xaml.controls/image.md) has a special behavior, see "FlowDirection for Image" section below.


Text in text containers such as [TextBlock](../windows.ui.xaml.controls/textblock.md) or [TextBox](../windows.ui.xaml.controls/textbox.md) does not flip horizontally if FlowDirection is **RightToLeft**, neither the whole string nor individual characters or glyphs are flipped. The order of [Inline](../windows.ui.xaml.documents/inline.md) elements in an [InlineCollection](../windows.ui.xaml.documents/inlinecollection.md) does not change either. This enables mixing content in an otherwise right-to-left app, such as including deliberate English language strings in an Arabic language UI. Any string that is intended to be a text source for a text container where the intended language is a right-to-left language should specify that string in the appropriate Unicode representation, which will be correctly presented in a text container. However, a value of FlowDirection as **RightToLeft** in a text container does change the default [TextAlignment](textalignment.md) value such that the right edge of the text is right-aligned with the text container bounds.

FlowDirection has no visible effect on text in a [Glyphs](../windows.ui.xaml.documents/glyphs.md) element but does change the element's hit testing and coordinate frame of reference.

### FlowDirection for Image and MediaElement

If you set FlowDirection as **RightToLeft** for an [Image](../windows.ui.xaml.controls/image.md), the visual content of an [Image](../windows.ui.xaml.controls/image.md) is flipped horizontally. However, an [Image](../windows.ui.xaml.controls/image.md) element does not inherit the FlowDirection value from any parent element. Typically you only want image-flipping behavior in images that are relevant to layout, but not necessarily to elements that have embedded text or other components that wouldn't make sense flipped for a right-to-left audience. To get image-flip behavior, you must set the FlowDirection element on the [Image](../windows.ui.xaml.controls/image.md) element specifically to **RightToLeft**, or set the FlowDirection property in code-behind. Consider identifying the [Image](../windows.ui.xaml.controls/image.md) element by [x:Uid directive](/windows/uwp/xaml-platform/x-uid-directive), and specifying FlowDirection values as a RESW resource, so that your localization experts can change this value later without changing the XAML or code.

[MediaElement](../windows.ui.xaml.controls/mediaelement.md) also does not inherit FlowDirection value from any parent element. If you do explicitly set FlowDirection as **RightToLeft** on [MediaElement](../windows.ui.xaml.controls/mediaelement.md), then the media view area is flipped horizontally, similar to how an [Image](../windows.ui.xaml.controls/image.md) flips. Doing this deliberately should be even more rare than [Image](../windows.ui.xaml.controls/image.md), because it's likely that any media source used in localized content already has any right-to-left issues corrected in the source media file.

### FlowDirection for WebView and WebViewBrush

[WebView](../windows.ui.xaml.controls/webview.md) and [WebViewBrush](../windows.ui.xaml.controls/webviewbrush.md) don't promote any right-to-left information to how the HTML is loaded. If there are any left-to-right considerations in the HTML content, consider setting [x:Uid directive](/windows/uwp/xaml-platform/x-uid-directive) on the [WebView](../windows.ui.xaml.controls/webview.md) element and specifying any [WebView.Source](../windows.ui.xaml.controls/webview_source.md)  Uniform Resource Identifier (URI) value as a string-form RESW resource. [WebView](../windows.ui.xaml.controls/webview.md) and [WebViewBrush](../windows.ui.xaml.controls/webviewbrush.md) also don't inherit FlowDirection from any parent elements. Setting FlowDirection on [WebView](../windows.ui.xaml.controls/webview.md) and [WebViewBrush](../windows.ui.xaml.controls/webviewbrush.md) doesn't cause exceptions, but any value you set is ignored by the runtime.

## -examples
This XAML example illustrates how a layout container such as [Grid](../windows.ui.xaml.controls/grid.md) interprets a value of **RightToLeft**. If you look at the UI that this XAML produces, the "Chartreuse" rectangle appears in the top right, not the top left as it would when FlowDirection is the default **LeftToRight**.

```xaml
            <Grid FlowDirection="RightToLeft">
                <Grid.ColumnDefinitions>
                    <ColumnDefinition/>
                    <ColumnDefinition/>
                </Grid.ColumnDefinitions>
                <Grid.RowDefinitions>
                    <RowDefinition/>
                    <RowDefinition/>
                </Grid.RowDefinitions>
                <Rectangle Fill="Chartreuse" Width="30" Height="30"/>
                <Rectangle Grid.Row="1" Fill="Purple" Width="30" Height="30"/>
                <Rectangle Grid.Column="1" Fill="Pink" Width="30" Height="30"/>
                <Rectangle Grid.Row="1" Grid.Column="1" Fill="Orange" Width="30" Height="30"/>
            </Grid>
```



## -see-also
[How to adjust layout and fonts for various languages, and support RTL layouts](/previous-versions/windows/apps/hh967760(v=win.10)), [Image](../windows.ui.xaml.controls/image.md)
