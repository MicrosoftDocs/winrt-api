---
-api-id: M:Windows.Services.Maps.PlaceInfo.Show(Windows.Foundation.Rect)
-api-type: winrt method
---

<!-- Method syntax.
public void PlaceInfo.Show(Rect selection)
-->

# Windows.Services.Maps.PlaceInfo.Show

## -description
Shows in a pop-up window, the map location and related information that is described in the [PlaceInfo](placeinfo.md).

## -parameters
### -param selection
The [Rect](../windows.foundation/rect.md) is the rectangular area of user selection (for example, pressing a button), around which the operating system displays the light-dismissible window, not within that rectangular area. For example, if an app uses a button to show the place, pass the [Rect](../windows.foundation/rect.md) of the button so the light-dismissible window displays around the button, not overlapping it.

## -remarks
This method closes any place card UIs that are already visible.

## -see-also

## -examples
