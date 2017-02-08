---
-api-id: P:Windows.UI.Xaml.Media.Animation.PointAnimation.EasingFunction
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Animation.EasingFunctionBase EasingFunction { get;  set; }
-->

# Windows.UI.Xaml.Media.Animation.PointAnimation.EasingFunction

## -description
Gets or sets the easing function you are applying to the animation.

## -xaml-syntax
```xaml
<PointAnimation>
  <PointAnimation.EasingFunction>
    singleEasingFunction
  </PointAnimation.EasingFunction>
</PointAnimation>
```


## -xaml-values
<dl><dt>singleEasingFunction</dt><dd>singleEasingFunctionA single object element for an easing function type that derives from EasingFunctionBase, for example, &lt;PowerEase/&gt;.</dd>
</dl>
## -property-value
The easing function you are applying to the animation. The default is null.

## -remarks
Easing functions allow you to apply custom mathematical formulas to your animations. Mathematical operations are often useful to produce animations that simulate real-world physics in a 2-D coordinate system. For example, you may want an object to realistically bounce or behave as though it were on a spring. For a list of easing functions and info on how to use them, see [Key-frame animations and easing function animations](http://msdn.microsoft.com/library/d8af24cd-f4c2-4562-afd7-25010955d677).

## -examples

## -see-also
[Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a), [Key-frame animations and easing function animations](http://msdn.microsoft.com/library/d8af24cd-f4c2-4562-afd7-25010955d677), [XAML animation sample](http://go.microsoft.com/fwlink/p/?linkid=238571)