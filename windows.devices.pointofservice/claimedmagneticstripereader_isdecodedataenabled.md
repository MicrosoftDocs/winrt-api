---
-api-id: P:Windows.Devices.PointOfService.ClaimedMagneticStripeReader.IsDecodeDataEnabled
-api-type: winrt property
-api-device-family-note: xbox
---

<!-- Property syntax
public bool IsDecodeDataEnabled { get;  set; }
-->

# Windows.Devices.PointOfService.ClaimedMagneticStripeReader.IsDecodeDataEnabled

## -description
Indicates whether to provide raw or decoded data from the most recently swiped card.

## -property-value
Set to true if decoded data is provided to the application; otherwise, false.

## -remarks
Use this property to decide whether to pass the data from the card swipe in the original raw form or to decode it first.

If set to true, each byte of track data is mapped from its original encoded bit sequence, as it exists in the magnetic card, to its corresponding decoded ASCII bit sequence. This conversion is not relevant to 7-bit format, which is not encoded.

For each card type, the decoding takes place as follows:<table>
   <tr><th>Card type</th><th>Track data property</th><th>Raw data format</th><th>Raw bytes</th><th>Decoded Values</th></tr>
   <tr><td>ISO</td><td>Track 1 data</td><td>6-bit</td><td>0x00-0x3F</td><td>0x20 through 0x5F</td></tr>
   <tr><td>ISO</td><td>Track 2 data</td><td>4-bit</td><td>0x00-0x3F</td><td>0x30 through 0x3F</td></tr>
   <tr><td>ISO</td><td>Track 3 data</td><td>4-bit</td><td>0x00-0x3F</td><td>0x30 through 0x3F</td></tr>
   <tr><td>JIS-I</td><td>Track 1 data</td><td>6-bit</td><td>0x00-0x3F</td><td>0x20 through 0x5F</td></tr>
   <tr><td>JIS-I</td><td>Track 1 data</td><td>7-bit</td><td>0x00-0x7F</td><td>Data unaltered</td></tr>
   <tr><td>JIS-I</td><td>Track 2 data</td><td>4-bit</td><td>0x00-0x0F</td><td>0x20 through 0x3F</td></tr>
   <tr><td>JIS-I</td><td>Track 3 data</td><td>4-bit</td><td>0x00-0x0F</td><td>0x20 through 0x3F</td></tr>
   <tr><td>JIS-I</td><td>Track 3 data</td><td>7-bit</td><td>0x00-0x7F</td><td>Data unaltered</td></tr>
   <tr><td>JIS-II</td><td>Track 4 data</td><td>7-bit</td><td>0x00-0x7F</td><td>Data unaltered</td></tr>
   <tr><td>AAMVA</td><td>Track 1 data</td><td>6-bit</td><td>0x00-0x3F</td><td>0x20 through 0x5F</td></tr>
   <tr><td>AAMVA</td><td>Track 2 data</td><td>4-bit</td><td>0x00-0x0F</td><td>0x30 through 0x3F</td></tr>
   <tr><td>AAMVA</td><td>Track 3 data</td><td>6-bit</td><td>0x00-0x3F</td><td>0x20 through 0x5F</td></tr>
</table>

This property is initialized to false.

## -examples

## -see-also
