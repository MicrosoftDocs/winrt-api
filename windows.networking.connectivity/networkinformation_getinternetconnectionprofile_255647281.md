---
-api-id: M:Windows.Networking.Connectivity.NetworkInformation.GetInternetConnectionProfile
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Networking.Connectivity.ConnectionProfile GetInternetConnectionProfile()
-->

# Windows.Networking.Connectivity.NetworkInformation.GetInternetConnectionProfile

## -description

Retrieves the connection profile associated with the *preferred* interface currently used by the local machine. The *preferred* interface is the one most likely to send or receive internet traffic. This means that the returned profile might or might not have internet access.

## -returns
The connection profile associated with the *preferred* interface, or **null** if there's no connection profile with a suitable connection.

## -remarks
To be notified of changes in connectivity, register a handler with the [NetworkStatusChanged](networkinformation_networkstatuschanged.md) event. When a notification is received of a network status change, call the **GetInternetConnectionProfile** method to get the current connection profile which can then be stored for later use when needed.

The following example demonstrates how to retrieve a [ConnectionProfile](connectionprofile.md). The function calls **GetInternetConnectionProfile** to retrieve the [ConnectionProfile](connectionprofile.md) representing the connection currently most likely used for internet connectivity. Alternatively, your app can call [GetConnectionProfiles](networkinformation_getconnectionprofiles_582657984.md) to retrieve all available connections on a device.

> [!NOTE]
> For the implementation of the **GetConnectionProfileInfo** method in the code below, and for additional examples of how [NetworkInformation](networkinformation.md) class methods are implemented to retrieve connection profiles, see [Quickstart: Retrieving network connection information](/previous-versions/windows/apps/hh452990(v=win.10)).

```csharp
using Windows.Networking.Connectivity;

// Retrieve the ConnectionProfile.
ConnectionProfile internetConnectionProfile = NetworkInformation.GetInternetConnectionProfile();

// Pass the returned object to a function that accesses the connection data.
string connectionProfileInfo = GetConnectionProfileInfo(internetConnectionProfile);
```

```cppwinrt
#include <winrt/Windows.Networking.Connectivity.h>
using namespace winrt;

std::wstring GetConnectionProfileInfo(Windows::Networking::Connectivity::ConnectionProfile const& connectionProfile)
{
    ...
}

int main()
{
    winrt::init_apartment();

    // Retrieve the ConnectionProfile.
    auto internetConnectionProfile{ Windows::Networking::Connectivity::NetworkInformation::GetInternetConnectionProfile() };

    // Pass the returned object to a function that accesses the connection data.
    std::wstring strConnectionProfileInfo{ GetConnectionProfileInfo(internetConnectionProfile) };
}
```

```cppcx
using namespace Windows::Networking::Connectivity;

// Retrieve the ConnectionProfile.
ConnectionProfile^ internetConnectionProfile = NetworkInformation::GetInternetConnectionProfile();

// Pass the returned object to a function that accesses the connection data.
String^ strConnectionProfileInfo = GetConnectionProfileInfo(internetConnectionProfile);
```

If more than one connection profile is currently connecting the machine to the internet, the preferred profile is returned by this method. The preferred profile represents the connection that is the most likely to be used when sending and receiving traffic to and from the internet.

## -examples

## -see-also
