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
> **Windows 11, version 23H2 and earlier:** the math mode APIs are part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -parameters

### -param mode

Specifies whether a [RichEditBox](../windows.ui.xaml.controls/richeditbox.md) interprets input as  ([MathML](https://www.w3.org/Math/)) or text.

## -remarks

Math mode enables users to have input automatically recognized and converted to [MathML](https://www.w3.org/Math/) while being received. For example, "4^2" is converted to "4<sup>2</sup>", and "1/2" is converted to "½".

Math mode might change formatting (fonts), context menus, and other aspects of the input.

## -see-also

[GetMath](richedittextdocument_getmath_68550788.md), [SetMath](richedittextdocument_setmath_83103344.md)

## -examples
