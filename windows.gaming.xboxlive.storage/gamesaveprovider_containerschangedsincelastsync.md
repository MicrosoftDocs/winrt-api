---
-api-id: P:Windows.Gaming.XboxLive.Storage.GameSaveProvider.ContainersChangedSinceLastSync
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<string> ContainersChangedSinceLastSync { get; }
-->

# Windows.Gaming.XboxLive.Storage.GameSaveProvider.ContainersChangedSinceLastSync

## -description

Called on a new [GameSaveProvider](gamesaveprovider.md) instance, returns the names of containers that have changed since the application last ran.

## -property-value

Type: **IVectorView\<;String>;** \[JavaScript/C++\] | [System.Collections.Generic.IReadOnlyList\<;String>;](https://msdn.microsoft.com/library/hh192385.aspx) \[.NET\]

String names of containers that changed since the application last ran.

## -remarks

Game save containers can be written to from another device while an application is suspended or terminated. When the application resumes, **ContainersChangedSinceLastSync** will indicate the containers that were changed.

## -examples

## -see-also

[GameSaveProvider](gamesaveprovider.md)
