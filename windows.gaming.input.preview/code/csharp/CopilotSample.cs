public void CopilotSample(GipGameControllerProvider pilotProvider,
                                    GipGameControllerProvider copilotProvider)
{
    // Establish a copilot pairing for the given pilot and copilot providers
    string pilotId = GameControllerProviderInfo.GetProviderId(pilotProvider);
    string copilotId = GameControllerProviderInfo.GetProviderId(copilotProvider);
    User user = User.GetDefault();
    LegacyGipGameControllerProvider.PairPilotToCopilot(user, pilotId,
        copilotId);

    // Read copilot properties
    LegacyGipGameControllerProvider.IsPilot(user, pilotId); // Returns copilotId
    LegacyGipGameControllerProvider.IsPilot(user, copilotId); // Returns null
    LegacyGipGameControllerProvider.IsCopilot(user, pilotId); // Returns null
    LegacyGipGameControllerProvider.IsCopilot(user, copilotId); // Returns pilotId

    // Removes the pairing for both controllers
    LegacyGipGameControllerProvider.ClearPairing(user, pilotId);
    // Also removes the pairing for both controllers (unnecessary since the pairing was already removed)
    LegacyGipGameControllerProvider.ClearPairing(user, copilotId);
}
