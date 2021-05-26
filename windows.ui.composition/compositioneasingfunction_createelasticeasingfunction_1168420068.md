---
-api-id: M:Windows.UI.Composition.CompositionEasingFunction.CreateElasticEasingFunction(Windows.UI.Composition.Compositor,Windows.UI.Composition.CompositionEasingFunctionMode,System.Int32,System.Single)
-api-type: winrt method
---

# Windows.UI.Composition.CompositionEasingFunction.CreateElasticEasingFunction(Windows.UI.Composition.Compositor,Windows.UI.Composition.CompositionEasingFunctionMode,System.Int32,System.Single)

<!--
public static Windows.UI.Composition.ElasticEasingFunction CreateElasticEasingFunction (Windows.UI.Composition.Compositor owner, Windows.UI.Composition.CompositionEasingFunctionMode mode, int oscillations, float springiness);
-->


## -description

Creates an instance of [ElasticEasingFunction](elasticeasingfunction.md).

## -parameters

### -param owner

The [Compositor](compositor.md) used to create the easing function.

### -param mode

One of the enumeration values that specifies how the animation interpolates.

### -param oscillations

The number of times the target slides back and forth over the animation destination. This value must be greater than or equal to 0.

### -param springiness

A positive number that specifies the stiffness of the spring.

## -returns

Returns the created [ElasticEasingFunction](elasticeasingfunction.md) object.

## -remarks

## -see-also

## -examples


