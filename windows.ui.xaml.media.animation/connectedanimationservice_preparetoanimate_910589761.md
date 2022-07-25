---
-api-id: M:Windows.UI.Xaml.Media.Animation.ConnectedAnimationService.PrepareToAnimate(System.String,Windows.UI.Xaml.UIElement)
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Xaml.Media.Animation.ConnectedAnimation PrepareToAnimate(System.String key, Windows.UI.Xaml.UIElement source)
-->

# Windows.UI.Xaml.Media.Animation.ConnectedAnimationService.PrepareToAnimate

## -description
Returns a connected animation that's associated with the specified key and source element.



## -parameters
### -param key
The key for the animation.

### -param source
The element that is animated out of view.

## -returns
The animation with the specified key.

## -remarks
When you call PrepareToAnimate, you supply a key to associate with the newly created [ConnectedAnimation](connectedanimation.md) returned by the method. You can later use this key to retrieve the same animation by calling [GetAnimation](connectedanimationservice_getanimation_1121981282.md). This lets you connect the animation between two different pages without having to manually pass the reference to the [ConnectedAnimation](connectedanimation.md) object between pages.

## -examples

## -see-also
