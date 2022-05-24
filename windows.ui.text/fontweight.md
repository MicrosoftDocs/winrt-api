---
-api-id: T:Windows.UI.Text.FontWeight
-api-type: winrt struct
---

<!-- Structure syntax.
public struct FontWeight 
-->

# FontWeight

## -description

Describes the density of a typeface, in terms of the lightness or heaviness of the strokes.

## -xaml-syntax

```xaml
<object property="fontWeightsPropertyName"/>
```

## -xaml-values
<dl><dt>fontWeightsPropertyName</dt><dd>fontWeightsPropertyNameA FontWeights static property name, such as Light, Normal, or Bold.</dd>
</dl>

## -struct-fields

### -field Weight

The font weight expressed as a numeric value.

## -remarks

In standard typography API, the weight of a font is expressed by using constant names such as "Bold". Using constant names for setting a font weight property is supported through type converter behaviors and also by the [FontWeights](fontweights.md) support class. For code access, the relevant information is expressed as the **Weight** member of a FontWeight structure.

The [FontWeights](fontweights.md) values correspond to the "usWeightClass" definition in the [OpenType specification](/typography/opentype/spec/). The "usWeightClass" represents an integer value between 1 and 999. Lower values indicate lighter weights; higher values indicate heavier weights.

The **Weight** member of a FontWeight structure is typically initiated with one of the [FontWeights](fontweights.md) values. If you access a FontWeight structure in code, you can compare the value of its **Weight** member with values from the [FontWeights](fontweights.md) static properties.

## -examples

This example shows how to set the FontWeight property on a XAML [TextBlock](../windows.ui.xaml.controls/textblock.md).

```xaml
<TextBlock Text="FontWeight ExtraBlack" FontWeight="ExtraBlack"/>
```

```csharp
TextBlock textBlock1 = new TextBlock();
textBlock1.Text = "FontWeight ExtraBlack";
textBlock1.FontWeight = Windows.UI.Text.FontWeights.ExtraBlack;
```

## -see-also
