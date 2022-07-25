---
-api-id: P:Windows.UI.Xaml.VisualState.StateTriggers
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVector<Windows.UI.Xaml.StateTriggerBase> StateTriggers { get; }
-->

# Windows.UI.Xaml.VisualState.StateTriggers

## -description
Gets a collection of [StateTriggerBase](statetriggerbase.md) objects that indicate when this [VisualState](visualstate.md) should be applied. If any (not all) of the triggers are active, the VisualState will be applied.



## -property-value
A collection of [StateTriggerBase](statetriggerbase.md) objects. The default is an empty collection.

## -remarks
Use this property to create rules in XAML that specify when a particular [VisualState](visualstate.md) is to be applied. You use StateTriggers directly in your XAML markup instead of calling [VisualStateManager.GoToState](visualstatemanager_gotostate_443481648.md) in your code.

You can use the built-in [AdaptiveTrigger](adaptivetrigger.md) to create rules based on window size, which is useful for creating responsive UI. You can also extend [StateTriggerBase](statetriggerbase.md) to create your own custom triggers and use them within the StateTriggers property.

For more examples, see the [XAML Responsive Techniques sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlResponsiveTechniques?amp;amp;clcid=0x409) and the [State Triggers sample](https://go.microsoft.com/fwlink/p/?LinkId=620025&amp;amp;clcid=0x409).

## -examples
This example shows how to use the StateTriggers property with an [AdaptiveTrigger](adaptivetrigger.md) to create a declarative rule in XAML markup based on window size. By default, the [StackPanel](../windows.ui.xaml.controls/stackpanel.md) orientation is **Vertical**. When the window width is &gt;= 720 effective pixels, the [VisualState](visualstate.md) change is triggered, and the [StackPanel](../windows.ui.xaml.controls/stackpanel.md) orientation is changed to **Horizontal**.

```xaml
<Page>
    <Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
        <VisualStateManager.VisualStateGroups>
            <VisualStateGroup>
                <VisualState>
                    <VisualState.StateTriggers>
                    <!--VisualState to be triggered when window width is >=720 effective pixels.-->
                        <AdaptiveTrigger MinWindowWidth="720" />
                    </VisualState.StateTriggers>

                    <VisualState.Setters>
                        <Setter Target="myPanel.Orientation" Value="Horizontal" />
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
[AdaptiveTrigger](adaptivetrigger.md), [StateTriggerBase](statetriggerbase.md), [XAML Responsive Techniques sample](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/XamlResponsiveTechniques?amp;amp;clcid=0x409), [State Triggers sample](https://go.microsoft.com/fwlink/p/?LinkId=620025&amp;amp;clcid=0x409)
