using System.Drawing;

namespace HearThis.UI
{
    partial class Shell
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shell));
			this.l10NSharpExtender1 = new L10NSharp.UI.L10NSharpExtender(this.components);
			this.toolStripButtonSave = new System.Windows.Forms.ToolStripButton();
			this.toolStripButtonChooseProject = new System.Windows.Forms.ToolStripButton();
			this._uiLanguageMenu = new System.Windows.Forms.ToolStripDropDownButton();
			this._btnMode = new System.Windows.Forms.ToolStripDropDownButton();
			this._toolStrip = new System.Windows.Forms.ToolStrip();
			this._moreMenu = new System.Windows.Forms.ToolStripDropDownButton();
			this._settingsItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this._syncWithAndroidItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this._exportSoundFilesItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this._mergeHearthisPackItem = new System.Windows.Forms.ToolStripMenuItem();
			this._saveHearthisPackItem = new System.Windows.Forms.ToolStripMenuItem();
			this._limitToCurrentActorItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this._aboutHearThisItem = new System.Windows.Forms.ToolStripMenuItem();
			this._actorCharacterButton = new System.Windows.Forms.Button();
			this._actorLabel = new System.Windows.Forms.Label();
			this._characterLabel = new System.Windows.Forms.Label();
			this._recordingToolControl1 = new HearThis.UI.RecordingToolControl();
			this._settingsProtectionHelper = new SIL.Windows.Forms.SettingProtection.SettingsProtectionHelper(this.components);
			this._multiVoicePanel = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.l10NSharpExtender1)).BeginInit();
			this._toolStrip.SuspendLayout();
			this._multiVoicePanel.SuspendLayout();
			this.SuspendLayout();
			// 
			// l10NSharpExtender1
			// 
			this.l10NSharpExtender1.LocalizationManagerId = "HearThis";
			this.l10NSharpExtender1.PrefixForNewItems = "Shell";
			// 
			// toolStripButtonSave
			// 
			this.toolStripButtonSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonSave.Image = global::HearThis.Properties.Resources.save;
			this.toolStripButtonSave.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.l10NSharpExtender1.SetLocalizableToolTip(this.toolStripButtonSave, null);
			this.l10NSharpExtender1.SetLocalizationComment(this.toolStripButtonSave, null);
			this.l10NSharpExtender1.SetLocalizingId(this.toolStripButtonSave, "RecordingControl.Save");
			this.toolStripButtonSave.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
			this.toolStripButtonSave.Name = "toolStripButtonSave";
			this.toolStripButtonSave.Size = new System.Drawing.Size(23, 20);
			this.toolStripButtonSave.Text = "Save";
			this.toolStripButtonSave.Click += new System.EventHandler(this.OnSaveClick);
			// 
			// toolStripButtonChooseProject
			// 
			this.toolStripButtonChooseProject.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripButtonChooseProject.Image = global::HearThis.Properties.Resources.folder;
			this.toolStripButtonChooseProject.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.l10NSharpExtender1.SetLocalizableToolTip(this.toolStripButtonChooseProject, null);
			this.l10NSharpExtender1.SetLocalizationComment(this.toolStripButtonChooseProject, null);
			this.l10NSharpExtender1.SetLocalizingId(this.toolStripButtonChooseProject, "RecordingControl.ChooseProject");
			this.toolStripButtonChooseProject.Margin = new System.Windows.Forms.Padding(0, 1, 10, 2);
			this.toolStripButtonChooseProject.Name = "toolStripButtonChooseProject";
			this.toolStripButtonChooseProject.Size = new System.Drawing.Size(23, 20);
			this.toolStripButtonChooseProject.Text = "Choose Project";
			this.toolStripButtonChooseProject.Click += new System.EventHandler(this.OnChooseProject);
			// 
			// _uiLanguageMenu
			// 
			this._uiLanguageMenu.ForeColor = System.Drawing.Color.DarkGray;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._uiLanguageMenu, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._uiLanguageMenu, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this._uiLanguageMenu, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this._uiLanguageMenu, "RecordingControl._uiLanguageMenu");
			this._uiLanguageMenu.Name = "_uiLanguageMenu";
			this._uiLanguageMenu.Size = new System.Drawing.Size(58, 20);
			this._uiLanguageMenu.Text = "English";
			this._uiLanguageMenu.ToolTipText = "User-interface Language";
			// 
			// _btnMode
			// 
			this._btnMode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this._btnMode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this._btnMode.ForeColor = System.Drawing.SystemColors.ControlDark;
			this._btnMode.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._btnMode, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._btnMode, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this._btnMode, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this._btnMode, "Shell.Shell._btnMode");
			this._btnMode.Name = "_btnMode";
			this._btnMode.Size = new System.Drawing.Size(97, 20);
			this._btnMode.Text = "Administrative";
			this._btnMode.ToolTipText = "Mode";
			this._btnMode.DropDownItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.ModeDropDownItemClicked);
			// 
			// _toolStrip
			// 
			this._toolStrip.AutoSize = false;
			this._toolStrip.BackColor = System.Drawing.Color.Transparent;
			this._toolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButtonSave,
            this.toolStripButtonChooseProject,
            this._uiLanguageMenu,
            this._btnMode,
            this._moreMenu});
			this.l10NSharpExtender1.SetLocalizableToolTip(this._toolStrip, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._toolStrip, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this._toolStrip, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this._toolStrip, "RecordingControl.ToolStrip");
			this._toolStrip.Location = new System.Drawing.Point(0, 0);
			this._toolStrip.Name = "_toolStrip";
			this._toolStrip.Padding = new System.Windows.Forms.Padding(15, 10, 20, 0);
			this._toolStrip.Size = new System.Drawing.Size(719, 33);
			this._toolStrip.TabIndex = 35;
			this._toolStrip.Text = "toolStrip1";
			// 
			// _moreMenu
			// 
			this._moreMenu.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this._moreMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
			this._moreMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._settingsItem,
            this.toolStripMenuItem1,
            this._syncWithAndroidItem,
            this.toolStripMenuItem2,
            this._exportSoundFilesItem,
            this.toolStripMenuItem3,
            this._mergeHearthisPackItem,
            this._saveHearthisPackItem,
            this._limitToCurrentActorItem,
            this.toolStripMenuItem4,
            this._aboutHearThisItem});
			this._moreMenu.ForeColor = System.Drawing.Color.DarkGray;
			this._moreMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._moreMenu, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._moreMenu, null);
			this.l10NSharpExtender1.SetLocalizingId(this._moreMenu, "Shell.toolStripDropDownButton1");
			this._moreMenu.Name = "_moreMenu";
			this._moreMenu.Size = new System.Drawing.Size(48, 20);
			this._moreMenu.Text = "More";
			// 
			// _settingsItem
			// 
			this.l10NSharpExtender1.SetLocalizableToolTip(this._settingsItem, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._settingsItem, null);
			this.l10NSharpExtender1.SetLocalizingId(this._settingsItem, "Shell.settingsToolStripMenuItem");
			this._settingsItem.Name = "_settingsItem";
			this._settingsItem.Size = new System.Drawing.Size(206, 22);
			this._settingsItem.Text = "Settings";
			this._settingsItem.Click += new System.EventHandler(this.OnSettingsButtonClicked);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(203, 6);
			// 
			// _syncWithAndroidItem
			// 
			this.l10NSharpExtender1.SetLocalizableToolTip(this._syncWithAndroidItem, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._syncWithAndroidItem, null);
			this.l10NSharpExtender1.SetLocalizingId(this._syncWithAndroidItem, "Shell.syncWithAndroidToolStripMenuItem");
			this._syncWithAndroidItem.Name = "_syncWithAndroidItem";
			this._syncWithAndroidItem.Size = new System.Drawing.Size(206, 22);
			this._syncWithAndroidItem.Text = "Sync with Android";
			this._syncWithAndroidItem.Click += new System.EventHandler(this._syncWithAndroidItem_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(203, 6);
			// 
			// _exportSoundFilesItem
			// 
			this.l10NSharpExtender1.SetLocalizableToolTip(this._exportSoundFilesItem, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._exportSoundFilesItem, null);
			this.l10NSharpExtender1.SetLocalizingId(this._exportSoundFilesItem, "Shell.exportSoundFilesToolStripMenuItem");
			this._exportSoundFilesItem.Name = "_exportSoundFilesItem";
			this._exportSoundFilesItem.Size = new System.Drawing.Size(206, 22);
			this._exportSoundFilesItem.Text = "Export Sound Files...";
			this._exportSoundFilesItem.Click += new System.EventHandler(this.OnPublishClick);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(203, 6);
			// 
			// _mergeHearthisPackItem
			// 
			this.l10NSharpExtender1.SetLocalizableToolTip(this._mergeHearthisPackItem, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._mergeHearthisPackItem, null);
			this.l10NSharpExtender1.SetLocalizingId(this._mergeHearthisPackItem, "Shell.openHearthisPackToolStripMenuItem");
			this._mergeHearthisPackItem.Name = "_mergeHearthisPackItem";
			this._mergeHearthisPackItem.Size = new System.Drawing.Size(206, 22);
			this._mergeHearthisPackItem.Text = "Merge Hearthis pack...";
			// 
			// _saveHearthisPackItem
			// 
			this.l10NSharpExtender1.SetLocalizableToolTip(this._saveHearthisPackItem, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._saveHearthisPackItem, null);
			this.l10NSharpExtender1.SetLocalizingId(this._saveHearthisPackItem, "Shell.saveHearthisPackToolStripMenuItem");
			this._saveHearthisPackItem.Name = "_saveHearthisPackItem";
			this._saveHearthisPackItem.Size = new System.Drawing.Size(206, 22);
			this._saveHearthisPackItem.Text = "Save Hearthis pack...";
			// 
			// _limitToCurrentActorItem
			// 
			this._limitToCurrentActorItem.CheckOnClick = true;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._limitToCurrentActorItem, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._limitToCurrentActorItem, null);
			this.l10NSharpExtender1.SetLocalizingId(this._limitToCurrentActorItem, "Shell.limitToCurrentActor1ToolStripMenuItem");
			this._limitToCurrentActorItem.Name = "_limitToCurrentActorItem";
			this._limitToCurrentActorItem.Size = new System.Drawing.Size(206, 22);
			this._limitToCurrentActorItem.Text = "Limit to current actor, {1}";
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(203, 6);
			// 
			// _aboutHearThisItem
			// 
			this.l10NSharpExtender1.SetLocalizableToolTip(this._aboutHearThisItem, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._aboutHearThisItem, null);
			this.l10NSharpExtender1.SetLocalizingId(this._aboutHearThisItem, "Shell.aboutHearThisToolStripMenuItem");
			this._aboutHearThisItem.Name = "_aboutHearThisItem";
			this._aboutHearThisItem.Size = new System.Drawing.Size(206, 22);
			this._aboutHearThisItem.Text = "About HearThis...";
			this._aboutHearThisItem.Click += new System.EventHandler(this.OnAboutClick);
			// 
			// _actorCharacterButton
			// 
			this._actorCharacterButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this._actorCharacterButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this._actorCharacterButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this._actorCharacterButton.Image = global::HearThis.Properties.Resources.speakIntoMike46x32;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._actorCharacterButton, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._actorCharacterButton, null);
			this.l10NSharpExtender1.SetLocalizingId(this._actorCharacterButton, "Shell.button1");
			this._actorCharacterButton.Location = new System.Drawing.Point(13, 4);
			this._actorCharacterButton.Name = "_actorCharacterButton";
			this._actorCharacterButton.Size = new System.Drawing.Size(65, 42);
			this._actorCharacterButton.TabIndex = 37;
			this._actorCharacterButton.UseVisualStyleBackColor = false;
			this._actorCharacterButton.Click += new System.EventHandler(this._actorCharacterButton_Click);
			// 
			// _actorLabel
			// 
			this._actorLabel.AutoSize = true;
			this._actorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(202)))), ((int)(((byte)(1)))));
			this.l10NSharpExtender1.SetLocalizableToolTip(this._actorLabel, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._actorLabel, null);
			this.l10NSharpExtender1.SetLocalizingId(this._actorLabel, "Shell.label1");
			this._actorLabel.Location = new System.Drawing.Point(84, 11);
			this._actorLabel.Name = "_actorLabel";
			this._actorLabel.Size = new System.Drawing.Size(37, 13);
			this._actorLabel.TabIndex = 38;
			this._actorLabel.Text = "?????";
			this._actorLabel.Click += new System.EventHandler(this._actorLabel_Click);
			// 
			// _characterLabel
			// 
			this._characterLabel.AutoSize = true;
			this._characterLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(202)))), ((int)(((byte)(1)))));
			this.l10NSharpExtender1.SetLocalizableToolTip(this._characterLabel, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._characterLabel, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this._characterLabel, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this._characterLabel, "Shell.label1");
			this._characterLabel.Location = new System.Drawing.Point(84, 31);
			this._characterLabel.Name = "_characterLabel";
			this._characterLabel.Size = new System.Drawing.Size(53, 13);
			this._characterLabel.TabIndex = 39;
			this._characterLabel.Text = "Character";
			this._characterLabel.Click += new System.EventHandler(this._characterLabel_Click);
			// 
			// _recordingToolControl1
			// 
			this._recordingToolControl1.BackColor = this._recordingToolControl1.BackColor;
			this._recordingToolControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this._recordingToolControl1.HidingSkippedBlocks = false;
			this.l10NSharpExtender1.SetLocalizableToolTip(this._recordingToolControl1, null);
			this.l10NSharpExtender1.SetLocalizationComment(this._recordingToolControl1, null);
			this.l10NSharpExtender1.SetLocalizingId(this._recordingToolControl1, "Shell.RecordingToolControl");
			this._recordingToolControl1.Location = new System.Drawing.Point(0, 0);
			this._recordingToolControl1.Name = "_recordingToolControl1";
			this._recordingToolControl1.Size = new System.Drawing.Size(719, 529);
			this._recordingToolControl1.TabIndex = 1;
			// 
			// _multiVoicePanel
			// 
			this._multiVoicePanel.Controls.Add(this._characterLabel);
			this._multiVoicePanel.Controls.Add(this._actorLabel);
			this._multiVoicePanel.Controls.Add(this._actorCharacterButton);
			this._multiVoicePanel.Dock = System.Windows.Forms.DockStyle.Top;
			this._multiVoicePanel.Location = new System.Drawing.Point(0, 33);
			this._multiVoicePanel.Name = "_multiVoicePanel";
			this._multiVoicePanel.Size = new System.Drawing.Size(719, 49);
			this._multiVoicePanel.TabIndex = 37;
			this._multiVoicePanel.Visible = false;
			// 
			// Shell
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
			this.ClientSize = new System.Drawing.Size(719, 529);
			this.Controls.Add(this._multiVoicePanel);
			this.Controls.Add(this._toolStrip);
			this.Controls.Add(this._recordingToolControl1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.l10NSharpExtender1.SetLocalizableToolTip(this, null);
			this.l10NSharpExtender1.SetLocalizationComment(this, null);
			this.l10NSharpExtender1.SetLocalizationPriority(this, L10NSharp.LocalizationPriority.NotLocalizable);
			this.l10NSharpExtender1.SetLocalizingId(this, "Shell.HearThis");
			this.MinimumSize = new System.Drawing.Size(719, 534);
			this.Name = "Shell";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "HearThis";
			this.ResizeEnd += new System.EventHandler(this.Shell_ResizeEnd);
			((System.ComponentModel.ISupportInitialize)(this.l10NSharpExtender1)).EndInit();
			this._toolStrip.ResumeLayout(false);
			this._toolStrip.PerformLayout();
			this._multiVoicePanel.ResumeLayout(false);
			this._multiVoicePanel.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

		private RecordingToolControl _recordingToolControl1;
		private L10NSharp.UI.L10NSharpExtender l10NSharpExtender1;
		private SIL.Windows.Forms.SettingProtection.SettingsProtectionHelper _settingsProtectionHelper;
		private System.Windows.Forms.ToolStripButton toolStripButtonSave;
		private System.Windows.Forms.ToolStripButton toolStripButtonChooseProject;
		private System.Windows.Forms.ToolStripDropDownButton _uiLanguageMenu;
		private System.Windows.Forms.ToolStripDropDownButton _btnMode;
		private System.Windows.Forms.ToolStrip _toolStrip;
		private System.Windows.Forms.Panel _multiVoicePanel;
		private System.Windows.Forms.Label _actorLabel;
		private System.Windows.Forms.Button _actorCharacterButton;
		private System.Windows.Forms.Label _characterLabel;
		private System.Windows.Forms.ToolStripDropDownButton _moreMenu;
		private System.Windows.Forms.ToolStripMenuItem _settingsItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem _syncWithAndroidItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
		private System.Windows.Forms.ToolStripMenuItem _exportSoundFilesItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem _mergeHearthisPackItem;
		private System.Windows.Forms.ToolStripMenuItem _saveHearthisPackItem;
		private System.Windows.Forms.ToolStripMenuItem _limitToCurrentActorItem;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem _aboutHearThisItem;
	}
}

