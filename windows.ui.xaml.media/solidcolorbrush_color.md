---
-api-id: P:Windows.UI.Xaml.Media.SolidColorBrush.Color
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Color Color { get;  set; }
-->

# Windows.UI.Xaml.Media.SolidColorBrush.Color

## -description
Gets or sets the color of this [SolidColorBrush](solidcolorbrush.md).



## -xaml-syntax
```xaml
<SolidColorBrush Color="predefinedColorName"/>
- or -
<SolidColorBrush Color="#rgb"/>
- or -
<SolidColorBrush Color="#argb"/>
- or -
<SolidColorBrush Color="#rrggbb"/>
- or -
<SolidColorBrush Color="#aarrggbb"/>
- or -
<SolidColorBrush Color="sc#scR,scG,scB"/>
- or -
<SolidColorBrush Color="sc#scA,scR,scG,scB"/>
```


## -xaml-values
<dl><dt>predefinedColorName</dt><dd>predefinedColorNameOne of the colors predefined by the Colors class (static properties), specified by the name of that property and color.</dd>
<dt>rgb</dt><dd>rgbA three-character hexadecimal value. The first character specifies the color's R value, the second character specifies the G value, and the third character specifies the B value. For example, #00F.</dd>
<dt>argb</dt><dd>argbA four-character hexadecimal value. The first character specifies the color's A value, the second character specifies its R value, the third character specifies the G value, and the fourth character specifies its B value. For example, #F00F.</dd>
<dt>rrggbb</dt><dd>rrggbbA six-character hexadecimal value. The first two characters specify the color's R value, the next two specify its G value, and the final two specify its B value. For example, #0000FF.</dd>
<dt>aarrggbb</dt><dd>aarrggbbAn eight-character hexadecimal value. The first two characters specify the color's A value, the next two specify its R value, the next two specify its G value, and the final two specify its B value. For example, #FF0000FF.</dd>
<dt>scA</dt><dd>scAThe color's ScA value as a value between 0 and 1. ScA is not exposed as a Color property directly.</dd>
<dt>scR</dt><dd>scRThe color's ScR value as a value between 0 and 1. ScR is not exposed as a Color property directly.</dd>
<dt>scG</dt><dd>scGThe color's ScG value as a value between 0 and 1. ScG is not exposed as a Color property directly.</dd>
<dt>scB</dt><dd>scBThe color's ScB value as a value between 0 and 1. ScB is not exposed as a Color property directly.</dd>
</dl>
## -property-value
The brush's color. The default value is [Transparent](../windows.ui/colors_transparent.md).

## -remarks

## -examples

## -see-also
