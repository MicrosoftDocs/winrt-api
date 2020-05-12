---
-api-id: T:Windows.UI.ViewManagement.Core.CoreInputViewKind
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum CoreInputViewKind : int 
-->

# Windows.UI.ViewManagement.Core.CoreInputViewKind

## -description

Defines the values for specifying a preferred view for the input pane.

## -enum-fields

### -field Keyboard:1

Show the software keyboard view.

### -field Handwriting:2

Show the handwriting pane view. If it is not available, it will show the software keyboard.

### -field Emoji:3

Show the emoji pane view. If it is not available, it will show the emoji view of the software keyboard.

### -field Default:0

Show the default input pane view.

Behaves exactly like [TryShow](coreinputview_tryshow_1077566544.md) or [TryShowPrimaryView](coreinputview_tryshowprimaryview_1925215151.md).

### -field Symbols:4

Show the emoji pane with symbols view enabled. If it is not available, it will show the emoji view of the software keyboard.

## -remarks

Pass this parameter in the [TryShow(CoreInputViewKind)](coreinputview_tryshow_154132369.md) method to specify the preferred input view.

This allows apps to build specific experiences around certain input views, if that view is available.

## -see-also

[TryShow(CoreInputViewKind)](coreinputview_tryshow_154132369.md)

## -examples
