---
-api-id: T:Windows.UI.Xaml.Documents.Span
-api-type: winrt class
---

<!-- Class syntax.
public class Span : Windows.UI.Xaml.Documents.Inline, Windows.UI.Xaml.Documents.ISpan
-->

# Windows.UI.Xaml.Documents.Span

## -description
Groups other [Inline](inline.md) content elements. Parent class for [Bold](bold.md), [Hyperlink](hyperlink.md), [Italic](italic.md) and [Underline](underline.md).



## -xaml-syntax
```xaml
<Span .../>
-or-
<Span ...>
  oneOrMoreInlines
</Span>
-or-
<Span ...>
  mixedContent
</Span>
```


## -remarks
You can use Span as an object element in XAML to enclose text. This enables a similar usage to how you might use the` span` tag in HTML. For this usage you'd set the attributes that are supported by [TextElement](textelement.md) such as [FontSize](textelement_fontsize.md) or [FontFamily](textelement_fontfamily.md), so that you can apply these text formatting decisions to the enclosed span of text. [Run](run.md) has similar functionality of applying [TextElement](textelement.md) properties to a range of text, but [Run](run.md) doesn't support mixed content (its [Run.Text](run_text.md) XAML content property can only contain text, not mixed content and further inlines).

Span supports mixed content if you set the content in XAML. What this means is that you can mix [Inline](inline.md) tags such as [Run](run.md), [Bold](bold.md) and so on with XAML text content (plain text), with no restrictions on the order in which tags versus text must appear. All text, whether plain text or as enclosed in an [Inline](inline.md) tag, renders in the order that the text is defined in the mixed content. For example, this is legal XAML:
```xaml
<RichTextBlock>
  <Paragraph>
    <Span>This is <Bold>mixed content</Bold> with multiple text areas <Italic> and inlines</Italic>.</Span>
  </Paragraph>
</RichTextBlock>
```

When mixed content is parsed from XAML, and the text object model is examined at run time, any text area that came from the plain text generates a [Run](run.md) object at the appropriate reading-order position in the [InlineCollection](inlinecollection.md) collection class that enables run-time access. That [Run](run.md) element contains the text but otherwise has no properties set.

> [!NOTE]
> Placing XAML content whether tags or text directly within a Span element is supported because Span denotes that its [Inlines](span_inlines.md) property is the XAML content property. For more info on XAML content properties, see "XAML content properties" section of [XAML syntax guide](/windows/uwp/xaml-platform/xaml-syntax-guide).

Span elements are typically used as elements within an [InlineCollection](inlinecollection.md), either as child elements of a [Paragraph](paragraph.md) (becomes part of [Paragraph.Inlines](paragraph_inlines.md)) or as the content of another Span (becomes part of [Span.Inlines](span_inlines.md)).

### **Span** derived classes

Span is the parent class for several derived classes that define an inline text region with a particular formatting convention:

+ [Bold](bold.md)
+ [Hyperlink](hyperlink.md)
+ [Italic](italic.md)
+ [Underline](underline.md)
[Hyperlink](hyperlink.md) enables a click behavior that navigates to the [NavigateUri](hyperlink_navigateuri.md). The other Span derived classes can be thought of as class-specific decorations to the text and don't otherwise add interaction.

## -examples

## -see-also
[Inline](inline.md), [Paragraph](paragraph.md)
