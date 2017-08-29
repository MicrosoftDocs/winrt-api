---
-api-id: M:Windows.UI.Input.Spatial.SpatialInteractionController.TryGetRenderableModelAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<IRandomAccessStreamWithContentType> SpatialInteractionController.TryGetRenderableModelAsync()
-->

# Windows.UI.Input.Spatial.SpatialInteractionController.TryGetRenderableModelAsync

## -description
Gets a renderable model stream for this controller, which can be unpacked and rendered to represent this controller.

## -returns
Operation that triggers once the renderable model stream is loaded, yielding the stream or null if there is no model available.

## -remarks
The model stream is returned as a glTF 2.0 Core binary file.  Apps may articulate the model to match the motion of the controller's component parts by updating the transforms of the nodes in the model's internal hierarchy.

## -see-also

## -examples

