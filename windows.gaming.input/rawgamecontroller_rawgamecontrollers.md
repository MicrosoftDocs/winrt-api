---
-api-id: P:Windows.Gaming.Input.RawGameController.RawGameControllers
-api-type: winrt property
---

<!-- Property syntax.
public IVectorView<RawGameController> RawGameControllers { get; }
-->

# Windows.Gaming.Input.RawGameController.RawGameControllers

## -description

The list of all connected raw game controllers.

## -property-value

The list of all connected raw game controllers.

## -remarks

**RawGameController** objects are managed by the system, therefore you don't have to create or initialize them. Instead, you can access connected raw game controllers through this property. Because you might only be interested in some of the connected raw game controllers, we recommend that you maintain your own collection.

This list is initially empty and will not list raw game controllers even if they are already connected. After a short period this will return a complete list of raw game controllers.

## -see-also

## -examples
