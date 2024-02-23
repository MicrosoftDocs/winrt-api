void RemapButtons(IGameController controller, IGameControllerProvider controllerProvider)
{
    LegacyGipGameControllerProvider legacyGipGameControllerProvider =
        LegacyGipGameControllerProvider.FromGameControllerProvider(controllerProvider);

    // Retrieve all current remappings set for standard controllers
    IReadOnlyDictionary<RemappingButtonCategory, object> currentMappings =
        legacyGipGameControllerProvider.GetStandardControllerButtonRemapping(
            controller.User, false);

    // Depending on the remapping button category a different type is
    // expected (if present):
    // ButtonSettings
    //  A uint64 composed of 16 nibbles. Each nibble represents a button's assignment.
    //  The standard assignment is: 0xfedcba9876543210
    //
    // AnalogSettings
    //  A uint32 with the following effects
    //  0x1 : Swaps triggers
    //  0x2 : Swaps thumbsticks
    //  0x4 : Inverts the left thumbstick
    //  0x8 : Inverts the right thumbstick
    //
    //  The standard assignment is 0
    //
    // VibrationSettings
    //  A uint32 with the following effects:
    //  0x01 : Disables vibration
    //
    //  The standard assignment is 0

    // Swap two of the buttons
    Dictionary<RemappingButtonCategory, object> remaps =
        new Dictionary<RemappingButtonCategory, object>();

    // Duplicates are not allowed. Swap two of the buttons
    UInt64 currentButtonMappings =
       (UInt64)currentMappings[RemappingButtonCategory.ButtonSettings];

    // Isolate the buttons we want to remap
    UInt64 lastButton = (currentButtonMappings & 0xf000000000000000);
    UInt64 secondLastButton = currentButtonMappings & 0x0f00000000000000;

    // Swap their positions
    UInt64 newMapping = (lastButton >> 4) | (secondLastButton << 4);

    // Recombine with the original mappings
    UInt64 newButtonMappings = (currentButtonMappings & 0x00ffffffffffffff) | newMapping;

    // Add the new button remappings to the mapping dictionary
    remaps.Add(RemappingButtonCategory.ButtonSettings, newButtonMappings);

    // Update controller mapping
    legacyGipGameControllerProvider.SetStandardControllerButtonRemapping(
        controller.User, false, newButtonMappings);
}
