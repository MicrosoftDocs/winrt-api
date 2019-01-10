---
-api-id: E:Windows.UI.Xaml.UIElement.NoFocusCandidateFound
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler NoFocusCandidateFound<UIElement, NoFocusCandidateFoundEventArgs>
-->

# Windows.UI.Xaml.UIElement.NoFocusCandidateFound

## -description

Occurs when a user attempts to move focus (via tab or directional arrows), but focus doesn't move because no focus candidate is found in the direction of movement.

## -xaml-syntax

```xaml
<uiElement NoFocusCandidateFound="eventhandler"/>
```

## -remarks

[NoFocusCandidateFound](uielement_nofocuscandidatefound.md) is a routed event. For more info on the routed event concept, see [Events and routed events overview](http://msdn.microsoft.com/library/34c219e8-3efb-45bc-8bbd-6fd937698832).

## -see-also

[NoFocusCandidateFoundEventArgs](../windows.ui.xaml.input/nofocuscandidatefoundeventargs.md)

## -examples