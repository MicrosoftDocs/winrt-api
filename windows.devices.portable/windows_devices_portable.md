---
-api-id: N:Windows.Devices.Portable
-api-type: winrt namespace
---

# Windows.Devices.Portable

## -description
[Windows Portable Devices](/windows/desktop/windows-portable-devices) (WPD) enables computers to communicate with attached media and storage devices. This namespace provides methods for identifying Windows Portable Device (WPD) services and storage.

## -remarks
This table lists the GUIDs of standard MTP device services that can be passed to the *serviceId* parameter. For more information about these MTP devices services, see [MTP Device Services for Windows](/previous-versions/windows/hardware/design/dn613966(v=vs.85)).

While the standard device services are all MTP device services, non-MTP devices may also support services. An MTP device may also support additional device services that are not standard device services. Check with the device manufacturer to find out what device services are supported on a given WPD device.

<table>
   <tr><th>Service</th><th>GUID</th></tr>
   <tr><td>MTP Contact Service</td><td>DD04D5FC-9D6E-4F76-9DCF-ECA6339B7389</td></tr>
   <tr><td>MTP Calendar Service</td><td>E4DFDBD3-7F04-45E9-9FA1-5CA0EAEB0AE3</td></tr>
   <tr><td>MTP Notes Service</td><td>5c017aea-e706-4719-8cc0-a303836fd321</td></tr>
   <tr><td>MTP Task Service</td><td>BB340C54-B5C6-491D-8827-28D0E7631903</td></tr>
   <tr><td>MTP Status Service</td><td>0B9F1048-B94B-DC9A-4ED7-FE4FED3A0DEB</td></tr>
   <tr><td>MTP Hints Service</td><td>c8a98b1f-6b19-4e79-a414-67ea4c39eec2</td></tr>
   <tr><td>MTP Device Metadata Service</td><td>332ffe6a-af65-41e1-a0af-d3e2627bdf54</td></tr>
   <tr><td>MTP Ringtone Service</td><td>d0eace0e-707d-4106-8d38-4f560e6a9f8e</td></tr>
   <tr><td>MTP Enumeration Synchronization Service</td><td>28d3aac9-c075-44be-8881-65f38d305909</td></tr>
   <tr><td>MTP Anchor Synchronization Service</td><td>056d8b9e-ad7a-44fc-946f-1d63a25cda9a</td></tr>
</table>

To access these services, you must declare the device service in the device capabilities section of the *appxmanifest* file. For example:

```
  <Capabilities>
    <DeviceCapability Name="0B9F1048-B94B-DC9A-4ED7-FE4FED3A0DEB"/> <!-- Status Device Service -->
    <DeviceCapability Name="D0EACE0E-707D-4106-8D38-4F560E6A9f8E"/> <!-- Ringtones Device Service -->
  </Capabilities>
```



This table lists GUIDs commonly used when accessing storage functionality on WPD devices using the WPD APIs. These can also be declared in the device capabilities section of the *appxmanifest* file.<table>
   <tr><th>Storage Functionality</th><th>GUID</th></tr>
   <tr><td>WPD Storage</td><td>6AC27878-A6FA-4155-BA85-F98F491D4F33</td></tr>
   <tr><td>WPD Storage (private devices)</td><td>BA0C718F-4DED-49B7-BDD3-FABE28661211</td></tr>
   <tr><td>Imaging Devices (for example, cameras)</td><td>6BDD1FC6-810F-11D0-BEC7-08002BE2092F</td></tr>
</table>

## -examples

## -see-also
[Windows Portable Devices](/windows/desktop/windows-portable-devices)
