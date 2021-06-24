---
-api-id: T:Windows.UI.Shell.ShareWindowCommand
-api-type: winrt enum
---

# Windows.UI.Shell.ShareWindowCommand

<!--
public enum ShareWindowCommand
-->

## -description

Defines constants that specify a window sharing command.

## -enum-fields

### -field None: 0

Specifies that no command is being indicated.

### -field StartSharing: 1

Specifies a *start sharing* command.

For single-window sharing scenarios (that is, client applications that are capable of sharing only one window from one machine at a time), you can use the **StartSharing** command as a **Swap** command to swap to another window or screen if some other window or screen is already being shared from that machine.

### -field StopSharing: 2

Specifies a *stop sharing* command.

## -remarks

## -see-also
[ShareWindowCommandEventArgs.Command](sharewindowcommandeventargs_command.md)

## -examples
