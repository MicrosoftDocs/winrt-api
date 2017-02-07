---
-api-id: T:Windows.Gaming.Input.Custom.IGameControllerProvider
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IGameControllerProvider : 
-->

# Windows.Gaming.Input.Custom.IGameControllerProvider

## -description
Base interface that represents the physical game controller devices connected to the system.

## -remarks
Device classes are not activatable, they can be enumerated via a collection property on the device manager runtime class, however this is restricted to store apps with the xboxAccessoryManagement capability. The typical way to gain access to a device class object is by registering a factory for a custom game controller class.

## -examples

## -see-also