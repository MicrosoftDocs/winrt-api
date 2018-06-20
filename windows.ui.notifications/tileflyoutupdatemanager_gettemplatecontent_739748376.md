---
-api-id: M:Windows.UI.Notifications.TileFlyoutUpdateManager.GetTemplateContent(Windows.UI.Notifications.TileFlyoutTemplateType)
-api-type: winrt method
-api-device-family-note: xbox
---

<!-- Method syntax
public Windows.Data.Xml.Dom.XmlDocument GetTemplateContent(Windows.UI.Notifications.TileFlyoutTemplateType type)
-->

# Windows.UI.Notifications.TileFlyoutUpdateManager.GetTemplateContent

## -description
Gets a blank XML template content that defines a tile flyout (mix view) notification. You can then fill in this template as needed, using Document Object Model (DOM)  API.

> [!NOTE]
> When you use the template retrieved through this method, you don't need to remove unused elements. They will be ignored.

## -parameters
### -param type
The specific template. At this time, the only valid value is **TileFlyoutTemplate01**.

## -returns
The template's content represented as an [XmlDocument](../windows.data.xml.dom/xmldocument.md) object.

## -remarks
Because there is currently only one template, this method always fetches the following XML: 

``` xml
<tileflyout>
    <visual version="3">
        <binding template="TileFlyoutTemplate01">
            <subtile id="1" arguments="">
                <image id="1" src=""/>
                <text id="1"></text>
            </subtile>
            
            <subtile id="2" arguments="">
                <image id="1" src=""/>
                <text id="1"></text>
            </subtile>
            
            <subtile id="3" arguments="">
                <image id="1" src=""/>
                <text id="1"></text>
            </subtile>
            
            <subtile id="4" arguments="">
                <image id="1" src=""/>
                <text id="1"></text>
            </subtile>
            
            <subtile id="5" arguments="">
                <image id="1" src=""/>
                <text id="1"></text>
                <text id="2"></text>
                <text id="3"></text>
                <text id="4"></text>
                <text id="5"></text>
                <text id="6"></text>
                <text id="7"></text>
                <text id="8"></text>
                <text id="9"></text>
                <text id="10"></text>
                <text id="11"></text>
            </subtile>
            
            <subtile id="6" arguments="">
                <image id="1" src=""/>
                <text id="1"></text>
                <text id="2"></text>
                <text id="3"></text>
                <text id="4"></text>
                <text id="5"></text>
                <text id="6"></text>
                <text id="7"></text>
                <text id="8"></text>
                <text id="9"></text>
                <text id="10"></text>
                <text id="11"></text>
            </subtile>
            
            <subtile id="7" arguments="">
                <image id="1" src=""/>
                <text id="1"></text>
                <text id="2"></text>
                <text id="3"></text>
                <text id="4"></text>
                <text id="5"></text>
                <text id="6"></text>
                <text id="7"></text>
                <text id="8"></text>
                <text id="9"></text>
                <text id="10"></text>
                <text id="11"></text>
            </subtile>
            
            <subtile id="8" arguments="">
                <image id="1" src=""/>
                <text id="1"></text>
                <text id="2"></text>
                <text id="3"></text>
                <text id="4"></text>
                <text id="5"></text>
                <text id="6"></text>
                <text id="7"></text>
                <text id="8"></text>
                <text id="9"></text>
                <text id="10"></text>
                <text id="11"></text>
            </subtile>
        </binding>
    </visual>
</tileflyout>
```

## -examples

## -see-also
