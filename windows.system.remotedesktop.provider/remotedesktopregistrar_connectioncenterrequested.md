---
-api-id: E:Windows.System.RemoteDesktop.Provider.RemoteDesktopRegistrar.ConnectionCenterRequested
-api-type: winrt event
---

# Windows.System.RemoteDesktop.Provider.RemoteDesktopRegistrar.ConnectionCenterRequested

<!--
public static event Windows.Foundation.EventHandler<object> ConnectionCenterRequested;
-->


## -description

Raised when the user requests the boot to cloud Connection Center in a remote desktop provider app.

## -remarks

Remote desktop provider apps running in the [boot to cloud](/windows-365/enterprise/windows-365-boot-overview#connection-center-at-logon) scenario should subscribe to this event to receive notifications when the user has requested the Connection Center. When the event is raised, the app should display the Connection Center UI to the user.

> [!IMPORTANT]
> The **RemoteDesktopRegistrar** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -see-also

[RemoteDesktopRegistrar](remotedesktopregistrar.md)

## -examples


