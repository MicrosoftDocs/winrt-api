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

## -remarks

Get an instance of this class by calling [GetForLaunchUri](xref:Windows.System.RemoteDesktop.Provider.RemoteDesktopConnectionInfo.GetForLaunchUri(Windows.Foundation.Uri,Windows.UI.WindowId)).

The remote desktop redirection of Windows devices and features for Cloud PC switch scenarios can be set by end users in the **Privacy and Security** tab Settings app. The following table lists the registry keys that are set by the settings app to control remote desktop redirection. 

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

The values of each key is a REG_DWORD and is interpreted using the following semantics:

- Off value: 0
- On value: 1
- No value (default): 1



## -see-also

## -examples


