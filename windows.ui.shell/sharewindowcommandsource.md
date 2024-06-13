---
-api-id: T:Windows.UI.Shell.ShareWindowCommandSource
-api-type: winrt class
---

# Windows.UI.Shell.ShareWindowCommandSource

<!--
public sealed class ShareWindowCommandSource
-->

## -description
Represents an object that your communications app can use to set up communication with the Window Shell to present UI for starting and stopping window sharing. 

Obtain an instance of **ShareWindowCommandSource**, and register to handle the instance's [ShareWindowCommandSource.CommandRequested](sharewindowcommandsource_commandrequested.md) and [ShareWindowCommandSource.CommandInvoked](sharewindowcommandsource_commandinvoked.md) events. Those events are raised by the Windows Shell.

> [!IMPORTANT]
> The **Windows.UI.Shell.ShareWindowCommandSource** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -remarks
This functionality augments the window sharing feature that your application already implements, providing an alternative method for selecting windows. The design allows your app to present start sharing and stop sharing commands; and to implement those in a way that corresponds to your app's ability to share one or more windows.

Your communications app identifies the window that corresponds with the ability to share windows&mdash;the single app window, or windows that host communication sessions (calls). The Windows Shell uses this to:

* Get application identification information, such as its icon and name, which will be presented with the share commands.
* Select among multiple share command sources. The most recently used sharing app will be selected.

Events are used to request commands and invoke them, this includes the [WindowId](/uwp/api/windows.ui.windowid) of the window to be shared.

[IShareWindowCommandSourceInterop](/windows/win32/api/sharewindowcommandsourceinterop/nn-sharewindowcommandsourceinterop-isharewindowcommandsourceinterop) is a native interoperation interface that allows getting a **ShareWindowCommandSource** object.

## -see-also
[ShareWindowCommandSource.CommandRequested](sharewindowcommandsource_commandrequested.md), [ShareWindowCommandSource.CommandInvoked](sharewindowcommandsource_commandinvoked.md), [WindowId](/uwp/api/windows.ui.windowid), [IShareWindowCommandSourceInterop](/windows/win32/api/sharewindowcommandsourceinterop/nn-sharewindowcommandsourceinterop-isharewindowcommandsourceinterop)

## -examples
