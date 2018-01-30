---
-api-id: M:Windows.UI.Input.Inking.InkManager.ProcessPointerUpdate(Windows.UI.Input.PointerPoint)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public object ProcessPointerUpdate(Windows.UI.Input.PointerPoint pointerPoint)
-->

# Windows.UI.Input.Inking.InkManager.ProcessPointerUpdate

## -description
> [!NOTE]
> For Universal Windows app using Extensible Application Markup Language (XAML), we recommend using [InkPresenter](inkpresenter.md) and the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control instead of [InkManager](inkmanager.md).

Processes position and state properties, such as pressure and tilt, for the specified pointer, from the last pointer event up to and including the current pointer event.Call this method after [ProcessPointerDown](inkmanager_processpointerdown.md) and before [ProcessPointerUp](inkmanager_processpointerup.md).

> [!IMPORTANT]
> This method is not supported in desktop apps.

## -parameters
### -param pointerPoint
The input pointer for which updates are to be processed.

## -returns
When the current [InkManipulationMode](inkmanipulationmode.md) is **Inking** or **Selecting**, this method returns the [Point](../windows.foundation/point.md) (screen position in ink space) associated with the last [ProcessPointerUpdate](inkmanager_processpointerupdate.md) of *pointerPoint*.

## -remarks

## -examples
The following example demonstrates a handler for a [PointerMoved](..\windows.ui.xaml\uielement_pointermoved.md) event on an InkCanvas.

Here, the intermediate points (`intermediatePoints`) unprocessed since the last update are processed by the [InkManager](inkmanager.md) (`inkManager`) in the [ProcessPointerUpdate](inkmanager_processpointerupdate.md) call.

```csharp
void InkingArea_PointerMoved(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
{
    var pointerPoint = e.GetCurrentPoint(InkingArea);

    if (pointerId == (int)pointerPoint.PointerId)
    {
        switch (inkManager.Mode)
        {
            case Windows.UI.Input.Inking.InkManipulationMode.Erasing:
                // Check if something has been erased.
                // In erase mode, ProcessPointerUpdate returns an 
                // `invalidateRect` (if it is not degenerate something 
                // has been erased). In erase mode we don't bother processing 
                // intermediate points.
                var invalidateRect = 
                    (Windows.Foundation.Rect)inkManager.ProcessPointerUpdate(
                        e.GetCurrentPoint(InkingArea));
                if (invalidateRect.Height != 0 && invalidateRect.Width != 0)
                {
                    // We don't know what has been erased so we clear the render
                    // and add back all the ink saved in the ink manager.
                    renderer.Clear();
                    renderer.AddInk(inkManager.GetStrokes());
                }
                break;

            case Windows.UI.Input.Inking.InkManipulationMode.Inking:
            case Windows.UI.Input.Inking.InkManipulationMode.Selecting:
                // Process intermediate points.
                var intermediatePoints = e.GetIntermediatePoints(InkingArea);
                for (int i = intermediatePoints.Count - 1; i >= 0; i--)
                {
                    inkManager.ProcessPointerUpdate(intermediatePoints[i]);
                }

                // Live rendering.
                renderer.UpdateLiveRender(pointerPoint);
                break;
        }
    }
}
```

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)