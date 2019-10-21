---
-api-id: T:Windows.Perception.People.HandMeshObserver
-api-type: winrt class
ms.custom: 19H1
---

<!-- Class syntax.
public class HandMeshObserver 
-->

# Windows.Perception.People.HandMeshObserver

## -description
Provides mesh updates each frame that track the detected shape of a hand.

## -remarks
Creating a **HandMeshObserver** subscribes you to hand mesh updates for a given [SpatialInteractionSource](../windows.ui.input.spatial/spatialinteractionsource.md) that tracks the detected shape of that hand.

When users are directly interacting with virtual objects with their hands, you may wish to render a visualization of the hands to increase the user's confidence in their interactions.  By creating a **HandMeshObserver**, you can get a fixed index buffer for the hand up front by calling [GetTriangleIndices](handmeshobserver_gettriangleindices_2079708971.md), and then an updated vertex buffer each frame by calling [GetVertexStateForPose](handmeshobserver_getvertexstateforpose_1608128188.md).  With these buffers, you can render a live visualization of the user's hand.

The hand mesh's index buffer will not change for the lifetime of the **HandMeshObserver**.  The hand mesh's vertex buffer contents will be updated each frame, while the vertex count will not.  You can therefore refill the same vertex buffer every frame.

You create a **HandMeshObserver** for a given interaction source by calling [SpatialInteractionSource.TryCreateHandMeshObserverAsync](../windows.ui.input.spatial/spatialinteractionsource_trycreatehandmeshobserverasync_89275821.md) or [SpatialInteractionSource.TryCreateHandMeshObserver](../windows.ui.input.spatial/spatialinteractionsource_trycreatehandmeshobserver_1809408895.md).  It can take more than a frame to initialize the app's subscription to hand mesh updates.  You should only call the synchronous version of the method from a background thread.  If you are calling from a UI thread, render thread or update thread, you should call the asynchronous version instead.

## -see-also
To render your own articulating hand model or to do physics-based interactions with the joints of the hand, see [HandPose](handpose.md).

## -examples

