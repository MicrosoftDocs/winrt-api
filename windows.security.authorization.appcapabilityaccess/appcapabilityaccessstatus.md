---
-api-id: T:Windows.Security.Authorization.AppCapabilityAccess.AppCapabilityAccessStatus
-api-type: winrt enum
---

<!-- Enumeration syntax.
public enum AppCapabilityAccessStatus : int 
-->

# Windows.Security.Authorization.AppCapabilityAccess.AppCapabilityAccessStatus

## -description
Describes an application's access to a single capability. 

## -enum-fields
### -field UserPromptRequired:3
State: User Prompt Required

### -field NotDeclaredByApp:1
State: Not Declared by App.

### -field DeniedByUser:2
State: Denied by User.

### -field DeniedBySystem:0
State: Denied by System.

### -field Allowed:4
State: Allowed.

## -remarks
"Requesting" access means to ask the system to do a full access check, which may involve a user prompt. Requests will never return "UserPromptRequired". "Checking" access will simply query your status and is guaranteed to not prompt, as such may return the status "UserPromptRequired".

## -see-also

## -examples

