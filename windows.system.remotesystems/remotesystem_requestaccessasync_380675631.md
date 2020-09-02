---
-api-id: M:Windows.System.RemoteSystems.RemoteSystem.RequestAccessAsync
-api-type: winrt method
---

<!-- Method syntax
public Windows.Foundation.IAsyncOperation<Windows.System.RemoteSystems.RemoteSystemAccessStatus> RequestAccessAsync()
-->

# Windows.System.RemoteSystems.RemoteSystem.RequestAccessAsync

## -description
Gets the status of the calling app's access to the Remote Systems feature. This method should always be called before an app attempts to discover or otherwise interact with remote systems.

## -returns
An asynchronous operation that returns the status of access.

## -remarks
This method must be called from the UI thread.

Some of the conditions that are tested by calls to this method are: 
* The application has added the `remoteSystem` capability.
* Remote Systems scenarios are allowed by the [Group Policy](https://www.microsoft.com/download/details.aspx?id=25250) setting (**HKLM\Software\Policies\Microsoft\Windows\System!EnableCdp**). 
* Remote Systems scenarios are allowed by the [mobile device management (MDM)](/windows/client-management/mdm/new-in-windows-mdm-enrollment-management) policy setting (**Connectivity/AllowConnectedDevices**).

## -examples

## -see-also


## -capabilities
remoteSystem
