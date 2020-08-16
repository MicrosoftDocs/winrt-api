---
-api-id: T:Windows.UI.ViewManagement.ApplicationViewState
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.ViewManagement.ApplicationViewState : int
-->

# ApplicationViewState

## -description

Specifies the set of app view state changes that can be handled.

> [!IMPORTANT]
> ApplicationViewState may be altered or unavailable for releases after Windows 8.1. Instead, query for window layout sizes directly.

## -enum-fields
### -field FullScreenLandscape:0
The current app's view is in full-screen (has no snapped app adjacent to it), and has changed to landscape orientation.

### -field Filled:1
The current app's view has been reduced to a partial screen view as the result of another app snapping.

### -field Snapped:2
The current app's view has been snapped.

### -field FullScreenPortrait:3
The current app's view is in full-screen (has no snapped app adjacent to it), and has changed to portrait orientation.


## -remarks

## -examples

## -see-also
