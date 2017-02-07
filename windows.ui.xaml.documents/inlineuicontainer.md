---
-api-id: T:Windows.UI.Xaml.Documents.InlineUIContainer
-api-type: winrt class
---

<!-- Class syntax.
public class InlineUIContainer : Windows.UI.Xaml.Documents.Inline, Windows.UI.Xaml.Documents.IInlineUIContainer
-->

# Windows.UI.Xaml.Documents.InlineUIContainer

## -description
Provides an inline content element that enables [UIElement](../windows.ui.xaml/uielement.md) types to be embedded in the content of a [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md).

## -xaml-syntax
```xaml
<InlineUIContainer .../>
-or-
<InlineUIContainer ...>
  singleChild
</InlineUIContainer>

```


## -remarks
The most common scenario for using an [InlineUIContainer](inlineuicontainer.md) object is to introduce an image into text content. Use a new [Image](../windows.ui.xaml.controls/image.md) object for the image, as the child content for an [InlineUIContainer](inlineuicontainer.md). Set [Height](../windows.ui.xaml/frameworkelement_height.md) and [Width](../windows.ui.xaml/frameworkelement_width.md) on the image if you don't want it to scale to the natural image size.

If you want more than one element inlined in the same position, consider using a panel as the single [InlineUIContainer](inlineuicontainer.md) child and then placing the multiple elements within that panel.

If placed within an [InlineUIContainer](inlineuicontainer.md), a control that can be focused still appears in the top-level tab sequence.

If you want interactive text, consider using a [Hyperlink](hyperlink.md) element (a type of [Inline](inline.md)) rather than using [InlineUIContainer](inlineuicontainer.md) with a [Button](../windows.ui.xaml.controls/button.md) or similar within it. See [Guidelines for links](http://msdn.microsoft.com/library/74302ff0-65fc-4820-b59a-718a765ef7f0).

[InlineUIContainer](inlineuicontainer.md) inherits properties from the [TextElement](textelement.md) class. However, most of these properties don't have any visible effect. It's most common to declare a [InlineUIContainer](inlineuicontainer.md) object element in XAML without there being any attributes set (except possibly [x:Name attribute](http://msdn.microsoft.com/library/4ff1f3ed-903a-4305-b2bd-dcd29e0c9e6d)) with the single child element that you're inlining as content of the [InlineUIContainer](inlineuicontainer.md) object element.

Setting properties on [InlineUIContainer](inlineuicontainer.md) that otherwise affect the character line height of a text element (such as [FontSize](textelement_fontsize.md), [FontFamily](textelement_fontfamily.md)) has no effect on the rendering and appearance. The content dictates its size and the [InlineUIContainer](inlineuicontainer.md) sizes to fit it.

If there's further text within the child content (like [TextBlock.Text](../windows.ui.xaml.controls/textblock_text.md) or other text elements within a nested [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md)) the text element properties of the [InlineUIContainer](inlineuicontainer.md) parent won't inherit into the content, they're ignored.

## -examples
The following code example shows how you can insert an image into a [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) by using [InlineUIContainer](inlineuicontainer.md).

```xaml
<RichTextBlock>
    <Paragraph>
        <Italic>This is an inline image.</Italic>

        <InlineUIContainer>
            <Image Source="Assets/SmallLogo.png" Height="30" Width="30"/>
        </InlineUIContainer>
 
        Mauris auctor tincidunt auctor.
    </Paragraph>
</RichTextBlock>
```



## -see-also
[Inline](inline.md), [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md), [UIElement](../windows.ui.xaml/uielement.md)