using System.Windows.Forms;

namespace UE4_Binary_Builder
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bWithFullDebugInfo = new System.Windows.Forms.CheckBox();
            this.GameConfigurations1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.bCleanBuild = new System.Windows.Forms.CheckBox();
            this.bSignExecutables = new System.Windows.Forms.CheckBox();
            this.bWithDDC = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bWithWin64 = new System.Windows.Forms.CheckBox();
            this.bHostPlatformOnly = new System.Windows.Forms.CheckBox();
            this.bWithXboxOne = new System.Windows.Forms.CheckBox();
            this.bWithPS4 = new System.Windows.Forms.CheckBox();
            this.bWithSwitch = new System.Windows.Forms.CheckBox();
            this.bWithHTML5 = new System.Windows.Forms.CheckBox();
            this.bWithLinux = new System.Windows.Forms.CheckBox();
            this.bWithTVOS = new System.Windows.Forms.CheckBox();
            this.bWithIOS = new System.Windows.Forms.CheckBox();
            this.bWithAndroid = new System.Windows.Forms.CheckBox();
            this.bWithMac = new System.Windows.Forms.CheckBox();
            this.bWithWin32 = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.BuildRocketUE = new System.Windows.Forms.Button();
            this.AutomationToolBrowse = new System.Windows.Forms.Button();
            this.AutomationToolPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LogWindow = new System.Windows.Forms.TextBox();
            this.mainMenu1 = new System.Windows.Forms.MainMenu(this.components);
            this.GetSourceCodeMenu = new System.Windows.Forms.MenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            this.toolTip1.SetToolTip(this.label1, resources.GetString("label1.ToolTip"));
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.bWithFullDebugInfo);
            this.groupBox1.Controls.Add(this.GameConfigurations1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.bCleanBuild);
            this.groupBox1.Controls.Add(this.bSignExecutables);
            this.groupBox1.Controls.Add(this.bWithDDC);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox1, resources.GetString("groupBox1.ToolTip"));
            // 
            // bWithFullDebugInfo
            // 
            resources.ApplyResources(this.bWithFullDebugInfo, "bWithFullDebugInfo");
            this.bWithFullDebugInfo.Name = "bWithFullDebugInfo";
            this.toolTip1.SetToolTip(this.bWithFullDebugInfo, resources.GetString("bWithFullDebugInfo.ToolTip"));
            this.bWithFullDebugInfo.UseVisualStyleBackColor = true;
            this.bWithFullDebugInfo.CheckedChanged += new System.EventHandler(this.bWithFullDebugInfo_CheckedChanged);
            // 
            // GameConfigurations1
            // 
            resources.ApplyResources(this.GameConfigurations1, "GameConfigurations1");
            this.GameConfigurations1.Name = "GameConfigurations1";
            this.toolTip1.SetToolTip(this.GameConfigurations1, resources.GetString("GameConfigurations1.ToolTip"));
            this.GameConfigurations1.TextChanged += new System.EventHandler(this.GameConfigurations1_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            this.toolTip1.SetToolTip(this.label3, resources.GetString("label3.ToolTip"));
            // 
            // bCleanBuild
            // 
            resources.ApplyResources(this.bCleanBuild, "bCleanBuild");
            this.bCleanBuild.Name = "bCleanBuild";
            this.toolTip1.SetToolTip(this.bCleanBuild, resources.GetString("bCleanBuild.ToolTip"));
            this.bCleanBuild.UseVisualStyleBackColor = true;
            // 
            // bSignExecutables
            // 
            resources.ApplyResources(this.bSignExecutables, "bSignExecutables");
            this.bSignExecutables.Name = "bSignExecutables";
            this.toolTip1.SetToolTip(this.bSignExecutables, resources.GetString("bSignExecutables.ToolTip"));
            this.bSignExecutables.UseVisualStyleBackColor = true;
            // 
            // bWithDDC
            // 
            resources.ApplyResources(this.bWithDDC, "bWithDDC");
            this.bWithDDC.Checked = true;
            this.bWithDDC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bWithDDC.Name = "bWithDDC";
            this.toolTip1.SetToolTip(this.bWithDDC, resources.GetString("bWithDDC.ToolTip"));
            this.bWithDDC.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Controls.Add(this.bWithWin64);
            this.groupBox2.Controls.Add(this.bHostPlatformOnly);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            this.toolTip1.SetToolTip(this.groupBox2, resources.GetString("groupBox2.ToolTip"));
            // 
            // bWithWin64
            // 
            resources.ApplyResources(this.bWithWin64, "bWithWin64");
            this.bWithWin64.Checked = true;
            this.bWithWin64.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bWithWin64.Name = "bWithWin64";
            this.toolTip1.SetToolTip(this.bWithWin64, resources.GetString("bWithWin64.ToolTip"));
            this.bWithWin64.UseVisualStyleBackColor = true;
            // 
            // bHostPlatformOnly
            // 
            resources.ApplyResources(this.bHostPlatformOnly, "bHostPlatformOnly");
            this.bHostPlatformOnly.Name = "bHostPlatformOnly";
            this.toolTip1.SetToolTip(this.bHostPlatformOnly, resources.GetString("bHostPlatformOnly.ToolTip"));
            this.bHostPlatformOnly.UseVisualStyleBackColor = true;
            this.bHostPlatformOnly.CheckedChanged += new System.EventHandler(this.bHostPlatformOnly_CheckedChanged);
            // 
            // bWithXboxOne
            // 
            resources.ApplyResources(this.bWithXboxOne, "bWithXboxOne");
            this.bWithXboxOne.Name = "bWithXboxOne";
            this.toolTip1.SetToolTip(this.bWithXboxOne, resources.GetString("bWithXboxOne.ToolTip"));
            this.bWithXboxOne.UseVisualStyleBackColor = true;
            // 
            // bWithPS4
            // 
            resources.ApplyResources(this.bWithPS4, "bWithPS4");
            this.bWithPS4.Name = "bWithPS4";
            this.toolTip1.SetToolTip(this.bWithPS4, resources.GetString("bWithPS4.ToolTip"));
            this.bWithPS4.UseVisualStyleBackColor = true;
            // 
            // bWithSwitch
            // 
            resources.ApplyResources(this.bWithSwitch, "bWithSwitch");
            this.bWithSwitch.Name = "bWithSwitch";
            this.toolTip1.SetToolTip(this.bWithSwitch, resources.GetString("bWithSwitch.ToolTip"));
            this.bWithSwitch.UseVisualStyleBackColor = true;
            // 
            // bWithHTML5
            // 
            resources.ApplyResources(this.bWithHTML5, "bWithHTML5");
            this.bWithHTML5.Checked = true;
            this.bWithHTML5.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bWithHTML5.Name = "bWithHTML5";
            this.toolTip1.SetToolTip(this.bWithHTML5, resources.GetString("bWithHTML5.ToolTip"));
            this.bWithHTML5.UseVisualStyleBackColor = true;
            // 
            // bWithLinux
            // 
            resources.ApplyResources(this.bWithLinux, "bWithLinux");
            this.bWithLinux.Checked = true;
            this.bWithLinux.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bWithLinux.Name = "bWithLinux";
            this.toolTip1.SetToolTip(this.bWithLinux, resources.GetString("bWithLinux.ToolTip"));
            this.bWithLinux.UseVisualStyleBackColor = true;
            // 
            // bWithTVOS
            // 
            resources.ApplyResources(this.bWithTVOS, "bWithTVOS");
            this.bWithTVOS.Checked = true;
            this.bWithTVOS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bWithTVOS.Name = "bWithTVOS";
            this.toolTip1.SetToolTip(this.bWithTVOS, resources.GetString("bWithTVOS.ToolTip"));
            this.bWithTVOS.UseVisualStyleBackColor = true;
            // 
            // bWithIOS
            // 
            resources.ApplyResources(this.bWithIOS, "bWithIOS");
            this.bWithIOS.Checked = true;
            this.bWithIOS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bWithIOS.Name = "bWithIOS";
            this.toolTip1.SetToolTip(this.bWithIOS, resources.GetString("bWithIOS.ToolTip"));
            this.bWithIOS.UseVisualStyleBackColor = true;
            // 
            // bWithAndroid
            // 
            resources.ApplyResources(this.bWithAndroid, "bWithAndroid");
            this.bWithAndroid.Checked = true;
            this.bWithAndroid.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bWithAndroid.Name = "bWithAndroid";
            this.toolTip1.SetToolTip(this.bWithAndroid, resources.GetString("bWithAndroid.ToolTip"));
            this.bWithAndroid.UseVisualStyleBackColor = true;
            // 
            // bWithMac
            // 
            resources.ApplyResources(this.bWithMac, "bWithMac");
            this.bWithMac.Checked = true;
            this.bWithMac.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bWithMac.Name = "bWithMac";
            this.toolTip1.SetToolTip(this.bWithMac, resources.GetString("bWithMac.ToolTip"));
            this.bWithMac.UseVisualStyleBackColor = true;
            // 
            // bWithWin32
            // 
            resources.ApplyResources(this.bWithWin32, "bWithWin32");
            this.bWithWin32.Checked = true;
            this.bWithWin32.CheckState = System.Windows.Forms.CheckState.Checked;
            this.bWithWin32.Name = "bWithWin32";
            this.toolTip1.SetToolTip(this.bWithWin32, resources.GetString("bWithWin32.ToolTip"));
            this.bWithWin32.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.IsBalloon = true;
            this.toolTip1.ShowAlways = true;
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Information";
            // 
            // BuildRocketUE
            // 
            resources.ApplyResources(this.BuildRocketUE, "BuildRocketUE");
            this.BuildRocketUE.Name = "BuildRocketUE";
            this.toolTip1.SetToolTip(this.BuildRocketUE, resources.GetString("BuildRocketUE.ToolTip"));
            this.BuildRocketUE.UseVisualStyleBackColor = true;
            this.BuildRocketUE.Click += new System.EventHandler(this.BuildRocketUE_Click);
            // 
            // AutomationToolBrowse
            // 
            resources.ApplyResources(this.AutomationToolBrowse, "AutomationToolBrowse");
            this.AutomationToolBrowse.Name = "AutomationToolBrowse";
            this.toolTip1.SetToolTip(this.AutomationToolBrowse, resources.GetString("AutomationToolBrowse.ToolTip"));
            this.AutomationToolBrowse.UseVisualStyleBackColor = true;
            this.AutomationToolBrowse.Click += new System.EventHandler(this.AutomationToolBrowse_Click);
            // 
            // AutomationToolPath
            // 
            resources.ApplyResources(this.AutomationToolPath, "AutomationToolPath");
            this.AutomationToolPath.Name = "AutomationToolPath";
            this.toolTip1.SetToolTip(this.AutomationToolPath, resources.GetString("AutomationToolPath.ToolTip"));
            this.AutomationToolPath.TextChanged += new System.EventHandler(this.AutomationToolPath_TextChanged);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            this.toolTip1.SetToolTip(this.label2, resources.GetString("label2.ToolTip"));
            // 
            // LogWindow
            // 
            resources.ApplyResources(this.LogWindow, "LogWindow");
            this.LogWindow.BackColor = System.Drawing.SystemColors.WindowText;
            this.LogWindow.ForeColor = System.Drawing.Color.White;
            this.LogWindow.Name = "LogWindow";
            this.toolTip1.SetToolTip(this.LogWindow, resources.GetString("LogWindow.ToolTip"));
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.GetSourceCodeMenu});
            resources.ApplyResources(this.mainMenu1, "mainMenu1");
            // 
            // GetSourceCodeMenu
            // 
            resources.ApplyResources(this.GetSourceCodeMenu, "GetSourceCodeMenu");
            this.GetSourceCodeMenu.Index = 0;
            // 
            // MainWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LogWindow);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AutomationToolBrowse);
            this.Controls.Add(this.BuildRocketUE);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AutomationToolPath);
            this.Menu = this.mainMenu1;
            this.Name = "MainWindow";
            this.toolTip1.SetToolTip(this, resources.GetString("$this.ToolTip"));
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox AutomationToolPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox bHostPlatformOnly;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.CheckBox bWithXboxOne;
        private System.Windows.Forms.CheckBox bWithPS4;
        private System.Windows.Forms.CheckBox bWithSwitch;
        private System.Windows.Forms.CheckBox bWithHTML5;
        private System.Windows.Forms.CheckBox bWithLinux;
        private System.Windows.Forms.CheckBox bWithTVOS;
        private System.Windows.Forms.CheckBox bWithIOS;
        private System.Windows.Forms.CheckBox bWithAndroid;
        private System.Windows.Forms.CheckBox bWithMac;
        private System.Windows.Forms.CheckBox bWithWin32;
        private System.Windows.Forms.CheckBox bWithWin64;
        private System.Windows.Forms.CheckBox bSignExecutables;
        private System.Windows.Forms.CheckBox bWithDDC;
        private System.Windows.Forms.Button BuildRocketUE;
        private System.Windows.Forms.Button AutomationToolBrowse;
        private System.Windows.Forms.CheckBox bCleanBuild;
        private System.Windows.Forms.MainMenu mainMenu1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox LogWindow;
        private System.Windows.Forms.MenuItem GetSourceCodeMenu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox GameConfigurations1;
        private System.Windows.Forms.CheckBox bWithFullDebugInfo;
    }
}

