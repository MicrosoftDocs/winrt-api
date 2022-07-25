---
-api-id: M:Windows.UI.Xaml.FrameworkElement.GoToElementStateCore(System.String,System.Boolean)
-api-type: winrt method
---

<!-- Method syntax
virtual protected bool GoToElementStateCore(System.String stateName, System.Boolean useTransitions)
-->

# Windows.UI.Xaml.FrameworkElement.GoToElementStateCore

## -description
When implemented in a derived class, enables per-state construction of a visual tree for a control template in code, rather than by loading XAML for all states at control startup.



## -parameters
### -param stateName
The state to transition to.

### -param useTransitions
**true** to use a [VisualTransition](visualtransition.md) to transition between states. **false** to skip using transitions and go directly to the requested state. The default is **false**.

## -returns
**true** if the control successfully transitions to the new state, or was already using that state; otherwise, **false**.

## -remarks
The default implementation of FrameworkElement.GoToElementStateCore provides the normal state change behavior that's accessed by calling [VisualStateManager.GoToState](visualstatemanager_gotostate_443481648.md), and also the default control template / visual state loading behavior for any XAML control. You should only override FrameworkElement.GoToElementStateCore if you are prepared to take full responsibility for constructing the visual tree for a control in your code at run time. This includes presentation of any content that comes from content properties, child element collections, and so on.

For general state change logic in a custom control, you should use [VisualStateManager.GoToState](visualstatemanager_gotostate_443481648.md). The intended scenario for FrameworkElement.GoToElementStateCore is more limited, it's specifically intended for apps or controls that want to optimize the template or logic that creates the visual tree of a [ListViewItem](../windows.ui.xaml.controls/listviewitem.md) or a [GridViewItem](../windows.ui.xaml.controls/gridviewitem.md) and presents the contents.

[VisualStateManager.GoToState](visualstatemanager_gotostate_443481648.md) has a slightly different signature because it's a static utility API and uses a *control* parameter to specify what control to apply state changes to. FrameworkElement.GoToElementStateCore uses the calling object to get this information.

## -examples

## -see-also
[VisualStateManager.GoToState](visualstatemanager_gotostate_443481648.md), [Storyboarded animations for visual states](/previous-versions/windows/apps/jj819808(v=win.10))
