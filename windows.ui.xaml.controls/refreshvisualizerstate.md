---
-api-id: T:Windows.UI.Xaml.Controls.RefreshVisualizerState
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum RefreshVisualizerState : int 
-->

# Windows.UI.Xaml.Controls.RefreshVisualizerState

## -description

Defines constants that specify the state of a [RefreshVisualizer](refreshvisualizer.md)

Equivalent **WinUI 2 API for UWP**: [Microsoft.UI.Xaml.Controls.RefreshVisualizerState](/windows/winui/api/microsoft.ui.xaml.controls.refreshvisualizerstate) (for WinUI in the [Windows App SDK](/windows/apps/windows-app-sdk/), see the **[Windows App SDK namespaces](/windows/windows-app-sdk/api/winrt/)**).

## -enum-fields
### -field Refreshing:4

The visualizer is being refreshed.

### -field Pending:3

The visualizer is pending.

### -field Peeking:1

The visualizer was pulled in the refresh direction from a position where a refresh is not allowed. Typically, the ScrollViewer was not at position 0 at the start of the pull.

### -field Interacting:2

The user is interacting with the visualizer.

### -field Idle:0

The visualizer is idle.

## -remarks

## -see-also

[RefreshVisualizer.State](refreshvisualizer_state.md), [RefreshStateChangedEventArgs.NewState](refreshstatechangedeventargs_newstate.md), [RefreshStateChangedEventArgs.OldState](refreshstatechangedeventargs_oldstate.md)

## -examples

