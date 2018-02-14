---
-api-id: T:Windows.UI.Xaml.Input.FocusNavigationDirection
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Input.FocusNavigationDirection : int
-->

# FocusNavigationDirection

## -description
Specifies the direction that focus moves from element to element within the app UI.

## -enum-fields
### -field Next:0
The next element in the tab order.

### -field Previous:1
The previous element in the tab order.

### -field Up:2
An element above the element with focus. 

> Not supported in Windows 8 apps and Windows Phone apps.

### -field Down:3
An element below the element with focus. 

> Not supported in Windows 8 apps and Windows Phone apps.

### -field Left:4
An element to the left of the element with focus. 

> Not supported in Windows 8 apps and Windows Phone apps.

### -field Right:5
An element to the right of the element with focus. 

> Not supported in Windows 8 apps and Windows Phone apps.

### -field None:6
No change in focus.

> Not supported in Windows 8 apps and Windows Phone apps.


## -remarks
[FocusNavigationDirection.Previous](focusnavigationdirection.md) and [FocusNavigationDirection.Next](focusnavigationdirection.md) cannot be used with [FindNextElementOptions](findnextelementoptions.md). Only [FocusNavigationDirection.Up](focusnavigationdirection.md), [FocusNavigationDirection.Down](focusnavigationdirection.md), [FocusNavigationDirection.Left](focusnavigationdirection.md), or [FocusNavigationDirection.Right](focusnavigationdirection.md) are valid.

## -examples

## -see-also
[TryMoveFocus](focusmanager_trymovefocus.md)