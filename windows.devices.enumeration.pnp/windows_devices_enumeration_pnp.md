---
-api-id: N:Windows.Devices.Enumeration.Pnp
-api-type: winrt namespace
---

# Windows.Devices.Enumeration.Pnp

## -description

> [!IMPORTANT]
> We no longer recommend that you use the types in the **Windows.Devices.Enumeration.Pnp** namespace. Instead, the types in the [Windows.Devices.Enumeration](/uwp/api/windows.devices.enumeration) namespace implement a modern, and better maintained, superset of the functionality of **Windows.Devices.Enumeration.Pnp**.
>
> The alternative to **PnpObjectType** is the [Windows.Devices.Enumeration.DeviceInformationKind](/uwp/api/windows.devices.enumeration.deviceinformationkind) enum, which you can pass as a parameter to **Windows.Devices.Enumeration** APIs. For example, instead of using **PnpObjectType** when you create a **PnpObjectWatcher**, use **DeviceInformationKind** when you create a [DeviceWatcher](/uwp/api/windows.devices.enumeration.devicewatcher).

Provides classes for enumerating a collection of Pnp device objects, and event handlers for monitoring changes to the objects in the collection asynchronously.

The following are typical uses of the Windows.Devices.Enumeration.Pnp API.

+ Building a user interface for selecting the device to be used by an application. For example, a voice chat application may present a list of microphones or webcams for the user to select from, or a photo import application may present a list of removable storage devices for the user to import photos from.
+ Device discovery and notifications about devices for apps that use them (see [Windows Hardware Dev Center](https://developer.microsoft.com/windows/hardware/)).

## -remarks

## -examples

## -see-also
