---
-api-id: P:Windows.UI.Xaml.Controls.Panel.BackgroundTransition
-api-type: winrt property
ms.custom: RS5
---

<!-- Property syntax.
public BrushTransition BackgroundTransition { get;  set; }
-->

# Windows.UI.Xaml.Controls.Panel.BackgroundTransition

## -description

Gets or sets an instance of BrushTransition to automatically animate changes to the Background property.



## -property-value

An instance of [BrushTransition](../windows.ui.xaml/brushtransition.md) to automatically animate changes to the [Background](panel_background.md); otherwise, **null**. The default is **null**.

## -remarks

Use this property to animate any change to the [Background](panel_background.md) property. When a new value is set from code or through data binding, the change is animated from the old value to the new value, rather than happening instantaneously.  

Even though the transition animation takes time, the change to the actual property value is instantaneous. For example, if you change a property from code and then read it back, you’ll see the new value, even though the visual effect of the property change is somewhere between the new and the old.

If a property value changes a second time while the first change is still animating, the animation will use the currently animated value as the "starting" value for the next animation, and then animate to the new "final" value. The duration will be reset.  

## -see-also

[BrushTransition](../windows.ui.xaml/brushtransition.md), [Background](panel_background.md)

## -examples

This example shows how to apply a background transition to a Grid. Each time `GridBackground` is updated, the background will animate from the old brush to the new brush.

```xaml
<Grid Background="{x:Bind GridBackground}">
    <Grid.BackgroundTransition>
        <BrushTransition />
    </Grid.BackgroundTransition>
</Grid>
```
