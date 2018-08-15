---
-api-id: T:Windows.UI.Xaml.AdaptiveTrigger
-api-type: winrt class
---

<!-- Class syntax.
public class AdaptiveTrigger : Windows.UI.Xaml.StateTriggerBase, Windows.UI.Xaml.IAdaptiveTrigger
-->

# Windows.UI.Xaml.AdaptiveTrigger

## -description
Represents a declarative rule that applies visual states based on window properties.

## -xaml-syntax
```xaml
<AdaptiveTrigger .../>
```


## -remarks
Use [AdaptiveTrigger](adaptivetrigger.md) s to create rules that automatically trigger a [VisualState](visualstate.md) change when the window is a specified height or width. When you use [AdaptiveTrigger](adaptivetrigger.md) s in your XAML markup, you don't need to handle the [Window.SizeChanged](window_sizechanged.md) event and call [VisualStateManager.GoToState](visualstatemanager_gotostate_443481648.md) in your code. Also, when you use [AdaptiveTrigger](adaptivetrigger.md) in your [VisualStateManager](visualstatemanager.md), you can see the effects of these adaptive changes directly on the XAML design surface in Microsoft Visual Studio.

You can use the [MinWindowWidth](adaptivetrigger_minwindowwidth.md) and [MinWindowHeight](adaptivetrigger_minwindowheight.md) properties either independently or in conjunction with each other. This XAML shows an example of using both properties together. The trigger indicates that the corresponding [VisualState](visualstate.md) is to be applied when the current window width is &gt;= 720 effective pixels AND the current window height is &gt;= 900 effective pixels.



```xaml
<AdaptiveTrigger MinWindowWidth="720" MinWindowHeight="900"/>
```



For more examples, see the [XAML Responsive Techniques sample](http://go.microsoft.com/fwlink/p/?LinkId=620024&amp;amp;clcid=0x409).

## -examples
This example shows how to use the [StateTriggers](visualstate_statetriggers.md) property with an [AdaptiveTrigger](adaptivetrigger.md) to create a declarative rule in XAML markup based on window size. By default, the [StackPanel](../windows.ui.xaml.controls/stackpanel.md) orientation is **Vertical**. When the window width is &gt;= 720 effective pixels, the [VisualState](visualstate.md) change is triggered, and the [StackPanel](../windows.ui.xaml.controls/stackpanel.md) orientation is changed to **Horizontal**.

```xaml
<Page>
    <Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
        <VisualStateManager.VisualStateGroups>
            <VisualStateGroup>
                <VisualState>
                    <VisualState.StateTriggers>
                    <!--VisualState to be triggered when window width is >=720 effective pixels.-->
                        <AdaptiveTrigger MinWindowWidth="720"/>
                    </VisualState.StateTriggers>

                    <VisualState.Setters>
                        <Setter Target="myPanel.Orientation" Value="Horizontal"/>
                    </VisualState.Setters>
                </VisualState>
            </VisualStateGroup>
        </VisualStateManager.VisualStateGroups>
        <StackPanel x:Name="myPanel" Orientation="Vertical">
            <TextBlock Text="This is a block of text. It is text block 1. " 
                       Style="{ThemeResource BodyTextBlockStyle}"/>
            <TextBlock Text="This is a block of text. It is text block 2. " 
                       Style="{ThemeResource BodyTextBlockStyle}"/>
            <TextBlock Text="This is a block of text. It is text block 3. " 
                       Style="{ThemeResource BodyTextBlockStyle}"/>
        </StackPanel>
    </Grid>
</Page>

```



## -see-also
[StateTriggerBase](statetriggerbase.md), [VisualState](visualstate.md), [VisualState.StateTriggers](visualstate_statetriggers.md)