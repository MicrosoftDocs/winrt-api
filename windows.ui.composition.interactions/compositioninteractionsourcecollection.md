---
-api-id: T:Windows.UI.Composition.Interactions.CompositionInteractionSourceCollection
-api-type: winrt class
---

<!-- Class syntax.
public class CompositionInteractionSourceCollection : Windows.UI.Composition.CompositionObject, Windows.Foundation.Collections.IIterable<Windows.UI.Composition.Interactions.ICompositionInteractionSource>, Windows.UI.Composition.Interactions.ICompositionInteractionSourceCollection
-->

# Windows.UI.Composition.Interactions.CompositionInteractionSourceCollection

## -description
A collection of interaction sources.

This is the collection of interaction sources that are associated with a given [InteractionTracker](interactiontracker.md). The only valid member of this collection is a [VisualInteractionSource](visualinteractionsource.md). Each [VisualInteractionSource](visualinteractionsource.md) needs to have a unique hit-test (source) visual. Each [VisualInteractionSource](visualinteractionsource.md) will be configured individually for the desired input to be sent to the [InteractionTracker](interactiontracker.md).



## -remarks
While multiple CompositionInteractionSources can be added to the same CompositionInteractionSourceCollection the most common case is to only have one member in this collection. Multiple can be used if multiple hit-test regions should drive the same [InteractionTracker](interactiontracker.md). If multiple source visuals are hit-test at the same time the visual tree hierarchy will determine which one takes precedence. If any common parent contains more hit-test contacts than a single child, the input will be promoted to that parent.

## -examples


```csharp

void SetupMultipleSourceInteractionTracker(Visual horizontalVisual, Visual verticalVisual, Visual contentVisual)
{
  //
  // Create the InteractionTracker and set its min/max position.  These could 
  // also be bound to expressions.  Note: The scrollable area can be changed from either 
  // end to facilitate content updates/virtualization.
  //
 
  _tracker = InteractionTracker.Create(_compositor);
 
  _tracker.MaxPosition = new Vector3(
    contentVisual.Size.X - viewportVisual.Size.X,
    contentVisual.Size.Y - viewportVisual.Size.Y,
    0.0f);
 
 
  //
  // Configure the two interaction sources.  Enable input with inertia.  
  //
 
  var interactionSource1 = VisualInteractionSource.Create(horizontalVisual);
  var interactionSource2 = VisualInteractionSource.Create(verticalVisual);
 
  interactionSource1.PositionXSourceMode = 
  InteractionSourceMode.EnabledWithInertia; 

  interactionSource2.PositionYSourceMode = 
  InteractionSourceMode.EnabledWithInertia;


  _tracker.InteractionSources.Add(interactionSource1);
  _tracker.InteractionSources.Add(interactionSource2);
 
 
  //
  // Bind the InteractionTracker outputs to the contentVisual.
  //
 
  var positionExpression = _compositor.CreateExpressionAnimation("- tracker.Position");
  positionExpression.SetReferenceParameter("tracker", _tracker);
 
  contentVisual.StartAnimation("Offset", positionExpression);
}
         
         
```



## -see-also
[CompositionObject](../windows.ui.composition/compositionobject.md), [IClosable](../windows.foundation/iclosable.md), [IIterable(ICompositionInteractionSource)](../windows.foundation.collections/iiterable_1.md)
