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
You typically use Typography attached properties with the text of [TextBlock](../windows.ui.xaml.controls/textblock.md) or [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md) controls. 

> [!NOTE]
> You cannot use these properties with the [TextBox](../windows.ui.xaml.controls/textbox.md) or [RichEditBox](../windows.ui.xaml.controls/richeditbox.md) controls. 

The Typography object exposes the set of features that the Microsoft OpenType font supports. By setting the properties of Typography in markup or code, you can author documents that take advantage of Microsoft OpenType features, and turn those features on at a per-element level if desired.

Some fonts contain stylistic variant glyphs that correspond to portions of a character set. Glyphs in stylistic sets may be designed to harmonize visually, interact in particular ways, or work together in other ways. Some of these variants are identified by particular conventions, for example the font might have discretionary ligatures. In this example case, the typography behavior can be enabled by setting [Typography.DiscretionaryLigatures](/uwp/api/windows.ui.xaml.documents.typography.discretionaryligatures) to true. Other stylistic variants are not identified by any Microsoft OpenType set or convention, and are instead specific to that particular font's typography design. These variants can be accessed by setting any of the **StylisticSet#** attached properties to true.



> [!NOTE]
> Whenever possible, [TextBlock](../windows.ui.xaml.controls/textblock.md) renders text using an efficient *fast path*. Only the default values for the various Typography attached properties are fast path. Non-default values require [TextBlock](../windows.ui.xaml.controls/textblock.md) to fall back to a more CPU intensive code path for text rendering. For more info, see the [TextBlock control guide](/windows/uwp/controls-and-patterns/text-block).

### XAML attached properties

Typography is the host service class for several [XAML attached properties](/windows/uwp/xaml-platform/attached-properties-overview).

In order to support XAML processor access to the attached properties, and also to expose equivalent _get_ and _set_ operations to code, each XAML attached property has a pair of Get and Set accessor methods. Another way to get or set the value in code is to use the dependency property system, calling either [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md) and passing the identifier field as the dependency property identifier.

| Attached property | Description |
| - | - |
| [AnnotationAlternates](typography_annotationalternates.md) | Gets or sets an extension instance that defines helper methods for phased rendering of a data template. |
| [Capitals](typography_capitals.md) | Gets or sets a FontCapitals value that indicates the capital form of the selected font. |
| [CapitalSpacing](typography_capitalspacing.md) | Gets or sets a value that determines whether inter-glyph spacing for all-capital text is globally adjusted to improve readability. |
| [CaseSensitiveForms](typography_casesensitiveforms.md) | Gets or sets a value that determines whether glyphs adjust their vertical position to better align with uppercase glyphs. |
| [ContextualAlternates](typography_contextualalternates.md) | Gets or sets a value that determines whether custom glyph forms can be used based upon the context of the text being rendered. |
| [ContextualLigatures](typography_contextualligatures.md) | Gets or sets a value that determines whether contextual ligatures are enabled. |
| [ContextualSwashes](typography_contextualswashes.md) | Gets or sets a value that specifies the index of a contextual swashes form. |
| [DiscretionaryLigatures](typography_discretionaryligatures.md) | Gets or sets a value that determines whether discretionary ligatures are enabled. |
| [EastAsianExpertForms](typography_eastasianexpertforms.md) | Gets or sets a value that determines whether the standard Japanese font forms have been replaced with the corresponding preferred typographic forms. |
| [EastAsianLanguage](typography_eastasianlanguage.md) | Gets or sets a FontEastAsianLanguage value that indicates glyphs used for a specific writing system or language. |
| [EastAsianWidths](typography_eastasianwidths.md) | Gets or sets a FontEastAsianWidths value that indicates the proportional width for Latin characters in an East Asian font. |
| [Fraction](typography_fraction.md) | Gets or sets a FontFraction value that indicates the fraction style. |
| [HistoricalForms](typography_historicalforms.md) | Gets or sets a value that determines whether historical forms are enabled. |
| [HistoricalLigatures](typography_historicalligatures.md) | Gets or sets a value that indicates whether historical ligatures are enabled. |
| [Kerning](typography_kerning.md) | Gets or sets a value that indicates whether kerning is enabled. Kerning is a typographic function that adjusts the spacing between characters to enhance word shape. |
| [MathematicalGreek](typography_mathematicalgreek.md) | Gets or sets a value that indicates whether standard typographic font forms of Greek glyphs have been replaced with corresponding font forms commonly used in mathematical notation. |
| [NumeralAlignment](typography_numeralalignment.md) | Gets or sets a FontNumeralAlignment value that indicates the alignment of widths for numerals. |
| [NumeralStyle](typography_numeralstyle.md) | Gets or sets a FontNumeralStyle value that determines the set of glyphs that are used to render numeric alternate font forms. |
| [SlashedZero](typography_slashedzero.md) | Gets or sets a value that indicates whether a nominal zero font form should be replaced with a slashed zero. |
| [StandardLigatures](typography_standardligatures.md) | Gets or sets a value that indicates whether standard ligatures are enabled. |
| [StandardSwashes](typography_standardswashes.md) | Gets or sets a value that specifies the index of a standard swashes form. |
| [StylisticAlternates](typography_stylisticalternates.md) | Gets or sets a value that specifies the index of a stylistic alternates form. |
| [StylisticSet1](typography_stylisticset1.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet2](typography_stylisticset2.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet3](typography_stylisticset3.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet4](typography_stylisticset4.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet5](typography_stylisticset5.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet6](typography_stylisticset6.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet7](typography_stylisticset7.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet8](typography_stylisticset8.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet9](typography_stylisticset9.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet10](typography_stylisticset10.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet11](typography_stylisticset11.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet12](typography_stylisticset12.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet13](typography_stylisticset13.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet14](typography_stylisticset14.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet15](typography_stylisticset15.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet16](typography_stylisticset16.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet17](typography_stylisticset17.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet18](typography_stylisticset18.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet19](typography_stylisticset19.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [StylisticSet20](typography_stylisticset20.md) | Gets or sets a value that indicates whether a stylistic set of a font form is enabled. |
| [Variants](typography_variants.md) | Gets or sets a FontVariants value that indicates a variation of the standard typographic form to be used. |

## -examples

Here, Typography values are set on a [TextBlock](../windows.ui.xaml.controls/textblock.md) to render the text in small caps using stylistic set 4.

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

In this example, the [Typography.Fraction](/uwp/api/windows.ui.xaml.documents.typography.fraction) attached property is set on a [Run](run.md) in a [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md).

```xaml
<RichTextBlock>
    <Paragraph>12 x <Run Typography.Fraction="Slashed">1/3</Run> = 4.</Paragraph>
</RichTextBlock>
```

## -see-also
[TextBlock](../windows.ui.xaml.controls/textblock.md), [RichTextBlock](../windows.ui.xaml.controls/richtextblock.md), [TextBlock control guide](/windows/uwp/controls-and-patterns/text-block), [RichTextBlock control guide](/windows/uwp/controls-and-patterns/rich-text-block)
