---
-api-id: P:Windows.UI.Xaml.Controls.RichTextBlock.OverflowContentTarget
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.RichTextBlockOverflow OverflowContentTarget { get;  set; }
-->

# Windows.UI.Xaml.Controls.RichTextBlock.OverflowContentTarget

## -description
Gets or sets a reference to a [RichTextBlockOverflow](richtextblockoverflow.md) that is the linked target for any text overflow from this [RichTextBlock](richtextblock.md).



## -xaml-syntax
```xaml
RichTextBlock OverflowContentTarget="{Binding ElementName=nameOfTarget}" />
```


## -xaml-values
<dl><dt>nameOfTarget</dt><dd>nameOfTargetThe x:Name or reference name of an existing RichTextBlockOverflow element in the same . Note that this usage assumes that the source and target are in the same data context.</dd>
</dl>
## -property-value
The target for overflow.

## -remarks

## -examples

## -see-also
[HasOverflowContent](richtextblock_hasoverflowcontent.md), [RichTextBlockOverflow](richtextblockoverflow.md)
