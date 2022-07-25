---
-api-id: T:Windows.UI.Xaml.Media.Animation.EasingFunctionBase
-api-type: winrt class
---

<!-- Class syntax.
public class EasingFunctionBase : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.Media.Animation.IEasingFunctionBase
-->

# Windows.UI.Xaml.Media.Animation.EasingFunctionBase

## -description
Provides the base class for all the easing functions.



## -remarks
EasingFunctionBase is not extensible. It provides base class support for the Windows Runtime easing function classes, for example [ExponentialEase](exponentialease.md). When you call [Ease](easingfunctionbase_ease_1478003980.md) on a Windows Runtime easing function class, you get the specific easing behavior of that easing function class. There may also be properties of the class other than [EasingMode](easingfunctionbase_easingmode.md) that modify the [Ease](easingfunctionbase_ease_1478003980.md) behavior.

Easing functions allow you to apply custom mathematical formulas to your animations. Mathematical operations are often useful to produce animations that simulate real-world physics in a 2-D coordinate system. For example, you may want an object to realistically bounce or behave as though it were on a spring. For a list of easing functions and info on how to use them, see [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations).

### **EasingFunctionBase** derived classes

EasingFunctionBase is the parent class for several immediately derived classes that implement specific easing behaviors for use in an easing key frame:

+ [BackEase](backease.md)
+ [BounceEase](bounceease.md)
+ [CircleEase](circleease.md)
+ [CubicEase](cubicease.md)
+ [ElasticEase](elasticease.md)
+ [ExponentialEase](exponentialease.md)
+ [PowerEase](powerease.md)
+ [QuadraticEase](quadraticease.md)
+ [QuarticEase](quarticease.md)
+ [QuinticEase](quinticease.md)
+ [SineEase](sineease.md)


## -examples

## -see-also
[DependencyObject](../windows.ui.xaml/dependencyobject.md), [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [Key-frame animations and easing function animations](/windows/uwp/graphics/key-frame-and-easing-function-animations), [XAML animation sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/XAML%20animation%20library%20sample)
