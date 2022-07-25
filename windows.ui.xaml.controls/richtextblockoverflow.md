---
-api-id: T:Windows.UI.Xaml.Controls.RichTextBlockOverflow
-api-type: winrt class
---

<!-- Class syntax.
public class RichTextBlockOverflow : Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.Controls.IRichTextBlockOverflow, Windows.UI.Xaml.Controls.IRichTextBlockOverflow2
-->

# Windows.UI.Xaml.Controls.RichTextBlockOverflow

## -description
Represents a rich text display overflow container. This element cannot have direct content. The only purpose of RichTextBlockOverflow is to display text content that does not fit in the bounds of a [RichTextBlock](richtextblock.md) or another RichTextBlockOverflow element.



## -xaml-syntax
```xaml
<RichTextBlockOverflow .../>
```


## -remarks
You can use a [RichTextBlock](richtextblock.md) with RichTextBlockOverflow elements to create advanced page layouts. The content for a RichTextBlockOverflow element always comes from a [RichTextBlock](richtextblock.md) element. You link RichTextBlockOverflow elements by setting them as the [OverflowContentTarget](richtextblock_overflowcontenttarget.md) of a [RichTextBlock](richtextblock.md) or another RichTextBlockOverflow.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | IsTextTrimmed |
| 1709 | 16299 | IsTextTrimmedChanged |

## -examples
Here, a [RichTextBlock](richtextblock.md) targets a RichTextBlockOverflow element to create a multi-column text layout. The first RichTextBlockOverflow element then targets a second RichTextBlockOverflow element that receives its content overflow. The controlling layout factor for how the text overflow is calculated is the constrained [Width](../windows.ui.xaml/frameworkelement_width.md) and [Height](../windows.ui.xaml/frameworkelement_height.md) of the parent [Grid](grid.md), and the [ColumnDefinition](columndefinition.md) settings that divide the [Grid](grid.md) into three equal columns of 300 pixels height/width. Overflow is also affected by [FontSize](richtextblock_fontsize.md) and many other text formatting properties that change characters in the text.



[!code-xaml[RichTextOverflow](../windows.ui.xaml.controls/code/TextDisplaySnippets/CS/MainPage.xaml#SnippetRichTextOverflow)]

## -see-also
[FrameworkElement](../windows.ui.xaml/frameworkelement.md), [OverflowContentTarget](richtextblockoverflow_overflowcontenttarget.md), [RichTextBlock](richtextblock.md), [RichTextBock.OverflowContentTarget](richtextblock_overflowcontenttarget.md), [XAML text display sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20text%20display%20sample)
