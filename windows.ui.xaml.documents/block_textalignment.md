---
-api-id: P:Windows.UI.Xaml.Documents.Block.TextAlignment
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.TextAlignment TextAlignment { get;  set; }
-->

# Windows.UI.Xaml.Documents.Block.TextAlignment

## -description
Gets or sets the horizontal alignment of the text content.



## -xaml-syntax
```xaml
<Paragraph TextAlignment="textAlignmentMemberName"/>
```


## -xaml-values
<dl><dt>textAlignmentMemberName</dt><dd>textAlignmentMemberNameA named constant of the TextAlignment enumeration, such as Left.</dd>
</dl>
## -property-value
The horizontal alignment of the text content. The default is **Left**.

## -remarks
[Block](block.md) is a base class for [Paragraph](paragraph.md). [Paragraph](paragraph.md) is the only element that you can set a TextAlignment value on in Windows Runtime XAML, unless you create a custom class based on [Block](block.md).

## -examples

## -see-also
[Run.FlowDirection](run_flowdirection.md), [RichEditBox.TextAlignment](../windows.ui.xaml.controls/richeditbox_textalignment.md)
