---
-api-id: T:Windows.Gaming.Input.RacingWheel
-api-type: winrt class
---

<!-- Class syntax.
public class RacingWheel : Windows.Gaming.Input.IGameController, Windows.Gaming.Input.IRacingWheel
-->

# Windows.Gaming.Input.RacingWheel

## -description

Represents a racing wheel.

## -remarks

### Supported Devices

**RacingWheel** supports any GIP (Gaming Input Protocol) or XUSB compatible racing wheel without force feedback support.

Force feedback is supported on the following device models:

<table>
   <tr><th>Manufacturer</th><th>Model</th></tr>
   <tr><td>Logitech</td><td>G25</td></tr>
   <tr><td /><td>G27</td></tr>
   <tr><td /><td>G29</td></tr>
   <tr><td /><td>G920</td></tr>
   <tr><td /><td>MOMO Force Feedback Racing Wheel</td></tr>
   <tr><td>Thrustmaster</td><td>T300RS</td></tr>
   <tr><td /><td>T500RS</td></tr>
   <tr><td /><td>RGT Force Feedback</td></tr>
   <tr><td /><td>T150</td></tr>
   <tr><td /><td>TX</td></tr>
   <tr><td /><td>TMX</td></tr>
   <tr><td>Fanatec</td><td>CSR</td></tr>
   <tr><td /><td>HID-mode for the Xbox One</td></tr>
</table>

Note that to use the devices listed above you should include a HID (Human Interface Device) capability declaration in your app's appxmanifest:

```xml

<Capabilities>
  <DeviceCapability Name="humaninterfacedevice">
    <Device Id="any">
      <Function Type="usage:0001 0004"/>
      <Function Type="usage:0001 0005"/>
    </Device>
  </DeviceCapability>
</Capabilities>

```

### Version history

| Windows version | SDK version | Value added |
| -- | -- | -- |
| 1703 | 15063 | FromGameController |
| 1703 | 15063 | TryGetBatteryReport |

## -examples

## -see-also

[IGameController](igamecontroller.md),
[Racing wheel and force feedback](/windows/uwp/gaming/racing-wheel-and-force-feedback),
[Input practices for games](/windows/uwp/gaming/input-practices-for-games)
