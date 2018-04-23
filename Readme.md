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


