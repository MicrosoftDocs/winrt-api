---
-api-id: M:Windows.UI.Core.AnimationMetrics.AnimationDescription.#ctor(Windows.UI.Core.AnimationMetrics.AnimationEffect,Windows.UI.Core.AnimationMetrics.AnimationEffectTarget)
-api-type: winrt method
---

<!-- Method syntax
public AnimationDescription(Windows.UI.Core.AnimationMetrics.AnimationEffect effect, Windows.UI.Core.AnimationMetrics.AnimationEffectTarget target)
-->

# Windows.UI.Core.AnimationMetrics.AnimationDescription.AnimationDescription

## -description
Creates an [AnimationDescription](animationdescription.md) object with a specific animation and target.

## -parameters
### -param effect
The animation effect to apply to the target.

### -param target
The target of the animation effect.

## -remarks
It is important to note that not all targets are valid for all animation effects. If an effect does not support the specified target, the method will fail.

The properties of an [AnimationDescription](animationdescription.md) object are captured at the time this method is called. If the user changes the animation settings, the originally captured values will continue to be returned by any [AnimationDescription](animationdescription.md) objects created before the change. To ensure that the properties you retrieve through methods of this class match the currently active settings, call this method to construct the object immediately before use.

Because all properties of the [AnimationDescription](animationdescription.md) object are captured at the time of construction, the object itself is immutable and can be marshaled freely.


<!-- @WRITER erictill 7/22/2011 :The properties are captured rather than recalculated so that applications always see a consistent set of AnimastionDescription properties. -->

<!-- @WRITER erictill 7/22/2011 : The application can use this object to obtain the parameters that describe the corresponding animations. Note that not all targets are valid with all effects. -->

<!-- @WRITER erictill 7/22/2011 : Return values:              S_OK - created successfully              E_INVALIDARG - the effect is not valid or the effect does not support the specified target.              E_OUTOFMEMORY - Insufficient memory to complete the operation.              E_FAIL - Catastrophic failure.                            HRESULTS are used to report errors. No exceptions are thrown directly, but languages can choose to convert HRESULTS to exceptions in their projections. -->

## -examples

## -see-also
[Animation metrics sample](http://go.microsoft.com/fwlink/p/?linkid=242462)