---
-api-id: M:Windows.UI.Xaml.UIElement.TryStartDirectManipulation(Windows.UI.Xaml.Input.Pointer)
-api-type: winrt method
---

<!-- Method syntax
public bool TryStartDirectManipulation(Windows.UI.Xaml.Input.Pointer value)
-->

# Windows.UI.Xaml.UIElement.TryStartDirectManipulation

## -description
Resumes direct manipulation processing (system-defined panning/zooming) on any [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) parent that contains the current [UIElement](uielement.md).



## -parameters
### -param value
The active touch point that initiated the manipulation.

## -returns
**true** if a [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) parent exists and setting the value resulted in resuming the panning/zooming action. **false** if calling the method results in no action.

## -remarks
By default, touch input interactions in [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) elements are handled by the [Direct Manipulation](/previous-versions/windows/desktop/directmanipulation/direct-manipulation-portal) engine off the UI thread. An app cannot directly process the associated pointer events after [Direct Manipulation](/previous-versions/windows/desktop/directmanipulation/direct-manipulation-portal) processing starts. You can call [CancelDirectManipulations](uielement_canceldirectmanipulations_1164631120.md) at the start of a [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) interaction and handle the pointer events on the UI thread, which gives you the opportunity to do custom input handling in a [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md).

If you cancel [Direct Manipulation](/previous-versions/windows/desktop/directmanipulation/direct-manipulation-portal) processing at the start of a [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) interaction, you can call TryStartDirectManipulation to resume having [Direct Manipulation](/previous-versions/windows/desktop/directmanipulation/direct-manipulation-portal) process the input stream. This lets you do custom input processing first, and then resume [Direct Manipulation](/previous-versions/windows/desktop/directmanipulation/direct-manipulation-portal) handling to make your app more responsive to touch interactions like scrolling and zooming.

Only active touch contacts can be passed to [Direct Manipulation](/previous-versions/windows/desktop/directmanipulation/direct-manipulation-portal). Using non-active or non-touch contacts causes an exception to be thrown.

Specifying a touch contact to pass to [Direct Manipulation](/previous-versions/windows/desktop/directmanipulation/direct-manipulation-portal) results in the framework walking up the parent chain and setting the contact on the [Direct Manipulation](/previous-versions/windows/desktop/directmanipulation/direct-manipulation-portal) viewport of each [ScrollViewer](../windows.ui.xaml.controls/scrollviewer.md) encountered in order, until the walk reaches any element (including the original target element) that does not have a [ManipulationMode](uielement_manipulationmode.md) that contains [ManipulationModes.System](../windows.ui.xaml.input/manipulationmodes.md). A given touch contact can only be associated with a single chain of visuals at a time. Calling TryStartDirectManipulation more than once on the same contact results in any previous chain being released.

## -examples

## -see-also
[CancelDirectManipulations](uielement_canceldirectmanipulations_1164631120.md), [ManipulationStarted](uielement_manipulationstarted.md), [ManipulationModes](../windows.ui.xaml.input/manipulationmodes.md), [Gestures, manipulations, and interactions](/previous-versions/windows/apps/hh761498(v=win.10)), [Direct Manipulation](/previous-versions/windows/desktop/directmanipulation/direct-manipulation-portal)
