---
-api-id: P:Windows.UI.Xaml.Controls.SemanticZoom.IsZoomOutButtonEnabled
-api-type: winrt property
---

<!-- Property syntax
public bool IsZoomOutButtonEnabled { get;  set; }
-->

# Windows.UI.Xaml.Controls.SemanticZoom.IsZoomOutButtonEnabled

## -description
Gets or sets a value that indicates whether the [ZoomedInView](semanticzoom_zoomedinview.md) shows a button that activates the [ZoomedOutView](semanticzoom_zoomedoutview.md).



## -xaml-syntax
```xaml
<SemanticZoom IsZoomOutButtonEnabled="bool" />
```


## -property-value
**True** if the [ZoomedInView](semanticzoom_zoomedinview.md) shows a button that activates the [ZoomedOutView](semanticzoom_zoomedoutview.md); otherwise, **false**. The default is **true**.

## -remarks
By default, when the zoomed in view is active and receives mouse or keyboard input, the [SemanticZoom](semanticzoom.md) control shows a button the user can click to activate the zoomed out view. To hide this button, set the IsZoomOutButtonEnabled property to **false**.

## -examples

## -see-also
