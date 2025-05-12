---
-api-id: M:Windows.AI.Actions.ActionEntityFactory.CreateRemoteFileEntity(System.String,Windows.AI.Actions.RemoteFileKind,Windows.Foundation.Uri,System.String,System.String,System.String,System.String,System.String)
-api-type: winrt method
---

# Windows.AI.Actions.ActionEntityFactory.CreateRemoteFileEntity(System.String,Windows.AI.Actions.RemoteFileKind,Windows.Foundation.Uri,System.String,System.String,System.String,System.String,System.String)

<!--
public Windows.AI.Actions.RemoteFileActionEntity CreateRemoteFileEntity (string sourceId, Windows.AI.Actions.RemoteFileKind fileKind, System.Uri sourceUri, string fileId, string contentType, string driveId, string accountId, string extension);
-->


## -description

Creates a new instance of [RemoteFileActionEntity](remotefileactionentity.md) which enables actions to operate on files hosted by cloud storage providers.

## -parameters

### -param sourceId

The identifier of the cloud storage provider that hosts the remote file.

### -param fileKind

A member of the [RemoteFileKind](remotefilekind.md) enumeration specifying the remote file kind.

### -param sourceUri

The URI of the remote file. Optional. Some cloud storage providers may use the *sourfileId* parameter instead.

### -param fileId

The identifier of the remote file. Optional. Some cloud storage providers may use the *sourceUri* parameter instead.

### -param contentType

The MIME type of the remote file.

### -param driveId

The identifier for the remote drive associated with the remote file.

### -param accountId

The identifier of the cloud service account associated with the remote file. Optional.

### -param extension

The extension of the remote file.

## -returns

A new **RemoteFileActionEntity**.

## -remarks

This method has parameters that represent values that are commonly used across different cloud providers. The implementation and behavior of these parameters will vary between providers. App action provider developers should consult the documentation for each supported cloud storage provider for usage information for these parameters.

## -see-also

## -examples


