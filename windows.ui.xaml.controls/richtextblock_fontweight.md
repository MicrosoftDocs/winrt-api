---
-api-id: P:Windows.UI.Xaml.Controls.RichTextBlock.FontWeight
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Text.FontWeight FontWeight { get;  set; }
-->

# Windows.UI.Xaml.Controls.RichTextBlock.FontWeight

## -description
Gets or sets the top-level font weight for the [RichTextBlock](richtextblock.md).



## -xaml-syntax
```xaml
<RichTextBlock FontWeight="fontWeightsMemberName"/>
```


## -xaml-values
<dl><dt>fontWeightsMemberName</dt><dd>fontWeightsMemberNameA FontWeights member name, such as Light or Normal.</dd>
</dl>
## -property-value
The requested font weight, which is a [FontWeight](../windows.ui.text/fontweight.md) that is obtained from one of the [FontWeights](../windows.ui.text/fontweights.md) property values. The default is [Normal](../windows.ui.text/fontweights_normal.md).

## -remarks
Set the FontWeight property to specify the default font stretch to use for all text in the [RichTextBlock](richtextblock.md). You can override this value for specific text elements in the [RichTextBlock](richtextblock.md) by setting the [TextElement.FontWeight](../windows.ui.xaml.documents/textelement_fontweight.md) property.

## -examples

## -see-also
[TextElement.FontWeight](../windows.ui.xaml.documents/textelement_fontweight.md)
