---
-api-id: M:Windows.UI.Xaml.Hosting.ElementCompositionPreview.SetImplicitShowAnimation(Windows.UI.Xaml.UIElement,Windows.UI.Composition.ICompositionAnimationBase)
-api-type: winrt method
---

<!-- Method syntax.
public void ElementCompositionPreview.SetImplicitShowAnimation(UIElement element, ICompositionAnimationBase animation)
-->

# Windows.UI.Xaml.Hosting.ElementCompositionPreview.SetImplicitShowAnimation

## -description

Associates the specified show animation with a UIElement.



## -parameters

### -param element

The UIElement to associate the animation with.

### -param animation

The animation to play when the UIElement is shown. A **Null** value prevents show animations from playing for this element until the method is called again with an animation value.

## -remarks

When an element is added to the scene or its **Visibility** property becomes **Visibility.Visible**, the element and all of its descendents in the UI tree will play their show animations.

## -see-also

## -examples

