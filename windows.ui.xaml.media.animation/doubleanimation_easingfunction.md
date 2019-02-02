---
-api-id: P:Windows.UI.Xaml.Media.Animation.DoubleAnimation.EasingFunction
-api-type: winrt property
---

<!-- Property syntax
public Windows.UI.Xaml.Media.Animation.EasingFunctionBase EasingFunction { get;  set; }
-->

# Windows.UI.Xaml.Media.Animation.DoubleAnimation.EasingFunction

## -description
Gets or sets the easing function applied to this animation.

## -xaml-syntax
```xaml
<DoubleAnimation>
  <DoubleAnimation.EasingFunction>
    singleEasingFunction
  </DoubleAnimation.EasingFunction>
</DoubleAnimation>
```


## -xaml-values
<dl><dt>singleEasingFunction</dt><dd>singleEasingFunctionA single object element for an easing function type that derives from EasingFunctionBase, for example, &lt;PowerEase/&gt;.</dd>
</dl>
## -property-value
The easing function applied to this animation.

## -remarks
Easing functions allow you to apply custom mathematical formulas to your animations. Mathematical operations are often useful to produce animations that simulate real-world physics in a 2-D coordinate system. For example, you may want an object to realistically bounce or behave as though it were on a spring. For a list of easing functions and info on how to use them, see [Key-frame animations and easing function animations](https://msdn.microsoft.com/library/d8af24cd-f4c2-4562-afd7-25010955d677).

## -examples
This XAML example applies a [BounceEase](bounceease.md) easing function to a [DoubleAnimation](doubleanimation.md) to create a bouncing effect.

```xaml
    <StackPanel x:Name="LayoutRoot" Background="White">
        <StackPanel.Resources>
            <Storyboard x:Name="myStoryboard">
                <DoubleAnimation From="30" To="200" Duration="00:00:3" 
                    Storyboard.TargetName="ball" 
                    Storyboard.TargetProperty="(UIElement.RenderTransform).(TranslateTransform.Y)">
                    <DoubleAnimation.EasingFunction>
                        <BounceEase Bounces="4" EasingMode="EaseOut" 
                                    Bounciness="1.8" />
                    </DoubleAnimation.EasingFunction>
                </DoubleAnimation>
            </Storyboard>
        </StackPanel.Resources>

        <Ellipse x:Name="ball" MouseLeftButtonDown="Clicked" 
         Fill="Blue" Width="100" Height="100">
          <Ellipse.RenderTransform>
            <TranslateTransform/>
          <Ellipse.RenderTransform>
        <Ellipse
    </StackPanel>
```

```csharp
        // When the user clicks the object, the animation begins. 
        private void Clicked(object sender, PointerRoutedEventArgs e)
        {
            myStoryboard.Begin();
        }
```



## -see-also
[Storyboarded animations](https://msdn.microsoft.com/library/0cbceea0-2b0e-44a1-a09a-f7a939632f3a), [Key-frame animations and easing function animations](https://msdn.microsoft.com/library/d8af24cd-f4c2-4562-afd7-25010955d677), [XAML animation sample](https://go.microsoft.com/fwlink/p/?linkid=238571)
