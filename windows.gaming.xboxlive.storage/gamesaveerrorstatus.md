---
-api-id: T:Windows.Gaming.XboxLive.Storage.GameSaveErrorStatus
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Gaming.XboxLive.Storage.GameSaveErrorStatus : int
-->

# GameSaveErrorStatus

## -description

Success and failure codes returned by game save operations.

## -enum-fields
### -field Ok:0

| **Ok** | **ok**                                         | 0          | The operation completed successfully. |

### -field Abort:-2147467260

| **Abort** | **abort**                                   | 0x80004004 | The operation was aborted. |

### -field InvalidContainerName:-2138898431

| **InvalidContainerName** | **invalidContainerName**     | 0x80830001 | The specified container name is empty, contains invalid characters, or is too long. |

### -field NoAccess:-2138898430

| **NoAccess** | **noAccess**                             | 0x80830002 | The operation failed because the title does not have write access to the container storage space. |

### -field OutOfLocalStorage:-2138898429

| **OutOfLocalStorage** | **outOfLocalStorage**           | 0x80830003 | The operation failed because there was not enough local storage available. Although the user was given the chance to free up some local storage they chose not to do so. |

### -field UserCanceled:-2138898428

| **UserCanceled** | **userCanceled**                     | 0x80830004 | The operation failed because the user canceled it. |

### -field UpdateTooBig:-2138898427

| **UpdateTooBig** | **updateTooBig**                     | 0x80830005 | The operation failed because the update contained more than 16MB of data. |

### -field QuotaExceeded:-2138898426

| **QuotaExceeded** | **quotaExceeded**                   | 0x80830006 | The operation failed because the update would cause the storage space to exceed its quota. Use IGameSaveProvider.GetRemainingBytesInQuotaAsync to query the remaining quota space. |

### -field ProvidedBufferTooSmall:-2138898425

| **ProvidedBufferTooSmall** | **providedBufferTooSmall** | 0x80830007 | The operation failed because a buffer provided to read a blob was too small to receive the blob. |

### -field BlobNotFound:-2138898424

| **BlobNotFound** | **blobNotFound**                     | 0x80830008 | The operation failed because a blob with the given name was not found in the container. |

### -field NoXboxLiveInfo:-2138898423

| **NoXboxLiveInfo** | **noXboxLiveInfo**                 | 0x80830009 | The operation failed because the title does not have a proper title id or service configuration id. |

### -field ContainerNotInSync:-2138898422

| **ContainerNotInSync** | **containerNotInSync**         | 0x8083000A | The operation failed because the container does not exist locally. This error can when submitting updates to a container that needs to sync, and a read, delete, or blob query has not been issued on the container. |

### -field ContainerSyncFailed:-2138898421

| **ContainerSyncFailed** | **containerSyncFailed**       | 0x8083000B | The operation failed because the container could not be synced. This indicates that the user canceled a container sync due to not wanting to wait, or due to network failure and the user did not retry. This error can be returned by [DeleteContainerAsync](gamesaveprovider_deletecontainerasync_1360317562.md), [ReadAsync](gamesavecontainer_readasync_130997576.md), [GetAsync](gamesavecontainer_getasync_465620582.md), or a [GameSaveBlobInfoQuery](gamesaveblobinfoquery.md) operation. |

### -field UserHasNoXboxLiveInfo:-2138898420

| **UserHasNoXboxLiveInfo** | **userHasNoXboxLiveInfo**   | 0x8083000C | The operation failed because there is no Xbox Live information associated with the user account. This error can returned by [GetForUserAsync](gamesaveprovider_getforuserasync_1027182495.md) or [GetSyncOnDemandForUserAsync](gamesaveprovider_getsyncondemandforuserasync_1696921570.md). |

### -field ObjectExpired:-2138898419

| **ObjectExpired** | **objectExpired**                   | 0x8083000D | The operation failed because the app has been suspended and the object is no longer valid. To perform game save operations after resuming, the app must request a new [GameSaveProvider](gamesaveprovider.md) with [GetForUserAsync](gamesaveprovider_getforuserasync_1027182495.md) or [GetSyncOnDemandForUserAsync](gamesaveprovider_getsyncondemandforuserasync_1696921570.md). |

## -remarks

> [!IMPORTANT]
> This API is targeted towards UWP games and apps with Xbox Live Enabled. Calls to these APIs made from sources that are not Xbox Live enabled will not be able to sync data to the cloud.

## -examples

## -see-also