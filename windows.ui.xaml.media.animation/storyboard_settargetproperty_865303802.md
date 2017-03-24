---
-api-id: M:Windows.UI.Xaml.Media.Animation.Storyboard.SetTargetProperty(Windows.UI.Xaml.Media.Animation.Timeline,System.String)
-api-type: winrt method
---

<!-- Method syntax
public void SetTargetProperty(Windows.UI.Xaml.Media.Animation.Timeline element, System.String path)
-->

# Windows.UI.Xaml.Media.Animation.Storyboard.SetTargetProperty

## -description
Sets the value of the [Storyboard.TargetProperty](storyboard_targetproperty.md)  XAML attached property for a target element.

## -parameters
### -param element
The target element for which to set the value.

### -param path
The [Storyboard.TargetProperty](storyboard_targetproperty.md) value of the target element to set. This specifies a qualification path that targets the dependency property where the animation applies. See Remarks.

## -remarks
Using [SetTargetProperty](storyboard_settargetproperty.md) in code as opposed to targeting an animation in initial XAML definitions is rare. It's tricky to get all the targeting and timing correct in an animation, particularly if you're trying to incorporate values that are only available at run time. We recommend that you create your animations in XAML, which means you'll use the [Storyboard.TargetProperty](storyboard_targetproperty.md) attached property, not the [SetTargetProperty](storyboard_settargetproperty.md) runtime method (which supports the XAML behind the scenes). Building up animations in code is an advanced scenario. Here's a very basic code example of what's involved:
```csharp
            Rectangle rect = new Rectangle();
            rect.RenderTransform = new ScaleTransform();
            //TODO - connect this Rectangle to the visual tree
            Storyboard storyboard = new Storyboard();
            DoubleAnimation scalex = new DoubleAnimation()
            {
                From = 0,
                To = 8,
                AutoReverse = true,
                Duration = TimeSpan.FromSeconds(2)
            };
            Storyboard.SetTargetProperty(scalex, "(Rectangle.RenderTransform).(ScaleTransform.ScaleX)");
            Storyboard.SetTarget(scalex, rect);
            //TODO - Begin the animation
```



### Property paths for animation property targeting

The [Storyboard.TargetProperty](storyboard_targetproperty.md) attached property is typically set on the individual [Timeline](timeline.md)-derived animations that make up the [Storyboard.Children](storyboard_children.md) collection of an animation definition in XAML.

The [Storyboard.TargetName](storyboard_targetname.md) property can process a string syntax that enables targeting a subproperty of a property value. The syntax uses a "dot-down" metaphor for targeting a chain of object-property relationships until a particular subproperty is identified. This enables animations to apply to the value types where there is a supporting animation structure ([Double](https://msdn.microsoft.com/library/system.double.aspx), [Color](../windows.ui/color.md), [Point](http://msdn.microsoft.com/library/0cdd5b17-2f7e-4e17-896c-7d7784c8643d), and [Object](https://msdn.microsoft.com/library/system.object.aspx) for [DiscreteObjectKeyFrameAnimation](discreteobjectkeyframe_discreteobjectkeyframe.md)). For example, you might want to animate the [Background](../windows.ui.xaml.controls/control_background.md) value of a [Control](../windows.ui.xaml.controls/control.md), which takes an object type of [Brush](../windows.ui.xaml.media/brush.md). There is no "BrushAnimation" animation type, so you cannot directly target an animation for [Background](../windows.ui.xaml.controls/control_background.md) . But what you can do instead is reference a [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md) subproperty that is named [Color](../windows.ui.xaml.media/solidcolorbrush_color.md), which takes type [Color](../windows.ui/color.md) and can thus be targeted by a [ColorAnimation](coloranimation.md). The string syntax for this is:

```xaml
(Control.Background).(SolidColorBrush.Color)
```

The parentheses around "(Control.Background)" inform the processing that the intermediate "dot" should not "dot down" and is instead part of the qualification name that finds the ownertype-qualified [Background](../windows.ui.xaml.controls/control_background.md) property for targeting. The following "dot" is treated as a "dot-down" instruction, which requests a subproperty of the [Brush](../windows.ui.xaml.media/brush.md) type. The final "(SolidColorBrush.Color)" fragment again includes the parentheses so that the interior "dot" is again used as *ownertype.member* qualification, not a "dot-down".

Note that for subproperty values, there can be some value inference. For example, the following string works by inference even though "Color" is actually a value of the particular [Brush](../windows.ui.xaml.media/brush.md) subclass [SolidColorBrush](../windows.ui.xaml.media/solidcolorbrush.md):

```xaml
(Control.Background).Color
```

There is a lot more to property path specification than this. This remark is just intended to get you started with the basic targeting scenarios. For more info, see [Property-path syntax](http://msdn.microsoft.com/library/ff3ecf47-d81f-46e3-be01-c839e0398025) and [Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a).

### Migration notes

When you specify a path value for the *path* parameter, you specify the string, and if you retrieve the value again using [GetTargetProperty](storyboard_gettargetproperty.md), you also get the value as a string. This is in contrast to some other implementations of animation property targeting concepts such as Microsoft Silverlight and Windows Presentation Foundation (WPF). These XAML technologies use a representative object type (a discrete **PropertyPath** object) to store the property path information for animation targeting, and the syntax for the **SetTargetProperty** methods use the **PropertyPath** type. The Windows Runtime also has a [PropertyPath](../windows.ui.xaml/propertypath.md) class; however that class is only used for data binding, which is another scenario for property path definitions. The Windows Runtime doesn't support modifying a property path in a [Storyboard](storyboard.md) after it's defined using the string, so its implementation of [Storyboard.TargetProperty](storyboard_targetproperty.md) takes a string. This distinction doesn't even matter for XAML syntax and attached property support. It only matters for creating dynamic storyboards in code, or programmatically modifying storyboard values after they are initially defined in XAML. If you have any need to retarget an animation to a different property at run time, create an entirely new [Storyboard](storyboard.md) with the new property path string, run animations with the new [Storyboard](storyboard.md), and stop using the previous one.

## -examples

## -see-also
[Storyboard.TargetProperty attached property](storyboard_targetproperty.md), [GetTargetProperty](storyboard_gettargetproperty.md), [SetTargetName](storyboard_settargetname.md), [Property-path syntax](http://msdn.microsoft.com/library/ff3ecf47-d81f-46e3-be01-c839e0398025), [Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a)