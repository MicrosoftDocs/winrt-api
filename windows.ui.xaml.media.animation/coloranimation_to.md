---
-api-id: P:Windows.UI.Xaml.Media.Animation.ColorAnimation.To
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.UI.Color> To { get;  set; }
-->

# Windows.UI.Xaml.Media.Animation.ColorAnimation.To

## -description
Gets or sets the animation's ending value.



## -xaml-syntax
```xaml
<ColorAnimation To="colorString"/>
-or-
<ColorAnimation To="referenceToColor"/>
- or -
<ColorAnimation>
  <ColorAnimation.To>
    <Color>colorString</Color>
  </ColorAnimation.To>
</ColorAnimation>
```


## -xaml-values
<dl><dt>colorString</dt><dd>colorStringA color specified as a string, using a variety of possible formats, including predefined named colors. For the full list of available string formats that can specify a Color as an attribute, see Color.</dd>
<dt>referenceToColor</dt><dd>referenceToColorA {StaticResource} markup extension reference or other reference to an existing color.</dd>
</dl>
## -property-value
The ending value of the animation. The default is null.

<!--Projection dochack:-->
If you are programming using C# or Visual Basic, the type of this property is projected as **Color?**(a nullable [Color](../windows.ui/color.md)).

## -remarks

## -examples

## -see-also
