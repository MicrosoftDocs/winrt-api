---
-api-id: P:Windows.Gaming.Input.ArcadeStick.ArcadeSticks
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Gaming.Input.ArcadeStick> ArcadeSticks { get; }
-->

# Windows.Gaming.Input.ArcadeStick.ArcadeSticks

## -description

The list of all connected arcade sticks.

## -property-value

The list of all connected arcade sticks.

## -remarks

**ArcadeStick** objects are managed by the system, therefore you don't have to create or initialize them. Instead, you can access connected arcade sticks through this property. Because you might only be interested in some of the connected arcade sticks, we recommend that you maintain your own collection.

This list is initially empty and will not list arcade sticks even if they are already connected. After a short period this will return a complete list of arcade sticks.

## -examples

## -see-also
