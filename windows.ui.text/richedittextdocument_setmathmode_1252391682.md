---
-api-id: M:Windows.UI.Text.RichEditTextDocument.SetMathMode(Windows.UI.Text.RichEditMathMode)
-api-type: winrt method
---

<!-- Method syntax.
public void RichEditTextDocument.SetMathMode(RichEditMathMode mode)
-->

# Windows.UI.Text.RichEditTextDocument.SetMathMode

## -description

Configures a [RichEditBox](../windows.ui.xaml.controls/richeditbox.md) to interpret input based on the specified math mode.

> [!IMPORTANT]
> The math mode APIs are a limited access feature. Please contact [richeditmathml@microsoft.com](mailto:richeditmathml@microsoft.com) for more info, or to request an unlock token.

## -parameters

### -param mode

Specifies whether a [RichEditBox](../windows.ui.xaml.controls/richeditbox.md) interprets input as  ([MathML](https://www.w3.org/Math/)) or text.

## -remarks

Math mode enables users to have input automatically recognized and converted to [MathML](https://www.w3.org/Math/) while being received. For example, "4^2" is converted to "4<sup>2</sup>", and "1/2" is converted to "½".

Math mode might change formatting (fonts), context menus, and other aspects of the input.

## -see-also

[GetMath](richedittextdocument_getmath_68550788.md), [SetMath](richedittextdocument_setmath_83103344.md)

## -examples
