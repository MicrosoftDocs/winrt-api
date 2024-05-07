---
-api-id: T:Windows.System.RemoteDesktop.Provider.RemoteDesktopConnectionInfo
-api-type: winrt class
---

# Windows.System.RemoteDesktop.Provider.RemoteDesktopConnectionInfo

<!--
public sealed class RemoteDesktopConnectionInfo
-->


## -description

Represents a remote desktop connection on the local desktop.

> [!IMPORTANT]
> The **RemoteDesktopConnectionInfo** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -remarks

Get an instance of this class by calling [GetForLaunchUri](xref:Windows.System.RemoteDesktop.Provider.RemoteDesktopConnectionInfo.GetForLaunchUri(Windows.Foundation.Uri,Windows.UI.WindowId)).

For the remote desktop connections to CloudPCs that are launched from Task view, users can configure which redirections they allow in the Settings app under the **Privacy and security > CloudPC** tab. Applications using this API may want to read the following registry keys to honor the Cloud PC configuration set by the user in the Settings application: 

|Feature | Registry Key |
|--------|--------------|
| Clipboard | HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\CloudPCSetting\AllowClipboardRedirection |
| Printer |  HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\CloudPCSetting\AllowPrinterRedirection |
| Local Hard Drive | HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\CloudPCSetting\AllowLocalHardDriveRedirection |
| Microphone | HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\CloudPCSetting\AllowMicrophoneRedirection |
| Location | HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\CloudPCSetting\AllowLocationRedirection |
| Camera | HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\CloudPCSetting\AllowCameraRedirection |
| Smart Card | HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\CloudPCSetting\AllowSmartCardRedirection |
| USB ports | HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\CloudPCSetting\AllowUSBPortsRedirection |
| COM ports | HKEY_CURRENT_USER\Software\Microsoft\Windows NT\CurrentVersion\CloudPCSetting\AllowCOMPortsRedirection |

The value for each key is a REG_DWORD and is interpreted using the following semantics:

- Off value: 0
- On value: 1
- No value (default): 1



## -see-also

## -examples


