---
-api-id: T:Windows.UI.Xaml.Media.Animation.DropTargetItemThemeAnimation
-api-type: winrt class
---

<!-- Class syntax.
public class DropTargetItemThemeAnimation : Windows.UI.Xaml.Media.Animation.Timeline, Windows.UI.Xaml.Media.Animation.IDropTargetItemThemeAnimation
-->

# Windows.UI.Xaml.Media.Animation.DropTargetItemThemeAnimation

## -description
Represents the preconfigured animation that applies to potential drop target elements.



## -xaml-syntax
```xaml
<DropTargetItemThemeAnimation .../>
```


## -remarks
Note that setting the [Duration](timeline_duration.md) property has no effect on this object since the duration is preconfigured.

## -examples
The following is an example of a template for a custom control that supports an animation for when it is dropped on the screen.


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
                        <!-- Dragging-related VisualStates of the ListViewItem control which use 
                             DragItemThemeAnimation and DropTargetItemThemeAnimation. -->
                        <VisualStateGroup x:Name="DragStates">
                            <VisualStateGroup.Transitions>
                                <VisualTransition GeneratedDuration="0:0:0.650" To="NotDragging"/>
                            </VisualStateGroup.Transitions>
                            <VisualState x:Name="NotDragging"/>
                            <VisualState x:Name="Dragging">
                                <Storyboard>
                                    <DragItemThemeAnimation TargetName="InnerDragContent"/>
                                    <FadeOutThemeAnimation TargetName="SelectedCheckMarkOuter"/>
                                    <FadeOutThemeAnimation TargetName="SelectedBorder"/>
                                </Storyboard>
                            </VisualState>
                            <VisualState x:Name="DraggingTarget">
                                <Storyboard>
                                    <DropTargetItemThemeAnimation TargetName="OuterContainer"/>
                                </Storyboard>
                            </VisualState>
                            <VisualState x:Name="MultipleDraggingPrimary">
                                <Storyboard>
                                    <FadeInThemeAnimation TargetName="MultiArrangeOverlayBackground"/>
                                    <FadeInThemeAnimation TargetName="MultiArrangeOverlayText"/>
                                    <DragItemThemeAnimation TargetName="ContentBorder"/>
                                    <FadeOutThemeAnimation TargetName="SelectionBackground"/>
                                    <FadeOutThemeAnimation TargetName="SelectedCheckMarkOuter"/>
                                    <FadeOutThemeAnimation TargetName="SelectedBorder"/>
                                    <FadeOutThemeAnimation TargetName="PointerOverBorder"/>
                                </Storyboard>
                            </VisualState>
                            <VisualState x:Name="MultipleDraggingSecondary">
                                <Storyboard>
                                    <FadeOutThemeAnimation TargetName="ContentContainer"/>
                                </Storyboard>
                            </VisualState>
                        </VisualStateGroup>                        
                        
                        <!-- Additional state groups here. -->

                    </VisualStateManager.VisualStateGroups>
                    
                    <!-- Template content here. -->
                </Border>
            </ControlTemplate>
        </Setter.Value>
    </Setter>
</Style>
```



## -see-also
[Timeline](timeline.md), [Animating drag-and-drop sequences](/previous-versions/windows/apps/jj649427(v=win.10)), [Guidelines and checklist for drag-and-drop animations](/windows/uwp/style/motion-dragdrop)
