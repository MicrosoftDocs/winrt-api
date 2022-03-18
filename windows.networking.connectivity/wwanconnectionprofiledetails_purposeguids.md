---
-api-id: P:Windows.Networking.Connectivity.WwanConnectionProfileDetails.PurposeGuids
-api-type: winrt property
---

<!-- Property syntax.
public IVectorView<Guid> PurposeGuids { get; }
-->

# Windows.Networking.Connectivity.WwanConnectionProfileDetails.PurposeGuids

## -description
Gets a list of purpose group GUIDs.

## -property-value
A list of purpose group GUIDs.

## -remarks
A purpose group [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) is a public, industry-wide published GUID value describing a service. For example, IMS has a predefined GUID that you can provision with your mobile network operator SIM when the SIM is inserted into a device, which describes the profile that should be used when you query for the IMS profile.

## -see-also
[PurposeGroupGuid](/previous-versions/windows/desktop/legacy/mt243429(v=vs.85))

## -examples
