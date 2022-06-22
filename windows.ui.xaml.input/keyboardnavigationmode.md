---
-api-id: T:Windows.UI.Xaml.Input.KeyboardNavigationMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Xaml.Input.KeyboardNavigationMode : int
-->

# KeyboardNavigationMode

## -description
Specifies the tabbing behavior across tab stops for a tabbing sequence within a container.



## -xaml-syntax
```xaml
<object property="enumMemberName"/>
```


## -enum-fields
### -field Local:0
Tab indexes are considered on the local subtree only inside this container.

### -field Cycle:1
Focus returns to the first or the last keyboard navigation stop inside of a container when the first or last keyboard navigation stop is reached.

### -field Once:2
The container and all of its child elements as a whole receive focus only once.


## -remarks
This enumeration is used by the [UIElement.TabFocusNavigation](../windows.ui.xaml/uielement_tabfocusnavigation.md) property.

## -examples

## -see-also
