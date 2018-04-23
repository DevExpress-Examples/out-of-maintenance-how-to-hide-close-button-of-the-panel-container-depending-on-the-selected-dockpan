using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraBars.Docking;

namespace Q205085 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();

        }

        private void OnDockManagerRegisterDockPanel(object sender, DockPanelEventArgs e) {
            if (e.Panel.Name.Contains("panelContainer")) {
                e.Panel.ActiveChildChanged += new DockPanelEventHandler(OnDockPanelActiveChildChanged);
                AdjustCloseButtonVisibility(e.Panel);
            }
        }

        private void OnDockPanelActiveChildChanged(object sender, DockPanelEventArgs e) {
            AdjustCloseButtonVisibility(e.Panel);
        }

        private static void AdjustCloseButtonVisibility(DockPanel panel) {
            panel.Options.ShowCloseButton = panel.ActiveChild.Options.ShowCloseButton;
        }
    }
}