public void EnumerateControllerProperties()
{
    foreach (Gamepad gamepad in Gamepad.Gamepads)
    {
        LegacyGipGameControllerProvider legacyGipGameControllerProvider =
            LegacyGipGameControllerProvider.FromGameController(gamepad);
        if (legacyGipGameControllerProvider == null)
        {
            // Not every gamepad is a legacy GIP game controller, continue enumerating
            continue;
        }

        GameControllerBatteryChargingState chargeState =
            legacyGipGameControllerProvider.BatteryChargingState;
        GameControllerBatteryLevel batteryLevel =
            legacyGipGameControllerProvider.BatteryLevel;
        bool isOldFirmwareCorrupted =
            legacyGipGameControllerProvider.IsFirmwareCorrupted;
        bool isNewFirmwareCorrupted =
            legacyGipGameControllerProvider.GetDeviceFirmwareCorruptionState()
            != GameControllerFirmwareCorruptReason.NotCorrupt;
        bool isSynthetic = legacyGipGameControllerProvider.IsSyntheticDevice;

        // Check for a particular GIP interface
        bool supportsSomeCustomInterface =
            legacyGipGameControllerProvider.IsInterfaceSupported(
                new Guid(
                    0xaaaaaaaa, 0xbbbb, 0xcccc, 0xe, 0xf, 0x1, 0x2, 0x3, 0x4, 0x5, 0x6));

        IReadOnlyList<string> preferredTypes =
            legacyGipGameControllerProvider.PreferredTypes;
        bool isGamepad = preferredTypes.Contains("Windows.Xbox.Input.Gamepad");
        bool isHeadset = preferredTypes.Contains("Windows.Xbox.Input.Headset");
    }
}
