---
-api-id: P:Windows.Gaming.Input.Gamepad.Gamepads
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Gaming.Input.Gamepad> Gamepads { get; }
-->

# Windows.Gaming.Input.Gamepad.Gamepads

## -description

The list of all connected gamepads.

## -property-value

The list of all connected gamepads.

## -remarks

**Gamepad** objects are managed by the system, therefore you don't have to create or initialize them. Instead, you can access connected gamepads through this property. Because you might only be interested in some of the connected gamepads, we recommend that you maintain your own collection.

This list is initally empty and will not list gamepads even if they are already connected. After a short period this will return a complete list of gamepads.

## -examples

## -see-also
