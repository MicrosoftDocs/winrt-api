---
-api-id: E:Windows.Devices.Bluetooth.GenericAttributeProfile.GattSession.MaxPduSizeChanged
-api-type: winrt event
---

<!-- Event syntax.
public event TypedEventHandler MaxPduSizeChanged<GattSession, object>
-->

# Windows.Devices.Bluetooth.GenericAttributeProfile.GattSession.MaxPduSizeChanged

## -description
An event that is raised when the maximum protocol data unit (PDU) size changes. The PDU is also known as the *maximum transmission unit (MTU)*.

**MaxPduSizeChanged** is raised whenever the negotiated MTU for the Attribute Protocol (ATT) is changed. And that can be changed or negotiated by a remote Bluetooth peripheral. As a developer, you can't change the value used by Windows itself, since that's fully managed by the operating system.

Also see the [GattSession.MaxPduSize](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattsession.maxpdusize) property which, as mentioned, is read-only.

## -remarks

> [!IMPORTANT]
> See the **Remarks** in the [GattSession.MaxPduSize](/uwp/api/windows.devices.bluetooth.genericattributeprofile.gattsession.maxpdusize) property topic.

## -see-also

## -examples

## -capabilities
bluetooth