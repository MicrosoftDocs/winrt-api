---
-api-id: P:Windows.ApplicationModel.Store.LicenseInformation.IsTrial
-api-type: winrt property
---

<!-- Property syntax
public bool IsTrial { get; }
-->

# Windows.ApplicationModel.Store.LicenseInformation.IsTrial

## -description
Gets a value that indicates whether the license is a trial license.

## -property-value
Returns true if the license is a trial license, and otherwise false.

## -remarks
For a trial experience with a trial period, there are some special considerations for interpreting the value of IsTrial. IsTrial returns **true** even after the trial period ends, because a trial license is logically considered to be a trial license both during and after the trial period. After purchase, when the license becomes full, IsTrial returns **false**. While IsTrial returns **true**, there are two ways to tell whether the trial period has expired. If you want to take action the moment the trial period expires then compare the current Coordinated Universal Time (or Zulu time) with [ExpirationDate](licenseinformation_expirationdate.md). Otherwise, you can check [IsActive](licenseinformation_isactive.md), which returns **true** during the trial period and **false** some time after the trial period ends.

> [!NOTE]
> Be aware that, for an app installed from the Microsoft Store, it can take some hours after the trial period ends for [IsActive](licenseinformation_isactive.md) to begin returning a value of **false**. When testing your app with [CurrentAppSimulator](currentappsimulator.md), [IsActive](licenseinformation_isactive.md) will return **false** at the exact datetime set in the configuration file.

## -examples

## -see-also
