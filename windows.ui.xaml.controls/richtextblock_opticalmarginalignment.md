---
-api-id: P:Windows.UI.Xaml.Controls.RichTextBlock.OpticalMarginAlignment
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.OpticalMarginAlignment OpticalMarginAlignment { get;  set; }
-->

# Windows.UI.Xaml.Controls.RichTextBlock.OpticalMarginAlignment

## -description
Get or sets a value that indicates how the font is modified to align with fonts of different sizes.



## -xaml-syntax
```xaml
<RichTextBlock OpticalMarginAlignment="None"/>
-or-
<RichTextBlock OpticalMarginAlignment="TrimSideBearings"/>
```


## -property-value
A value of the enumeration that indicates how the font is modified to align at different sizes. The default is **None**.

## -remarks
When OpticalMarginAlignment is set to [TrimSideBearings](../windows.ui.xaml/opticalmarginalignment.md), the text is trimmed to the leftmost stroke of the first character and the rightmost stroke of the last character on a line. For example, an "L" has a small amount of space to the left of the vertical stroke, which scales with font size. When [TrimSideBearings](../windows.ui.xaml/opticalmarginalignment.md) is set, the left of the vertical stroke is directly aligned without the spacing. This enables easier alignment to the Windows grid system as explained in [Laying out an app page](/previous-versions/windows/apps/hh872191(v=win.10)).

## -examples

## -see-also
