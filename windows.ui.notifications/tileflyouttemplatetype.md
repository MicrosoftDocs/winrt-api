---
-api-id: T:Windows.UI.Notifications.TileFlyoutTemplateType
-api-type: winrt enum
-api-device-family-note: xbox
---

<!-- Enumeration syntax
public enum Windows.UI.Notifications.TileFlyoutTemplateType : int
-->

# TileFlyoutTemplateType

## -description
Specifies the layout template to use in a tile flyout (mix view) update. At present, only one template is defined.

## -enum-fields
### -field TileFlyoutTemplate01:0
Eight sub-tiles that surround a central medium (150x150) tile. Each sub-tile supports a combination of text and images.

<img src="images/TileFlyoutTemplate01.png" alt="TileFlyoutTemplate01 example" />
+ Sub-tiles 1-4 support an image optionally overlaid with a single text string normally used as a label. If the user hovers over one of these sub-tiles, the text scrolls.
+ Sub-tiles 5-8 support an image optionally overlaid with one or more strings from a set of 11 possible strings, each of which provides its own placement and font size on the sub-tile.



## -remarks
### Sub-tile configurations

### How to specify a configuration
Each of sub-tiles 5-8 can be given one of eight configurations. The configuration is determined by which text elements you include in that sub-tile, with an order of precedence to those elements. 
1. If Text10 or Text11 are set    + If Text08 or Text09 are set       + Configuration 3

   + Else       + Configuration 2


1. Else if Text02 is set    + If Text06 or Text07 are set       + Configuration 9

   + Else if Text03 is set       + Configuration 1

   + Else       + Configuration 5


1. Else if Text06    + If Text01       + Configuration 6

   + Else       + Configuration 7


1. Else if Text01    + Configuration 8

1. Else configuration 4


### Configuration examples

The layout of each configuration is shown here. Note that any text element included but not recognized by a configuration is ignored.

<table>
   <tr><td>**Configuration 1**

Supported text elements: 
<ul><li>1 ("Application")</li><li>2 ("List item 1")</li><li>3 ("List item 2")</li><li>4 ("List item 3")</li><li>5 ("List item 4")</li></ul></td><td><img src="images/TileFlyoutConfig01.png" alt="Tile flyout configuration 1 example" /></td></tr>
   <tr><td>**Configuration 2**

Supported text elements: 
<ul><li>1 ("Application")</li><li>6 ("String one wraps")</li><li>7 ("String two wraps")</li><li>10 ("0000" - upper)</li><li>11 ("0000" - lower)</li></ul></td><td><img src="images/TileFlyoutConfig02.png" alt="Tile flyout configuration 2 example" /></td></tr>
   <tr><td>**Configuration 3**

Valid text elements: 
<ul><li>1 ("Application")</li><li>6 ("String one")</li><li>7 ("String two")</li><li>8 ("String three")</li><li>9 ("String four")</li><li>10 ("0000" - upper)</li><li>11 ("0000" - lower)</li></ul></td><td><img src="images/TileFlyoutConfig03.png" alt="Tile flyout configuration 3 example" /></td></tr>
   <tr><td>**Configuration 4**

Valid text elements: none (image only)</td><td><img src="images/TileFlyoutConfig04.png" alt="Tile flyout configuration 4 example" /></td></tr>
   <tr><td>**Configuration 5**

Valid text elements: 
<ul><li>1 ("Label")</li><li>2 ("Text example of text wrapping to four lines")</li></ul></td><td><img src="images/TileFlyoutConfig05.png" alt="Tile flyout configuration 5 example" /></td></tr>
   <tr><td>**Configuration 6**

Valid text elements: 
<ul><li>1 ("Label")</li><li>6 ("Text example of headline")</li></ul></td><td><img src="images/TileFlyoutConfig06.png" alt="Tile flyout configuration 6 example" /></td></tr>
   <tr><td>**Configuration 7**

Valid text elements: 
<ul><li>6 ("Text example of headine text on photo")</li></ul></td><td><img src="images/TileFlyoutConfig07.png" alt="Tile flyout configuration 7 example" /></td></tr>
   <tr><td>**Configuration 8**

Valid text elements: 1 
<ul><li>1 ("Label")</li></ul></td><td><img src="images/TileFlyoutConfig08.png" alt="Tile flyout configuration 8 example" /></td></tr>
   <tr><td>**Configuration 9**

Valid text elements: 
<ul><li>1 ("Label" - bottom)</li><li>2 ("Headline" - upper)</li><li>3 ("Headline" - lower)</li><li>6 ("Label" - upper)</li><li>7 ("Label" - lower)</li></ul></td><td><img src="images/TileFlyoutConfig09.png" alt="Tile flyout configuration 9 example" /></td></tr>
</table>


<!-- @WRITER erictill 5/6/2014 :<rem>-->

<!-- @WRITER erictill 5/6/2014 : Safe to assume that left and right switches on RTL languages? -->

<!-- @WRITER erictill 5/6/2014 : On element 2, it wraps? Do the others? And if they do, do they push the others down or overlay them? -->

<!-- @WRITER erictill 5/6/2014 : On items 2-5, what if item 2 is omitted? Does it take the upper place or remain in place as though an invisible element 2 is there? -->

<!-- @WRITER erictill 5/6/2014 :
                <p>The following table explains the use of the different strings.
                    
                    <table class="clsStd">
                        <tr>
                            <th>Text element ID</th>
                            <th>Details</th>
                        </tr>
                        <tr>
                            <td>1</td>
                            <td>
                                <list>
                                    <item>Placement: lower left</item>
                                    <item>Font size: small</item>
                                    <item>Similar to an app's display name</item>
                                </list>
                            </td>
                        </tr>
                        <tr>
                            <td>2</td>
                            <td>
                                <list>
                                    <item>Placement: upper left</item>
                                    <item>Font size: large</item>
                                    <item>Elements 2-5 form a list. This is the first entry in the list.</item>
                                </list>
                            </td>
                        </tr>
                        <tr>
                            <td>3</td>
                            <td>
                                <list>
                                    <item>Placement: below text element 2</item>
                                    <item>Font size: large</item>
                                    <item>Elements 2-5 form a list. This is the 2nd entry in the list.</item>
                                </list>
                            </td>
                        </tr>
                        <tr>
                            <td>4</td>
                            <td>
                                <list>
                                    <item>Placement: below text element 3</item>
                                    <item>Font size: large</item>
                                    <item>Elements 2-5 form a list. This is the 3rd entry in the list.</item>
                                </list>
                            </td>
                        </tr>
                        <tr>
                            <td>5</td>
                            <td>
                                <list>
                                    <item>Placement: below text element 4</item>
                                    <item>Font size: large</item>
                                    <item>Elements 2-5 form a list. This is the 4th entry in the list.</item>
                                </list>
                            </td>
                        </tr>
                        <tr>
                            <td>6</td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>7</td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>8</td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>9</td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>10</td>
                            <td></td>
                            <td></td>
                        </tr>
                        <tr>
                            <td>11</td>
                            <td></td>
                            <td></td>
                        </tr>
                    </table>
                </p></rem> -->

## -examples

## -see-also