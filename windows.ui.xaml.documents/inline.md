---
-api-id: T:Windows.UI.Xaml.Documents.Inline
-api-type: winrt class
---

<!-- Class syntax.
public class Inline : Windows.UI.Xaml.Documents.TextElement, Windows.UI.Xaml.Documents.IInline
-->

# Windows.UI.Xaml.Documents.Inline

## -description
Provides a base class for inline text elements, such as [Span](span.md) and [Run](run.md).



## -remarks
[InlineCollection](inlinecollection.md) is a strongly typed collection class that is used by various **Inlines** properties: [TextBlock.Inlines](../windows.ui.xaml.controls/textblock_inlines.md), [Paragraph.Inlines](paragraph_inlines.md) and [Span.Inlines](span_inlines.md). By specifying XAML object elements within one of these **Inlines** properties, you can assign multiple Inline elements to be the text content for an inline text container. This is usually done using an implicit collection and XAML property syntax, such that the inline child elements appear as direct children of the container in XAML markup. This example uses all of the common Inline types as content for a [Paragraph](paragraph.md):
```xaml
<Paragraph>
  <Bold>Bold</Bold><LineBreak/>
  <Hyperlink>Hyperlink</Hyperlink><LineBreak/>
  <InlineUIContainer>
    <Ellipse Fill="Red" Height="20" Width="20"/>
  </InlineUIContainer><LineBreak/>
  <Italic>Italic</Italic><LineBreak/>
  <Run>Run</Run><LineBreak/>
  <Span>Span</Span><LineBreak/>
  <Underline>Underline</Underline><LineBreak/>
 </Paragraph>
```



### **Inline** derived classes

Inline is the parent class for several immediately derived classes that further define varieties of inline text for the XAML text object model:
+ [InlineUIContainer](inlineuicontainer.md)
+ [LineBreak](linebreak.md)
+ [Run](run.md)
+ [Span](span.md)


[Span](span.md) has several derived classes too: [Bold](bold.md), [Hyperlink](hyperlink.md), [Italic](italic.md), and [Underline](underline.md). Span can also be used as a formatting element to apply [TextElement](textelement.md) properties to mixed content (inlines and plain text). [Block](block.md) and Inline are both considered base classes (you don't typically see a `<Inline>` tag in XAML). For more info on how to use block and inline elements, see [Quickstart: Displaying text](/previous-versions/windows/apps/hh700392(v=win.10)).

## -examples

## -see-also
[TextElement](textelement.md), [Run](run.md), [Span](span.md), [Paragraph.Inlines](paragraph_inlines.md), [TextBlock.Inlines](../windows.ui.xaml.controls/textblock_inlines.md), [Quickstart: Displaying text](/previous-versions/windows/apps/hh700392(v=win.10))
