---
-api-id: T:Windows.Devices.Printers.Extensions.PrintTaskConfigurationSaveRequestedEventArgs
-api-type: winrt class
---

<!-- Class syntax.
public class PrintTaskConfigurationSaveRequestedEventArgs : Windows.Devices.Printers.Extensions.IPrintTaskConfigurationSaveRequestedEventArgs
-->

# Windows.Devices.Printers.Extensions.PrintTaskConfigurationSaveRequestedEventArgs

## -description
Called to notify the device app that the print task configuration must be saved.

## -remarks
When the print dialog for your UWP app raises the [PrintTaskConfiguration.SaveRequested](printtaskconfiguration_saverequested.md) event, it references an instance of the **PrintTaskConfigurationSaveRequestedEventArgs** class. The Microsoft Store device app retrieves the information that it needs from this class to update the print ticket.

## -examples

## -see-also
[PrintTaskConfiguration.SaveRequested](printtaskconfiguration_saverequested.md)