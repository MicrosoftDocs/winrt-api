---
-api-id: T:Windows.UI.Text.RichEditMathMode
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum RichEditMathMode : int 
-->

# Windows.UI.Text.RichEditMathMode

## -description

Defines constants that specify whether a [RichEditBox](../windows.ui.xaml.controls/richeditbox.md) interprets input as math ([MathML](https://www.w3.org/Math/)) or text.

> [!IMPORTANT]
> The math mode APIs are a limited access feature. Please contact [richeditmathml@microsoft.com](mailto:richeditmathml@microsoft.com) for more info, or to request an unlock token.

## -enum-fields

### -field NoMath:0

Input is interpreted as text.

### -field MathOnly:1

Input is interpreted as math.

## -remarks

Math mode enables users to have input automatically recognized and converted to [MathML](https://www.w3.org/Math/) while being received. For example, "4^2" is converted to "4<sup>2</sup>", and "1/2" is converted to "½".

Math mode might change formatting (fonts), context menus, and other aspects of the input.

## -see-also

[SetMathMode](richedittextdocument_setmathmode_1252391682.md)

## -examples
