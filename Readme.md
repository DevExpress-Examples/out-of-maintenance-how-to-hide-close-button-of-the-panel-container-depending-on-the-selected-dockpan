<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128616954/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1437)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q205085/Form1.cs) (VB: [Form1.vb](./VB/Q205085/Form1.vb))
<!-- default file list end -->
# How to hide Close Button of the Panel Container depending on the selected DockPanel


<p>This functionality is built-in in Dock Panels starting with version 2009 vol3.</p><p>The following solution applies to earlier versions:</p><p>You can accomplish this task by handling the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsDockingDockPanel_ActiveChildChangedtopic"><u>DockPanel.ActiveChildChanged</u></a> of the Control Container. You can handle this event within the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsDockingDockManager_RegisterDockPaneltopic"><u>DockManager.RegisterDockPanel</u></a> event handler.</p>

<br/>


