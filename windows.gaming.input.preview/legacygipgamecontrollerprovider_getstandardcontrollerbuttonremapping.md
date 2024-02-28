---
-api-id: M:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.GetStandardControllerButtonRemapping(Windows.System.User, bool)
-api-type: winrt method
---

<!-- Method syntax.
public IReadOnlyDictionary<RemappingButtonCategory, object> LegacyGipGameControllerProvider.GetStandardControllerButtonRemapping(User user, bool previous)
-->

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.GetStandardControllerButtonRemapping

## -description

Gets the button and axis mapping of a standard gamepad for a user.

## -parameters

### -param user

The user to get controller mappings for.

### -param previous

```True``` if the mapping should be read from the inactive Previous store; ```false``` if the active mapping should be read.

## -returns

A dictionary matching each [RemappingButtonCategory](remappingbuttoncategory.md) to data that specifies the remapping. The data type is specific to the category as follows:

|RemappingButtonCategory  |Data Description  |
|---------|---------|
|ButtonsSettings     |A uint64 composed of 16 nibbles. Each nibble represents a button's assignment. The standard assignment is 0xfedcba9876543210         |
|AnalogSettings     |A uint32 with the following effects: 0x1 : Swaps triggers 0x2 : Swaps thumbsticks 0x4 : Inverts the left thumbstick 0x8 : Inverts the right thumbstick. The standard assignment is 0.         |
|VibrationSettings  |A uint32 with the following effects: 0x01 : Disables vibration. The standard assignment is 0. |

## -remarks

Normally, the ```previous``` parameter should be ```false```. This will read the current controller mapping. ```Previous``` may be used to read a mapping that was saved for later. For example, it may be useful to read a saved mapping to restore a previous state.

> [!CAUTION]
> Controller mapping is system-wide and persistent for the given user. This should only be done at the user's direction.

## -examples

:::code language="csharp" source="code/csharp/RemapButtonsSample.cs":::

## -see-also

[RemappingButtonCategory](remappingbuttoncategory.md)
