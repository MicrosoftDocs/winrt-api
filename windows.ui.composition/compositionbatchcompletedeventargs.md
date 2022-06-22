---
-api-id: T:Windows.UI.Composition.CompositionBatchCompletedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionBatchCompletedEventArgs : Windows.UI.Composition.CompositionObject, Windows.UI.Composition.ICompositionBatchCompletedEventArgs
-->

# Windows.UI.Composition.CompositionBatchCompletedEventArgs

## -description
Arguments for the [CompositionCommitBatch.Completed](compositioncommitbatch_completed.md) or [CompositionScopedBatch.Completed](compositionscopedbatch_completed.md) events.



## -remarks

## -examples


```csharp

        private void CreateVisuals_Click(object sender, RoutedEventArgs e)
        {
            //Create Scoped batch for animations
            _batch = _compositor.CreateScopedBatch(CompositionBatchTypes.Animation);
 
            //Setup completion event 
            _batch.Completed += ScopedBatchCompleted;
            
           
            //Setup animations
            Animation1(_target);
            
            _batch.End()
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
 
        public void ScopedBatchCompleted(object sender, 
            CompositionBatchCompletedEventArgs args)
        {
            _root.Children.Remove(_target);
        }      
    }
          
          
```



## -see-also
[Composition Animations Overview](/windows/uwp/composition/composition-animation), [CompositionObject](compositionobject.md), [IClosable](../windows.foundation/iclosable.md)
