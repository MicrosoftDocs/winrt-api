---
-api-id: T:Windows.Services.Cortana.CortanaPermission
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum CortanaPermission : int 
-->

# Windows.Services.Cortana.CortanaPermission

## -description

Specifies the Cortana permissions available to a [CortanaPermissionManager](cortanapermissionsmanager.md) object.

## -enum-fields

### -field PhoneCall:10

Cortana can make phone calls.

### -field Personalization:9

Cortana personalization settings are exposed.

### -field Microphone:8

Cortana can access the microphone.

### -field Messaging:7

Cortana can send text messages.

### -field Location:6

Cortana can access the user's location.

### -field InputPersonalization:5

Cortana can access input personalization settings.

### -field Email:4

Cortana can send email.

### -field Contacts:3

Cortana can access the user's contacts.

### -field CallHistory:2

Cortana can access the user's call history.

### -field Calendar:1

Cortana can access the user's calendar.

### -field BrowsingHistory:0

Cortana can access the user's web browsing history.

## -capabilities

cortanaPermissions

## -remarks

The [CortanaPermissionManager](cortanapermissionsmanager.md) class requires the following be added to the Package.appmanifest:

- To \<Package\>
  - `xmlns:rescap="http://schemas.microsoft.com/appx/manifest/foundation/windows10/restrictedcapabilities"`
  - `IgnorableNamespaces="rescap"`
- Under \<Capabilities\>
  - `<rescap:capability name="cortanaPermissions"/>`

## -see-also

[CortanaPermissionsChangeResult](cortanapermissionschangeresult.md), [CortanaPermissionManager](cortanapermissionsmanager.md), [CortanaPermissionsManager.ArePermissionsGrantedAsync](cortanapermissionsmanager_arepermissionsgrantedasync_1821808521.md), [CortanaPermissionsManager.GrantPermissionsAsync](cortanapermissionsmanager_grantpermissionsasync_1382961431.md), [CortanaPermissionsManager.RevokePermissionsAsync](cortanapermissionsmanager_revokepermissionsasync_517405145.md)

## -examples