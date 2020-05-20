---
-api-id: P:Windows.UI.ViewManagement.Core.CoreInputViewOcclusionsChangedEventArgs.Occlusions
-api-type: winrt property
---

<!-- Property syntax.
public IVectorView<CoreInputViewOcclusion> Occlusions { get; }
-->

# Windows.UI.ViewManagement.Core.CoreInputViewOcclusionsChangedEventArgs.Occlusions

## -description

Gets the collection of input panes (and associated UI) currently occluding the app.

## -property-value

The [CoreInputViewOcclusion](coreinputviewocclusion.md) collection.

## -remarks

Occluding events can be handled by your app first. If your app doesn't handle the events, they bubble up to any framework that needs to handle the events.

## -see-also

## -examples
