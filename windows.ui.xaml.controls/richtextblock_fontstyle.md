---
-api-id: P:Windows.UI.Xaml.Controls.RichTextBlock.FontStyle
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Text.FontStyle FontStyle { get;  set; }
-->

# Windows.UI.Xaml.Controls.RichTextBlock.FontStyle

## -description
Gets or sets the font style for the content in this element.



## -xaml-syntax
```xaml
<RichTextBlock FontStyle="fontStyleMemberName"/>
```


## -xaml-values
<dl><dt>fontStyleMemberName</dt><dd>fontStyleMemberName A FontStyle member name, such as Italic.</dd>
</dl>
## -property-value
The requested font style, which is a [FontStyle](../windows.ui.text/fontstyle.md) enumeration named constant. The default is Normal.

## -remarks
Set the FontStyle property to specify the default font stretch to use for all text in the [RichTextBlock](richtextblock.md). You can override this value for specific text elements in the [RichTextBlock](richtextblock.md) by setting the [TextElement.FontStyle](../windows.ui.xaml.documents/textelement_fontstyle.md) property.

## -examples

## -see-also
[TextElement.FontStyle](../windows.ui.xaml.documents/textelement_fontstyle.md)
