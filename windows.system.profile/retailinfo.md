---
-api-id: T:Windows.System.Profile.RetailInfo
-api-type: winrt class
---

<!-- Class syntax.
public class RetailInfo 
-->

# Windows.System.Profile.RetailInfo

## -description
A utility class that supports one method, [IsDemoModeEnabled](retailinfo_isdemomodeenabled.md), and one property, [Properties](retailinfo_properties.md). Call [IsDemoModeEnabled](retailinfo_isdemomodeenabled.md) to determine whether the device where the app is running has specifically enabled its retail demo mode.

## -remarks
If [RetailInfo.IsDemoModeEnabled](retailinfo_isdemomodeenabled.md) returns **true**, you can get the set of available properties from [RetailInfo.Properties](retailinfo_properties.md). These properties include specific information that is useful for pre-installed demo apps that run in a retail setting. For example, you can get a [ManufacturerName](knownretailinfoproperties_manufacturername.md), [ScreenSize](knownretailinfoproperties_screensize.md), and so on, and display that info in an app that's intended for retail demo. The strings returned are typically suitable for inclusion in a UI.

When possible, use [RetailInfo](retailinfo.md) instead of the previous [Windows.Phone.System.Profile.RetailMode](../windows.phone.system.profile/retailmode.md) API. [Windows.Phone.System.Profile.RetailMode](../windows.phone.system.profile/retailmode.md) is only available for Windows Phone and doesn't support a "Properties" set of device-specific properties.

## -examples

## -see-also
[KnownRetailInfoProperties](knownretailinfoproperties.md)
