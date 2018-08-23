---
-api-id: T:Windows.UI.Xaml.Media.Animation.Storyboard
-api-type: winrt class
---

<!-- Class syntax.
public class Storyboard : Windows.UI.Xaml.Media.Animation.Timeline, Windows.UI.Xaml.Media.Animation.IStoryboard
-->

# Windows.UI.Xaml.Media.Animation.Storyboard

## -description
Controls animations with a timeline, and provides object and property targeting information for its child animations.

## -xaml-syntax
```xaml
<Storyboard ...>
  oneOrMoreChildTimelines
</Storyboard>
```


## -remarks
[Storyboard](storyboard.md) is an important class in the concept of *storyboarded animations*. For more info on the concept, see [Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a).

[Storyboard](storyboard.md) is used for these properties:
+ [VisualState.Storyboard](../windows.ui.xaml/visualstate_storyboard.md)
+ [VisualTransition.Storyboard](../windows.ui.xaml/visualtransition_storyboard.md)
+ [BeginStoryboard.Storyboard](beginstoryboard_storyboard_1221375020.md)


These properties aren't the only place where a [Storyboard](storyboard.md) is defined. The typical way that a [Storyboard](storyboard.md) is used for a storyboarded animation is that the [Storyboard](storyboard.md) is defined in a **Resources** collection (either [Application.Resources](../windows.ui.xaml/application_resources.md) or [FrameworkElement.Resources](../windows.ui.xaml/frameworkelement_resources.md), or possibly as a resource within a file such as Generic.xaml for a custom control). Whenever it's defined as a XAML resource, you should always assign an [x:Name attribute](http://msdn.microsoft.com/library/4ff1f3ed-903a-4305-b2bd-dcd29e0c9e6d) value to your [Storyboard](storyboard.md). You can then reference the name as a programming variable later in code-behind. You'll need this reference to actually run the animations that the [Storyboard](storyboard.md) contains, by calling the [Begin](storyboard_begin_1621727531.md) method on that [Storyboard](storyboard.md) instance. [Storyboard](storyboard.md) also has other control methods such as [Stop](storyboard_stop_1201535524.md) that can control the animation thereafter.

[Storyboard](storyboard.md) inherits several properties from [Timeline](timeline.md). These properties can be applied either to a [Storyboard](storyboard.md) or to one of the animations within it (in the [Children](storyboard_children.md) collection). There are pros and cons to setting [Timeline](timeline.md) properties on the main [Storyboard](storyboard.md) instead of on each animation. For more info, see [Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a).

You also need a [Storyboard](storyboard.md) in order to control the predefined animations that you add to controls or UI, if you are using one of the theme animations. Theme animations don't have an innate trigger point, so you need to contain theme animations in a [Storyboard](storyboard.md) as the [Children](storyboard_children.md). If the [Storyboard](storyboard.md) is used as the [VisualState.Storyboard](../windows.ui.xaml/visualstate_storyboard.md) value then the animation runs when that visual state is loaded. Or, if it's in a [VisualTransition.Storyboard](../windows.ui.xaml/visualtransition_storyboard.md), the animation runs when that transition is detected by the visual state manager. These are the most common way to use a theme animation, but you could also put one in a loose [Storyboard](storyboard.md) resource and explicitly start the animation by calling [Begin](storyboard_begin_1621727531.md). For more info on how to use theme animations, see [Quickstart: Animating your UI using library animations](http://msdn.microsoft.com/library/4e715281-d247-4e7f-9f88-2af0d88ed5cf) or [Storyboarded animations for visual states](http://msdn.microsoft.com/library/5e715281-d247-4e7f-9f88-2af0d88ed5e4).

### Storyboard XAML attached properties

[Storyboard](storyboard.md) is the host service class for several XAML attached properties. Theses enable child animations under control by the [Storyboard](storyboard.md) to each target separate target elements and target properties, while still following the same controlling timeline and triggering mechanism as the parent.

The XAML attached properties that are supported by [Storyboard](storyboard.md) are:

+ [Storyboard.TargetName](storyboard_targetname.md)
+ [Storyboard.TargetProperty](storyboard_targetproperty.md)
[Storyboard.TargetName](storyboard_targetname.md) is used to reference another element by its name. The element being referenced is the element/object where the animation should apply. This mechanism is part of the basic design of the animation system: it enables animation resources to be declared separately from UI declaration resources, and makes it possible to apply one animation definition to several different property behaviors. For the value of [Storyboard.TargetName](storyboard_targetname.md) on a particular animation, you specify the target element's [Name](../windows.ui.xaml/frameworkelement_name.md) or [x:Name attribute](http://msdn.microsoft.com/library/4ff1f3ed-903a-4305-b2bd-dcd29e0c9e6d) value, which is a string. That named element should already exist in some other area of XAML markup.

The meaning of [Name](../windows.ui.xaml/frameworkelement_name.md)/[x:Name attribute](http://msdn.microsoft.com/library/4ff1f3ed-903a-4305-b2bd-dcd29e0c9e6d) strings is controlled by a XAML namescope concept. For most animation targeting scenarios you won't need to worry about the influence of XAML namescopes, but you might encounter XAML name resolution issues if you're trying to target template parts, or objects that were created using [XamlReader.Load](../windows.ui.xaml.markup/xamlreader_load_1077941801.md) and subsequently added to the object tree. For more info, see [XAML namescopes](http://msdn.microsoft.com/library/eb060cbd-a589-475e-b83d-b24068b54c21).

[Storyboard.TargetProperty](storyboard_targetproperty.md) targets a particular property of the element as named by [Storyboard.TargetName](storyboard_targetname.md). The value you provide for [Storyboard.TargetProperty](storyboard_targetproperty.md) involves a concept known as a *property path*. For more information on how to specify a property path for an animation, see Remarks in [SetTargetProperty](storyboard_settargetproperty_865303802.md) or [Storyboard.TargetProperty](storyboard_targetproperty.md), or the [Property-path syntax](http://msdn.microsoft.com/library/ff3ecf47-d81f-46e3-be01-c839e0398025) topic.

In order to support XAML processor access to the attached properties, and also to expose equivalent get and set operations to code, each XAML attached property has a pair of **Get** and **Set** accessor methods. For example, the [GetTargetName](storyboard_gettargetname_1123683858.md) and [SetTargetName](storyboard_settargetname_235945962.md) methods support and provide the equivalent code-only support for [Storyboard.TargetName](storyboard_targetname.md). Alternatively, you can use the dependency property system to get or set the value of the attached property. Call [GetValue](../windows.ui.xaml/dependencyobject_getvalue_1188551207.md) or [SetValue](../windows.ui.xaml/dependencyobject_setvalue_52578133.md), passing the arguments of the dependency property identifier to set, and a reference to the target object on which to get or set the value.

## -examples
The following example shows how to use the [Begin](storyboard_begin_1621727531.md), [Stop](storyboard_stop_1201535524.md), [Pause](storyboard_pause_1953642114.md), and [Resume](storyboard_resume_406343050.md) methods to control the playback of a storyboard (animation). A set of buttons allow the user to call these methods.



[!code-xml[Interactive_animation](../windows.ui.xaml.media.animation/code/interactive_animation/csharp/Page.xaml#SnippetInteractive_animation)]


[!code-csharp[Interactive_animation_cs](../windows.ui.xaml.media.animation/code/interactive_animation/csharp/Page.xaml.cs#SnippetInteractive_animation_cs)]

[!code-vb[Interactive_animation_cs](../windows.ui.xaml.media.animation/code/interactive_animation/vbnet/Page.xaml.vb#SnippetInteractive_animation_cs)]

```csharp
        //using Windows.UI.Xaml.Media.Animation;
        //using Windows.UI.Xaml.Shapes;
        //using Windows.UI

        private void Create_And_Run_Animation(object sender, RoutedEventArgs e)
        {
            // Create a red rectangle that will be the target
            // of the animation.
            Rectangle myRectangle = new Rectangle();
            myRectangle.Width = 200;
            myRectangle.Height = 200;
            SolidColorBrush myBrush = new SolidColorBrush(Colors.Red);
            myRectangle.Fill = myBrush;

            // Create the transform
            TranslateTransform moveTransform = new TranslateTransform();
            moveTransform.X = 0;
            moveTransform.Y = 0;
            myRectangle.RenderTransform = moveTransform;

            // Add the rectangle to the tree.
            LayoutRoot.Children.Add(myRectangle);

            // Create a duration of 2 seconds.
            Duration duration = new Duration(TimeSpan.FromSeconds(2));
            // Create two DoubleAnimations and set their properties.
            DoubleAnimation myDoubleAnimationX = new DoubleAnimation();
            DoubleAnimation myDoubleAnimationY = new DoubleAnimation();
            myDoubleAnimationX.Duration = duration;
            myDoubleAnimationY.Duration = duration;
            Storyboard justintimeStoryboard = new Storyboard();
            justintimeStoryboard.Duration = duration;
            justintimeStoryboard.Children.Add(myDoubleAnimationX);
            justintimeStoryboard.Children.Add(myDoubleAnimationY);
            Storyboard.SetTarget(myDoubleAnimationX, moveTransform);
            Storyboard.SetTarget(myDoubleAnimationY, moveTransform);

            // Set the X and Y properties of the Transform to be the target properties
            // of the two respective DoubleAnimations.
            Storyboard.SetTargetProperty(myDoubleAnimationX, "X");
            Storyboard.SetTargetProperty(myDoubleAnimationY, "Y");
            myDoubleAnimationX.To = 200;
            myDoubleAnimationY.To = 200;

            // Make the Storyboard a resource.
            LayoutRoot.Resources.Add("justintimeStoryboard", justintimeStoryboard);
            // Begin the animation.
            justintimeStoryboard.Begin();
        }
```

```vbnet
    ' need Imports for Windows.UI.Xaml.Shapes, Windows.UI.Media.Animation, Windows.UI
    Private Sub Create_And_Run_Animation(sender As Object, e As RoutedEventArgs)
        ' Create a red rectangle that will be the target
        ' of the animation.
        Dim myRectangle As Rectangle = New Rectangle
        myRectangle.Width = 200
        myRectangle.Height = 200
        Dim myBrush As SolidColorBrush = New SolidColorBrush(Colors.Red)
        myRectangle.Fill = myBrush
 
       ' Create the transform
        Dim moveTransform As TranslateTransform = New TranslateTransform
        moveTransform.X = 0
        moveTransform.Y = 0
        myRectangle.RenderTransform = moveTransform

        ' Add the rectangle to the tree.
        LayoutRoot.Children.Add(myRectangle)

        ' Create a duration of 2 seconds.
        Dim duration As Duration = New Duration(TimeSpan.FromSeconds(2))
        ' Create two DoubleAnimations and set their properties.
        Dim myDoubleAnimationX As DoubleAnimation = New DoubleAnimation
        Dim myDoubleAnimationY As DoubleAnimation = New DoubleAnimation
        myDoubleAnimationX.Duration = duration
        myDoubleAnimationY.Duration = duration
        Dim justintimeStoryboard As Storyboard = New Storyboard
        justintimeStoryboard.Duration = duration
        justintimeStoryboard.Children.Add(myDoubleAnimationX)
        justintimeStoryboard.Children.Add(myDoubleAnimationY)
        Storyboard.SetTarget(myDoubleAnimationX, moveTransform)
        Storyboard.SetTarget(myDoubleAnimationY, moveTransform)

        ' Set the X and Y properties of the Transform to be the target properties
        ' of the two respective DoubleAnimations.
        Storyboard.SetTargetProperty(myDoubleAnimationX, "X")
        Storyboard.SetTargetProperty(myDoubleAnimationY, "Y")
        myDoubleAnimationX.To = 200
        myDoubleAnimationY.To = 200

        ' Make the Storyboard a resource.
        LayoutRoot.Resources.Add("justintimeStoryboard", justintimeStoryboard)
        ' Begin the animation.
        justintimeStoryboard.Begin()
    End Sub
```



## -see-also
[Timeline](timeline.md), [TimelineCollection](timelinecollection.md), [VisualState.Storyboard](../windows.ui.xaml/visualstate_storyboard.md), [VisualTransition.Storyboard](../windows.ui.xaml/visualtransition_storyboard.md), [Storyboarded animations](http://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a), [Storyboarded animations for visual states](http://msdn.microsoft.com/library/5e715281-d247-4e7f-9f88-2af0d88ed5e4), [Key-frame animations and easing function animations](http://msdn.microsoft.com/library/d8af24cd-f4c2-4562-afd7-25010955d677), [Quickstart: Animating your UI using library animations](http://msdn.microsoft.com/library/4e715281-d247-4e7f-9f88-2af0d88ed5cf), [Property-path syntax](http://msdn.microsoft.com/library/ff3ecf47-d81f-46e3-be01-c839e0398025), [Attached properties overview](http://msdn.microsoft.com/library/098c1de0-d640-48b1-9961-d0adf33266e2)
p://msdn.microsoft.com/library/098c1de0-d640-48b1-9961-d0adf33266e2)
