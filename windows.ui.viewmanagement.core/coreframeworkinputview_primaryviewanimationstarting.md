---
-api-id: E:Windows.UI.ViewManagement.Core.CoreFrameworkInputView.PrimaryViewAnimationStarting
-api-type: winrt event
---

# Windows.UI.ViewManagement.Core.CoreFrameworkInputView.PrimaryViewAnimationStarting

<!--
public event Windows.Foundation.TypedEventHandler<Windows.UI.ViewManagement.Core.CoreFrameworkInputView,Windows.UI.ViewManagement.Core.CoreFrameworkInputViewAnimationStartingEventArgs> PrimaryViewAnimationStarting;
-->

## -description

Animations in the application that occur in response to the showing or hiding of the input pane associated with the [CoreFrameworkInputView](coreframeworkinputview.md).

## -remarks

Primary view refers to either of the [CoreInputViewKind.Keyboard](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-keyboard1) or [CoreInputViewKind.Handwriting](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-handwriting2) views, while CoreInputView can be any of the values from [CoreInputViewKind](coreinputviewkind.md).

The application UI reflows based on the [CoreInputViewOcclusion.OccludingRect](coreinputviewocclusion_occludingrect.md), which is an empty rect when hiding.

## -see-also

[CoreInputViewAnimationStartingEventArgs](coreinputviewanimationstartingeventargs.md), [TryShow](coreinputview_tryshow_1077566544.md),  [TryShow(CoreInputViewKind type)](coreinputview_tryshow_154132369.md),[TryHide](coreinputview_tryhide_42550069.md)

## -examples
