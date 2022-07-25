---
-api-id: P:Windows.UI.Xaml.Documents.Block.LineStackingStrategy
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.LineStackingStrategy LineStackingStrategy { get;  set; }
-->

# Windows.UI.Xaml.Documents.Block.LineStackingStrategy

## -description
Gets or sets a value that indicates how a line box is determined for each line of text in the [Block](block.md).



## -xaml-syntax
```xaml
<Paragraph LineStackingStrategy="BlockLineHeight"/>
-or-
<Paragraph LineStackingStrategy="MaxHeight"/>
```


## -property-value
A value that indicates how a line box is determined for each line of text in the [Block](block.md). The default is **MaxHeight**.

## -remarks
[Block](block.md) is a base class for [Paragraph](paragraph.md). [Paragraph](paragraph.md) is the only element that you can set a LineStackingStrategy value on in Windows Runtime XAML, unless you create a custom class based on [Block](block.md).

**BlockLineHeight** and **MaxHeight** are the only two constant names that exist in the [LineStackingStrategy](../windows.ui.xaml/linestackingstrategy.md) enumeration, so the XAML syntax shows those two choices.


## -examples

## -see-also
[Paragraph](paragraph.md), [LineStackingStrategy](../windows.ui.xaml/linestackingstrategy.md)
