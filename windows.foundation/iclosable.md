---// Arduino SPIDigialPot example: http://arduino.cc/en/Tutorial/SPIDigitalPot 

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
-api-id: T:Windows.Foundation.IClosable
-api-type: winrt interface
---

<!-- Interface syntax.
public interface IClosable : 
-->

# Windows.Foundation.IClosable

## -description
Defines a method to release allocated resources.



> **.NET**
> This interface appears as [System.IDisposable](/dotnet/api/system.idisposable?view=dotnet-uwp-10.0&preserve-view=true).



> **C++/CX**
> This interface appears as [Platform::IDisposable](/cpp/cppcx/platform-idisposable-interface).

## -remarks
This interface is projected to a different interface for all possible languages, so it should be considered as an infrastructure piece that the overall Windows Runtime programming experience uses as an implementation detail. There are no typical app development scenarios that rely on implementing or using the IClosable interface directly, unless you're using WRL. For more info, see [WRL Integration](/cpp/cppcx/wrl-integration-c-cx).

### Notes to implementers

When programming with .NET, this interface is hidden and is replaced by the [System.IDisposable](/dotnet/api/system.idisposable?view=dotnet-uwp-10.0&preserve-view=true) interface.

If you are defining a runtime class in C++/CX and define a destructor, don't implement IClosable. There's already compiler-based behavior that implements a cleanup behavior for you, (as [Platform::IDisposable](/cpp/cppcx/platform-idisposable-interface)) and your explicit implementation will clash with the built-in behavior. For more info, see the "Destructors" section of [Ref classes and structs (C++/CX)](/cpp/cppcx/ref-classes-and-structs-c-cx).

The purpose of this interface (as exposed by the languages) is so that Windows Runtime objects can wrap and dispose of exclusive system or device/hardware resources appropriately, such as file handles and network sockets. You do not implement this interface for Windows Runtime objects that wrap shared system resources, such as memory and shareable devices.

### Notes to callers

The scenario for [Platform::IDisposable](/cpp/cppcx/platform-idisposable-interface)/[System.IDisposable](/dotnet/api/system.idisposable?view=dotnet-uwp-10.0&preserve-view=true) is to support language-specific syntax that isolates references, such as the **using()** syntax in C#, or scoping behavior for reference counting in C++. Actually casting to the interfaces or invoking its methods from any app code in any language is rarely necessary.

## -examples

## -see-also
[System.IDisposable](/dotnet/api/system.idisposable?view=dotnet-uwp-10.0&preserve-view=true)
