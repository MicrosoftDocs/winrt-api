---
-api-id: M:Windows.UI.Xaml.Controls.ListViewBase.TryStartConnectedAnimationAsync(Windows.UI.Xaml.Media.Animation.ConnectedAnimation,System.Object,System.String)
-api-type: winrt method
---

<!-- Method syntax.
public IAsyncOperation<bool> ListViewBase.TryStartConnectedAnimationAsync(ConnectedAnimation animation, Object item, String elementName)
-->

# Windows.UI.Xaml.Controls.ListViewBase.TryStartConnectedAnimationAsync

## -description
Attempts to start the animation.



## -parameters
## -param animation
The animation to start.

### -param item
The data item that is animated into view.

### -param elementName
The name of the element in the ItemTemplate that provides the animated visual.

## -returns
**true** if the animation started; **false** if the animation has already been started, if it is no longer active, or if the destination element is the same as the source element.

## -remarks

## -see-also
[ConnectedAnimation.TryStart](./../windows.ui.xaml.media.animation/connectedanimation_trystart_323048605.md)

## -examples

