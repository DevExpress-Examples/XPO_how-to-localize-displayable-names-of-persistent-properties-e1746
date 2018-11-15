<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/LocalizableDisplayName/Form1.cs) (VB: [Form1.vb](./VB/LocalizableDisplayName/Form1.vb))
* [Product.cs](./CS/LocalizableDisplayName/Product.cs) (VB: [Product.vb](./VB/LocalizableDisplayName/Product.vb))
* [Program.cs](./CS/LocalizableDisplayName/Program.cs) (VB: [Program.vb](./VB/LocalizableDisplayName/Program.vb))
* [PropertyNamesRes.de.resx](./CS/LocalizableDisplayName/PropertyNamesRes.de.resx) (VB: [PropertyNamesRes.de.resx](./VB/LocalizableDisplayName/PropertyNamesRes.de.resx))
* [PropertyNamesRes.resx](./CS/LocalizableDisplayName/PropertyNamesRes.resx) (VB: [PropertyNamesRes.resx](./VB/LocalizableDisplayName/PropertyNamesRes.resx))
<!-- default file list end -->
# How to localize displayable names of persistent properties


<p>This example demonstrates how to apply DXDisplayName to persistent properties. It's also required to add neutral and localized resource files to the project and set the DXDisplayNameAttribute.UseResourceManager static property to True:</p>

```cs
<newline/>
System.ComponentModel.DXDisplayNameAttribute.UseResourceManager = true;<newline/>

```



```vb
<newline/>
System.ComponentModel.DXDisplayNameAttribute.UseResourceManager = True<newline/>

```

<p>Please review the <a href="https://www.devexpress.com/Support/Center/p/K18268">K18268</a> Knowledge Base article to learn more.</p>

<br/>


