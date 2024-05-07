---
-api-id: M:Windows.UI.Shell.TaskbarManager.RequestPinSecondaryTileAsync(Windows.UI.StartScreen.SecondaryTile)
-api-type: winrt method
ms.custom: RS5
---

<!-- Method syntax.
public IAsyncOperation<bool> TaskbarManager.RequestPinSecondaryTileAsync(SecondaryTile secondaryTile)
-->

# Windows.UI.Shell.TaskbarManager.RequestPinSecondaryTileAsync

## -description

Requests to pin the specified tile to taskbar. Requires user approval as described [here](/windows/uwp/design/shell/pin-to-taskbar#4-pin-your-app).

> [!IMPORTANT]
> The **TaskbarManager.RequestPinSecondaryTileAsync** API is part of a Limited Access Feature (see [LimitedAccessFeatures class](/uwp/api/windows.applicationmodel.limitedaccessfeatures)). For more information or to request an unlock token, please use the [LAF Access Token Request Form](https://go.microsoft.com/fwlink/?linkid=2271232&clcid=0x409).

## -parameters

### -param secondaryTile

The secondary tile to be pinned.

## -returns

A boolean representing whether the tile is pinned to the takbar. If the tile was already pinned, this will update the tile and return true. If pinning wasn't allowed or taskbar isn't supported, this will return false.

## -remarks

This API can only be used with user approval, as described [here](/windows/uwp/design/shell/pin-to-taskbar#4-pin-your-app). See the docs for pinning secondary tiles to taskbar to learn more.

## -see-also

[Pin your app to the taskbar](/windows/uwp/design/shell/pin-to-taskbar), [Pin secondary tiles to taskbar](/windows/uwp/design/shell/tiles-and-notifications/secondary-tiles-pin-to-taskbar)

## -examples
