---
-api-id: T:Windows.UI.Xaml.Media.Animation.IndependentlyAnimatableAttribute
-api-type: winrt class
---

<!-- Class syntax.
public class IndependentlyAnimatableAttribute : System.Attribute
-->

# Windows.UI.Xaml.Media.Animation.IndependentlyAnimatableAttribute

## -description
Not intended for general use. This attribute is used by design tools such as Microsoft Visual Studio. Microsoft Visual Studio interprets the attribute and informs app developers how an animation-property combination will work as far as performance and restrictions.



## -remarks
Animations of properties can either be enabled or disabled by default. Which case applies is determined by both the type of animation itself (and its subproperties) and the specific property being animated. Core Windows Runtime dependency properties are annotated with metadata describing whether the property is independently animatable. This information is also reported by design tools such as Microsoft Visual Studio in order to provide app developers with info about how a given animation will work and whether it's permitted to run at all.

[ConditionallyIndependentlyAnimatableAttribute](conditionallyindependentlyanimatableattribute_conditionallyindependentlyanimatableattribute_1221375020.md) is applied to sub-property animation types that might be independently animatable depending on which property the animated type is applied to. In contrast, IndependentlyAnimatableAttribute is applied to those specific properties that really are independently animatable. 
<!--For example, .... can't give the examples because these are not fully applied in codebase yet-->

## -examples

## -see-also
[Attribute](/dotnet/api/system.attribute?view=dotnet-uwp-10.0&preserve-view=true)
