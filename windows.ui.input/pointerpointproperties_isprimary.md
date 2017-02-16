---
-api-id: P:Windows.UI.Input.PointerPointProperties.IsPrimary
-api-type: winrt property
---

<!-- Property syntax
public bool IsPrimary { get; }
-->

# Windows.UI.Input.PointerPointProperties.IsPrimary

## -description
Gets a value that indicates whether the input is from the primary pointer when multiple pointers are registered.

## -property-value
True if the input is from the pointer designated as primary; otherwise false.

## -remarks
The primary pointer is a single pointer (touch, mouse, and pen/stylus) in the current interaction.

For mouse, the primary pointer is the only pointer for which mouse events can be generated.

For touch, the primary pointer is the first contact in an interaction. A new primary pointer is only registered when all contacts in that interaction are removed and a new contact is subsequently detected.

A primary pointer can perform actions that are not available to other pointers. For example, the primary pointer can send a WM_POINTERACTIVATE message.

## -examples
For any interaction, [IsPrimary](pointerpointproperties_isprimary.md) returns false after the first [pointerdown](XREF:TODO:wwa.HTMLElement_onmspointerdown) event. Use the [pointerType](XREF:TODO:wwa.shared_pointerType) property as shown in the following example when you need to know whether a pointer is primary, such as a mouse pointer.

```javascript
function isreallyprimary (event) {
  if (event.isPrimary) {
    return (true);
  } else {
    if (event.pointerType == event.MSPOINTER_TYPE_MOUSE) {
      return (true);
    } else {
      return (false);
    }
  }
}
```



## -see-also
