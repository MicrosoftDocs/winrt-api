---
-api-id: P:Windows.UI.Xaml.Documents.Block.Margin
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Thickness Margin { get;  set; }
-->

# Windows.UI.Xaml.Documents.Block.Margin

## -description
Gets or sets the amount of space around a [Block](block.md) element.



## -xaml-syntax
```xaml
<Paragraph Margin="uniform"/>
- or -
<Paragraph Margin="left+right,top+bottom"/>
- or -
<Paragraph Margin="left,top,right,bottom"/>
 
```


## -xaml-values
<dl><dt>uniform
</dt><dd>uniform A value measured in pixels that specifies a uniform Thickness. The uniform value is applied to all four Thickness properties (Left, Top, Right, Bottom).</dd>
<dt>left+right
</dt><dd>left+right A value measured in pixels that specifies the Left and Right of a symmetrical Thickness.</dd>
<dt>top+bottom</dt><dd>top+bottomA value measured in pixels that specifies the Top and Bottom of a symmetrical Thickness.</dd>
<dt>left top right bottom
</dt><dd>left top right bottom Values measured in pixels that specify the four possible dimension properties of a Thickness (Left, Top, Right, Bottom). In the syntaxes shown previously, you can also use a space instead of a comma as the delimiter between values.</dd>
</dl>
## -property-value
The amount of space around a [Block](block.md) element.

## -remarks
> **Code migration note**
> Microsoft Silverlight doesn't support a **Margin** property on **Block** or **Paragraph**. Windows Presentation Foundation (WPF) has a **Margin** property on **Block** and **Paragraph**, but also has a **Padding** property there that the Windows Runtime doesn't support. If you need per-paragraph padding support, you might need to put each [Paragraph](paragraph.md) in a different [Border](../windows.ui.xaml.controls/border.md) container and use a [Panel](../windows.ui.xaml.controls/panel.md) for layout control, and set [Border.Padding](../windows.ui.xaml.controls/border_padding.md) on each [Border](../windows.ui.xaml.controls/border.md). Or, use [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md).

## -examples

## -see-also
[Thickness](../windows.ui.xaml/thickness.md), [Paragraph](paragraph.md), [FrameworkElement.Margin](../windows.ui.xaml/frameworkelement_margin.md), [Control.Padding](../windows.ui.xaml.controls/control_padding.md)
