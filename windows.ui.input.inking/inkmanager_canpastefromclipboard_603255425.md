---
-api-id: M:Windows.UI.Input.Inking.InkManager.CanPasteFromClipboard
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public bool CanPasteFromClipboard()
-->

# Windows.UI.Input.Inking.InkManager.CanPasteFromClipboard

## -description
> [!NOTE]
> For Universal Windows app using Extensible Application Markup Language (XAML), we recommend using [InkPresenter](inkpresenter.md) and the [InkCanvas](../windows.ui.xaml.controls/inkcanvas.md) control instead of [InkManager](inkmanager.md).

Identifies whether content on the clipboard can be added to the [InkStroke](inkstroke.md) collection that is managed by the [InkManager](inkmanager.md).

> [!NOTE]
> Clipboard content must be in Ink Serialized Format (ISF).

## -returns
True if content can be pasted from the clipboard; otherwise, false.

## -remarks

## -examples

## -see-also
[Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43), [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)