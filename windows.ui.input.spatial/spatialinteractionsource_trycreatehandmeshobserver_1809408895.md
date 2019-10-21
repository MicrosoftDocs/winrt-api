---
-api-id: M:Windows.UI.Input.Spatial.SpatialInteractionSource.TryCreateHandMeshObserver
-api-type: winrt method
ms.custom: 19H1
---

<!-- Method syntax.
public HandMeshObserver SpatialInteractionSource.TryCreateHandMeshObserver()
-->

# Windows.UI.Input.Spatial.SpatialInteractionSource.TryCreateHandMeshObserver

## -description

Synchronously requests a [HandMeshObserver](../windows.perception.people/handmeshobserver.md) to provide mesh updates for each frame that tracks the detected shape of a hand.

## -returns

A hand mesh observer if this source supports hand meshes; otherwise, null.

## -remarks

It can take more than a frame to initialize the app's subscription to hand mesh updates.  

You should call this synchronous method only from a background thread. If you are calling from a UI thread, render thread or update thread, you should call the asynchronous [TryCreateHandMeshObserverAsync](spatialinteractionsource_trycreatehandmeshobserverasync_89275821.md) method instead.

## -see-also

## -examples
