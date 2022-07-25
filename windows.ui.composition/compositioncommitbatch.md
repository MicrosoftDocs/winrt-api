---
-api-id: T:Windows.UI.Composition.CompositionCommitBatch
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionCommitBatch : Windows.UI.Composition.CompositionObject, Windows.UI.Composition.ICompositionCommitBatch
-->

# Windows.UI.Composition.CompositionCommitBatch

## -description
A group of active animations or effects.



## -remarks
Represents a group of active animations or effects and triggers a callback when all members of the group have completed. A CompositionCommitBatch is implicitly created but must be retrieved in order declare the completed event. A Commit batch will be implicitly closed at the end of each commit cycle.

For an animation batch type, the callback triggers when the combined delay and duration of the longest animation in the batch has elapsed. For an effect [batch type](compositionbatchtypes.md), the callback triggers when the processing of all the effects in the batch have completed.

The current Commit batch can be retrieved by calling [Compositor.GetCommitBatch](compositor_getcommitbatch_1103907014.md) at any time during the commit cycle. The commit cycle is defined as the time between updates from the compositor. Updates are queued until the system is ready to process the changes and draw bits to the screen. The Commit batch will aggregate all objects within the commit cycle, those before and after [GetCommitBatch](compositor_getcommitbatch_1103907014.md) was called.   The Commit batch is implicitly created on the composition thread, the thread which the compositor is created on. There can only be one compositor per thread hence one Commit batch per thread. A Commit batch must be retrieved in order declare the completed event. A Commit batch will be implicitly closed at the end of each commit cycle and cannot be suspended or resumed, this will result in an error if attempted.

See [Composition Animations Overview](/windows/uwp/composition/composition-animation) for more information on composition batches.

<!--
      <rem><p>There are two types of CompositionBatches, commit batches and scoped batches.</p>
        
        <p>Commit Batch: A batch that is implicitly created during the commit cycle.  
        The batch must be retrieved using <xref targtype="method_winrt" rid="w_ui_comp.compositor_getcommitbatch">Compositor.GetCommitBatch</xref> in order to declare the completed event.  
        A commit batch remains open between commit cycles, and will be implicitly closed at the end of each commit cycle.</p>
        <snippet devlang="csharp" type="code">CompositionCommitBatch commitBatch = Compositor.GetCommitBatch(CompositionBatchTypes.Animation);</snippet>
        
        <p>Scoped Batch: A batch that is explicitly created using <xref targtype="method_winrt" rid="w_ui_comp.compositor_createscopedbatch">Compositor.CreateScopedBatch</xref> and is used to designate specific objects to be included in a single batch.  
        A scoped batch can be created off the composition thread and can only aggregate objects with the thread it is created.</p>
        <snippet devlang="csharp" type="code">CompositionScopedBatch scopedBatch = Compositor.CreateScopedBatch(CompositionBatchTypes.Animation);</snippet>
 
        <p>A Scoped batch must be explicitly closed using <xref targtype="method_winrt" rid="w_ui_comp.compositionscopedbatch_end">End</xref>. </p>
 
        <p>Multiple Scoped batches can be created and can span across commit cycles. This means a Scoped batched can be created in one commit cycle and ended in a later commit cycle. 
        When a CompositionBatch is open and actively collecting objects it is possible to overlap with several other batches.  Batch finish events are orthogonal to one another and are not chained.</p></rem>
      -->

## -examples
Commit Batch

```csharp

private void UsingCommitBatch()
{
  //Create Scoped batch for animations
  CompositionCommitBatch batch =  Compositor.GetCommitBatch(CompositionBatchTypes.Animation);
 
  //Setup completion event 
  batch.Completed += CommitBatchCompleted;
 
  //Setup animations
  Animation1(_target);
}
 
// Creates and defines the key frame animation 
private void Animation1(Visual targetVisual)
{
  var animation1 = _compositor.CreateVector3KeyFrameAnimation();
 
  animation1.InsertKeyFrame(0.0f, new Vector3(100.00f, 100.00f, 0.00f));
  animation1.InsertKeyFrame(0.5f, new Vector3(300.00f, 100.00f, 0.00f));
  animation1.InsertKeyFrame(1.0f, new Vector3(500.00f, 100.00f, 0.00f));
 
  animation1.Duration = TimeSpan.FromMilliseconds(2000);
  targetVisual.StartAnimation("Offset", animation1);
}
 
public void CommitBatchCompleted(object sender, CompositionBatchCompletedEventArgs args)
{
  _root.Children.Remove(_target);
}      
          
```



## -see-also
[Composition Animations Overview](/windows/uwp/composition/composition-animation), [CompositionObject](compositionobject.md), [IClosable](../windows.foundation/iclosable.md), [CompositionScopedBatch](compositionscopedbatch.md)
