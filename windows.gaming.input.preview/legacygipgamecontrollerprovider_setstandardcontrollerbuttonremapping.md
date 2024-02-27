---
-api-id: M:Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.SetStandardControllerButtonRemapping(Windows.System.User, bool, IReadOnlyDictionary<RemappingButtonCategory, Object>
)
-api-type: winrt method
---

<!-- Method syntax.
public void LegacyGipGameControllerProvider.SetStandardControllerButtonRemapping(User user, bool previous, IReadOnlyDictionary<RemappingButtonCategory, object> remapping
)
-->

# Windows.Gaming.Input.Preview.LegacyGipGameControllerProvider.SetStandardControllerButtonRemapping

## -description

Changes the button and axis mapping of a standard gamepad for a user.

## -parameters

### -param user

The user to remap the controller for.

### -param previous

<!-- TODO: What is this? -->

### -param remapping

A dictionary matching each [RemappingButtonCategory](remappingbuttoncategory.md) to data that specifies the remapping. The data type is specific to the category as follows:

|RemappingButtonCategory  |Data Description  |
|---------|---------|
|ButtonsSettings     |A uint64 composed of 16 nibbles. Each nibble represents a button's assignment. The standard assignment is 0xfedcba9876543210         |
|AnalogSettings     |A uint32 with the following effects: 0x1 : Swaps triggers 0x2 : Swaps thumbsticks 0x4 : Inverts the left thumbstick 0x8 : Inverts the right thumbstick. The standard assignment is 0.         |
|VibrationSettings  |A uint32 with the following effects: 0x01 : Disables vibration. The standard assignment is 0. |

## -remarks

> [!CAUTION]
> Controller mapping is system-wide and persistent for the given user. This should only be done at the user's direction.

## -examples

:::code language="csharp" source="code/csharp/RemapButtonsSample.cs":::

## -see-also

[RemappingButtonCategory](remappingbuttoncategory.md)
