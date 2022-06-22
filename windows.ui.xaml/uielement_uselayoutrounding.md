---
-api-id: P:Windows.UI.Xaml.UIElement.UseLayoutRounding
-api-type: winrt property
---

<!-- Property syntax
public bool UseLayoutRounding { get;  set; }
-->

# Windows.UI.Xaml.UIElement.UseLayoutRounding

## -description
Gets or sets a value that determines whether rendering for the object and its visual subtree should use rounding behavior that aligns rendering to whole pixels.



## -xaml-syntax
```xaml
<uiElement UseLayoutRounding="bool" />
```


## -property-value
**true** if rendering and layout should use layout rounding to whole pixels; otherwise, **false**. The default is **true**.

## -remarks
Various Windows Runtime properties of type **Double** are used to specify layout desired values or characteristics. The most obvious are [Height](frameworkelement_height.md) and [Width](frameworkelement_width.md) but there are many others. The default value of **true** for UseLayoutRounding will cause measurement and layout operations to round potential subpixel values from these layout properties to the nearest integer value, and render objects aligned to pixel boundaries. This behavior is intended to reduce the visual artifacts that can appear when a subpixel value renders and affects pixels on either side of the subpixel boundary. The most prominent example of such an artifact is when you intend to produce a crisp, thin line of a particular color. If your measurement for the line gave a subpixel value, and the layout behavior did not round to whole pixels, then the line can potentially appear blurry as well as appearing as a dimmer color shade than you intended.

Layout rounding affects aliasing as well as positioning.

Possible scenarios for setting UseLayoutRounding to **false** are not documented here. If you feel that there might be benefit in enabling subpixel rendering for your app, experiment with setting UseLayoutRounding to **false**, examine the visual results, and make sure that possible rendering artifacts from subpixel rendering do not outweigh the perceived benefits. If you do set UseLayoutRounding to **false**, it's common to do so on the root of your XAML page or object tree.

## -examples

## -see-also
[Define layouts with XAML](/windows/uwp/layout/layouts-with-xaml)
