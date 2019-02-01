---
-api-id: P:Windows.UI.Xaml.Controls.TextBlock.OpticalMarginAlignment
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.OpticalMarginAlignment OpticalMarginAlignment { get;  set; }
-->

# Windows.UI.Xaml.Controls.TextBlock.OpticalMarginAlignment

## -description
Get or sets a value that indicates how the font is modified to align with fonts of different sizes.

## -xaml-syntax
```xaml
<TextBlock OpticalMarginAlignment="None"/>
-or-
<TextBlock OpticalMarginAlignment="TrimSideBearings"/>
```


## -property-value
A value of the enumeration that indicates how the font is modified to align at different sizes. The default is **None**.

## -remarks
When [OpticalMarginAlignment](textblock_opticalmarginalignment.md) is set to [TrimSideBearings](../windows.ui.xaml/opticalmarginalignment.md), the text is trimmed to the leftmost stroke of the first character and the rightmost stroke of the last character on a line. For example, an "L" has a small amount of space to the left of the vertical stroke, which scales with font size. When [TrimSideBearings](../windows.ui.xaml/opticalmarginalignment.md) is set, the left of the vertical stroke is directly aligned without the spacing. This enables easier alignment to the Windows grid system as explained in [Laying out an app page](https://msdn.microsoft.com/library/2d4ec23b-185e-4f44-a302-02b77b0d4cee).

## -examples

## -see-also
