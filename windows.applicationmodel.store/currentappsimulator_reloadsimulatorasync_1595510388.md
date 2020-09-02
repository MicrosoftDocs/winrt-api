---
-api-id: M:Windows.ApplicationModel.Store.CurrentAppSimulator.ReloadSimulatorAsync(Windows.Storage.StorageFile)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncAction ReloadSimulatorAsync(Windows.Storage.StorageFile simulatorSettingsFile)
-->

# Windows.ApplicationModel.Store.CurrentAppSimulator.ReloadSimulatorAsync

## -description
Reloads the simulator using a [StorageFile](../windows.storage/storagefile.md) containing the **WindowsStoreProxy.xml** file.

If you do not call this method to load your own file, the simulator will create/load (but not overwrite) a **WindowsStoreProxy.xml** file containing a set of default values.

## -parameters
### -param simulatorSettingsFile
The WindowsStoreProxy.xml file that the simulator uses.

## -returns
The async operation that reloads the simulator.

## -remarks
For more information about using this method, see [Using the WindowsStoreProxy.xml file with CurrentAppSimulator](/windows/uwp/monetize/in-app-purchases-and-trials-using-the-windows-applicationmodel-store-namespace).

## -examples

## -see-also
