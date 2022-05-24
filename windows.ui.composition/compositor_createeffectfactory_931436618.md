---
-api-id: M:Windows.UI.Composition.Compositor.CreateEffectFactory(Windows.Graphics.Effects.IGraphicsEffect,Windows.Foundation.Collections.IIterable{System.String})
-api-type: winrt method
---

<!-- Method syntax
public Windows.UI.Composition.CompositionEffectFactory CreateEffectFactory(Windows.Graphics.Effects.IGraphicsEffect graphicsEffect, Windows.Foundation.Collections.IIterable<System.String> animatableProperties)
-->

# Windows.UI.Composition.Compositor.CreateEffectFactory

## -description
Creates an instance of [CompositionEffectFactory](compositioneffectfactory.md) specifying effect parameters that should be animatable.


## -parameters
### -param graphicsEffect
The type of effect to create.

### -param animatableProperties
The list of properties that should be animatable. Properties are specified using strings of the form 'EffectName.PropertyName', where 'EffectName' identifies a graphics effect object by its IGraphicsEffect.Name property and 'PropertyName' identifies a property of that object.

## -returns
Returns the created [CompositionEffectFactory](compositioneffectfactory.md) object.

## -remarks

## -examples

## -see-also
[CreateEffectFactory(IGraphicsEffect)](compositor_createeffectfactory_720924202.md)
