---
-api-id: P:Windows.UI.Xaml.UIElement.XamlLights
-api-type: winrt property
---

<!-- Property syntax.
public XamlLightCollection XamlLights { get;  set; }
-->

# Windows.UI.Xaml.UIElement.XamlLights

## -description
Gets the collection of [XamlLight](../windows.ui.xaml.media/xamllight.md) objects attached to this element.

## -xaml-syntax
```xaml
<uielement>
  <uielement.Lights>
    <XamlLightCollection>
      oneOrMoreXamlLights
    </XamlLightCollection>
  </uielement.Lights>
</uielement>
```

## -xaml-values
<dl><dt>oneOrMoreXamlLights</dt><dd>One or more object elements of types that are derived from the XamlLight base type. Typically there is only one of each type of light included in the collection.</dd>
</dl>

## -property-value
The strongly typed collection of [XamlLight](../windows.ui.xaml.media/xamllight.md) elements that apply to a [UIElement](uielement.md).

## -remarks

## -see-also
[XamlLight](../windows.ui.xaml.media/xamllight.md)

## -examples

