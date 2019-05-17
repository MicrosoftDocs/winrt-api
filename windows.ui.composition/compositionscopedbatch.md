---
-api-id: T:Windows.UI.Composition.CompositionScopedBatch
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionScopedBatch : Windows.UI.Composition.CompositionObject, Windows.UI.Composition.ICompositionScopedBatch
-->

# Windows.UI.Composition.CompositionScopedBatch

## -description
An explicitly created group of active animations or effects.

## -remarks
Represents a group of active animations or effects and triggers a callback when all members of the group have completed. A CompositionScopedBatch is explicitly created and is used to designate specific objects to be included in a single Scoped batch.

A scoped batch is explicitly created using [Compositor.CreateScopedBatch](compositor_createscopedbatch_706133524.md) and is used to designate specific objects to be included in a single batch. A Scoped batch can be created on any thread and is not tied to the composition thread. Scoped batches will only aggregate objects within the thread it is created.

   CompositionScopedBatch may be explicitly paused with [Suspend](compositionscopedbatch_suspend_1316139061.md) in order to exclude objects from that batch. When a batch is suspended it can be reopened by calling [Resume](compositionscopedbatch_resume_406343050.md).

   A CompositionScopedBatch must be explicitly closed using [End](compositionscopedbatch_end_1028829999.md). Once it has been closed it cannot be suspended or resumed again.

   Multiple CompositionScopedBatch instances can be created and objects can be aggregated in multiple batches at the same time.

See [Composition Animations Overview](https://go.microsoft.com/fwlink/p/?LinkID=692060) for more information on composition batches.

## -examples
Scoped Batch

```csharp

// The Green Square's completion events for the Offset and Opacity animations are aggregated
// The Rotation animation completion event is not aggregated
// When the aggregated events are completed OnBatchCompleted method is executed
public void BatchAnimations()
{
    // Create a Scoped batch to capture animation completion events
    _batch = _compositor.CreateScopedBatch(CompositionBatchTypes.Animation);

    // Executing the Offset animation and aggregating completion event
    ApplyOffsetAnimation(_greenSquare);

    // Suspending to exclude the following Rotation animation from the batch
    _batch.Suspend();

    // Executing the Rotation animation 
    ApplyRotationAnimation(_greenSquare);

    // Resuming the batch to collect additional animations
    _batch.Resume();

    // Executing the Opacity animation and aggregating completion event
    ApplyOpacityAnimation(_greenSquare);

    // Batch is ended and no objects can be added
    _batch.End();

    // Method triggered when batch completion event fires
    _batch.Completed += OnBatchCompleted;
}
          
```



## -see-also
[Composition Animations Overview](https://go.microsoft.com/fwlink/p/?LinkID=692060), [CompositionObject](compositionobject.md), [IClosable](../windows.foundation/iclosable.md)
