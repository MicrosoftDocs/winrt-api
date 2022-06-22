---
-api-id: T:Windows.UI.Xaml.Controls.Primitives.FlyoutShowMode
-api-type: winrt enum
ms.custom: RS5
---

<!-- Enumeration syntax.
public enum FlyoutShowMode : int 
-->

# Windows.UI.Xaml.Controls.Primitives.FlyoutShowMode

## -description

Defines constants that specify how a flyout behaves when shown.



## -enum-fields

### -field Auto:0

The show mode is determined automatically based on the method used to show the flyout.

### -field Standard:1

Behavior is typical of a flyout shown reactively, like a context menu. The open flyout takes focus. For a CommandBarFlyout, it opens in its expanded state.

### -field Transient:2

Behavior is typical of a flyout shown proactively. The open flyout does not take focus. For a CommandBarFlyout, it opens in its collapsed state.

### -field TransientWithDismissOnPointerMoveAway:3

The flyout exhibits Transient behavior while the cursor is close to it, but is dismissed when the cursor moves away.

## -remarks

## -see-also

[FlyoutShowOptions.ShowMode](flyoutshowoptions_showmode.md)

## -examples
