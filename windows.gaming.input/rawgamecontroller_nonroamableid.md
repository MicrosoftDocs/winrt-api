---
-api-id: P:Windows.Gaming.Input.RawGameController.NonRoamableId
-api-type: winrt property
---

<!-- Property syntax.
public string NonRoamableId { get; }
-->

# Windows.Gaming.Input.RawGameController.NonRoamableId

## -description

A unique ID that identifies the controller. As long as the controller is connected, the ID will never change.

## -property-value

A unique ID that identifies the controller. As long as the controller is connected, the ID will never change.

## -remarks

This ID has a longer lifetime than both the application and the controller's connection. It's guaranteed not to change for a given controller, even between reboots of the device it's connected to, as long as the controller remains plugged into the same USB port on the device. An example where this might be useful is for games like flight simulators, where the user might plug several of the same type of controller into their PC, like modules with instrument panels. When the user assigns functions to those controllers in the game, the game needs to be able to identify each controller uniquely (which it can't do from the product and vendor IDs alone) so it can make sure the right functions are assigned to the right controllers the next time it runs.

This ID is also unique to the application on that device. The same exact gamepad, plugged into the same PC, will have a different **NonRoamableId** in two different applications. Likewise, the same exact gamepad, running in the same application, but on different PCs, will have different **NonRoamableId**s.

## -see-also

## -examples
