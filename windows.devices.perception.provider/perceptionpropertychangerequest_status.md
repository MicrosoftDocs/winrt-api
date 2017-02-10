---
-api-id: P:Windows.Devices.Perception.Provider.PerceptionPropertyChangeRequest.Status
-api-type: winrt property
---

<!-- Property syntax
public Windows.Devices.Perception.PerceptionFrameSourcePropertyChangeStatus Status { get;  set; }
-->

# Windows.Devices.Perception.Provider.PerceptionPropertyChangeRequest.Status

## -description
Sets the new status of the request after processing the request.

## -property-value
The currently stored status of the request.

## -remarks

The value should be set as follows:

+ **Windows::Devices::Perception::PerceptionFrameSourcePropertyChangeStatus::Accepted** –  The property has been updated to the new value.
+ **Windows::Devices::Perception::PerceptionFrameSourcePropertyChangeStatus::PropertyNotSupported** –  The property is not supported on this IPerceptionFrameProvider and can't be set.
+ **Windows::Devices::Perception::PerceptionFrameSourcePropertyChangeStatus::PropertyReadOnly** –  The property is supported on this IPerceptionFrameProvider but can't be changed.
+ **Windows::Devices::Perception::PerceptionFrameSourcePropertyChangeStatus::ValueOutOfRange** –  The property is supported on this IPerceptionFrameProvider but the provided new value is outside of the range of accepted values.


## -examples

## -see-also
