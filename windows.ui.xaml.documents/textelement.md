---
-api-id: T:Windows.UI.Xaml.Documents.TextElement
-api-type: winrt class
---

<!-- Class syntax.
public class TextElement : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Documents.ITextElement, Windows.UI.Xaml.Documents.ITextElement2, Windows.UI.Xaml.Documents.ITextElement3, Windows.UI.Xaml.Documents.ITextElement4, Windows.UI.Xaml.Documents.ITextElementOverrides
-->

# Windows.UI.Xaml.Documents.TextElement

## -description
An abstract class used as the base class for the also-abstract [Block](block.md) and [Inline](inline.md) classes. [TextElement](textelement.md) supports common API for classes involved in the XAML text object model, such as properties that control text size, font families and so on.

## -remarks
The various properties defined by [TextElement](textelement.md) support a common API for classes involved in the XAML text object model. Here's a list of the most commonly used properties:
+ [FontFamily](textelement_fontfamily.md)
+ [FontSize](textelement_fontsize.md)
+ [FontStretch](textelement_fontstretch.md)
+ [Foreground](textelement_foreground.md)


By setting [TextElement](textelement.md) properties, you can apply common text formatting properties to text, both in blocks and in inlines. There are also additional ways to format text, but these aren't directly supported by [TextElement](textelement.md). Instead, you can use the attached properties of the [Typography](typography.md) class. [Typography](typography.md) attached properties typically support advanced typographic features or conventions, such as accessing typographic features defined at the font level that are not necessarily supported by all fonts. For example, you could set [Typography.Variants](typography_variants.md) as an attached property on any text block or inline, and this would influence the font-variants behavior as enabled by the particular font you chose for setting [FontFamily](textelement_fontfamily.md) on that text element.


<!--TODO seealso for advanced typography, right now the APs and Typography class is all we got.-->
[TextElement](textelement.md) doesn't inherently define a connection point to a XAML visual tree. In other words a [TextElement](textelement.md) defines text and text object model within that text, but it doesn't yet enable the display of that text within a UI. For that, you need to use one of the controls or elements that are descendants of [UIElement](../windows.ui.xaml/uielement.md) and can be connected to the XAML tree and the root visual of your app window. There are two such elements in the Windows Runtime:
+ [TextBlock](../windows.ui.xaml.controls/textblock.md): Supports a text object model of inlines only with its [Inlines](../windows.ui.xaml.controls/textblock_inlines.md) collection.
+ [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md): Supports a block text object model with its [Blocks](../windows.ui.xaml.controls/richtextblock_blocks.md) collection. The blocks can contain blocks and inlines.


> [!NOTE]
> [PasswordBox](../windows.ui.xaml.controls/passwordbox.md), [RichEditBox](../windows.ui.xaml.controls/richeditbox.md) and [TextBox](../windows.ui.xaml.controls/textbox.md) don't support a text object model that's based on [TextElement](textelement.md). [RichEditBox](../windows.ui.xaml.controls/richeditbox.md) does enable programmatic access to a different text object model through the [ITextDocument](../windows.ui.text/itextdocument.md) interface.

[TextElement](textelement.md) defines API that support examining the text object model as programming objects after the XAML is parsed. In particular [TextElement](textelement.md) implements [Name](textelement_name.md) and [Language](textelement_language.md), which parallel properties of the same name on [FrameworkElement](../windows.ui.xaml/frameworkelement.md). [TextElement](textelement.md) also implements [FindName](textelement_findname.md) (a utility method for finding objects at run time based on how [Name](textelement_name.md) was set in initial XAML), and [OnDisconnectVisualChildren](textelement_ondisconnectvisualchildren.md) (for advanced scenarios and designer support).

 [TextElement](textelement.md) has four properties that provide access to [TextPointer](textpointer.md) objects from within text. These properties are: [ContentStart](textelement_contentstart.md), [ContentEnd](textelement_contentend.md), [ElementStart](textelement_elementstart.md), [ElementEnd](textelement_elementend.md). A Windows Runtime  [TextPointer](textpointer.md) object gives you an entry point for traversal of content. For more info, see [TextPointer](textpointer.md).
<!--TODO better seealso. WPF TP supports manipulation, WinRTs does not, that's a point to document.-->

[TextElement](textelement.md) is a class derived from [DependencyObject](../windows.ui.xaml/dependencyobject.md). That means it can define dependency properties, and each of the read-write properties of [TextElement](textelement.md) is a dependency property, with its property identifier also defined by [TextElement](textelement.md). For more info on what dependency properties enable, see [Dependency properties overview](http://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e).

### **TextElement** derived classes

[TextElement](textelement.md) is the parent class for two derived classes that split the text object model into two text usage conventions: [Block](block.md), and [Inline](inline.md). [Block](block.md) and [Inline](inline.md) are both considered base classes (you don't typically see a `<Block>` tag in XAML) and exist in the hierarchy mainly to be the parent class of other practical text elements. For example, [Block](block.md) is the parent class of [Paragraph](paragraph.md). For more info on how to use block and inline elements, see [Quickstart: Displaying text](http://msdn.microsoft.com/library/3efa9d2a-71a5-41d3-bba4-ec6cc356d47f).

## -examples

## -see-also
[DependencyObject](../windows.ui.xaml/dependencyobject.md), [Block](block.md), [Inline](inline.md), [Typography](typography.md), [Quickstart: Displaying text](http://msdn.microsoft.com/library/3efa9d2a-71a5-41d3-bba4-ec6cc356d47f)