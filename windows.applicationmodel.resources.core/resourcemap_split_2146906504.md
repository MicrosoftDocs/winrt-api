---
-api-id: M:Windows.ApplicationModel.Resources.Core.ResourceMap.Split(Windows.Foundation.Collections.IMapView{System.String,Windows.ApplicationModel.Resources.Core.NamedResource}@,Windows.Foundation.Collections.IMapView{System.String,Windows.ApplicationModel.Resources.Core.NamedResource}@)
-api-type: winrt method
---

<!-- Method syntax
public void Split(Windows.Foundation.Collections.IMapView<System.String, Windows.ApplicationModel.Resources.Core.NamedResource> first, Windows.Foundation.Collections.IMapView<System.String, Windows.ApplicationModel.Resources.Core.NamedResource> second)
-->

# Windows.ApplicationModel.Resources.Core.ResourceMap.Split

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
