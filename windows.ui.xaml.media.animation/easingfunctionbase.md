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
[EasingFunctionBase](easingfunctionbase.md) is not extensible. It provides base class support for the Windows Runtime easing function classes, for example [ExponentialEase](exponentialease.md). When you call [Ease](easingfunctionbase_ease_1478003980.md) on a Windows Runtime easing function class, you get the specific easing behavior of that easing function class. There may also be properties of the class other than [EasingMode](easingfunctionbase_easingmode.md) that modify the [Ease](easingfunctionbase_ease_1478003980.md) behavior.

Easing functions allow you to apply custom mathematical formulas to your animations. Mathematical operations are often useful to produce animations that simulate real-world physics in a 2-D coordinate system. For example, you may want an object to realistically bounce or behave as though it were on a spring. For a list of easing functions and info on how to use them, see [Key-frame animations and easing function animations](https://msdn.microsoft.com/library/d8af24cd-f4c2-4562-afd7-25010955d677).

### **EasingFunctionBase** derived classes

[EasingFunctionBase](easingfunctionbase.md) is the parent class for several immediately derived classes that implement specific easing behaviors for use in an easing key frame:

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
[DependencyObject](../windows.ui.xaml/dependencyobject.md), [Storyboarded animations](https://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a), [Key-frame animations and easing function animations](https://msdn.microsoft.com/library/d8af24cd-f4c2-4562-afd7-25010955d677), [XAML animation sample](https://go.microsoft.com/fwlink/p/?linkid=238571)
