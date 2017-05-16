---
-api-id: P:Windows.UI.Xaml.Media.RevealBrush.FallbackForced
-api-type: winrt property
---

<!-- Property syntax.
public bool FallbackForced { get;  set; }
-->

# Windows.UI.Xaml.Media.RevealBrush.FallbackForced

## -description

Gets or sets a value that specifies whether the brush is forced to the solid fallback color.

## -property-value

**true** to always replace the reveal effect with the solid fallback color. Otherwise, **false**. The default is **false**.

## -remarks

By default, the reveal effect is replaced with a solid color and default ambient lighting when one of the fallback conditions is met (such as entering battery saver mode). You can set this property to **true** to always replace the reveal effect with the fallback values. Setting this property will synchronously trigger a transition animation between the normal look and fallback color.

## -see-also

## -examples

