---
-api-id: T:Windows.Services.Maps.PlaceInfo
-api-type: winrt class
---

<!-- Class syntax.
public class PlaceInfo
-->

# Windows.Services.Maps.PlaceInfo

## -description
Displays a map location and information that describes that location in a light-dismissible window which closes automatically when the user clicks outside of the window.

## -remarks

## -examples
This example shows the location of the Seattle Space Needle below the button that the user clicks to see that location.

```csharp
private void SpaceNeedle_Click(object sender, RoutedEventArgs e)
{
    Geopoint spaceNeedlePoint = new Geopoint
        (new BasicGeoposition { Latitude = 47.6205, Longitude = -122.3493 });

    PlaceInfoCreateOptions options = new PlaceInfoCreateOptions();

    options.DisplayAddress = "400 Broad St, Seattle, WA 98109";
    options.DisplayName = "Seattle Space Needle";

    PlaceInfo spaceNeedlePlace =  PlaceInfo.Create(spaceNeedlePoint, options);

    FrameworkElement targetElement = (FrameworkElement)sender;

    GeneralTransform generalTransform =
        targetElement.TransformToVisual((FrameworkElement)targetElement.Parent);

    Rect rectangle = generalTransform.TransformBounds(new Rect(new Point
        (targetElement.Margin.Left, targetElement.Margin.Top), targetElement.RenderSize));

    spaceNeedlePlace.Show(rectangle, Windows.UI.Popups.Placement.Below);
}
```

## -see-also

## -examples
