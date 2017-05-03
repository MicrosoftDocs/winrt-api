---
-api-id: M:Windows.UI.Input.Inking.InkManager.ProcessPointerDown(Windows.UI.Input.PointerPoint)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public void ProcessPointerDown(Windows.UI.Input.PointerPoint pointerPoint)
-->

# Windows.UI.Input.Inking.InkManager.ProcessPointerDown

## -description
> [!NOTE]
> For Universal Windows app using Extensible Application Markup Language (XAML), we recommend using [InkPresenter](inkpresenter.md) and the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control instead of [InkManager](inkmanager.md).

Processes information about the position and features of the contact point, like pressure and tilt, on initial down contact. You must call this method before you call [ProcessPointerUpdate](inkmanager_processpointerupdate.md), and then [ProcessPointerUp.](inkmanager_processpointerdown.md)

> [!IMPORTANT]
> This method is not supported in desktop apps.

## -parameters
### -param pointerPoint
Information about the position and features of the contact point.

## -remarks

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)