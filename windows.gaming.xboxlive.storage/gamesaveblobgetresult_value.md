---
-api-id: P:Windows.Gaming.XboxLive.Storage.GameSaveBlobGetResult.Value
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IMapView<string, Windows.Storage.Streams.IBuffer> Value { get; }
-->

# Windows.Gaming.XboxLive.Storage.GameSaveBlobGetResult.Value

## -description
Collection of named game save blobs.

## -property-value
Type: **IMapView\<;String, IBuffer>;** \[JavaScript/C++\] | [System.Collections.Generic.IReadOnlyDictionary\<;String, IBuffer>;](/dotnet/api/system.collections.generic.ireadonlydictionary-2?view=dotnet-uwp-10.0&preserve-view=true) \[.NET\]

## -remarks
**Value** is valid only if [GameSaveBlobGetResult.Status](gamesaveblobgetresult_status.md) is [GameSaveErrorStatus.Ok](gamesaveerrorstatus.md).

## -examples

## -see-also
[GameSaveBlobGetResult](gamesaveblobgetresult.md)