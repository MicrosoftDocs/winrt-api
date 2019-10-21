---
-api-id: P:Windows.Media.Devices.LowLagPhotoSequenceControl.PastPhotoLimit
-api-type: winrt property
---

<!-- Property syntax
public uint PastPhotoLimit { get;  set; }
-->

# Windows.Media.Devices.LowLagPhotoSequenceControl.PastPhotoLimit

## -description
Gets or sets a value that specifies the number of past photos to store.

## -property-value
The number of past photos to store. To determine the maximum number of past photos that can be stored, check the [MaxPastPhotos](lowlagphotosequencecontrol_maxpastphotos.md) property.

## -remarks
To determine the maximum number of past photos that can be stored, check the [MaxPastPhotos](lowlagphotosequencecontrol_maxpastphotos.md) property.

The actual number of past photos cannot be more than [MaxPastPhotos](lowlagphotosequencecontrol_maxpastphotos.md), which is the maximum number of past photos that is supported by the driver. The number of past photos returned will be the smaller of the following values: PastPhotoLimit, [MaxPastPhotos](lowlagphotosequencecontrol_maxpastphotos.md), or the current number of available past photos.

## -examples

## -see-also
