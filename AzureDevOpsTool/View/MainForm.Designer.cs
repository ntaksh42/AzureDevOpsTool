﻿
namespace AzureDevOpsTool.View
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            _richTextBoxResult = new RichTextBox();
            _comboBoxServieType = new ComboBox();
            _btnSetting = new Button();
            _panel = new Panel();
            _panel.SuspendLayout();
            SuspendLayout();
            // 
            // _richTextBoxResult
            // 
            _richTextBoxResult.Dock = DockStyle.Fill;
            _richTextBoxResult.Location = new Point(0, 0);
            _richTextBoxResult.Name = "_richTextBoxResult";
            _richTextBoxResult.Size = new Size(403, 358);
            _richTextBoxResult.TabIndex = 1;
            _richTextBoxResult.Text = "";
            // 
            // _comboBoxServieType
            // 
            _comboBoxServieType.DropDownStyle = ComboBoxStyle.DropDownList;
            _comboBoxServieType.FormattingEnabled = true;
            _comboBoxServieType.Location = new Point(12, 12);
            _comboBoxServieType.Name = "_comboBoxServieType";
            _comboBoxServieType.Size = new Size(282, 23);
            _comboBoxServieType.TabIndex = 2;
            _comboBoxServieType.SelectedIndexChanged += _comboBoxServieType_SelectedIndexChanged;
            // 
            // _btnSetting
            // 
            _btnSetting.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            _btnSetting.Location = new Point(322, 12);
            _btnSetting.Name = "_btnSetting";
            _btnSetting.Size = new Size(93, 23);
            _btnSetting.TabIndex = 3;
            _btnSetting.Text = "User Setting";
            _btnSetting.UseVisualStyleBackColor = true;
            _btnSetting.Click += _btnSetting_Click;
            // 
            // _panel
            // 
            _panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            _panel.Controls.Add(_richTextBoxResult);
            _panel.Location = new Point(12, 41);
            _panel.Name = "_panel";
            _panel.Size = new Size(403, 358);
            _panel.TabIndex = 4;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(427, 411);
            Controls.Add(_panel);
            Controls.Add(_btnSetting);
            Controls.Add(_comboBoxServieType);
            Name = "MainForm";
            Text = "AzureDevOpsTool";
            _panel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private RichTextBox _richTextBoxResult;
        private ComboBox _comboBoxServieType;
        private Button _btnSetting;
        private Panel _panel;
    }
}
