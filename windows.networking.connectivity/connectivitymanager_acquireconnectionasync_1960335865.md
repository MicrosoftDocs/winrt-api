---
-api-id: M:Windows.Networking.Connectivity.ConnectivityManager.AcquireConnectionAsync(Windows.Networking.Connectivity.CellularApnContext)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.Networking.Connectivity.ConnectionSession> AcquireConnectionAsync(Windows.Networking.Connectivity.CellularApnContext cellularApnContext)
-->

# Windows.Networking.Connectivity.ConnectivityManager.AcquireConnectionAsync

## -description
Establishes a connection to a specific access point on a network. The request is defined using a [CellularApnContext](cellularapncontext.md) object.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators. Mobile operators must enable the **cellularDeviceControl** restricted capability to use this API. 

## -parameters
### -param cellularApnContext
Provides specific details about the APN.

## -returns
The established APN connection.

## -remarks

## -examples

## -see-also
[CellularApnContext](cellularapncontext.md)

## -capabilities
cellularDeviceControl
