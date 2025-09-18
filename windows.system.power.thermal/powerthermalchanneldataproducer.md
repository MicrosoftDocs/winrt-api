---
-api-id: T:Windows.System.Power.Thermal.PowerThermalChannelDataProducer
-api-type: winrt class
---

# Windows.System.Power.Thermal.PowerThermalChannelDataProducer

<!--
public sealed class PowerThermalChannelDataProducer : System.IDisposable
-->

## -description

Represents a producer that publishes power/thermal channel data to consumers.

## -remarks

Constructing **PowerThermalChannelDataProducer** with an array of [PowerThermalChannelId](./powerthermalchannelid.md) claims exclusive ownership of the specified input channels. Construction fails with HRESULT STG_E_INUSE if any requested channel IDs are already claimed.

In a typical usage scenario, create a producer for the desired channel IDs, call [GetChannelConfigurations](./powerthermalchanneldataproducer_getchannelconfigurations_1473707459.md) to obtain per-channel configuration, then call [Start](./powerthermalchanneldataproducer_start_1587696324.md) and use [PublishInputChannelData](./powerthermalchanneldataproducer_publishinputchanneldata_1736334526.md) to supply samples. Producer instances are intended to be long‑lived.

Calling [PublishInputChannelData](./powerthermalchanneldataproducer_publishinputchanneldata_1736334526.md) for a disabled channel will re‑enable that channel; use [DisableChannel](./powerthermalchanneldataproducer_disablechannel_6125057.md) to prevent publishing until explicitly re‑enabled. Passing an invalid channel identifier to [PublishInputChannelData](./powerthermalchanneldataproducer_publishinputchanneldata_1736334526.md) results in HRESULT_INVALID_ARGUMENT.

The **BackEndStatus** property and **BackEndStatusChanged** event indicate whether the MPTF backend is **Started** or **Stopped**; clients should stop publishing while the backend is **Stopped**.

## -see-also

## -examples


