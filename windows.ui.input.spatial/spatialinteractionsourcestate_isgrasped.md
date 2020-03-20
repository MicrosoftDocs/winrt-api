---
-api-id: P:Windows.UI.Input.Spatial.SpatialInteractionSourceState.IsGrasped
-api-type: winrt property
---

<!-- Property syntax.
public bool IsGrasped { get; }
-->

# Windows.UI.Input.Spatial.SpatialInteractionSourceState.IsGrasped

## -description

Gets whether an input device detects a grasp/grab action (how users take direct action on objects in order to manipulate them).

## -property-value

True, if the source detects a grasp/grab action. Otherwise, false.

## -remarks

A [SpatialInteractionSource](spatialinteractionsource.md) represents one of three possible sources of input.

- [Hand](/windows/mixed-reality/hands-and-motion-controllers-in-directx#articulated-hand-tracking) - The user's hand, which supports different features based on the input device. This ranges from basic gestures on HoloLens to fully articulated hand tracking on HoloLens 2.
- [Controller](/windows/mixed-reality/hands-and-motion-controllers-in-directx#controller-specific-input-properties) - A motion controller, which supports input options such as select triggers, menu buttons, grasp buttons, palm triggers, touchpads, or thumbsticks.
- [Speech](/windows/mixed-reality/voice-input-in-directx) - System keywords such as "Select" (which represents a press and release gesture).

| Source | Support |
| ------ | ------- |
| Hololens hand gesture | None |
| Articulated hand gestures | Pinch or closed hand |
| Controller | Grab button pressed or hand squeezed |

## -see-also

[Hands and motion controllers](/windows/mixed-reality/hands-and-motion-controllers-in-directx), [Speech input](/windows/mixed-reality/voice-input-in-directx), [Instinctual interactions](/windows/mixed-reality/interaction-fundamentals)

## -examples
