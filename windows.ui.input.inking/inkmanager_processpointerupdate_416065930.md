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
The following example demonstrates a handler for an [onmspointermove](XREF:TODO:wwa.HTMLElement_onmspointermove) event.

Here, the unprocessed intermediate points (`pts`) since the last update are processed by the [InkManager](inkmanager.md) (`inkManager`) in the call to [ProcessPointerUpdate](inkmanager_processpointerupdate.md).

```
function handlePointerMove(evt)
{
    try
    {
        evt.preventManipulation();
        if (evt.pointerId === penID)
        {
            var pt = evt.currentPoint;
            context.lineTo(pt.rawPosition.x, pt.rawPosition.y);
            context.stroke();
            var pts = evt.intermediatePoints;
            var i;
            for (i = pts.length - 1; i >= 0 ; i--)
            {
                inkManager.processPointerUpdate(pts[i]);
            }
        }
    }
    catch (e)
    {
        displayError("handlePointerMove " + e.toString());
    }
}
```

For the complete example, see [Ink App sample](http://go.microsoft.com/fwlink/p/?linkid=231622).

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)