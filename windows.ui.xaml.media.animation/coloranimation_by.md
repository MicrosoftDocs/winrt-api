---
-api-id: P:Windows.UI.Xaml.Media.Animation.ColorAnimation.By
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.IReference<Windows.UI.Color> By { get;  set; }
-->

# Windows.UI.Xaml.Media.Animation.ColorAnimation.By

## -description
Gets or sets the total amount by which the animation changes its starting value.

## -xaml-syntax
```xaml
<ColorAnimation By="colorString"/>
-or-
<ColorAnimation By="referenceToColor"/>
```

```xaml
<ColorAnimation>
  <ColorAnimation.By>
    <Color>colorString</Color>
  </ColorAnimation.By>
</ColorAnimation>
```


## -xaml-values
<dl><dt>colorString</dt><dd>colorStringA color specified as a string, using a variety of possible formats, including predefined named colors. For the full list of available string formats that can specify a Color as an attribute, see Color.</dd>
<dt>referenceToColor</dt><dd>referenceToColorA {StaticResource} markup extension reference or other reference to an existing color.</dd>
</dl>
## -property-value
The total amount by which the animation changes its starting value. The default is null.

<!--Projection dochack:-->
If you are programming using C# or Visual Basic, the type of this property is projected as **Color?**(a nullable [Color](../windows.ui/color.md)).

## -remarks

## -examples

## -see-also
