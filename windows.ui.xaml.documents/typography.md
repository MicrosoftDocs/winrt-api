---
-api-id: T:Windows.UI.Xaml.Documents.Typography
-api-type: winrt class
---

<!-- Class syntax.
public class Typography : Windows.UI.Xaml.Documents.ITypography
-->

# Windows.UI.Xaml.Documents.Typography

## -description
Provides access to a set of Microsoft OpenType typography properties. These properties are implemented as XAML attached properties such that they can be set from text object model properties as well as from specific text controls.

## -remarks
You typically use [Typography](typography.md) attached properties with the text of [TextBlock](../windows.ui.xaml.controls/textblock.md) or [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) controls. The [Typography](typography.md) object exposes the set of features that the Microsoft OpenType font supports. By setting the properties of [Typography](typography.md) in markup or code, you can author documents that take advantage of Microsoft OpenType features, and turn those features on at a per-element level if desired.

Some fonts contain stylistic variant glyphs that correspond to portions of a character set. Glyphs in stylistic sets may be designed to harmonize visually, interact in particular ways, or work together in other ways. Some of these variants are identified by particular conventions, for example the font might have discretionary ligatures. In this example case, the typography behavior can be enabled by setting [Typography.DiscretionaryLigatures](typography_discretionaryligatures.md) to true. Other stylistic variants are not identified by any Microsoft OpenType set or convention, and are instead specific to that particular font's typography design. These variants can be accessed by setting any of the **StylisticSet#** attached properties to true.



> [!NOTE]
> Whenever possible, [TextBlock](../windows.ui.xaml.controls/textblock.md) renders text using an efficient *fast path*. Only the default values for the various [Typography](typography.md) attached properties are fast path. Non-default values require [TextBlock](../windows.ui.xaml.controls/textblock.md) to fall back to a more CPU intensive code path for text rendering. For more info, see the [TextBlock control guide](http://msdn.microsoft.com/library/da562509-d893-425a-aae6-b2ae9e9f8a19).

## -examples
Here, [Typography](typography.md) values are set on a [TextBlock](../windows.ui.xaml.controls/textblock.md) to render the text in small caps using stylistic set 4.

```xaml
<TextBlock Text="Hello, world!"
           Typography.Capitals="SmallCaps"
           Typography.StylisticSet4="True"/>
```

```csharp
TextBlock textBlock1 = new TextBlock();
textBlock1.Text = "Hello, world!";
Windows.UI.Xaml.Documents.Typography.SetCapitals(textBlock1, FontCapitals.SmallCaps);
Windows.UI.Xaml.Documents.Typography.SetStylisticSet4(textBlock1, true);
```

In this example, the [Typography.Fraction](typography_fraction.md) attached property is set on a [Run](run.md) in a [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md).

```xaml
<RichTextBlock>
    <Paragraph>12 x <Run Typography.Fraction="Slashed">1/3</Run> = 4.</Paragraph>
</RichTextBlock>
```



## -see-also
[TextBlock](../windows.ui.xaml.controls/textblock.md), [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md), [TextBlock control guide](http://msdn.microsoft.com/library/da562509-d893-425a-aae6-b2ae9e9f8a19), [RichTextBlock control guide](http://msdn.microsoft.com/library/e4be4b1b-418e-4075-88f1-22c09ddf8e45)