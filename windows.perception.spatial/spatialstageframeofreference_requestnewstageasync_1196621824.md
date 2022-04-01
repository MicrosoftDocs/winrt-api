---
-api-id: M:Windows.Perception.Spatial.SpatialStageFrameOfReference.RequestNewStageAsync
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<SpatialStageFrameOfReference> SpatialStageFrameOfReference.RequestNewStageAsync()
-->

# Windows.Perception.Spatial.SpatialStageFrameOfReference.RequestNewStageAsync


## -description

Shows system UI to guide the user in defining a new stage to replace the current stage.

## -returns

An app may call RequestNewStageAsync if there is no stage defined or if the current stage is insufficient to meet the app's needs, such as not defining movement bounds.

## -remarks

This API must be called from within an ASTA thread (also known as a UI thread).

## -see-also

## -examples

