---
-api-id: P:Windows.UI.Xaml.Media.Animation.ColorKeyFrame.Value
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Color Value { get;  set; }
-->

# Windows.UI.Xaml.Media.Animation.ColorKeyFrame.Value

## -description
Gets or sets the key frame's target value.



## -xaml-syntax
```xaml
<colorKeyFrame Value="colorString"/>
-or-
<colorKeyFrame Value="referenceToColor"/>
- or -
<colorKeyFrame>
  <colorKeyFrame.Value>
    <Color>colorString</Color>
  </colorKeyFrame.Value>
</colorKeyFrame>
```


## -xaml-values
<dl><dt>colorString</dt><dd>colorStringA color specified as a string, using a variety of possible formats, including predefined named colors. For the full list of available string formats that can specify a Color as an attribute, see Color.</dd>
<dt>referenceToColor</dt><dd>referenceToColorA {StaticResource} markup extension reference or other reference to an existing color. You can define a Color in a ResourceDictionary in the form &lt;Color x:Key="key"&gt;colorString&lt;/Color&gt;.</dd>
</dl>
## -property-value
The key frame's target value, which is the value at its specified [KeyTime](colorkeyframe_keytime.md). The default is a [Color](../windows.ui/color.md) with an ARGB value of #00000000.

## -remarks

## -examples

## -see-also
