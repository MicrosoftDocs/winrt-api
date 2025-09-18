---
-api-id: M:Windows.System.Power.Thermal.PowerThermalChannelDataProducer.PublishInputChannelData(Windows.System.Power.Thermal.PowerThermalChannelData[])
-api-type: winrt method
---

# Windows.System.Power.Thermal.PowerThermalChannelDataProducer.PublishInputChannelData(Windows.System.Power.Thermal.PowerThermalChannelData[])

<!--
public void PublishInputChannelData (Windows.System.Power.Thermal.PowerThermalChannelData[] data);
-->


## -description

Publishes one or more channel data samples to the producer's configured channels.

## -parameters

### -param data

An array of [PowerThermalChannelData](./powerthermalchanneldata.md) structures containing the samples to publish.

## -remarks

**PublishInputChannelData** publishes values to configured channels; calling it for a disabled channel will re-enable that channel. Passing an invalid channel ID results in HRESULT_INVALID_ARGUMENT.

## -see-also

## -examples


