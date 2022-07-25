---
-api-id: P:Windows.UI.Xaml.Controls.ToggleSwitch.OffContent
-api-type: winrt property
---

<!-- Property syntax
public object OffContent { get;  set; }
-->

# Windows.UI.Xaml.Controls.ToggleSwitch.OffContent

## -description
Provides the object content that should be displayed using the [OffContentTemplate](toggleswitch_offcontenttemplate.md) when this [ToggleSwitch](toggleswitch.md) has state of "Off".



## -xaml-syntax
```xaml
<ToggleSwitch OffContent="stringContent"/>
- or -
<ToggleSwitch>
  <ToggleSwitch.OffContent>
    singleContentElement
  </ToggleSwitch.OffContent>
</ToggleSwitch>
```


## -xaml-values
<dl><dt>stringContent</dt><dd>stringContentA string that declares the Off state content. Can also be a reference to a resource, which might be a string or could also be a composited object.</dd>
<dt>singleContentElement</dt><dd>singleContentElementA single object element for a class that derives from UIElement and can be handled by the default ContentPresenter.</dd>
</dl>
## -property-value
The object content. In some cases this is a string, in other cases it is a single element that provides a root for further composition content. Probably the most common "set" usage is to place a binding here.

## -remarks

## -examples

## -see-also
