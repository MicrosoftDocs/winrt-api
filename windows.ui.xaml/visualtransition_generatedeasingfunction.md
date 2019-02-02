---
-api-id: P:Windows.UI.Xaml.VisualTransition.GeneratedEasingFunction
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Animation.EasingFunctionBase GeneratedEasingFunction { get;  set; }
-->

# Windows.UI.Xaml.VisualTransition.GeneratedEasingFunction

## -description
Gets or sets the easing function applied to the generated animations.

## -property-value
An easing function implementation that is applied to the generated animations.

## -remarks
A [VisualTransition](visualtransition.md) typically uses a linear interpolation to control the implicit transition animations that happen over the [GeneratedDuration](visualtransition_generatedduration.md). Setting a value for [GeneratedEasingFunction](visualtransition_generatedeasingfunction.md) changes this linear behavior and instead applies the timing logic of a particular [EasingFunctionBase](../windows.ui.xaml.media.animation/easingfunctionbase.md) derived class to the interpolation. For example, if you wanted an interpolation rate to start off slowly and reach the **To** value rapidly at the end of the transition's duration, you might set [GeneratedEasingFunction](visualtransition_generatedeasingfunction.md) using a [PowerEase](../windows.ui.xaml.media.animation/powerease.md) with [EasingMode.EaseIn](../windows.ui.xaml.media.animation/easingmode.md).

## -examples
This XAML example shows the markup for applying a [QuadraticEase](../windows.ui.xaml.media.animation/quadraticease.md) easing function to the interpolation of implicit transition animations during the transition. Setting the [EasingMode](../windows.ui.xaml.media.animation/easingfunctionbase_easingmode.md) is important if you don't want the default easing mode for all easing functions, which is [EasingMode.EaseIn](../windows.ui.xaml.media.animation/easingmode.md).

```xaml

<!--template root-->
<VisualStateManager.VisualStateGroups>
  <VisualStateGroup x:Name="States">
    <VisualState x:Name="FirstState">
       <!--state logic omitted-->
    </VisualState>
    <VisualState x:Name="SecondState">
       <!--state logic omitted-->
    </VisualState>
    <VisualStateGroup.Transitions>
      <VisualTransition To="SecondState" GeneratedDuration="0:0:10">
        <VisualTransition.GeneratedEasingFunction>
          <QuadraticEase EasingMode="EaseOut"/>
        </VisualTransition.GeneratedEasingFunction>
      </VisualTransition>
    </VisualStateGroup.Transitions>
  </VisualStateGroup>
</VisualStateManager.VisualStateGroups>
```



## -see-also
[Key-frame animations and easing function animations](https://msdn.microsoft.com/library/d8af24cd-f4c2-4562-afd7-25010955d677), [Quickstart: Control templates](https://msdn.microsoft.com/library/67c424ae-afb1-4560-a6a8-4a3506775d77), [Storyboarded animations](https://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a), [Storyboarded animations for visual states](https://msdn.microsoft.com/library/5e715281-d247-4e7f-9f88-2af0d88ed5e4)
