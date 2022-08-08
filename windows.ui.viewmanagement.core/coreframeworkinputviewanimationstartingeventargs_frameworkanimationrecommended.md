---
-api-id: P:Windows.UI.ViewManagement.Core.CoreFrameworkInputViewAnimationStartingEventArgs.FrameworkAnimationRecommended
-api-type: winrt property
---

# Windows.UI.ViewManagement.Core.CoreFrameworkInputViewAnimationStartingEventArgs.FrameworkAnimationRecommended

<!--
public bool FrameworkAnimationRecommended { get; }
-->

## -description

Gets a value that indicates whether the framework should animate on behalf of the application based on other application settings.

## -property-value

True, if the application should animate application UI in response to the PrimaryViewAnimationStarting event. Otherwise, false.

## -remarks

Primary view refers to either of the [CoreInputViewKind.Keyboard](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-keyboard1) or [CoreInputViewKind.Handwriting](https://github.com/MicrosoftDocs/winrt-api/blob/docs/windows.ui.viewmanagement.core/coreinputviewkind.md#-field-handwriting2) views, while CoreInputView can be any of the values from [CoreInputViewKind](coreinputviewkind.md).

## -see-also

## -examples
