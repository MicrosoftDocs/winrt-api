---
-api-id: T:Windows.UI.Composition.Interactions.VisualInteractionSource
-api-type: winrt class
---

<!-- Class syntax.
public class VisualInteractionSource : Windows.UI.Composition.CompositionObject, Windows.UI.Composition.Interactions.ICompositionInteractionSource, Windows.UI.Composition.Interactions.IVisualInteractionSource
-->

# Windows.UI.Composition.Interactions.VisualInteractionSource

## -description
Object for configuring input to the InteractionTracker relative to a visual.

The VisualInteractionSource is designed to be used only with [InteractionTracker](interactiontracker.md) and defines which input will be sent to the [InteractionTracker](interactiontracker.md) to drive its state and properties. This class contains both the visual to be used for hit-testing, as well as a variety of configuration properties for which gestures and types of input will be sent to the [InteractionTracker](interactiontracker.md).



## -remarks
The VisualInteractionSource is used to define important properties about the types of interactions that should drive the InteractionTracker's state and properties. The source property is used both for hit-testing, as well as the coordinate space for gesture detection. As a result, it is important to use a Visual that is not going to be in motion during the manipulation. Multiple VisualInteractionSources can be associated with the same InteractionTracker if there are multiple hit-test regions, but the most common cases require only one VisualInteractionSource for a given InteractionTracker.

VisualInteractionSource is the class for configuring which types of gestures should be considered for driving the InteractionTracker. Position X and Y are associated with horizontal and vertical panning respectively. Scale is detected with a pinch gesture, often associated with zooming. These three source modes are all configurable for touch and Precision Touchpad input. Each of these source modes can be enabled with or without inertia:

* Enabling inertia indicates that position or scale will naturally interpolate from the release velocity to no velocity during the inertia state. 

* Disabling inertia indicates that position or scale velocity will immediately go to 0 upon completion of the interaction. When input that drives position or scale is routed to the InteractionTracker, the InteractionTracker property of the same name will be updated appropriately.

The rails configurations indicate how the gesture will be detected. Rails, by default, is on and indicates that the horizontal or vertical pan will lock to a particular axis when started primarily on that axis. This is explained in more detail on the railing property pages.

The chaining configuration indicates whether input that is processed by one VisualInteractionSource can flow to another entity when the InteractionTracker reaches the min or max in that direction. This configuration will allow input to chain to either another InteractionTracker via another VisualInteractionSource, or to a ScrollViewer if the VisualInteractionSource's source visual is a child of the ScrollViewer.

<!--
     <section><title>Compositor Hit-testing</title>
     
      <sectioncontents>
        <p>The hit-test result used for determining if the manipulation has hit-tested to the VisualInteractionSource's
        source visual will be based on the compositor's hit-testing.  Compositor hit-testing does not always have the same logic as XAML hit-testing,
        so there are cases where results could have a slight discrepancy.  This outlines they key differences that could impact developers.</p>
      </sectioncontents>
    </section>
    -->

<!--
     <section><title>Irregular Shapes</title>
      <sectioncontents><p>The compositor can only hit-test within a bounding box.  Irregular shapes will therefore not be hit-tested. 
      The impact of this should be minimal as long as there is a parent-child relationship because the compositor will have a larger
      hit-test region than the application.  At the point the app is choosing to call "TryRedirectForManipulation"
      they should have already determined that the desired behavior.  If visuals are siblings, then the scenario below presents a problem. 
      In the scenario below, the app would call TryRedirectForManipulation on a PointerPressed at P1.
      If V2 is a child of V1, then system manipulation would take over as expected. 
      If V1 and V2 are siblings, then the compositor would not take over the manipulation since
      it will only manipulate when V1 or a child is hit-tested.</p>
      </sectioncontents>
    </section>
    -->

<!--
     <section>
       <title>Visual Tree Structure Reliance</title>
       <sectioncontents>
         <p>In the scenario below, we show an InteractionTracker visually placed on top of a SwapChainPanel.  
         In this case, the two are siblings.  If the user touches down on the InteractionTracker, input will go to the UI thread.
         There is no way for this input to fall through to the SwapChainPanel.  </p>
       </sectioncontents>
    </section>
    -->

<!--
     <section><title>Additional Limitations</title>
      <sectioncontents>
        <p>In addition to the scenarios described about there are some other differences between XAML and Compositor hit-test logic.</p>
        <list>
          <item>IsHit-testVisible = false is not always propagated from XAML to compositor</item>
          <item>Compositor hit-tests the bounds of swapchain not only the image portion</item>
          <item>ContainerVisuals do not Hit-test – it is recommended not to use this type of visual when creating your InteractionSource</item>
          <item>SpriteVisual will hit test within the rectangular bounds with most brushes. In the case where a SurfaceBrush is applied, the system will Hit-test the surface and respect stretch and transform changes</item>
        </list>
    </sectioncontents>
</section>
-->

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | ConfigureCenterPointXModifiers |
| 1703 | 15063 | ConfigureCenterPointYModifiers |
| 1703 | 15063 | ConfigureDeltaPositionXModifiers |
| 1703 | 15063 | ConfigureDeltaPositionYModifiers |
| 1703 | 15063 | ConfigureDeltaScaleModifiers |
| 1703 | 15063 | DeltaPosition |
| 1703 | 15063 | DeltaScale |
| 1703 | 15063 | Position |
| 1703 | 15063 | PositionVelocity |
| 1703 | 15063 | Scale |
| 1703 | 15063 | ScaleVelocity |
| 1809 | 17763 | PointerWheelConfig |
| 1903 | 18362 | CreateFromIVisualElement |

## -examples
```csharp

void SetupSimpleInteractionTracker(Visual viewportVisual, Visual contentVisual)
{
  //
  // Create the InteractionTracker and set its min/max position and scale.  These could 
  // also be bound to expressions.  Note: The scrollable area can be changed from either 
  // end to facilitate content updates/virtualization.
  //
 
  _tracker = InteractionTracker.Create(_compositor);
 
  _tracker.MaxPosition = new Vector3(
    contentVisual.Size.X - viewportVisual.Size.X,
    contentVisual.Size.Y - viewportVisual.Size.Y,
    0.0f);
 
  _tracker.MinScale = 0.5f;
  _tracker.MaxScale = 4.0f;
 
 
  //
  // Configure the interaction source.  Enable input with inertia on all axis.
  //
 
  var interactionSource = VisualInteractionSource.Create(viewportVisual);
 
  interactionSource.PositionXSourceMode = InteractionSourceMode.EnabledWithInertia;
  interactionSource.PositionYSourceMode = InteractionSourceMode.EnabledWithInertia;
  interactionSource.ScaleSourceMode = InteractionSourceMode.EnabledWithInertia;
 
  _tracker.InteractionSources.Add(interactionSource);
 
 
  //
  // Bind the InteractionTracker outputs to the contentVisual.
  //
 
  var positionExpression = _compositor.CreateExpressionAnimation("-tracker.Position");
  positionExpression.SetReferenceParameter("tracker", _tracker);
 
  contentVisual.StartAnimation("Offset", positionExpression);
 
 
  var scaleExpression = _compositor.CreateExpressionAnimation("Vector3(tracker.Scale, tracker.Scale, 1.0)");
 
  scaleExpression.SetReferenceParameter("tracker", _tracker);
 
  contentVisual.StartAnimation("Scale", scaleExpression);
}
         
         
```



## -see-also
[CompositionObject](../windows.ui.composition/compositionobject.md), [IClosable](../windows.foundation/iclosable.md), [ICompositionInteractionSource](icompositioninteractionsource.md)
