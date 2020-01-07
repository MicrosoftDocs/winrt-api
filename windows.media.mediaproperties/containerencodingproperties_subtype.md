---
-api-id: P:Windows.Media.MediaProperties.ContainerEncodingProperties.Subtype
-api-type: winrt property
---

<!-- Property syntax
public string Subtype { get;  set; }
-->

# Windows.Media.MediaProperties.ContainerEncodingProperties.Subtype

## -description
Gets or sets the subtype of the media container.

## -property-value
The subtype.

## -remarks
The value can be the string representation of a [GUID](/windows/win32/api/guiddef/ns-guiddef-guid) in canonical form, or one of the predefined values listed in the following table.

| Subtype | GUID |  
|--------------|------------|
|ASF          |430f6f6e-b6bf-4fc1-a0bd-9ee46eee2afb | 
|MP3          |e438b912-83f1-4de6-9e3a-9ffbc6dd24d1 |
|MPEG4        |dc6cd05d-b9d0-40ef-bd35-fa622c1ab28a |
|AVI          |7edfe8af-402f-4d76-a33c-619fd157d0f1 |
|MPEG2        |bfc2dbf9-7bb4-4f8f-afde-e112c44ba882 |
|WAVE         |64c3453c-0f26-4741-be63-87bdf8bb935b |
|AACADTS      |132fd27d-0f02-43de-a301-38fbbbb3834e |
|ADTS         |132fd27d-0f02-43de-a301-38fbbbb3834e |
|3GP          |34c50167-4472-4f34-9ea0-c49fbacf037d |
|AMR          |025d5ad3-621a-475b-964d-66b1c824f079 |
|FLAC         |31344aa3-05a9-42b5-901b-8e9d4257f75e |




> [!WARNING]
> The string values returned by the [MediaEncodingSubtypes](mediaencodingsubtypes.md) properties may not use the same letter casing as [AudioEncodingProperties.Subtype](audioencodingproperties_subtype.md), [VideoEncodingProperties.Subtype](videoencodingproperties_subtype.md), ContainerEncodingProperties.Subtype, and [ImageEncodingProperties.Subtype](imediaencodingproperties_subtype.md). For this reason, if you compare the values, you should use a case-insensitive comparison or use hardcoded strings that match the casing returned by the encoding properties.

## -examples

## -see-also
