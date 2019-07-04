---
-api-id: P:Windows.Gaming.Input.RacingWheel.RacingWheels
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Gaming.Input.RacingWheel> RacingWheels { get; }
-->

# Windows.Gaming.Input.RacingWheel.RacingWheels

## -description

The list of all connected racing wheels.

## -property-value

The list of all connected racing wheels.

## -remarks

**RacingWheel** objects are managed by the system, therefore you don't have to create or initialize them. Instead, you can access connected racing wheels through this property. Because you might only be interested in some of the connected racing wheels, we recommend that you maintain your own collection.

This list is initially empty and will not list racing wheels even if they are already connected. After a short period this will return a complete list of racing wheels.

## -examples

## -see-also
