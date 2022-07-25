---
-api-id: M:Windows.UI.Xaml.Media.LoadedImageSurface.Close
-api-type: winrt method
---

<!-- Method syntax.
public void LoadedImageSurface.Close()
-->

# Windows.UI.Xaml.Media.LoadedImageSurface.Close


## -description

Disposes of the [LoadedImageSurface](loadedimagesurface.md) and associated resources.



## -remarks

Calling this method will dispose the [LoadedImageSurface](loadedimagesurface.md) reference, however any brushes or surfaces created from the **LoadedImageSurface** that still have active references will 
continue to render unless you explicitly dispose of those as well.

## -see-also

## -examples

In this example, the [CompositionSurfaceBrush](../windows.ui.composition/compositionsurfacebrush.md) will continue to exist even after the 
[LoadedImageSurface](loadedimagesurface.md) has been closed.

```csharp
Compositor compositor = new Compositor();
CompositionSurfaceBrush imageBrush = compositor.CreateSurfaceBrush();

LoadedImageSurface loadedSurface = LoadedImageSurface.StartLoadFromUri(new Uri("ms-appx:///Assets/myPic.jpg"));
loadedSurface.LoadCompleted += Load_Completed;
imageBrush.Surface = loadedSurface;

loadedSurface.Close();
// The imageBrush still exists

```

