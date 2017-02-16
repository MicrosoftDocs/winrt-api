---
-api-id: M:Windows.Devices.Perception.Provider.PerceptionCorrelation.#ctor(System.String,Windows.Foundation.Numerics.Vector3,Windows.Foundation.Numerics.Quaternion)
-api-type: winrt method
---

<!-- Method syntax
public PerceptionCorrelation(System.String targetId, Windows.Foundation.Numerics.Vector3 position, Windows.Foundation.Numerics.Quaternion orientation)
-->

# Windows.Devices.Perception.Provider.PerceptionCorrelation.PerceptionCorrelation

## -description
Initializes a new PerceptionCorrelation instance.

## -parameters
### -param targetId
The unique identifier of the IPerceptionFrameProvider being described.

### -param position
The position of the device in a common coordinate frame of all members of a PerceptionCorrelationGroup.

### -param orientation
The orientation of the device in a common coordinate frame of all members of a PerceptionCorrelationGroup.

## -remarks
Creates a PerceptionCorrelation associating a position and orientation with the unique identifier of an IPerceptionFrameProvider (via its PerceptionFrameProviderInfo::Id). When combined into an PerceptionCorrelationGroup, relative positions and orientations can be obtained to correlate resulting frames from each IPerceptionFrameProvider in the group.

## -examples

## -see-also
