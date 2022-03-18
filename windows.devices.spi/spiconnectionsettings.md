---
-api-id: T:Windows.Devices.Spi.SpiConnectionSettings
-api-type: winrt class
---

<!-- Class syntax.
public class SpiConnectionSettings : Windows.Devices.Spi.ISpiConnectionSettings
-->

# Windows.Devices.Spi.SpiConnectionSettings

## -description
Represents the settings for the connection with an [SpiDevice](/uwp/api/windows.devices.spi.spidevice).

## -remarks

## -examples

The following sample illustrates the basic functionality of this and other SPI APIs by showing how to open an SPI bus by friendly name using the default connection settings.

```csharp
// Arduino SPIDigialPot example: http://arduino.cc/en/Tutorial/SPIDigitalPot 
// using digital potentiometer AD5206 the 50kohm variance 
async void Digipot_AD5206() 
{ 
    // Get a device selector query that will select buses with SP10 
    // property set on them (we expect only 1 SP10 bus at the end) 
    var spi0Aqs = SpiDevice.GetDeviceSelector("SPI0"); 
    // Find all buses using the AQS query formed above 
    var devicesInfo = await DeviceInformation.FindAllAsync(spi0Aqs); 

    // Construct time settings beforehand which can't be changed 
    // once a SPI device is created 
    const Int32 DigipotChipSelectLine = 0; 
    var settings = new SpiConnectionSettings(DigipotChipSelectLine); 
    
    // Ask the SPI bus to open a device with the connection settings 
    // provided. Once we go out of scope, the device will be released 
    using (var spiDev = await SpiDevice.FromIdAsync(devicesInfo[0].Id, settings)) 
    { 
    
        // data[0] is the channel address 
        // data[1] is the resistance step (0 - 255) 
        // 0 is max digipot resistance, and 255 is no resistance 
        byte[] data = { 0x0, 0x0 }; 
        
        // Go over the 6 channels of the digipot 
        for (byte channel = 0; channel < 6; ++channel) 
        { 
            data[0] = channel; 
            
            // Step the resistance on this channel from max to min 
            for (byte r = 0; r <= 255; ++r) 
            { 
                data[1] = r; 
                spiDev.Write(data); 
                await Task.Delay(100); 
            } 

            // Step the resistance on this channel from min to max 
            for (byte r = 255; r >= 0; --r) 
            { 
                data[1] = r; 
                spiDev.Write(data); 
                await Task.Delay(100); 
            } 
        } 
    } 
} 
```
The following sample shows how to use this and other SPI APIs to initialize an SPI device with non-default connection settings. It does so by reading the light-intensity from an analog Photocell connected to an 8-channel 10-bit ADC108S102 A/D Converter.

> [!NOTE]
> This sample contains several settings specific to the above devices. You may need to change these settings to account for your specific device. For instance, Raspberry Pi devices support a max 8/9 bit length for SPI.

```csharp
// Knowing that an SPI bus with 'spiBusId' exist, and has the ADC connected 
// on 'chipSelectLine', read a digital sample from some sensor wired to 'channel' 
async Task<int> AnalogRead_ADC108S102(string spiBusId, Int32 chipSelectLine, byte channel) 
{ 
    var settings = new SpiConnectionSettings(chipSelectLine); 
    
    // The defaults (4MHz, 8-bit, Mode0) will not work here according 
    // to the datasheet. 
    // e.g The datasheet specifies a clock freq range (8MHz - 16MHz) 
    settings.ClockFrequency = 8000000; 
    // CPOL=1, CPHA=1 
    settings.Mode = SpiMode.Mode3; 
    // Conversion happens on a 16-bit frame 
    settings.DataBitLength = 16; 
    // The ADC108S102 has 8 input analog channels, where each can be 
    // connected to a specific analog sensor and each sensor is 
    // used by a different application independently 
    // The IO requests to the SPI bus are implicitly synchronized 
    // by the driver model, plus that the ADC configuration is per 
    // 1 sampling read 
    settings.SharingMode = SpiSharingMode.Shared; 
    
    // Ask the SPI bus to open a shared device with the connection settings 
    // provided. 
    using (var spiDev = await SpiDevice.FromIdAsync(spiBusId, settings)) 
    { 
        if (spiDev == null) 
            return -1; 

        // Set up control register to get a conversion on a specific 
        // channel address 
        byte[] write16bitData = { (byte)(channel << 3), 0 }; 
        byte[] read16bitData = new byte[2]; 
        // The transfer is guaranteed to be atomic according to SpbCx model 
        spiDev.TransferFullDuplex(write16bitData, read16bitData); 
        
        ushort result = BitConverter.ToUInt16(read16bitData, 0); 
        // Get rid of the 2 LSB zeros and mask the 10-bit sampled value 
        return (int)((result >> 2) & 0x3ff); 
    } 
} 
```

## -see-also
