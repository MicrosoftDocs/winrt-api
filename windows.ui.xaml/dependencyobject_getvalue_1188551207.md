---
-api-id: M:Windows.UI.Xaml.DependencyObject.GetValue(Windows.UI.Xaml.DependencyProperty)
-api-type: winrt method
---

<!-- Method syntax
public object GetValue(Windows.UI.Xaml.DependencyProperty dp)
-->

# Windows.UI.Xaml.DependencyObject.GetValue

## -description
Returns the current effective value of a dependency property from a [DependencyObject](dependencyobject.md).

## -parameters
### -param dp
The [DependencyProperty](dependencyproperty.md) identifier of the property for which to retrieve the value.

## -returns
Returns the current effective value.

## -remarks
[GetValue](dependencyobject_getvalue_1188551207.md) obtains the current effective value of a dependency property. The current effective value is determined by using rules of [Dependency properties overview](http://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e).

[GetValue](dependencyobject_getvalue_1188551207.md) is the API you want in most cases if you are using the property system API for obtaining property values. But sometimes you might want to examine other values to see how the dependency property precedence is acting for a given property. If so, you can use one of these API:


+ [GetAnimationBaseValue](dependencyobject_getanimationbasevalue_1072186849.md) to get values that might currently be animated but you want to know the value before the animation ran. Note that animations with [HoldEnd](../windows.ui.xaml.media.animation/fillbehavior.md) behavior might not have this same value. For more info on the [HoldEnd](../windows.ui.xaml.media.animation/fillbehavior.md) concept, see [Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a).
+ [ReadLocalValue](dependencyobject_readlocalvalue_275037327.md) to get the local value, which does not have styles or templates or animations applied. Bindings do count as local values, but depending on when you call [ReadLocalValue](dependencyobject_readlocalvalue_275037327.md), the acting binding context might not be available yet, so you won't get the same value as would be applied at run time.
For more info on dependency property precedence and other property system utility API, see [Dependency properties overview](http://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e).

## -examples

## -see-also
[SetValue](dependencyobject_setvalue_52578133.md), [Custom dependency properties](http://msdn.microsoft.com/library/5adf7935-f2cf-4bb6-b1a5-f535c2ed8ef8), [Dependency properties overview](http://msdn.microsoft.com/library/ad649e66-f71c-4daa-9994-617c886fda7e)