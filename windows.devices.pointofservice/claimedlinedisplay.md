---
-api-id: T:Windows.Devices.PointOfService.ClaimedLineDisplay
-api-type: winrt class
---

<!-- Class syntax.
public class ClaimedLineDisplay : IClosable
-->

# Windows.Devices.PointOfService.ClaimedLineDisplay

## -description
Represents a claimed line display device.

## -remarks
This object can be constructed directly, or by using [LineDisplay.ClaimAsync](linedisplay_claimasync_1760840245.md). Unlike other peripherals, the EnableAsync() method has been removed for line displays. Instead, the device is implicitly enabled whenever commands are sent that require the line display to be in an enabled state.

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1709 | 16299 | CheckHealthAsync |
| 1709 | 16299 | CheckPowerStatusAsync |
| 1709 | 16299 | CustomGlyphs |
| 1709 | 16299 | GetAttributes |
| 1709 | 16299 | GetStatisticsAsync |
| 1709 | 16299 | MaxBitmapSizeInPixels |
| 1709 | 16299 | StatusUpdated |
| 1709 | 16299 | SupportedCharacterSets |
| 1709 | 16299 | SupportedScreenSizesInCharacters |
| 1709 | 16299 | TryClearDescriptorsAsync |
| 1709 | 16299 | TryCreateWindowAsync |
| 1709 | 16299 | TrySetDescriptorAsync |
| 1709 | 16299 | TryStoreStorageFileBitmapAsync(StorageFile) |
| 1709 | 16299 | TryStoreStorageFileBitmapAsync(StorageFile,LineDisplayHorizontalAlignment,LineDisplayVerticalAlignment) |
| 1709 | 16299 | TryStoreStorageFileBitmapAsync(StorageFile,LineDisplayHorizontalAlignment,LineDisplayVerticalAlignment,Int32) |
| 1709 | 16299 | TryUpdateAttributesAsync |
| 1809 | 17763 | Closed |

## -see-also

## -examples
