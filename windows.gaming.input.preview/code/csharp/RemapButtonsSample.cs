void RemapButtons(IGameController controller, IGameControllerProvider controllerProvider)
{
    LegacyGipGameControllerProvider legacyGipGameControllerProvider =
        LegacyGipGameControllerProvider.FromGameControllerProvider(controllerProvider);

    // Retrieve all current remappings set for standard controllers
    IReadOnlyDictionary<RemappingButtonCategory, object> currentMappings =
        legacyGipGameControllerProvider.GetStandardControllerButtonRemapping(
            controller.User, false);

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
