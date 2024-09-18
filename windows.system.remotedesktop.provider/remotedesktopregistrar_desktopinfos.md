---
-api-id: P:Windows.System.RemoteDesktop.Provider.RemoteDesktopRegistrar.DesktopInfos
-api-type: winrt property
---

# Windows.System.RemoteDesktop.Provider.RemoteDesktopRegistrar.DesktopInfos

<!--
public static System.Collections.Generic.IList<Windows.System.RemoteDesktop.Provider.RemoteDesktopInfo> DesktopInfos { get; }
-->


## -description

Gets the list of [RemoteDesktopInfo](xref:Windows.System.RemoteDesktop.Provider.RemoteDesktopInfo) objects representing the currently enabled remote desktop connections.

## -property-value

A list of **RemoteDesktopInfo** objects.

## -remarks

When the URI `ms-remotedesktop:setup` is invoked, remote desktop client apps should call **Append** on the **DesktopInfos** collection to register Windows 365 Cloud PCs to the Windows shell.

## -see-also

## -examples


