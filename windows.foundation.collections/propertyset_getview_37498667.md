---
-api-id: M:Windows.Foundation.Collections.PropertySet.GetView
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.Collections.IMapView<string, object> GetView()
-->

# Windows.Foundation.Collections.PropertySet.GetView

## -description
Gets an immutable view of the property set.

## -returns
The immutable view.

## -remarks

If changes are made to the map, such as adding, modifying, or deleting elements,
the map view is permitted to raise an exception for all future operations.

## -examples

## -see-also
