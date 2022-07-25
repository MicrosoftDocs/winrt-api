---
-api-id: T:Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class RepositionThemeAnimation : Windows.UI.Xaml.Media.Animation.Timeline, Windows.UI.Xaml.Media.Animation.IRepositionThemeAnimation
-->

# Windows.UI.Xaml.Media.Animation.RepositionThemeAnimation

## -description
Use to animate an object that is being repositioned.



## -xaml-syntax
```xaml
<RepositionThemeAnimation .../>
```

## -remarks
Note that setting the [Duration](timeline_duration.md) property has no effect on this object since the duration is preconfigured.

## -examples
The following example applies a [RepositionThemeAnimation](repositionthemetransition.md) to a rectangle.

```xaml
<Grid>
    <Grid.Resources>
        <!-- Sets up a RepositionThemeAnimation using the FromHorizontalOffset property 
             to start the animation from the old location. -->
        <Storyboard x:Name="PointerReleasedStoryboard">
            <RepositionThemeAnimation Storyboard.TargetName="myRectangle" FromHorizontalOffset="-400"/>
        </Storyboard>
    </Grid.Resources>

    <Rectangle x:Name="myRectangle" 
         HorizontalAlignment="Left" 
         Width="200" 
         Height="200" 
         Fill="Blue"
         PointerReleased="Rectangle_PointerReleased" 
/>
</Grid>
```

```csharp
private void Rectangle_PointerReleased(object sender, PointerRoutedEventArgs e)
{
    myRectangle.Margin = new Thickness(400, 0, 0, 0);
    PointerReleasedStoryboard.Begin();            
}
```

```cppwinrt
void DocsCppWinRT::MainPage::Rectangle_PointerReleased(
    Windows::Foundation::IInspectable const& /* sender */,
    Windows::UI::Xaml::Input::PointerRoutedEventArgs const& /* e */)
{
    myRectangle().Margin({ 400, 0, 0, 0 });
    PointerReleasedStoryboard().Begin();
}
```

```cppcx
void MyPage::Rectangle_PointerReleased(Object^ sender, PointerRoutedEventArgs^ e)
{
    myRectangle->Margin = Thickness(400, 0, 0, 0);
    PointerReleasedStoryboard->Begin();
}
```

## -see-also
[Timeline](timeline.md), [Animating repositions](/previous-versions/windows/apps/jj649434(v=win.10)), [Guidelines and checklist for reposition animations](/windows/uwp/style/motion-reposition)
