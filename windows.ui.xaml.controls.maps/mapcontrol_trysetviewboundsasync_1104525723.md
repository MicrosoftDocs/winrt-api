---
-api-id: M:Windows.UI.Xaml.Controls.Maps.MapControl.TrySetViewBoundsAsync(Windows.Devices.Geolocation.GeoboundingBox,Windows.Foundation.IReference{Windows.UI.Xaml.Thickness},Windows.UI.Xaml.Controls.Maps.MapAnimationKind)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<bool> TrySetViewBoundsAsync(Windows.Devices.Geolocation.GeoboundingBox bounds, Windows.Foundation.IReference<Windows.UI.Xaml.Thickness> margin, Windows.UI.Xaml.Controls.Maps.MapAnimationKind animation)
-->

# Windows.UI.Xaml.Controls.Maps.MapControl.TrySetViewBoundsAsync

## -description
Sets the view of the map displayed in the [MapControl](mapcontrol.md) to the contents of the specified [GeoboundingBox](../windows.devices.geolocation/geoboundingbox.md) with the specified margin. The view change uses the specified animation.

## -parameters
### -param bounds
The geographic area to display in the view.

### -param margin
The margin to use in the view.

### -param animation
The animation to use when changing the view. For more info, see [MapAnimationKind](mapanimationkind.md).

## -returns
**true** if the asynchronous operation succeeded; otherwise, **false**.

## -remarks
If the area specified by the [GeoboundingBox](../windows.devices.geolocation/geoboundingbox.md) doesn't fill the [MapControl](mapcontrol.md), the control also displays the surrounding area outside the [GeoboundingBox](../windows.devices.geolocation/geoboundingbox.md).

## -examples

## -see-also
[Display maps with 2D, 3D, and Streetside views](/windows/uwp/maps-and-location/display-maps)
