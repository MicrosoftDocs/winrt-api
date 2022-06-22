---
-api-id: T:Windows.UI.Xaml.VisualState
-api-type: winrt class
---

<!-- Class syntax.
public class VisualState : Windows.UI.Xaml.DependencyObject, Windows.UI.Xaml.IVisualState, Windows.UI.Xaml.IVisualState2
-->

# Windows.UI.Xaml.VisualState

## -description

Represents the visual appearance of a UI element when it is in a specific state. Visual states use [Setters](visualstate_setters.md) or a [Storyboard](visualstate_storyboard.md) to set UI properties within pages or control templates where the VisualState is defined.



## -xaml-syntax

```xaml
<VisualState x:Name="stateName" />
-or-
<VisualState x:Name="stateName">
  singleStoryboard
</VisualState>
-or-
<VisualState x:Name="stateName">
  <VisualState.Setters>
    oneOrMoreSetters
  </VisualState.Setters>
  [optional]singleStoryboard
</VisualState>
-or-
<VisualState x:Name="stateName">
  <VisualState.StateTriggers>
    oneOrMoreTriggers
  </VisualState.StateTriggers>  
  <VisualState.Setters>
    oneOrMoreSetters
  </VisualState.Setters>
  [optional]singleStoryboard
</VisualState>
```

## -remarks

A VisualState element must always be contained within a [VisualStateGroup](visualstategroup.md) parent in the XAML markup. The [VisualStateGroup](visualstategroup.md) has an implicit collection property [States](visualstategroup_states.md), so you can put each VisualState as an immediate child element of the [VisualStateGroup](visualstategroup.md) parent. For example:

```xaml

<VisualStateGroup x:Name="CommonStates">
   <VisualState x:Name="Normal"/>
   <VisualState x:Name="PointerOver">...</VisualState>
<!-- do not need explicit VisualStateGroups.States property element, States is the XAML content property-->
</VisualStateGroup>

```

When you use [StateTriggers](visualstate_statetriggers.md), ensure that the [VisualStateGroup](visualstategroup.md) is declared under the first child of the root in order for the triggers to take effect automatically.

### Default state

It's legal and common to define a VisualState that has an [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) but doesn't specify anything in the [Storyboard](visualstate_storyboard.md). This is useful because such a VisualState will use whatever values are present in the default template. You can then specifically request the empty state from a [GoToState](visualstatemanager_gotostate_443481648.md) call. When an empty state becomes the current state, that cancels all modifications to template properties made by a previous visual state from the same [VisualStateGroup](visualstategroup.md). For more info on how to use groups for visual states, see [Storyboarded animations for visual states](/previous-versions/windows/apps/jj819808(v=win.10)).

When you use [StateTriggers](visualstate_statetriggers.md), you are no longer required to create an empty VisualState to call [GoToState](visualstatemanager_gotostate_443481648.md) on. When the conditions for a [StateTrigger](statetrigger.md) are no longer met, all the modifications to the properties made by the corresponding VisualState are automatically removed and the values provided in the default markup take effect.

### VisualState and x:Name

The [GoToState](visualstatemanager_gotostate_443481648.md) method (which is typically called from control code) requires a *stateName* parameter to inform the [VisualStateManager](visualstatemanager.md) which state should be used as a current state. Specify an [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) for each VisualState that will need to be manually applied using a [GoToState](visualstatemanager_gotostate_443481648.md) call from code. If you are using [StateTriggers](visualstate_statetriggers.md) to automatically trigger a VisualState from markup, you don’t need to specify an [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) on that VisualState.

If you use visual transitions, the [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) value of a VisualState is also referenced by the [From](visualtransition_from.md) or [To](visualtransition_to.md) values of a [VisualTransition](visualtransition.md). In this case the name identifies the state or states that the [VisualTransition](visualtransition.md) provides the intermediate values between.

The [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) value that you specify for a VisualState must be unique within the control template XAML where the VisualState exists. Scope for state names isn't just scoped for each [VisualStateGroup](visualstategroup.md), it's scoped to all visual states in the template. For example, you can't define two different states named "Focused" in the same template XAML, even if they are in different groups.

You must use the [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute) to name a visual state or visuals state group; the unprefixed attribute "Name" won't work. VisualState and [VisualStateGroup](visualstategroup.md) each have a **Name** property but these are read-only. That **Name** property exists for advanced scenarios that use code to examine a control template's content at run-time, not for setting from XAML.

### Replacing an existing control's control template

If you are an app developer using a control in your app UI, you can replace the control template by setting the [Control.Template](../windows.ui.xaml.controls/control_template.md) property to a different value. Or you can replace the template by declaring a new style that uses the implicit style key for that control. For more info on these concepts, see [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)).

When you replace a control template, it's important that you reproduce all the existing named VisualState elements from the original control template's [VisualStateManager.VisualStateGroups](/dotnet/api/system.windows.visualstatemanager.visualstategroups) content in XAML. The control code (which you aren't modifying) is calling [GoToState](visualstatemanager_gotostate_443481648.md). States with those names must exist in the control template. A request for a missing VisualState won't throw exceptions, but it often will leave the control in a visual state that will be confusing to the user. For example, if you don't supply a VisualState named "Checked" for a [CheckBox](../windows.ui.xaml.controls/checkbox.md) control, no visual feedback appears when the user selects the control. The user will expect that there's something visually different to distinguish a checked [CheckBox](../windows.ui.xaml.controls/checkbox.md) from an unchecked [CheckBox](../windows.ui.xaml.controls/checkbox.md). So a failure to reproduce the visual states on the app developer's part will make the control seem broken to the user.

When you use an IDE such as Microsoft Visual Studio, the actions that you use to replace a control template provide the option to start with a copy of the original template XAML, so you can see all the original named VisualState elements and other control composition you are replacing. It's best to start with template copies, then modify them, so that you don't accidentally omit an expected visual state from your new template.

### Attributing a custom control's named visual states

If you are defining a custom control that has visual states in its control template XAML, it's a best practice to attribute the control class to indicate to control consumers which visual states are available. To do this, apply one or more [TemplateVisualState](templatevisualstateattribute.md) attributes at the class level of your control definition code. Each attribute should specify the state's [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute), which is the *stateName* value a control consumer would pass in a [GoToState](visualstatemanager_gotostate_443481648.md) call to use that visual state. If the VisualState is part of a [VisualStateGroup](visualstategroup.md), that should also be indicated in your attribute values.

## -examples

This example creates a [VisualStateGroup](visualstategroup.md) in the [ControlTemplate](../windows.ui.xaml.controls/controltemplate.md) of a [Button](../windows.ui.xaml.controls/button.md) called "CommonStates" and adds VisualState objects for the states, "Normal", "Pressed", and "PointerOver". The [Button](../windows.ui.xaml.controls/button.md) also defines a state called "Disabled" that is in the "CommonStates" named [VisualStateGroup](visualstategroup.md), but the example omits it for brevity.

[!code-xaml[VisualStates](../windows.ui.xaml.data/code/StylingTemplatingOverview/csharp/ButtonStages.xaml#SnippetVisualStates)]

```xaml
<Page>
    <Grid Background="{ThemeResource ApplicationPageBackgroundThemeBrush}">
        <VisualStateManager.VisualStateGroups>
            <VisualStateGroup>
                <VisualState>
                    <VisualState.StateTriggers>
                        <!-- VisualState to be triggered when window width is >=720 effective pixels -->
                        <AdaptiveTrigger MinWindowWidth="720"/>
                    </VisualState.StateTriggers>
                    <VisualState.Setters>
                        <Setter Target="myPanel.Orientation" Value="Horizontal"/>
                    </VisualState.Setters>
                </VisualState>
            </VisualStateGroup>
        </VisualStateManager.VisualStateGroups>
        <StackPanel x:Name="myPanel" Orientation="Vertical">
            <TextBlock x:Name="myTextBlock" MaxLines="5" Style="{ThemeResource BodyTextBlockStyle}"/>
        </StackPanel>
    </Grid>
</Page>

```

## -see-also

[DependencyObject](dependencyobject.md), [VisualStateGroup](visualstategroup.md), [Storyboarded animations for visual states](/previous-versions/windows/apps/jj819808(v=win.10)), [Storyboarded animations](/windows/uwp/graphics/storyboarded-animations), [x:Name attribute](/windows/uwp/xaml-platform/x-name-attribute), [Quickstart: Control templates](/previous-versions/windows/apps/hh465374(v=win.10)), [XAML control and app styling sample](https://github.com/microsoftarchive/msdn-code-gallery-microsoft/tree/master/Official%20Windows%20Platform%20Sample/Windows%208.1%20Store%20app%20samples/99866-Windows%208.1%20Store%20app%20samples/XAML%20control%20and%20app%20styling%20sample/C%23), [Master/detail sample (Windows 10)](https://go.microsoft.com/fwlink/p/?LinkId=619901)
