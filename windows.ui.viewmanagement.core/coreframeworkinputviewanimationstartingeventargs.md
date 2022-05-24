---
-api-id: T:Windows.UI.ViewManagement.Core.CoreFrameworkInputViewAnimationStartingEventArgs
-api-type: winrt class
---

# Windows.UI.ViewManagement.Core.CoreFrameworkInputViewAnimationStartingEventArgs

<!--
public sealed class CoreFrameworkInputViewAnimationStartingEventArgs
-->

## -description

Contains event data for the [CoreFrameworkInputView.PrimaryViewAnimationStarting](coreframeworkinputview_primaryviewanimationstarting.md) event.

> [!NOTE]
> Not supported on HoloLens.

## -remarks

Used by frameworks (such as XAML) or custom text controls only.

Occluding events can be handled by your app first. If your app doesn't handle the events, they bubble up to any framework that needs to handle the events.

Primary view refers to either of the [CoreInputViewKind.Keyboard](coreinputviewkind.md#-field-keyboard1) or [CoreInputViewKind.Handwriting](coreinputviewkind.md#-field-handwriting2) views, while CoreInputView can be any of the types from [CoreInputViewKind](coreinputviewkind.md).

## -see-also

## -examples
