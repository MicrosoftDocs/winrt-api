public void SetupHeadset(IGameControllerProvider headsetProvider)
{
    LegacyGipGameControllerProvider legacyGipGameControllerProvider =
        LegacyGipGameControllerProvider.FromGameControllerProvider(headsetProvider);

    // Reset the device
    legacyGipGameControllerProvider.ExecuteCommand(DeviceCommand.Reset);

    // Check the smart mute level
    byte[] smartMuteBuffer =
        legacyGipGameControllerProvider.GetHeadsetOperation(HeadsetOperation.SmartMute);
    HeadsetLevel smartMuteValue = (HeadsetLevel)smartMuteBuffer[0];

    // Set bass boost to 3db
    byte[] bassBuffer = BitConverter.GetBytes((UInt32)3);
    legacyGipGameControllerProvider.SetHeadsetOperation(HeadsetOperation.BassBoostGain,
        bassBuffer);
}
