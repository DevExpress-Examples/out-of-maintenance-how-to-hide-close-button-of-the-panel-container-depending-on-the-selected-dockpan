<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q205085/Form1.cs) (VB: [Form1.vb](./VB/Q205085/Form1.vb))
<!-- default file list end -->
# How to hide Close Button of the Panel Container depending on the selected DockPanel


<p>This functionality is built-in in Dock Panels starting with version 2009 vol3.</p><p>The following solution applies to earlier versions:</p><p>You can accomplish this task by handling the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsDockingDockPanel_ActiveChildChangedtopic"><u>DockPanel.ActiveChildChanged</u></a> of the Control Container. You can handle this event within the <a href="http://documentation.devexpress.com/#WindowsForms/DevExpressXtraBarsDockingDockManager_RegisterDockPaneltopic"><u>DockManager.RegisterDockPanel</u></a> event handler.</p>

<br/>


