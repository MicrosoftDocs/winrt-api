---
-api-id: T:Windows.Storage.KnownFoldersAccessStatus
-api-type: winrt enumeration
---

## -description
Describes a known folder's access to a single capability.

## -enum-fields

### -field DeniedBySystem:0

System admin disabled access for all users.

### -field NotDeclaredByApp:1

App doesn't have the capability declared in the manifest.

### -field DeniedByUser:2

User has denied access and there is no fallback for this location.

### -field UserPromptRequired:3

User consent is required, but not yet completed.

### -field Allowed:4

Access is allowed.

### -field AllowedPerAppFolder:5

Access is allowed but limited to a Per App Subfolder.

## -remarks

## -see-also
[KnownFolders](knownfolders.md)

## -examples

