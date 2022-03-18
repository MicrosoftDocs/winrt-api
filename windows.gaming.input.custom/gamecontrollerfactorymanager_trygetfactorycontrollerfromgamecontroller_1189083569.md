---
-api-id: M:Windows.Gaming.Input.Custom.GameControllerFactoryManager.TryGetFactoryControllerFromGameController(Windows.Gaming.Input.Custom.ICustomGameControllerFactory,Windows.Gaming.Input.IGameController)
-api-type: winrt method
---

<!-- Method syntax.
public IGameController GameControllerFactoryManager.TryGetFactoryControllerFromGameController(ICustomGameControllerFactory factory, IGameController gameController)
-->

# Windows.Gaming.Input.Custom.GameControllerFactoryManager.TryGetFactoryControllerFromGameController

## -description

Tries to get a game controller that belongs to the specified factory and references the same underlying game controller as the one that was specified. 

## -parameters

### -param factory

The factory for the type of game controller that you want to get.

### -param gameController

The game controller that references the underlying device for which you want to get another game controller representation.

## -returns

If found, a game controller that belongs to the specified factory and references the same underlying device as the specified game controller; otherwise, **null**.

## -remarks

This method provides the implementation for each game controller class's **FromGameController** method. A class's **FromGameController** method allows you to pass in an instance of one game controller class, and get an object from another game controller class that references the same underlying device. For example, if you have an [ArcadeStick](../windows.gaming.input/arcadestick.md) and you want to get a [RawGameController](../windows.gaming.input/rawgamecontroller.md) representation of that same underlying controller, you would call [RawGameController.FromGameController](../windows.gaming.input/rawgamecontroller_fromgamecontroller_421915006.md), passing in the **ArcadeStick** (which you can do, since the method takes an [IGameController](../windows.gaming.input/igamecontroller.md) object, and **ArcadeStick** inherits from **IGameController**). Your custom game controller classes must also inherit from **IGameController**.

Since each game controller class implements [ICustomGameControllerFactory](icustomgamecontrollerfactory.md) (including your own custom classes), you can pass the factory for the game controller class that you want into **GameControllerFactoryManager.TryGetFactoryControllerFromGameController**, and then the **GameControllerFactoryManager** can try to return an object of that class that references the same underlying device as the game controller that you specified.

## -see-also

[Windows.Gaming.Input.IGameController](../windows.gaming.input/igamecontroller.md), [Windows.Gaming.Input.Custom.ICustomGameControllerFactory](icustomgamecontrollerfactory.md)

## -examples

