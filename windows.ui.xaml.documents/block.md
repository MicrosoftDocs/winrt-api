---
-api-id: T:Windows.UI.Xaml.Documents.Block
-api-type: winrt class
---

<!-- Class syntax.
public class Block : Windows.UI.Xaml.Documents.TextElement, Windows.UI.Xaml.Documents.IBlock
-->

# Windows.UI.Xaml.Documents.Block

## -description
An abstract class that provides a base for all block-level content elements.



## -remarks
Block defines text formatting properties that should apply to all types of Block content. These properties are: [LineHeight](block_lineheight.md), [LineStackingStrategy](block_linestackingstrategy.md), [Margin](block_margin.md), and [TextAlignment](block_textalignment.md). Block also inherits the text formatting properties and other API of [TextElement](textelement.md).

In the Windows Runtime XAML vocabulary the only block type is [Paragraph](paragraph.md). You use [Paragraph](paragraph.md) to define the blocks of text to display within a [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) control. Every [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) should include at least one [Paragraph](paragraph.md).

[BlockCollection](blockcollection.md) is a strongly typed collection class that is used by the [RichTextBlock.Blocks](../windows.ui.xaml.controls/richtextblock_blocks.md) property. By specifying XAML object elements within a [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md), you can assign the block text content for the [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md). This is usually done using an implicit collection and XAML property syntax, such that the [Paragraph](paragraph.md) elements appear as direct children of [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) in XAML markup. For example:
```xaml
<RichTextBlock>
  <Paragraph>First paragraph.</Paragraph>
  <Paragraph>Second paragraph.</Paragraph>
  <Paragraph>Third paragraph. <Bold>With an inline.</Bold></Paragraph>
</RichTextBlock>
```

<!--For more info on how to use block and inline elements, see <xref targtype="ovw" rid="m_ui_controls_mca.quickstart__displaying_text"  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance">Quickstart: Displaying text</xref>.Commented out because the QS only covers TextBlock, we have no ovw on the rich TOM-->

### **Block** derived classes

Block is the parent class for [Paragraph](paragraph.md).

### Migration notes

The Windows Runtime XAML vocabulary doesn't support a **Section** class. If you're migrating XAML from Windows Presentation Foundation (WPF) or Microsoft Silverlight, use a [Paragraph](paragraph.md) block element instead.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | HorizontalTextAlignment |

## -examples

## -see-also
[TextElement](textelement.md), [Paragraph](paragraph.md), [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md)
