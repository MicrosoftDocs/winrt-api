---
-api-id: P:Windows.UI.Xaml.Controls.ParallaxView.Source
-api-type: winrt property
---

<!-- Property syntax.
public UIElement Source { get;  set; }
-->

# Windows.UI.Xaml.Controls.ParallaxView.Source

## -description

The element that either is or contains the ScrollViewer that controls the parallax operation.

## -xaml-syntax

```xaml
<ParallaxView Source="sourceElement" .../>
```

## -property-value

## -remarks

If the source element is not a ScrollViewer, the XAML tree is walked starting at the source element to find an embedded ScrollViewer.

## -see-also

## -examples

