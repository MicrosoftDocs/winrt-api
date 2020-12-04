---
-api-id: M:Windows.ApplicationModel.Resources.Core.ResourceMapMapView.Split(Windows.Foundation.Collections.IMapView{System.String,Windows.ApplicationModel.Resources.Core.ResourceMap}@,Windows.Foundation.Collections.IMapView{System.String,Windows.ApplicationModel.Resources.Core.ResourceMap}@)
-api-type: winrt method
---

<!-- Method syntax
public void Split(Windows.Foundation.Collections.IMapView<System.String, Windows.ApplicationModel.Resources.Core.ResourceMap> first, Windows.Foundation.Collections.IMapView<System.String, Windows.ApplicationModel.Resources.Core.ResourceMap> second)
-->

# Windows.ApplicationModel.Resources.Core.ResourceMapMapView.Split

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
