---
-api-id: T:Windows.UI.Xaml.Controls.RichTextBlockOverflow
-api-type: winrt class
---

<!-- Class syntax.
public class RichTextBlockOverflow : Windows.UI.Xaml.FrameworkElement, Windows.UI.Xaml.Controls.IRichTextBlockOverflow, Windows.UI.Xaml.Controls.IRichTextBlockOverflow2
-->

# Windows.UI.Xaml.Controls.RichTextBlockOverflow

## -description
Represents a rich text display overflow container. This element cannot have direct content. The only purpose of [RichTextBlockOverflow](richtextblockoverflow.md) is to display text content that does not fit in the bounds of a [RichTextBlock](richtextblock.md) or another [RichTextBlockOverflow](richtextblockoverflow.md) element.

## -xaml-syntax
```xaml
<RichTextBlockOverflow .../>
```


## -remarks
You can use a [RichTextBlock](richtextblock.md) with [RichTextBlockOverflow](richtextblockoverflow.md) elements to create advanced page layouts. The content for a [RichTextBlockOverflow](richtextblockoverflow.md) element always comes from a [RichTextBlock](richtextblock.md) element. You link [RichTextBlockOverflow](richtextblockoverflow.md) elements by setting them as the [OverflowContentTarget](richtextblock_overflowcontenttarget.md) of a [RichTextBlock](richtextblock.md) or another [RichTextBlockOverflow](richtextblockoverflow.md).

## -examples
Here, a [RichTextBlock](richtextblock.md) targets a [RichTextBlockOverflow](richtextblockoverflow.md) element to create a multi-column text layout. The first [RichTextBlockOverflow](richtextblockoverflow.md) element then targets a second [RichTextBlockOverflow](richtextblockoverflow.md) element that receives its content overflow. The controlling layout factor for how the text overflow is calculated is the constrained [Width](../windows.ui.xaml/frameworkelement_width.md) and [Height](../windows.ui.xaml/frameworkelement_height.md) of the parent [Grid](grid.md), and the [ColumnDefinition](columndefinition.md) settings that divide the [Grid](grid.md) into three equal columns of 300 pixels height/width. Overflow is also affected by [FontSize](richtextblock_fontsize.md) and many other text formatting properties that change characters in the text.



[!code-xml[RichTextOverflow](../windows.ui.xaml.controls/code/TextDisplaySnippets/CS/MainPage.xaml#SnippetRichTextOverflow)]

## -see-also
[FrameworkElement](../windows.ui.xaml/frameworkelement.md), [OverflowContentTarget](richtextblockoverflow_overflowcontenttarget.md), [RichTextBlock](richtextblock.md), [RichTextBock.OverflowContentTarget](richtextblock_overflowcontenttarget.md), [XAML text display sample](http://go.microsoft.com/fwlink/p/?linkid=238579)
flowcontenttarget.md), [XAML text display sample](http://go.microsoft.com/fwlink/p/?linkid=238579)