---
-api-id: P:Windows.Devices.Gpio.GpioChangeCounter.Polarity
-api-type: winrt property
---

<!-- Property syntax.
public GpioChangePolarity Polarity { get;  set; }
-->

# Windows.Devices.Gpio.GpioChangeCounter.Polarity

## -description
Gets or sets the polarity of transitions that will be counted. The polarity may only be changed when pin counting is not started.

## -property-value

## -remarks
The default polarity value is Falling. See [GpioChangePolarity](gpiochangepolarity.md) for more information on polarity values. Counting a single edge can be considerably more efficient than counting both edges.

The following exceptions can be thrown when setting the polarity:

* E_INVALIDARG - value is not a valid [GpioChangePolarity](gpiochangepolarity.md) value.
* HRESULT_FROM_WIN32(ERROR_BAD_COMMAND) - change counting is currently active. Polarity can only be set before calling [Start()](gpiochangecounter_start_1587696324.md) or after calling [Stop()](gpiochangecounter_stop_1201535524.md).


## -see-also

## -examples

