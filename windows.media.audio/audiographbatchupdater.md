---
-api-id: T:Windows.Media.Audio.AudioGraphBatchUpdater
-api-type: winrt class
---

<!-- Class syntax.
public class AudioGraphBatchUpdater : Windows.Foundation.IClosable
-->

# Windows.Media.Audio.AudioGraphBatchUpdater

## -description
An object that, upon creation with [CreateBatchUpdater](audiograph_createbatchupdater.md), causes all subsequent modifications to all nodes in an [AudioGraph](audiograph.md) to be accumulated and then committed once your app closes or disposes of the batch updater object.

## -remarks
Get an instance of this class by calling [AudioGraph.CreateBatchUpdater](audiograph_createbatchupdater.md).

## -examples

## -see-also
[IClosable](../windows.foundation/iclosable.md)
## -capabilities
backgroundMediaRecording
