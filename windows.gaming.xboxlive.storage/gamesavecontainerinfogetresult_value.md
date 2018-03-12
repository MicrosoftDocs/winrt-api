---
-api-id: P:Windows.Gaming.XboxLive.Storage.GameSaveContainerInfoGetResult.Value
-api-type: winrt property
---

<!-- Property syntax
public Windows.Foundation.Collections.IVectorView<Windows.Gaming.XboxLive.Storage.GameSaveContainerInfo> Value { get; }
-->

# Windows.Gaming.XboxLive.Storage.GameSaveContainerInfoGetResult.Value

## -description

A collection of container information returned by [GameSaveContainerInfoQuery](gamesavecontainerinfoquery.md).

## -property-value

Type: **IVectorView\<;GameSaveContainerInfo>;** \[JavaScript/C++\] | [System.Collections.Generic.IReadOnlyList\<;GameSaveContainerInfo>;](https://msdn.microsoft.com/library/hh192385.aspx) \[.NET\]

Collection of container information returned by [GameSaveContainerInfoQuery](gamesavecontainerinfoquery.md).

## -remarks

**Value** is valid only if [GameSaveContainerInfoGetResult.Status](gamesavecontainerinfogetresult_status.md) is [GameSaveErrorStatus.Ok](gamesaveerrorstatus.md).

## -examples

## -see-also

[GameSaveContainerInfoGetResult](gamesavecontainerinfogetresult.md)