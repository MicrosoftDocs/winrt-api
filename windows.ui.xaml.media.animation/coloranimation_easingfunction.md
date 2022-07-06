---
-api-id: P:Windows.UI.Xaml.Media.Animation.ColorAnimation.EasingFunction
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Animation.EasingFunctionBase EasingFunction { get;  set; }
-->

# Windows.UI.Xaml.Media.Animation.ColorAnimation.EasingFunction

## -description
Gets or sets the easing function applied to this animation.



## -xaml-syntax
```xaml
<ColorAnimation>
  <ColorAnimation.EasingFunction>
    singleEasingFunction
  </ColorAnimation.EasingFunction>
</ColorAnimation>

```


## -xaml-values
<dl><dt>singleEasingFunction</dt><dd>singleEasingFunctionA single object element for an easing function type that derives from EasingFunctionBase, for example, &lt;PowerEase/&gt;</dd>
</dl>
## -property-value
The easing function applied to this animation.

## -remarks
Easing functions allow you to apply custom mathematical formulas to your animations. Mathematical operations are often useful to produce animations that simulate real-world physics in a 2-D coordinate system. For example, you may want an object to realistically bounce or behave as though it were on a spring. For a list of easing functions and info on how to use them, see [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations).

## -examples

## -see-also
[Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations), [XAML animation sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20animation%20library%20sample)
