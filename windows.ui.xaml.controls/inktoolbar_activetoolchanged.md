---
-api-id: E:Windows.UI.Xaml.Controls.InkToolbar.ActiveToolChanged
-api-type: winrt event
---

<!-- Event syntax
public event Windows.Foundation.TypedEventHandler ActiveToolChanged<Windows.UI.Xaml.Controls.InkToolbar,  object>
-->

# Windows.UI.Xaml.Controls.InkToolbar.ActiveToolChanged

## -description
Occurs when the currently selected feature in the [RadioButton](radiobutton.md) group of the [InkToolbar](inktoolbar.md) is changed.
This event provides access to the following objects:

+ [InkToolbarBallpointPenButton](inktoolbarballpointpenbutton.md)
+ [InkToolbarPencilButton](inktoolbarpencilbutton.md)
+ [InkToolbarEraserButton](inktoolbareraserbutton.md)
+ [InkToolbarHighlighterButton](inktoolbarhighlighterbutton.md)
+ [InkToolbarCustomPenButton](inktoolbarcustompenbutton.md)
+ [InkToolbarCustomToolButton](inktoolbarcustomtoolbutton.md)


Features in this group are mutually exclusive: selecting a feature deselects the currently active feature.

> [!NOTE]
> [InkToolbarRulerButton](inktoolbarrulerbutton.md) and [InkToolbarCustomToggleButton](inktoolbarcustomtogglebutton.md) objects work in conjunction with the active feature and are not exposed to the [ActiveToolChanged](inktoolbar_activetoolchanged.md) event.

## -remarks

## -examples

## -see-also
