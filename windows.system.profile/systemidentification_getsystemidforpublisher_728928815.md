---
-api-id: M:Windows.System.Profile.SystemIdentification.GetSystemIdForPublisher
-api-type: winrt method
---

<!-- Method syntax
public Windows.System.Profile.SystemIdentificationInfo GetSystemIdForPublisher()
-->

# Windows.System.Profile.SystemIdentification.GetSystemIdForPublisher

## -description
Gets an identifier value for the system based on the app publisher ID.

## -returns
A [SystemIdentificationInfo](systemidentificationinfo.md) object for this system, based on the app publisher ID.

## -remarks
The identifier returned by this method is specific to the app publisher on the current device.


The ID has the following characteristics:

+ Unique for each system
+ On any particular system, all apps by the same publisher will get the same value for this ID (for all users). Conversely, apps by different publishers on the same system will obtain different IDs.
+ Can be created offline
+ Persists across restarts, reinstalls and upgrades of Windows, including clean installs (please see below for exceptions)
+ Persists across most hardware modifications
+ Available in OneCore

This method requires either a Unified Extensible Firmware Interface (UEFI) or a Trusted Platform Module (TPM) to generate the system ID. The method will first attempt to use the TPM, if present, to get an ID. If a TPM is not present, the method will try to get an ID from UEFI. If neither of these sources are available, this method will return an ID that is backed by the Windows registry. In the case of the Windows registry, the ID will not satisfy all the above guarantees. For example, if a system does not have a TPM or UEFI support, and thus an ID was obtained from the registry, a clean install of Windows will result in a new, different ID being returned. Callers of this method should refer to the Source property of the returned SystemIdentificationInfo to determine where the ID was obtained from in order to understand the guarantees provided.

## -examples

## -see-also
