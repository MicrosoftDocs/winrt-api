---
-api-id: M:Windows.UI.Input.Inking.Preview.PalmRejectionDelayZonePreview.CreateForVisual(Windows.UI.Composition.Visual,Windows.Foundation.Rect,Windows.UI.Composition.Visual,Windows.Foundation.Rect)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public PalmRejectionDelayZonePreview PalmRejectionDelayZonePreview.CreateForVisual(Visual inputPanelVisual, Rect inputPanelRect, Visual viewportVisual, Rect viewportRect)
-->

# Windows.UI.Input.Inking.Preview.PalmRejectionDelayZonePreview.CreateForVisual

## -description

Creates a palm rejection region based on the specified inking panel and viewport.

## -parameters

### -param inputPanelVisual

The visual object associated with the inking panel.

### -param inputPanelRect

The region where palm rejection is to be enabled, relative to the coordinate space of the *inputPanelVisual*.

### -param viewportVisual

The visual object associated with the viewport within which *inputPanelVisual* is located.

### -param viewportRect

The viewport that contains the region where palm rejection is to be enabled, relative to the coordinate space of the *viewportVisual*.

## -returns

Returns a PalmRejectionDelayZonePreview object.

## -remarks

Palm rejection for the specified inking region is deactivated if the region is scrolled out of view within the specified viewport. Palm rejection is automatically reactivated when the region is scrolled back into view.

Use [PalmRejectionDelayZonePreview.CreateForVisual(Visual inputPanelVisual, Rect inputPanelRect)](palmrejectiondelayzonepreview_createforvisual_1931711328.md) if you do not need to specify an enclosing viewport for your inking region.

If either *viewportRect* or *inputPanelRect* changes, you must call [PalmRejectionDelayZonePreview.Dispose](/uwp/api/windows.ui.input.inking.preview.palmrejectiondelayzonepreview.dispose) to release the [PalmRejectionDelayZonePreview](palmrejectiondelayzonepreview.md) object and then call [CreateForVisual](/uwp/api/windows.ui.input.inking.preview.palmrejectiondelayzonepreview.createforvisual) with the updated rectangles to create a new palm rejection region.

## -see-also

## -examples
