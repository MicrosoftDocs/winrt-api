---
-api-id: M:Windows.ApplicationModel.Resources.Core.ResourceQualifierMapView.Split(Windows.Foundation.Collections.IMapView{System.String,System.String}@,Windows.Foundation.Collections.IMapView{System.String,System.String}@)
-api-type: winrt method
---

<!-- Method syntax
public void Split(Windows.Foundation.Collections.IMapView<System.String, System.String> first, Windows.Foundation.Collections.IMapView<System.String, System.String> second)
-->

# Windows.ApplicationModel.Resources.Core.ResourceQualifierMapView.Split

## -description
Splits the map view into two views.

## -parameters
### -param first
One half of the original map.

### -param second
The second half of the original map.

## -remarks
The two views that result from the split operation might not contain the same number of items. The two views do not overlap.

If a view can't be split, then both the first and second parameter are `null`.

## -examples

## -see-also
