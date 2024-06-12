---
-api-id: P:Windows.System.UserProfile.AdvertisingManager.AdvertisingId
-api-type: winrt property
---

<!-- Property syntax
public string AdvertisingId { get; }
-->

# Windows.System.UserProfile.AdvertisingManager.AdvertisingId

## -description

Retrieves a unique ID used to provide more relevant advertising. If the advertising ID feature is turned off, no ID is retrieved.

## -property-value

The advertising ID is represented as an alphanumeric string. When the advertising ID feature is turned off, this is an empty string.

## -remarks

This property retrieves a unique ID used to provide more relevant advertising by understanding which apps are used by the user and how they are used. It is also used to improve quality of service by determining the frequency and effectiveness of ads, and to detect fraud and security issues. This ID is per-user, per-device; all apps for a single user on a device have the same advertising ID.

If the advertising ID feature is turned off, no ID is retrieved. The advertising ID feature is turned on if the user chooses express settings when installing Windows. The feature can be turned off by the user, either during the custom setup process when installing Windows or at any time later through the **Privacy** page of **PC Settings**. It can also be turned off through group policy.

> [!NOTE]
> If the advertising ID feature is turned off by the user during the new device customization process, the feature will be turned off by default for any user account added to the device later. If they want to use the advertising ID, those users will have to explicitly turn the feature on through **PC Settings**.

When the feature is turned off and then on again, Windows creates a new advertising ID— the old one is not reused. The advertising ID can also be reset during operating system upgrades. Because the advertising ID is a per-device value, it is does not roam with the user account. It cannot be turned on for child accounts. The value is not backed up.

This property is retrieved as shown here:

```csharp
var advertisingId = Windows.System.UserProfile.AdvertisingManager.AdvertisingId;
```

```cppwinrt
winrt::hstring advertisingId{ Windows::System::UserProfile::AdvertisingManager::AdvertisingId() };
```

```cppcx
auto advertisingId = Windows::System::UserProfile::AdvertisingManager::AdvertisingId;
```

## -examples

## -see-also

[Microsoft Advertising SDK](https://aka.ms/ads-sdk-uwp), [Microsoft Store policies for advertising conduct and content](/windows/apps/publish/store-policies#1010-advertising-conduct-and-content)
