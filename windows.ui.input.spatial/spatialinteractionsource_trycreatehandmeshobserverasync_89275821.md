---
-api-id: M:Windows.UI.Input.Spatial.SpatialInteractionSource.TryCreateHandMeshObserverAsync
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public IAsyncOperation<HandMeshObserver> SpatialInteractionSource.TryCreateHandMeshObserverAsync()
-->

# Windows.UI.Input.Spatial.SpatialInteractionSource.TryCreateHandMeshObserverAsync

## -description

Requests a [HandMeshObserver](../windows.perception.people/handmeshobserver.md) to provide mesh updates for each frame that tracks the detected shape of a hand.

## -returns

An operation that triggers with a hand mesh observer (if this source supports hand meshes); otherwise, an operation that returns null.

## -remarks

It can take more than a frame to initialize the app's subscription to hand mesh updates.

## -see-also

## -examples
