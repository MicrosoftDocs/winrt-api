---
-api-id: P:Windows.Devices.WiFiDirect.WiFiDirectLegacySettings.Passphrase
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public Windows.Security.Credentials.PasswordCredential Passphrase { get;  set; }
-->

# Windows.Devices.WiFiDirect.WiFiDirectLegacySettings.Passphrase

## -description
Gets or sets the pass phrase used by non-Wi-Fi Direct clients to connect to this access point in "legacy mode".

## -property-value
The pass phrase for the Wi-Fi network. This access point functions as a normal Wi-Fi access point, and is intended to support devices which do not support connection via Wi-Fi Direct.

## -remarks
Windows 10 and Windows 10 Mobile can be configured to allow embedded mode, which allows a device to run a single app. If embedded mode is configured, the Passphrase value can be explicitly set to **null** to support Open/None Authentication. Not all Wi-Fi adapters may support this feature on Windows. For more information, see [Embedded mode](/windows/iot-core/develop-your-app/EmbeddedMode). 

## -examples

## -see-also
