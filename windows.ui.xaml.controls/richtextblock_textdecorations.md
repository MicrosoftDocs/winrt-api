---
-api-id: P:Windows.UI.Xaml.Controls.RichTextBlock.TextDecorations
-api-type: winrt property
---

<!-- Property syntax.
public TextDecorations TextDecorations { get;  set; }
-->

# Windows.UI.Xaml.Controls.RichTextBlock.TextDecorations

## -description

Gets or sets a value that indicates what decorations are applied to the text.



## -xaml-syntax

```xaml
<RichTextBlock TextDecorations="textDecorationsMemberName"/>
```

## -xaml-values

<dl><dt>textDecorationsMemberName</dt><dd>textDecorationsMemberNameA named constant of the TextDecorations enumeration.</dd>
</dl>

## -property-value

A value of the enumeration. The default is **None**.

## -remarks

Starting with the Windows 10 Creators Update (SDK version 15063), this property is the preferred way to strikethrough or underline text.

For earlier versions of Windows, you can underline text with the [Underline](../windows.ui.xaml.documents/underline.md) class.

## -see-also

[TextElement.TextDecorations](../windows.ui.xaml.documents/textelement_textdecorations.md)

## -examples

This example shows how to apply text decorations to text in a RichTextBlock, both at the control level and at the [TextElement](../windows.ui.xaml.documents/textelement.md) level.

```xaml
<RichTextBlock TextDecorations="Underline"
            Loaded="RichTextBlock_Loaded">
    <Paragraph>This text has an underline.</Paragraph>
    <Paragraph TextDecorations="Strikethrough">
        This text has a strikethrough, but no underline.
    </Paragraph>
    <Paragraph TextDecorations="Strikethrough, Underline">This text has it all!</Paragraph>
    <Paragraph x:Name="Paragraph4">This text is decorated in code.</Paragraph>
</RichTextBlock>
```

```csharp
private void RichTextBlock_Loaded(object sender, RoutedEventArgs e)
{
    // Apply both strikethough and underline to the last paragraph.
    Paragraph4.TextDecorations =
        TextDecorations.Strikethrough | TextDecorations.Underline;
}
```
