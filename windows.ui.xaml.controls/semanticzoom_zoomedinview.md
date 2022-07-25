---
-api-id: P:Windows.UI.Xaml.Controls.SemanticZoom.ZoomedInView
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Controls.ISemanticZoomInformation ZoomedInView { get;  set; }
-->

# Windows.UI.Xaml.Controls.SemanticZoom.ZoomedInView

## -description
Gets or sets the semantically more complete zoomed-in view of the [SemanticZoom](semanticzoom.md).



## -xaml-syntax
```xaml
<SemanticZoom ...>
  <SemanticZoom.ZoomedInView>
    zoomedInViewContent
  </SemanticZoom.ZoomedInView>
</SemanticZoom>

```


## -xaml-values
<dl><dt>zoomedInViewContent</dt><dd>zoomedInViewContentA single object element for a class that implements ISemanticZoomInfo (typically this is a practical ListViewBase implementation such as GridView).</dd>
</dl>
## -property-value
An object that implements [ISemanticZoomInfo](isemanticzoominformation.md). Typically this is a practical [ListViewBase](listviewbase.md) implementation such as [GridView](gridview.md).

## -remarks

## -examples

## -see-also
