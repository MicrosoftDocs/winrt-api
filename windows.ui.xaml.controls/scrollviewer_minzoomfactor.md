---
-api-id: P:Windows.UI.Xaml.Controls.ScrollViewer.MinZoomFactor
-api-type: winrt property
---

<!-- Property syntax
public float MinZoomFactor { get;  set; }
-->

# Windows.UI.Xaml.Controls.ScrollViewer.MinZoomFactor

## -description

Gets or sets a value that indicates the minimum permitted run-time value of [ZoomFactor](scrollviewer_zoomfactor.md).

## -xaml-syntax

```xaml
<ScrollViewer MinZoomFactor="single" />
```

## -property-value

The minimum permitted run-time value of [ZoomFactor](scrollviewer_zoomfactor.md). The value must be greater than or equal to 0.1. The default is 0.1.

## -remarks

The value for this property must be greater than or equal to 0.1; otherwise, an exception is thrown.

## -examples

## -see-also
