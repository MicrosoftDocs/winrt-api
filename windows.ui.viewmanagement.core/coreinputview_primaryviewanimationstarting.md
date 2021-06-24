---
-api-id: E:Windows.UI.ViewManagement.Core.CoreInputView.PrimaryViewAnimationStarting
-api-type: winrt event
---

# Windows.UI.ViewManagement.Core.CoreInputView.PrimaryViewAnimationStarting

<!--
public event Windows.Foundation.TypedEventHandler<Windows.UI.ViewManagement.Core.CoreInputView,Windows.UI.ViewManagement.Core.CoreInputViewAnimationStartingEventArgs> PrimaryViewAnimationStarting;
-->

## -description

Animations in the application that occur in response to the showing or hiding of the input pane associated with the [CoreInputView](coreinputview.md).

## -remarks

The application UI reflows based on the [CoreInputViewOcclusion.OccludingRect](coreinputviewocclusion_occludingrect.md), which is an empty rect when hiding.

Primary view refers to the [CoreInputViewKind.Keyboard](coreinputviewkind.md#-field-keyboard1), while CoreInputView can be any of the values from [CoreInputViewKind](coreinputviewkind.md).

## -see-also

[CoreInputViewAnimationStartingEventArgs](coreinputviewanimationstartingeventargs.md), [TryShow](coreinputview_tryshow_1077566544.md),  [TryShow(CoreInputViewKind type)](coreinputview_tryshow_154132369.md),[TryHide](coreinputview_tryhide_42550069.md)

## -examples
