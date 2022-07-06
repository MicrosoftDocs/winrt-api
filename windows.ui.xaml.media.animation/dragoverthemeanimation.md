---
-api-id: T:Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class DragOverThemeAnimation : Windows.UI.Xaml.Media.Animation.Timeline, Windows.UI.Xaml.Media.Animation.IDragOverThemeAnimation
-->

# Windows.UI.Xaml.Media.Animation.DragOverThemeAnimation

## -description
Represents the preconfigured animation that applies to the elements underneath an element being dragged.



## -xaml-syntax
```xaml
<DragItemThemeAnimation .../>
```


## -remarks
Note that setting the [Duration](timeline_duration.md) property has no effect on this object since the duration is preconfigured.

## -examples
The following is an example of a template for a custom control that animates as another element is being dragged over it.


<!--<p xml:space="preserve">
            <TRANSLATE_MANUALLY>
              <externalLink xmlns="http://ddue.schemas.microsoft.com/authoring/2003/5">
                <linkText>Run this sample</linkText>
                <linkUri>http://go.microsoft.com/fwlink/p/?linkid=139798&amp;sref=SineEase</linkUri>
              </externalLink>
            </TRANSLATE_MANUALLY>
          </p>-->

```xaml
<Style x:Key="ListViewItemStyle1" TargetType="ListViewItem">
    <Setter Property="Template">
        <Setter.Value>
            <ControlTemplate TargetType="ListViewItem">
                <Border x:Name="OuterContainer">
                    <VisualStateManager.VisualStateGroups>                        
                        <!—Reordering hint VisualStates of the ListViewItem control which use 
                             DragOverThemeAnimation. -->
                        <VisualStateGroup x:Name="ReorderHintStates">
                            <VisualStateGroup.Transitions>
                                <VisualTransition GeneratedDuration="0:0:0.650" To="NoReorderHint"/>
                            </VisualStateGroup.Transitions>
                            <VisualState x:Name="NoReorderHint"/>
                            <VisualState x:Name="BottomReorderHint">
                                <Storyboard>
                                    <DragOverThemeAnimation 
                                          Direction="Bottom" 
                                          ToOffset="{StaticResource ListViewItemReorderHintThemeOffset}"
                                          TargetName="ReorderHintContent"
                              />
                                </Storyboard>
                            </VisualState>
                            <VisualState x:Name="TopReorderHint">
                                <Storyboard>
                                    <DragOverThemeAnimation 
                                          Direction="Top" 
                                          ToOffset="{StaticResource ListViewItemReorderHintThemeOffset}"
                                          TargetName="ReorderHintContent"
                              />
                                </Storyboard>
                            </VisualState>
                            <VisualState x:Name="RightReorderHint">
                                <Storyboard>
                                    <DragOverThemeAnimation 
                                          Direction="Right" 
                                          ToOffset="{StaticResource ListViewItemReorderHintThemeOffset}"
                                          TargetName="ReorderHintContent"
                              />
                                </Storyboard>
                            </VisualState>
                            <VisualState x:Name="LeftReorderHint">
                                <Storyboard>
                                    <DragOverThemeAnimation 
                                          Direction="Left" 
                                          ToOffset="{StaticResource ListViewItemReorderHintThemeOffset}"
                                          TargetName="ReorderHintContent"
                              />
                                </Storyboard>
                            </VisualState>
                        </VisualStateGroup>
                        
                        <!-- Additional state groups here. -->

                    </VisualStateManager.VisualStateGroups>
                    
                    <!-- Template content here. -->

            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
```



## -see-also
[Timeline](timeline.md), [Animating drag-and-drop sequences](/previous-versions/windows/apps/jj649427(v=win.10)), [Guidelines and checklist for drag-and-drop animations](/windows/uwp/style/motion-dragdrop)
