---
-api-id: P:Windows.UI.ViewManagement.Core.CoreInputViewAnimationStartingEventArgs.AnimationDuration
-api-type: winrt property
---

# Windows.UI.ViewManagement.Core.CoreInputViewAnimationStartingEventArgs.AnimationDuration

<!--
public System.TimeSpan AnimationDuration { get; }
-->

## -description

Gets the interval of time required to complete the [CoreInputView](coreinputview.md) animation.

> [!Important]
> The application should use this value when setting any animation durations that are based on the showing or hiding of the [CoreInputView](coreinputview.md). If coordinating animations between the application and the [CoreInputView](coreinputview.md), ensure the application animation does not complete before the [CoreInputView](coreinputview.md) animation.

## -property-value

The interval of time required to complete the animation.

## -remarks

## -see-also

## -examples
