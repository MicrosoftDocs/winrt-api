---
-api-id: T:Windows.UI.Core.CoreVirtualKeyStates
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Core.CoreVirtualKeyStates : uint
-->

# CoreVirtualKeyStates

## -description
Specifies flags for indicating the possible states of a virtual key.

## -enum-fields
### -field None:0
The key is up or in no specific state.

### -field Down:1
The key is pressed down for the input event.

### -field Locked:2
The key is in a toggled or modified state (for example, Caps Lock) for the input event.

> All keys support the **Locked** state (not just the standard Caps Lock and Num Lock keys).


## -remarks

## -examples

## -see-also
[Windows.UI.Core](windows_ui_core.md), [CoreComponentInputSource.GetCurrentKeyState](corecomponentinputsource_getcurrentkeystate.md), [CoreWindow.GetAsyncKeyState](corewindow_getasynckeystate.md), [CoreWindow.GetKeyState](corewindow_getkeystate.md)