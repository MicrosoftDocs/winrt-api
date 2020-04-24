---
-api-id: N:Windows.Devices.WiFiDirect.Services
-api-type: winrt namespace
---

# Windows.Devices.WiFiDirect.Services

## -description

Provides support for implementing your own Wi-Fi Direct Services.

Wi-Fi Direct is a technology that enables two devices to connect directly to each other using Wi-Fi, without needing to join an existing network through an access point. Wi-Fi Direct Services are the way that one device (a *Service Advertiser*) offers capabilities to another device (a *Service Seeker*) over a Wi-Fi Direct connection. A seeker makes use of an advertised service by establishing a *session*. A given device can advertise multiple services and also seek multiple services. The Seeker and Advertiser roles are defined with respect to how the devices interact in a particular session.

While the Wi-Fi Direct Services specification defines several standard services, this API supports only the *Enable* service. It does not support *Send*, *Play*, *Print*, or *Display* functionality.

## -remarks

### Setting the Group Owner (GO)

You might want to be able to exert precise control over which of the members of a Peer to Peer (P2P) group is the Group Owner (GO). Your code should use the [WiFiDirectAdvertiser.PreferGroupOwnerMode](wifidirectserviceadvertiser_prefergroupownermode.md) property to specify that a given advertiser wants to be the GO. However, if two devices have been previously paired via Wi-Fi Direct, then the Wi-Fi direct roles in the saved profile from that pairing override the advertiser's specified preference. In order to guarantee that a given device in a P2P pairing will be the GO, you must first delete any existing pairing data, using methods provided by the [Windows.Devices.Enumeration](../windows.devices.enumeration/windows_devices_enumeration.md) namespace.

Note that a pairing profile pairs two MAC addresses, so unpairing two devices applies to all apps that use Wi-Fi Direct between those two devices. Your app should never assume that a pairing profile exists, or that it has not been changed by another app, even if it has paired with a device in the past. You should get current profile information from the current profile rather than storing profile information and assuming it is still true at a later date. Another app might have changed the pairing profile in the interim.

The following code finds any Wi-Fi Direct pairing profile between the local device and another device, and unpairs the two devices. After this code has successfully unpaired the two devices, subsequent pairing will obey the [WiFiDirectAdvertiser.PreferGroupOwnerMode](wifidirectserviceadvertiser_prefergroupownermode.md) value active at the time of pairing.

```csharp

using Windows.Devices.Enumeration;

private async void Unpair_Click(object sender, Windows.UI.Xaml.RoutedEventArgs e)
{
    if (DiscoveredServices.Items.Count > 0)
    {
        DiscoveredDeviceWrapper service = 
            (DiscoveredDeviceWrapper)DiscoveredServices.Items[DiscoveredServices.SelectedIndex];

        String[] aepId = service.DeviceInfo.Id.Split('#');
        String deviceSelector = "System.Devices.DeviceInstanceId:=\"SWD\\WiFiDirect\\" + aepId[1] + "\"";

        // Check if device is paired
        DeviceInformationCollection pairedDeviceCollection = 
            await DeviceInformation.FindAllAsync(deviceSelector, null, DeviceInformationKind.DeviceInterface);

        if (pairedDeviceCollection.Count > 0)
        {
            try
            {
                DeviceInformation devInfo = pairedDeviceCollection[0];
                await devInfo.Pairing.UnpairAsync();
                MainPage.Current.NotifyUser("UnpairAsync succeeded", NotifyType.StatusMessage);
            }

            catch (Exception ex)
            {
                MainPage.Current.NotifyUser("UnpairAsync failed: " + ex.Message, NotifyType.ErrorMessage);
            }
        }
    }
}


```

## -examples

## -see-also

[Wi-Fi Direct services sample (Windows 10)](https://github.com/Microsoft/Windows-universal-samples/tree/master/Samples/WiFiDirectServices)
