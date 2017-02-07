---
-api-id: T:Windows.Devices.Spi.Provider.ProviderSpiMode
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.Devices.Spi.Provider.ProviderSpiMode : int
-->

# ProviderSpiMode

## -description
Defines the SPI communication mode. The communication mode defines the clock edge on which the master out line toggles, the master in line samples, and the signal clock's signal steady level (named SCLK). Each mode is defined with a pair of parameters called clock polarity (CPOL) and clock phase (CPHA).

## -enum-fields
### -field Mode0:0
CPOL = 0, CPHA = 0.

### -field Mode1:1
CPOL = 0, CPHA = 1.

### -field Mode2:2
CPOL = 1, CPHA = 0.

### -field Mode3:3
CPOL = 1, CPHA = 1.


## -remarks

## -examples

## -see-also