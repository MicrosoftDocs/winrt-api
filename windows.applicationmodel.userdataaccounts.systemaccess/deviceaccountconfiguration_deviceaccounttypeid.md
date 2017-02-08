---
-api-id: P:Windows.ApplicationModel.UserDataAccounts.SystemAccess.DeviceAccountConfiguration.DeviceAccountTypeId
-api-type: winrt property
---

<!-- Property syntax
public string DeviceAccountTypeId { get;  set; }
-->

# Windows.ApplicationModel.UserDataAccounts.SystemAccess.DeviceAccountConfiguration.DeviceAccountTypeId

## -description
Gets or sets the value that identifies the device account type.

## -property-value
The value that identifies the device account type.

## -remarks
Valid values for this property are:

<table>
   <tr><th>Account type</th><th>ID</th></tr>
   <tr><td>Exchange Active Sync</td><td>6833942B-ABDA-4C20-9757-4F9252396BD4</td></tr>
   <tr><td>Google via Exchange Active Sync</td><td>E288529A-1917-4985-897F-34D8121EBFC3</td></tr>
   <tr><td>Internet Mail (Pop/IMAP)</td><td>DC23EAD7-BBF2-44D7-A791-6B2B7580F0C2</td></tr>
   <tr><td>Google via IMAP/CardDAV/CalDAV</td><td>0A95CDAA-C7EB-4133-9793-75E13089F082</td></tr>
   <tr><td>iCloud via IMAP/CardDAV/CalDAV</td><td>45157403-77C9-4E68-9485-6DD9A79D534A</td></tr>
</table>

Other values may be added in the future, so you should have a default case to handle unknown values.

## -examples

## -see-also
