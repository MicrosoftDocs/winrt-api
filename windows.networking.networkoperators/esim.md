---
-api-id: T:Windows.Networking.NetworkOperators.ESim
-api-type: winrt class
---

<!-- Class syntax.
public class ESim 
-->

# Windows.Networking.NetworkOperators.ESim

## -description
A class that represents an embedded SIM (eSIM, or eUICC). An eSIM stores one or more identities (eSIM profiles) belonging to one or more mobile network operators (MNOs). An eSIM is not a form factor; it's a way to manage SIM profiles.

> [!NOTE]
> This functionality is available only to mobile operator apps and UWP apps given privileged access by mobile network operators.
>
> If you want to use this API and publish your app to the Microsoft Store, then you'll need to request special approval to use the custom capability **Microsoft.eSIMManagement_8wekyb3d8bbwe**. For more info, see [Custom capabilities](/windows/uwp/packaging/app-capability-declarations#custom-capabilities).

## -remarks
A traditional SIM card stores a single identity that the modem can use to register onto a mobile network operator's (MNO's) network, and provide cellular service (the card is usually distributed by the MNO). But an eSIM stores one or more identities (eSIM profiles) belonging to one or more mobile operators. An eSIM switches identities by enabling and disabling the eSIM profiles saved on the card. Once an eSIM profile is enabled, the eSIM appears and functions as if it were a traditional SIM card from the MNO that distributed the profile. In this way, the end-user can easily switch between MNOs without changing the physical card.

There are several steps in the process of installing a profile onto an eSIM. The end-user provides an activation code, which is a string that contains the uniform resource location (URL) of a profile-distributing server together with some identifying information. Next, the eSIM-capable device uses the data in the activation code to contact the server. The server returns the metadata for a specific profile, together with information that's then presented to the user asking for consent to download the profile. Having received consent, the eSIM-capable device downloads the profile and sends the profile binary blob to the eSIM. Lastly, the profile is ready to be activated when the profile is successfully written to the eSIM. LpaSvc is a service for handling all eSIM-related operation requests. For end-users, there is a *Managing eSIM profiles* page in **Settings** to provide a UI for managing the eSIM.

## -see-also

## -examples

## -capabilities
Microsoft.eSIMManagement_8wekyb3d8bbwe