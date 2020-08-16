---
-api-id: M:Windows.Gaming.XboxLive.Storage.GameSaveProvider.CreateContainerInfoQuery
-api-type: winrt method
---

<!-- Method syntax
public Windows.Gaming.XboxLive.Storage.GameSaveContainerInfoQuery CreateContainerInfoQuery()
-->

# Windows.Gaming.XboxLive.Storage.GameSaveProvider.CreateContainerInfoQuery

## -description

Creates a [GameSaveContainerInfoQuery](gamesavecontainerinfoquery.md) instance that enumerates all containers in this game save provider.

## -returns

Type: [GameSaveContainerInfoQuery](gamesavecontainerinfoquery.md)

[GameSaveContainerInfoQuery](gamesavecontainerinfoquery.md) instance that enumerates all containers in this game save provider.

## -remarks

Call [GetContainerInfoAsync](gamesavecontainerinfoquery_getcontainerinfoasync_1018947810.md) on the returned object to retrieve container information. Containers are enumerated in order of the most recently modified first.

## -examples

## -see-also

[GameSaveProvider](gamesaveprovider.md),
[CreateContainerInfoQuery(String)](gamesaveprovider_createcontainerinfoquery_1087708274.md)