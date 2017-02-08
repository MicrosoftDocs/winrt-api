---
-api-id: T:Windows.Devices.Perception.Provider.PerceptionCorrelation
-api-type: winrt class
---

<!-- Class syntax.
public class PerceptionCorrelation : Windows.Devices.Perception.Provider.IPerceptionCorrelation
-->

# Windows.Devices.Perception.Provider.PerceptionCorrelation

## -description
A description of the physical position and orientation of a device specified by the IPerceptionFrameProvider's unique identifier (PerceptionFrameProviderInfo::Id) sharing a common coordinate frame of other PerceptionCorrelations that will be combined into a PerceptionCorrelationGroup.

## -remarks
The origin of this coordinate frame can be the position of one of the cameras in the PerceptionCorrelationGroup such that one camera will have a Windows::Foundation::Numerics::Vector3::Zero Position and all others will not.

## -examples

## -see-also
