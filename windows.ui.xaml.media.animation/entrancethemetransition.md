---
-api-id: T:Windows.UI.Xaml.Media.Animation.EntranceThemeTransition
-api-type: winrt class
---

<!-- Class syntax.
public class EntranceThemeTransition : Windows.UI.Xaml.Media.Animation.Transition, Windows.UI.Xaml.Media.Animation.IEntranceThemeTransition
-->

# Windows.UI.Xaml.Media.Animation.EntranceThemeTransition

## -description
Provides the animated transition behavior on controls when they first appear. You can use this on individual objects or on containers of objects. In the latter case, child elements will animate into view in sequence rather than all at the same time.


## -xaml-syntax
```xaml
<EntranceThemeTransition .../>
```


## -remarks

## -examples
This example shows a how to apply an EntranceThemeTransition to a [Button](../windows.ui.xaml.controls/button.md).

[!code-xaml[EntranceThemeTransitionSimple](../windows.ui.xaml.media.animation/code/EntranceThemeTransition/csharp/BlankPage.xaml#SnippetEntranceThemeTransitionSimple)]

Here, the EntranceThemeTransition is applied using a Style resource.

[!code-xaml[EntranceThemeTransitionStyle](../windows.ui.xaml/code/EntranceThemeTransitionStyle/csharp/BlankPage.xaml#SnippetEntranceThemeTransitionStyle)]

If you set an EntranceThemeTransition animation on a panel, the children of the panel will automatically offset when they animate into view to create a visually appealing entrance.

Here, as rectangles are added to the StackPanel, they fly in from the upper right, rather than just appearing in place.

```xaml
<Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
    <Button Content="Add rectangle" Click="Button_Click"/>

    <StackPanel x:Name="panel1" HorizontalAlignment="Left" Margin="200">
        <StackPanel.ChildrenTransitions>
            <TransitionCollection>
                <EntranceThemeTransition 
                FromHorizontalOffset="200" 
                FromVerticalOffset="-200"/>
            </TransitionCollection>
        </StackPanel.ChildrenTransitions>
    </StackPanel>
</Grid>
```

```csharp
private void Button_Click(object sender, RoutedEventArgs e)
{
    // Add a rectangle to the StackPanel.
    Rectangle r = new Rectangle();
    r.Width = 100;
    r.Height = 100;

    // Alternate colors as rectangles are added.
    if (panel1.Children.Count % 2 == 0)
    {
        r.Fill = new SolidColorBrush(Colors.Green);
    }
    else
    {
        r.Fill = new SolidColorBrush(Colors.Yellow);
    }
    panel1.Children.Add(r);
}
```



## -see-also
[Transition](transition.md), [Animating page transitions](/previous-versions/windows/apps/jj649426(v=win.10)), [Guidelines and checklist for page transition animations](/windows/apps/design/motion/content-transition-animations)
