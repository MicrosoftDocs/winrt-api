---
-api-id: M:Windows.UI.Text.RichEditTextDocument.SetMath(System.String)
-api-type: winrt method
---

<!-- Method syntax.
public void RichEditTextDocument.SetMath(String value)
-->

# Windows.UI.Text.RichEditTextDocument.SetMath

## -description

Sets the [RichEditBox](../windows.ui.xaml.controls/richeditbox.md) content to the specified [MathML](https://www.w3.org/Math/).

> [!IMPORTANT]
> The math mode APIs are a limited access feature. Please contact [richeditmathml@microsoft.com](mailto:richeditmathml@microsoft.com) for more info, or to request an unlock token.

## -parameters

### -param value

The [MathML](https://www.w3.org/Math/) content for the [RichEditBox](../windows.ui.xaml.controls/richeditbox.md).

## -remarks

This method fails if current math mode of the [RichEditBox](../windows.ui.xaml.controls/richeditbox.md) is set to [NoMath](richeditmathmode.md).

Math mode enables users to have input automatically recognized and converted to [MathML](https://www.w3.org/Math/) while being received. For example, "4^2" is converted to "4<sup>2</sup>", and "1/2" is converted to "½".

Math mode might change formatting (fonts), context menus, and other aspects of the input.

## -see-also

[GetMath](richedittextdocument_getmath_68550788.md)

## -examples
