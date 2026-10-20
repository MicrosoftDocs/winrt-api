---
-api-id: T:Windows.System.Profile.HardwareIdentification
-api-type: winrt class
---

<!-- Class syntax.
public class HardwareIdentification 
-->

# Windows.System.Profile.HardwareIdentification

## -description
Provides the ability to obtain a hardware identifier that represents the current hardware.

## -remarks
The Application Specific Hardware ID (ASHWID) encodes characteristics of up to nine hardware component types: processor, memory, disk device, network adapter, audio adapter, docking station, mobile broadband, Bluetooth, and system BIOS. The byte stream uses 4-byte groups where the first 2 bytes identify the component type and the next 2 bytes contain its value.

The ASHWID **can contain multiple records of the same component type**. For example, a device with three physical disk drives produces three disk-device records; a docked tablet may produce additional network adapter and audio adapter records. Your cloud service should account for this variation when comparing ASHWIDs across sessions.

The ASHWID format is described in detail in [Guidance on using the App Specific Hardware ID (ASHWID) to implement per-device app logic](/previous-versions/windows/apps/jj553431(v=win.10)).

<!-- confirmed -->
> [!NOTE]
> This class is not agile, which means that you need to consider its threading model and marshaling behavior. For more info, see [Threading and Marshaling (C++/CX)](/cpp/cppcx/threading-and-marshaling-c-cx) and [Using Windows Runtime objects in a multithreaded environment (.NET)](/windows/uwp/threading-async/using-windows-runtime-objects-in-a-multithreaded-environment).

## -examples
The following code shows how to get the hardware id of a device using [GetPackageSpecificToken](hardwareidentification_getpackagespecifictoken_1192424865.md).

```csharp
// nonce is an IBuffer object that would be sent from the cloud service.
HardwareToken packageSpecificToken;

packageSpecificToken =  Windows.System.Profile.HardwareIdentification.GetPackageSpecificToken(nonce);

// hardware id, signature, certificate IBuffer objects 
// that can be accessed through properties.
IBuffer hardwareId  = packageSpecificToken.Id;
IBuffer signature = packageSpecificToken.Signature;
IBuffer certificate = packageSpecificToken.Certificate;
```

```cppwinrt
void MainPage::DefaultLaunch()
{
    // nonce is a value of type Windows::Storage::Streams::IBuffer, which
    // would be sent from the cloud service in a real scenario.
    Windows::System::Profile::HardwareToken packageSpecificToken{
        Windows::System::Profile::HardwareIdentification::GetPackageSpecificToken(nonce) };

    // hardware id, signature, certificate IBuffer objects 
    // that can be accessed through properties.
    Windows::Storage::Streams::IBuffer hardwareId{ packageSpecificToken.Id() };
    Windows::Storage::Streams::IBuffer signature{ packageSpecificToken.Signature() };
    Windows::Storage::Streams::IBuffer certificate{ packageSpecificToken.Certificate() };
}
```

```cppcx
// nonce is an IBuffer object that would be sent from the cloud service.
HardwareToken^ packageSpecificToken;

packageSpecificToken =  Windows::System::Profile::HardwareIdentification::GetPackageSpecificToken(nonce);

// hardware id, signature, certificate IBuffer objects 
// that can be accessed through properties.
IBuffer^ hardwareId = packageSpecificToken->Id;
IBuffer^ signature = packageSpecificToken->Signature;
IBuffer^ certificate = packageSpecificToken->Certificate;
```

```vb
// nonce is an IBuffer object that would be sent from the cloud service.
Dim packageSpecificToken As Windows.System.Profile.HardwareToken

packageSpecificToken = Windows.System.Profile.HardwareIdentification.GetPackageSpecificToken(nonce)

// hardware id, signature, certificate IBuffer objects 
// that can be accessed through properties.
Dim hardwareId As Windows.Storage.Streams.IBuffer = packageSpecificToken.Id
Dim signature As Windows.Storage.Streams.IBuffer = packageSpecificToken.Signature
Dim certificate As Windows.Storage.Streams.IBuffer = packageSpecificToken.Certificate
```

## -see-also
[Guidance on using the App Specific Hardware ID (ASHWID) to implement per-device app logic](/previous-versions/windows/apps/jj553431(v=win.10))
