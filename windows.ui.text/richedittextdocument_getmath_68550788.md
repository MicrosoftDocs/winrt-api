---
-api-id: M:Windows.UI.Text.RichEditTextDocument.GetMath(System.String@)
-api-type: winrt method
---

<!-- Method syntax.
public void RichEditTextDocument.GetMath(String value)
-->

# Windows.UI.Text.RichEditTextDocument.GetMath

## -description

Retrieves the [RichEditBox](../windows.ui.xaml.controls/richeditbox.md) content as [MathML](https://www.w3.org/Math/).

> [!IMPORTANT]
> The math mode APIs are a limited access feature. Please contact [richeditmathml@microsoft.com](mailto:richeditmathml@microsoft.com) for more info, or to request an unlock token.

## -parameters

### -param value

The [RichEditBox](../windows.ui.xaml.controls/richeditbox.md) content as [MathML](https://www.w3.org/Math/).

## -remarks

This method fails if current math mode of the [RichEditBox](../windows.ui.xaml.controls/richeditbox.md) is set to [NoMath](richeditmathmode.md).

Math mode enables users to have input automatically recognized and converted to [MathML](https://www.w3.org/Math/) while being received. For example, "4^2" is converted to "4<sup>2</sup>", and "1/2" is converted to "½".

Math mode might change formatting (fonts), context menus, and other aspects of the input.

## -see-also

[SetMath](richedittextdocument_setmath_83103344.md)

## -examples
