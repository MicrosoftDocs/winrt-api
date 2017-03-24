---
-api-id: T:Windows.Networking.NetworkOperators.MobileBroadbandUiccApp
-api-type: winrt class
-api-device-family-note: xbox
---

<!-- Class syntax.
public class MobileBroadbandUiccApp : Windows.Networking.NetworkOperators.IMobileBroadbandUiccApp
-->

# Windows.Networking.NetworkOperators.MobileBroadbandUiccApp

## -description
Represents a UICC (SIM card) application.

## -remarks
Your code does not instantiate this class directly. To get instances of this class, first call the [MobileBroadbandUicc.GetUiccAppsAsync](mobilebroadbanduicc_getuiccappsasync.md) method. Then, from the [MobileBroadbandUiccAppsResult](mobilebroadbanduiccappsresult.md) instance returned by that method, get instances of this class from the list in the [MobileBroadbandUiccAppsResult.UiccApps](mobilebroadbanduiccappsresult.md) property.

## -examples

## -see-also
