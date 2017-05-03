---
-api-id: P:Windows.Devices.Gpio.GpioChangeReader.Polarity
-api-type: winrt property
---

<!-- Property syntax.
public GpioChangePolarity Polarity { get;  set; }
-->

# Windows.Devices.Gpio.GpioChangeReader.Polarity

## -description
Gets or sets the polarity of transitions that will be recorded. The polarity may only be changed when pin change recording is not started.

## -property-value
Rising or Falling. The default polarity value is Falling.

## -remarks
Listening to a single edge (Falling or Rising) can be considerably more efficient than listening to both edges.

The following exceptions can be thrown when setting the polarity:

* E_INVALIDARG - value is not a valid [GpioChangePolarity](gpiochangepolarity.md) value.
* HRESULT_FROM_WIN32(ERROR_BAD_COMMAND) - change recording is currently active. Polarity can only be set before calling [Start()](gpiochangereader_start_1587696324.md) or after calling [Stop()](gpiochangereader_stop_1201535524.md).

## -see-also

## -examples

