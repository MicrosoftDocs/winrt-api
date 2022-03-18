---
-api-id: P:Windows.Networking.Connectivity.ConnectionProfileFilter.PurposeGuid
-api-type: winrt property
---

<!-- Property syntax.
public IReference<Guid> PurposeGuid { get;  set; }
-->

# Windows.Networking.Connectivity.ConnectionProfileFilter.PurposeGuid

## -description
Gets or sets the purpose group [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) that a connection profile must match in order to be included in query results.

## -property-value
The purpose group GUID that a connection profile must match.

## -remarks
A purpose group GUID is a public, industry-wide published GUID value describing a service. For example, IMS has a predefined GUID that you can provision with your mobile network operator SIM when the SIM is inserted into a device, which describes the profile that should be used when you query for the IMS profile.

## -see-also
[PurposeGroupGuid](/previous-versions/windows/desktop/legacy/mt243429(v=vs.85))

## -examples
