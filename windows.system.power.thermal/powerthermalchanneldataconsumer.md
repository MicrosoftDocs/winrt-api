---
-api-id: T:Windows.System.Power.Thermal.PowerThermalChannelDataConsumer
-api-type: winrt class
---

# Windows.System.Power.Thermal.PowerThermalChannelDataConsumer

<!--
public sealed class PowerThermalChannelDataConsumer : System.IDisposable
-->


## -description

Represents a consumer that receives power/thermal channel data and raises events when new data is available.

## -remarks

When instantiated with an array of [PowerThermalChannelId](./powerthermalchannelid.md) values, the consumer claims exclusive ownership of the specified output channels; construction fails with HRESULT STG_E_INUSE if any requested channel IDs are already claimed.

The [ChannelDataReceived](./powerthermalchanneldataconsumer_channeldatareceived.md) event fires with batches of output channel data (approximately once per second). Handlers receive [PowerThermalChannelDataReceivedEventArgs](./powerthermalchanneldatareceivedeventargs.md) containing the samples.

## -see-also

## -examples


