---
-api-id: M:Windows.UI.Input.Inking.Preview.PalmRejectionDelayZonePreview.CreateForVisual(Windows.UI.Composition.Visual,Windows.Foundation.Rect)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public PalmRejectionDelayZonePreview PalmRejectionDelayZonePreview.CreateForVisual(Visual inputPanelVisual, Rect inputPanelRect)
-->

# Windows.UI.Input.Inking.Preview.PalmRejectionDelayZonePreview.CreateForVisual

## -description

Creates a palm rejection region based on the specified inking panel.

## -parameters

### -param inputPanelVisual

The visual object associated with the inking panel.

### -param inputPanelRect

The region where palm rejection is to be enabled, relative to the coordinate space of the *inputPanelVisual*.

## -returns

Returns the palm rejection region.

## -remarks

Use [PalmRejectionDelayZonePreview.CreateForVisual(Visual inputPanelVisual, Rect inputPanelRect, Visual viewportVisual, Rect viewportRect)](palmrejectiondelayzonepreview_createforvisual_1317285844.md) if you need to specify an enclosing viewport for your inking region.

If *inputPanelRect* changes, you must call [PalmRejectionDelayZonePreview.Dispose](/uwp/api/windows.ui.input.inking.preview.palmrejectiondelayzonepreview.dispose) to release the [PalmRejectionDelayZonePreview](palmrejectiondelayzonepreview.md) object and then call [CreateForVisual](/uwp/api/windows.ui.input.inking.preview.palmrejectiondelayzonepreview.createforvisual) with the updated rect to create a new palm rejection region.

## -see-also

## -examples
