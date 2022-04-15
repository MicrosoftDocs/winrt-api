---
-api-id: P:Windows.ApplicationModel.Activation.ILaunchActivatedEventArgs.TileId
-api-type: winrt property
---

<!-- Property syntax
public string TileId { get; }
-->

# Windows.ApplicationModel.Activation.ILaunchActivatedEventArgs.TileId

## -description
Gets the ID of the tile that was invoked to launch the app.

## -property-value
The ID of the tile that launched the app. If the app's main tile was used, this value is "App". If a secondary tile is used, the [SecondaryTile.TileId](../windows.ui.startscreen/secondarytile_tileid.md) value, assigned to the secondary tile when it was created, is returned.

## -remarks
Starting with Windows 10, **TileId** behavior is different for apps that are launched after having been terminated. Previously, the **TileId** always returned the ID of the tile that launched the app. The **TileId** behavior now depends on how the app is reactivated:

| How the app is reactivated | Behavior of TileId |
|---|---|
| The user switches to the app by using the task switcher or by using the global back key | Returns the empty string `("")`. |
| The user taps the app tile | Returns the tile ID. |

The new behavior makes it possible to differentiate between a switch to the app versus a re-launch of the app. If your app uses tile ID information during activation, handle the `TileId==""` case. For example:


```csharp
protected override void OnLaunched(LaunchActivatedEventArgs e)
{
...
  if (e.TileId == "")
  {
    // resumed from switch/backstack
  }
  else
  {
    // resumed from tile launch
  }
...
}
```



## -examples

## -see-also
