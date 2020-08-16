---
-api-id: M:Windows.Gaming.XboxLive.Storage.GameSaveProvider.CreateContainerInfoQuery(System.String)
-api-type: winrt method
---

<!-- Method syntax
public Windows.Gaming.XboxLive.Storage.GameSaveContainerInfoQuery CreateContainerInfoQuery(System.String containerNamePrefix)
-->

# Windows.Gaming.XboxLive.Storage.GameSaveProvider.CreateContainerInfoQuery

## -description

Creates a [GameSaveContainerInfoQuery](gamesavecontainerinfoquery.md) instance that enumerates the containers in this game save provider that have names that begin with the specified prefix.

## -parameters
### -param containerNamePrefix

Type: **String** \[JavaScript\] | [System.String](https://docs.microsoft.com/dotnet/api/system.string?redirectedfrom=MSDN) \[.NET\] | [Platform::String](https://docs.microsoft.com/cpp/cppcx/platform-string-class) \[C++\]

String name prefix of the containers to enumerate.

## -returns

Type: [GameSaveContainerInfoQuery](gamesavecontainerinfoquery.md)

[GameSaveContainerInfoQuery](gamesavecontainerinfoquery.md) instance that enumerates the containers in this game save provider that have names that begin with the specified prefix.

## -remarks

Call [GetContainerInfoAsync](gamesavecontainerinfoquery_getcontainerinfoasync_1018947810.md) on the returned object to retrieve container information.

## -examples

## -see-also

[GameSaveProvider](gamesaveprovider.md),
[CreateContainerInfoQuery](gamesaveprovider_createcontainerinfoquery_424994130.md)