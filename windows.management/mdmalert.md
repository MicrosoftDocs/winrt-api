---
-api-id: T:Windows.Management.MdmAlert
-api-type: winrt class
---

<!-- Class syntax.
public class MdmAlert 
-->

# Windows.Management.MdmAlert

## -description
Provides functionality to configure the data sent to the mobile device management server.

## -remarks
There are two uses of MdmAlert:

1. Before you start an MdmSession: Create an alert and customize the alert parameters.
2. After you start an MdmSession: Query the session for results from the alert, including status sent back by the server for the alert.

Note: The generic alert (1226) is most common.

## -see-also

## -examples

```cpp
void MultipleMdmAlerts() 
{
    Log::Comment(WEX::Common::String().Format(L"Attempt to start syncing with two Alerts..."));
    Log::Comment(WEX::Common::String().Format(L"Fill in all members of first alert."));

    Windows::Management::MdmAlert^ myAlert = ref new Windows::Management::MdmAlert();

    // This format is mandated by the OMA-DM standards for alerts.
    myAlert->Type = ref new Platform::String(L"Reversed-Domain-Name:org.domain.samplealert");
    myAlert->Format = Windows::Management::MdmAlertDataType::String;
    myAlert->Data = ref new Platform::String(L"alert-specific content.");
    myAlert->Mark = Windows::Management::MdmAlertMark::Critical;

    // Source and Target URIs are relative to the device and typically in the MDM namespace.
    // Here, they indicate that an app was installed at "InstallSample" and the resulting
    // inventory location of the app is at "Results".
    myAlert->Source = ref new Platform::String(L"./Vendor/MSFT/AppManagement/InstallSample");
    myAlert->Target = ref new Platform::String(L"./Vendor/MSFT/AppManagement/Results");
   
    Windows::Management::MdmAlert^ myAlertNext = ref new Windows::Management::MdmAlert();
    myAlertNext->Type = ref new Platform::String(L"Reversed-Domain-Name:org.domain.nextalert");

    Windows::Foundation::Collections::IVector<MdmAlert^>^ alertList = ref new Platform::Collections::Vector<MdmAlert^>();

    alertList->Append(myAlert);
    alertList->Append(myAlertNext);
}
```
