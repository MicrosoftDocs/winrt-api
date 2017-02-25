---
-api-id: T:Windows.UI.Input.Inking.InkPersistenceFormat
-api-type: winrt enum
---

<!-- Enumeration syntax
public enum Windows.UI.Input.Inking.InkPersistenceFormat : int
-->

# InkPersistenceFormat

## -description
Specifies the formats for saving ink input.

## -enum-fields
### -field GifWithEmbeddedIsf:0
Ink is saved as a GIF file with embedded Ink Serialized Format (ISF) format data.

### -field Isf:1
Ink is saved as Ink Serialized Format (ISF) format data.

## -remarks

## -examples

## -see-also
- [InkStrokeContainer.SaveAsync(Windows.Storage.Streams.IOutputStream outputStream, Windows.UI.Input.Inking.InkPersistenceFormat inkPersistenceFormat)](inkstrokecontainer_saveasync_238248194.md)
- [InkStrokeContainer.SaveAsync(Windows.Storage.Streams.IOutputStream outputStream)](inkstrokecontainer_saveasync_1696379726.md)
- [Pen and stylus interactions](http://msdn.microsoft.com/library/3da4f2d2-5405-42a1-9ed9-3a87bcd84c43)
- [Ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620308), [Simple ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620312), [Complex ink sample](http://go.microsoft.com/fwlink/p/?LinkID=620314)