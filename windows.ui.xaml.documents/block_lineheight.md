---
-api-id: P:Windows.UI.Xaml.Documents.Block.LineHeight
-api-type: winrt property
---

<!-- Property syntax
public double LineHeight { get;  set; }
-->

# Windows.UI.Xaml.Documents.Block.LineHeight

## -description
Gets or sets the height of each line of content.



## -xaml-syntax
```xaml
<Paragraph LineHeight="double"/>
```


## -property-value
The pixel height of each line as modified by [LineStackingStrategy](block_linestackingstrategy.md). A value of 0 indicates that the line height is determined automatically from the current font characteristics. The default is 0.

## -remarks
[Block](block.md) is a base class for [Paragraph](paragraph.md). [Paragraph](paragraph.md) is the only element that you can set a LineHeight value on in Windows Runtime XAML, unless you create a custom class based on [Block](block.md).

## -examples

## -see-also
[Paragraph](paragraph.md), [LineStackingStrategy](block_linestackingstrategy.md)
