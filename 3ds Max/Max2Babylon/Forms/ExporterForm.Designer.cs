﻿namespace Max2Babylon
{
    partial class ExporterForm
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
            this.butExport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtModelName = new System.Windows.Forms.TextBox();
            this.butModelBrowse = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.treeView = new System.Windows.Forms.TreeView();
            this.butCancel = new System.Windows.Forms.Button();
            this.chkManifest = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.chkWriteTextures = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEnvironmentName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.chkFullPBR = new System.Windows.Forms.CheckBox();
            this.btnEnvBrowse = new System.Windows.Forms.Button();
            this.chkNoAutoLight = new System.Windows.Forms.CheckBox();
            this.textureLabel = new System.Windows.Forms.Label();
            this.txtTextureName = new System.Windows.Forms.TextBox();
            this.btnTxtBrowse = new System.Windows.Forms.Button();
            this.chkExportMaterials = new System.Windows.Forms.CheckBox();
            this.chkKHRMaterialsUnlit = new System.Windows.Forms.CheckBox();
            this.chkKHRTextureTransform = new System.Windows.Forms.CheckBox();
            this.chkKHRLightsPunctual = new System.Windows.Forms.CheckBox();
            this.chkOverwriteTextures = new System.Windows.Forms.CheckBox();
            this.chkDracoCompression = new System.Windows.Forms.CheckBox();
            this.chkMergeAOwithMR = new System.Windows.Forms.CheckBox();
            this.txtQuality = new System.Windows.Forms.TextBox();
            this.labelQuality = new System.Windows.Forms.Label();
            this.chkExportTangents = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtScaleFactor = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboOutputFormat = new System.Windows.Forms.ComboBox();
            this.chkOnlySelected = new System.Windows.Forms.CheckBox();
            this.chkAutoSave = new System.Windows.Forms.CheckBox();
            this.chkHidden = new System.Windows.Forms.CheckBox();
            this.butExportAndRun = new System.Windows.Forms.Button();
            this.butClose = new System.Windows.Forms.Button();
            this.toolTipDracoCompression = new System.Windows.Forms.ToolTip(this.components);
            this.butMultiExport = new System.Windows.Forms.Button();
            this.saveOptionBtn = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.envFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // butExport
            // 
            this.butExport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butExport.Enabled = false;
            this.butExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExport.Location = new System.Drawing.Point(322, 494);
            this.butExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butExport.Name = "butExport";
            this.butExport.Size = new System.Drawing.Size(296, 42);
            this.butExport.TabIndex = 100;
            this.butExport.Text = "Export";
            this.butExport.UseVisualStyleBackColor = true;
            this.butExport.Click += new System.EventHandler(this.butExport_Click);
            this.butExport.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Model name:";
            // 
            // txtModelName
            // 
            this.txtModelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtModelName.Location = new System.Drawing.Point(129, 22);
            this.txtModelName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtModelName.Name = "txtModelName";
            this.txtModelName.Size = new System.Drawing.Size(484, 26);
            this.txtModelName.TabIndex = 2;
            this.txtModelName.TextChanged += new System.EventHandler(this.txtFilename_TextChanged);
            this.txtModelName.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            // 
            // butModelBrowse
            // 
            this.butModelBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butModelBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butModelBrowse.Location = new System.Drawing.Point(624, 18);
            this.butModelBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butModelBrowse.Name = "butModelBrowse";
            this.butModelBrowse.Size = new System.Drawing.Size(42, 35);
            this.butModelBrowse.TabIndex = 3;
            this.butModelBrowse.Text = "...";
            this.butModelBrowse.UseVisualStyleBackColor = true;
            this.butModelBrowse.Click += new System.EventHandler(this.butModelBrowse_Click);
            this.butModelBrowse.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "babylon";
            this.saveFileDialog.Filter = "Babylon files|*.babylon";
            this.saveFileDialog.RestoreDirectory = true;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(18, 1041);
            this.progressBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(957, 35);
            this.progressBar.TabIndex = 104;
            // 
            // treeView
            // 
            this.treeView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.treeView.Location = new System.Drawing.Point(18, 546);
            this.treeView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView.Name = "treeView";
            this.treeView.Size = new System.Drawing.Size(1213, 450);
            this.treeView.TabIndex = 103;
            this.treeView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            // 
            // butCancel
            // 
            this.butCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butCancel.Enabled = false;
            this.butCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancel.Location = new System.Drawing.Point(984, 1041);
            this.butCancel.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butCancel.Name = "butCancel";
            this.butCancel.Size = new System.Drawing.Size(120, 35);
            this.butCancel.TabIndex = 105;
            this.butCancel.Text = "Cancel";
            this.butCancel.UseVisualStyleBackColor = true;
            this.butCancel.Click += new System.EventHandler(this.butCancel_Click);
            this.butCancel.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            // 
            // chkManifest
            // 
            this.chkManifest.AutoSize = true;
            this.chkManifest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkManifest.Location = new System.Drawing.Point(480, 263);
            this.chkManifest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkManifest.Name = "chkManifest";
            this.chkManifest.Size = new System.Drawing.Size(167, 24);
            this.chkManifest.TabIndex = 14;
            this.chkManifest.Text = "Generate .manifest";
            this.chkManifest.UseVisualStyleBackColor = true;
            this.chkManifest.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Options:";
            // 
            // chkWriteTextures
            // 
            this.chkWriteTextures.AutoSize = true;
            this.chkWriteTextures.Checked = true;
            this.chkWriteTextures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkWriteTextures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkWriteTextures.Location = new System.Drawing.Point(27, 192);
            this.chkWriteTextures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkWriteTextures.Name = "chkWriteTextures";
            this.chkWriteTextures.Size = new System.Drawing.Size(132, 24);
            this.chkWriteTextures.TabIndex = 11;
            this.chkWriteTextures.Text = "Write Textures";
            this.chkWriteTextures.UseVisualStyleBackColor = true;
            this.chkWriteTextures.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtEnvironmentName);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkFullPBR);
            this.groupBox1.Controls.Add(this.btnEnvBrowse);
            this.groupBox1.Controls.Add(this.chkNoAutoLight);
            this.groupBox1.Controls.Add(this.textureLabel);
            this.groupBox1.Controls.Add(this.txtTextureName);
            this.groupBox1.Controls.Add(this.btnTxtBrowse);
            this.groupBox1.Controls.Add(this.chkExportMaterials);
            this.groupBox1.Controls.Add(this.chkKHRMaterialsUnlit);
            this.groupBox1.Controls.Add(this.chkKHRTextureTransform);
            this.groupBox1.Controls.Add(this.chkKHRLightsPunctual);
            this.groupBox1.Controls.Add(this.chkOverwriteTextures);
            this.groupBox1.Controls.Add(this.chkDracoCompression);
            this.groupBox1.Controls.Add(this.chkMergeAOwithMR);
            this.groupBox1.Controls.Add(this.txtQuality);
            this.groupBox1.Controls.Add(this.labelQuality);
            this.groupBox1.Controls.Add(this.chkExportTangents);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtScaleFactor);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.comboOutputFormat);
            this.groupBox1.Controls.Add(this.chkOnlySelected);
            this.groupBox1.Controls.Add(this.chkAutoSave);
            this.groupBox1.Controls.Add(this.chkHidden);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.chkWriteTextures);
            this.groupBox1.Controls.Add(this.txtModelName);
            this.groupBox1.Controls.Add(this.chkManifest);
            this.groupBox1.Controls.Add(this.butModelBrowse);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(18, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(675, 475);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 388);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Environment";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 331);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(166, 20);
            this.label7.TabIndex = 33;
            this.label7.Text = "Babylon PBR Options:";
            // 
            // txtEnvironmentName
            // 
            this.txtEnvironmentName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEnvironmentName.Location = new System.Drawing.Point(129, 385);
            this.txtEnvironmentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEnvironmentName.Name = "txtEnvironmentName";
            this.txtEnvironmentName.Size = new System.Drawing.Size(484, 26);
            this.txtEnvironmentName.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 416);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "GLTF Options:";
            // 
            // chkFullPBR
            // 
            this.chkFullPBR.AutoSize = true;
            this.chkFullPBR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkFullPBR.Location = new System.Drawing.Point(258, 356);
            this.chkFullPBR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkFullPBR.Name = "chkFullPBR";
            this.chkFullPBR.Size = new System.Drawing.Size(125, 24);
            this.chkFullPBR.TabIndex = 28;
            this.chkFullPBR.Text = "Use Full PBR";
            this.chkFullPBR.UseVisualStyleBackColor = true;
            // 
            // btnEnvBrowse
            // 
            this.btnEnvBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEnvBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnvBrowse.Location = new System.Drawing.Point(624, 381);
            this.btnEnvBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEnvBrowse.Name = "btnEnvBrowse";
            this.btnEnvBrowse.Size = new System.Drawing.Size(42, 35);
            this.btnEnvBrowse.TabIndex = 31;
            this.btnEnvBrowse.Text = "...";
            this.btnEnvBrowse.UseVisualStyleBackColor = true;
            this.btnEnvBrowse.Click += new System.EventHandler(this.btnEnvBrowse_Click);
            // 
            // chkNoAutoLight
            // 
            this.chkNoAutoLight.AutoSize = true;
            this.chkNoAutoLight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkNoAutoLight.Location = new System.Drawing.Point(27, 356);
            this.chkNoAutoLight.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkNoAutoLight.Name = "chkNoAutoLight";
            this.chkNoAutoLight.Size = new System.Drawing.Size(165, 24);
            this.chkNoAutoLight.TabIndex = 27;
            this.chkNoAutoLight.Text = "No Automatic Light";
            this.chkNoAutoLight.UseVisualStyleBackColor = true;
            // 
            // textureLabel
            // 
            this.textureLabel.AutoSize = true;
            this.textureLabel.Location = new System.Drawing.Point(9, 66);
            this.textureLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.textureLabel.Name = "textureLabel";
            this.textureLabel.Size = new System.Drawing.Size(110, 20);
            this.textureLabel.TabIndex = 24;
            this.textureLabel.Text = "Texture folder:";
            // 
            // txtTextureName
            // 
            this.txtTextureName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTextureName.Location = new System.Drawing.Point(129, 62);
            this.txtTextureName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTextureName.Name = "txtTextureName";
            this.txtTextureName.Size = new System.Drawing.Size(484, 26);
            this.txtTextureName.TabIndex = 25;
            // 
            // btnTxtBrowse
            // 
            this.btnTxtBrowse.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTxtBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTxtBrowse.Location = new System.Drawing.Point(624, 58);
            this.btnTxtBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnTxtBrowse.Name = "btnTxtBrowse";
            this.btnTxtBrowse.Size = new System.Drawing.Size(42, 35);
            this.btnTxtBrowse.TabIndex = 26;
            this.btnTxtBrowse.Text = "...";
            this.btnTxtBrowse.UseVisualStyleBackColor = true;
            this.btnTxtBrowse.Click += new System.EventHandler(this.btnTextureBrowse_Click);
            // 
            // chkExportMaterials
            // 
            this.chkExportMaterials.AutoSize = true;
            this.chkExportMaterials.Checked = true;
            this.chkExportMaterials.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExportMaterials.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkExportMaterials.Location = new System.Drawing.Point(27, 300);
            this.chkExportMaterials.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkExportMaterials.Name = "chkExportMaterials";
            this.chkExportMaterials.Size = new System.Drawing.Size(144, 24);
            this.chkExportMaterials.TabIndex = 23;
            this.chkExportMaterials.Text = "Export Materials";
            this.chkExportMaterials.UseVisualStyleBackColor = true;
            // 
            // chkKHRMaterialsUnlit
            // 
            this.chkKHRMaterialsUnlit.AutoSize = true;
            this.chkKHRMaterialsUnlit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkKHRMaterialsUnlit.Location = new System.Drawing.Point(477, 441);
            this.chkKHRMaterialsUnlit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkKHRMaterialsUnlit.Name = "chkKHRMaterialsUnlit";
            this.chkKHRMaterialsUnlit.Size = new System.Drawing.Size(175, 24);
            this.chkKHRMaterialsUnlit.TabIndex = 22;
            this.chkKHRMaterialsUnlit.Text = "KHR_materials_unlit";
            this.chkKHRMaterialsUnlit.UseVisualStyleBackColor = true;
            // 
            // chkKHRTextureTransform
            // 
            this.chkKHRTextureTransform.AutoSize = true;
            this.chkKHRTextureTransform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkKHRTextureTransform.Location = new System.Drawing.Point(250, 441);
            this.chkKHRTextureTransform.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkKHRTextureTransform.Name = "chkKHRTextureTransform";
            this.chkKHRTextureTransform.Size = new System.Drawing.Size(199, 24);
            this.chkKHRTextureTransform.TabIndex = 21;
            this.chkKHRTextureTransform.Text = "KHR_texture_transform";
            this.chkKHRTextureTransform.UseVisualStyleBackColor = true;
            // 
            // chkKHRLightsPunctual
            // 
            this.chkKHRLightsPunctual.AutoSize = true;
            this.chkKHRLightsPunctual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkKHRLightsPunctual.Location = new System.Drawing.Point(28, 441);
            this.chkKHRLightsPunctual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkKHRLightsPunctual.Name = "chkKHRLightsPunctual";
            this.chkKHRLightsPunctual.Size = new System.Drawing.Size(180, 24);
            this.chkKHRLightsPunctual.TabIndex = 20;
            this.chkKHRLightsPunctual.Text = "KHR_lights_punctual";
            this.chkKHRLightsPunctual.UseVisualStyleBackColor = true;
            // 
            // chkOverwriteTextures
            // 
            this.chkOverwriteTextures.AutoSize = true;
            this.chkOverwriteTextures.Checked = true;
            this.chkOverwriteTextures.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkOverwriteTextures.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkOverwriteTextures.Location = new System.Drawing.Point(27, 229);
            this.chkOverwriteTextures.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkOverwriteTextures.Name = "chkOverwriteTextures";
            this.chkOverwriteTextures.Size = new System.Drawing.Size(161, 24);
            this.chkOverwriteTextures.TabIndex = 19;
            this.chkOverwriteTextures.Text = "Overwrite Textures";
            this.chkOverwriteTextures.UseVisualStyleBackColor = true;
            // 
            // chkDracoCompression
            // 
            this.chkDracoCompression.AutoSize = true;
            this.chkDracoCompression.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkDracoCompression.Location = new System.Drawing.Point(249, 263);
            this.chkDracoCompression.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkDracoCompression.Name = "chkDracoCompression";
            this.chkDracoCompression.Size = new System.Drawing.Size(200, 24);
            this.chkDracoCompression.TabIndex = 18;
            this.chkDracoCompression.Text = "Use Draco compression";
            this.chkDracoCompression.UseVisualStyleBackColor = true;
            this.chkDracoCompression.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            // 
            // chkMergeAOwithMR
            // 
            this.chkMergeAOwithMR.AutoSize = true;
            this.chkMergeAOwithMR.Checked = true;
            this.chkMergeAOwithMR.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMergeAOwithMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMergeAOwithMR.Location = new System.Drawing.Point(27, 263);
            this.chkMergeAOwithMR.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkMergeAOwithMR.Name = "chkMergeAOwithMR";
            this.chkMergeAOwithMR.Size = new System.Drawing.Size(137, 24);
            this.chkMergeAOwithMR.TabIndex = 17;
            this.chkMergeAOwithMR.Text = "Merge AO map";
            this.chkMergeAOwithMR.UseVisualStyleBackColor = true;
            this.chkMergeAOwithMR.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            // 
            // txtQuality
            // 
            this.txtQuality.Location = new System.Drawing.Point(604, 141);
            this.txtQuality.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtQuality.Name = "txtQuality";
            this.txtQuality.Size = new System.Drawing.Size(62, 26);
            this.txtQuality.TabIndex = 9;
            this.txtQuality.Text = "100";
            this.txtQuality.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtQuality.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            // 
            // labelQuality
            // 
            this.labelQuality.AutoSize = true;
            this.labelQuality.Location = new System.Drawing.Point(478, 145);
            this.labelQuality.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelQuality.Name = "labelQuality";
            this.labelQuality.Size = new System.Drawing.Size(115, 20);
            this.labelQuality.TabIndex = 8;
            this.labelQuality.Text = "Texture quality:";
            // 
            // chkExportTangents
            // 
            this.chkExportTangents.AutoSize = true;
            this.chkExportTangents.Checked = true;
            this.chkExportTangents.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkExportTangents.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkExportTangents.Location = new System.Drawing.Point(480, 228);
            this.chkExportTangents.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkExportTangents.Name = "chkExportTangents";
            this.chkExportTangents.Size = new System.Drawing.Size(143, 24);
            this.chkExportTangents.TabIndex = 16;
            this.chkExportTangents.Text = "Export tangents";
            this.chkExportTangents.UseVisualStyleBackColor = true;
            this.chkExportTangents.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(496, 108);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Scale factor:";
            // 
            // txtScaleFactor
            // 
            this.txtScaleFactor.Location = new System.Drawing.Point(605, 104);
            this.txtScaleFactor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtScaleFactor.Name = "txtScaleFactor";
            this.txtScaleFactor.Size = new System.Drawing.Size(61, 26);
            this.txtScaleFactor.TabIndex = 7;
            this.txtScaleFactor.Text = "1";
            this.txtScaleFactor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtScaleFactor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Output format:";
            // 
            // comboOutputFormat
            // 
            this.comboOutputFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboOutputFormat.Items.AddRange(new object[] {
            "babylon",
            "binary babylon",
            "gltf",
            "glb"});
            this.comboOutputFormat.Location = new System.Drawing.Point(129, 98);
            this.comboOutputFormat.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboOutputFormat.Name = "comboOutputFormat";
            this.comboOutputFormat.Size = new System.Drawing.Size(180, 28);
            this.comboOutputFormat.TabIndex = 5;
            this.comboOutputFormat.SelectedIndexChanged += new System.EventHandler(this.comboOutputFormat_SelectedIndexChanged);
            this.comboOutputFormat.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            // 
            // chkOnlySelected
            // 
            this.chkOnlySelected.AutoSize = true;
            this.chkOnlySelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkOnlySelected.Location = new System.Drawing.Point(480, 192);
            this.chkOnlySelected.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkOnlySelected.Name = "chkOnlySelected";
            this.chkOnlySelected.Size = new System.Drawing.Size(172, 24);
            this.chkOnlySelected.TabIndex = 13;
            this.chkOnlySelected.Text = "Export only selected";
            this.chkOnlySelected.UseVisualStyleBackColor = true;
            this.chkOnlySelected.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            // 
            // chkAutoSave
            // 
            this.chkAutoSave.AutoSize = true;
            this.chkAutoSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkAutoSave.Location = new System.Drawing.Point(249, 228);
            this.chkAutoSave.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkAutoSave.Name = "chkAutoSave";
            this.chkAutoSave.Size = new System.Drawing.Size(188, 24);
            this.chkAutoSave.TabIndex = 15;
            this.chkAutoSave.Text = "Auto save 3ds Max file";
            this.chkAutoSave.UseVisualStyleBackColor = true;
            this.chkAutoSave.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            // 
            // chkHidden
            // 
            this.chkHidden.AutoSize = true;
            this.chkHidden.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkHidden.Location = new System.Drawing.Point(249, 192);
            this.chkHidden.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkHidden.Name = "chkHidden";
            this.chkHidden.Size = new System.Drawing.Size(183, 24);
            this.chkHidden.TabIndex = 12;
            this.chkHidden.Text = "Export hidden objects";
            this.chkHidden.UseVisualStyleBackColor = true;
            this.chkHidden.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            // 
            // butExportAndRun
            // 
            this.butExportAndRun.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butExportAndRun.Enabled = false;
            this.butExportAndRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butExportAndRun.Location = new System.Drawing.Point(627, 494);
            this.butExportAndRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butExportAndRun.Name = "butExportAndRun";
            this.butExportAndRun.Size = new System.Drawing.Size(296, 42);
            this.butExportAndRun.TabIndex = 102;
            this.butExportAndRun.Text = "Export && Run";
            this.butExportAndRun.UseVisualStyleBackColor = true;
            this.butExportAndRun.Click += new System.EventHandler(this.butExportAndRun_Click);
            this.butExportAndRun.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            // 
            // butClose
            // 
            this.butClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butClose.Location = new System.Drawing.Point(1113, 1041);
            this.butClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butClose.Name = "butClose";
            this.butClose.Size = new System.Drawing.Size(120, 35);
            this.butClose.TabIndex = 106;
            this.butClose.Text = "Close";
            this.butClose.UseVisualStyleBackColor = true;
            this.butClose.Click += new System.EventHandler(this.butClose_Click);
            this.butClose.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            // 
            // toolTipDracoCompression
            // 
            this.toolTipDracoCompression.ShowAlways = true;
            // 
            // butMultiExport
            // 
            this.butMultiExport.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.butMultiExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butMultiExport.Location = new System.Drawing.Point(932, 494);
            this.butMultiExport.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.butMultiExport.Name = "butMultiExport";
            this.butMultiExport.Size = new System.Drawing.Size(299, 42);
            this.butMultiExport.TabIndex = 109;
            this.butMultiExport.Text = "Multi-File Export | Shift-click to edit";
            this.butMultiExport.UseVisualStyleBackColor = true;
            this.butMultiExport.Click += new System.EventHandler(this.butMultiExport_Click);
            // 
            // saveOptionBtn
            // 
            this.saveOptionBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.saveOptionBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveOptionBtn.Location = new System.Drawing.Point(18, 494);
            this.saveOptionBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saveOptionBtn.Name = "saveOptionBtn";
            this.saveOptionBtn.Size = new System.Drawing.Size(296, 42);
            this.saveOptionBtn.TabIndex = 110;
            this.saveOptionBtn.Text = "Save";
            this.saveOptionBtn.UseVisualStyleBackColor = true;
            this.saveOptionBtn.Click += new System.EventHandler(this.saveOptionBtn_Click);
            // 
            // envFileDialog
            // 
            this.envFileDialog.DefaultExt = "dds";
            this.envFileDialog.Filter = "dds files|*.dds";
            this.envFileDialog.Title = "Select Environment";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Max2Babylon.Properties.Resources.MaxExporter;
            this.pictureBox2.Location = new System.Drawing.Point(709, 17);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(522, 245);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // ExporterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 1010);
            this.Controls.Add(this.saveOptionBtn);
            this.Controls.Add(this.butMultiExport);
            this.Controls.Add(this.butExportAndRun);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.butClose);
            this.Controls.Add(this.butCancel);
            this.Controls.Add(this.treeView);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.butExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MinimumSize = new System.Drawing.Size(1261, 576);
            this.Name = "ExporterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Babylon.js - Export scene to babylon or glTF format";
            this.Activated += new System.EventHandler(this.ExporterForm_Activated);
            this.Deactivate += new System.EventHandler(this.ExporterForm_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExporterForm_FormClosed);
            this.Load += new System.EventHandler(this.ExporterForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ExporterForm_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butExport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtModelName;
        private System.Windows.Forms.Button butModelBrowse;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.TreeView treeView;
        private System.Windows.Forms.Button butCancel;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.CheckBox chkManifest;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chkHidden;
        private System.Windows.Forms.CheckBox chkAutoSave;
        private System.Windows.Forms.Button butExportAndRun;
        private System.Windows.Forms.CheckBox chkOnlySelected;
        private System.Windows.Forms.Button butClose;
        private System.Windows.Forms.ComboBox comboOutputFormat;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtScaleFactor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkExportTangents;
        private System.Windows.Forms.Label labelQuality;
        private System.Windows.Forms.TextBox txtQuality;
        private System.Windows.Forms.CheckBox chkMergeAOwithMR;
        private System.Windows.Forms.CheckBox chkDracoCompression;
        private System.Windows.Forms.ToolTip toolTipDracoCompression;
        private System.Windows.Forms.CheckBox chkOverwriteTextures;
        private System.Windows.Forms.Button butMultiExport;
        private System.Windows.Forms.CheckBox chkKHRLightsPunctual;
        private System.Windows.Forms.CheckBox chkKHRTextureTransform;
        private System.Windows.Forms.CheckBox chkKHRMaterialsUnlit;
        private System.Windows.Forms.CheckBox chkExportMaterials;
        private System.Windows.Forms.Button saveOptionBtn;
        private System.Windows.Forms.Label textureLabel;
        private System.Windows.Forms.TextBox txtTextureName;
        private System.Windows.Forms.Button btnTxtBrowse;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEnvironmentName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox chkFullPBR;
        private System.Windows.Forms.Button btnEnvBrowse;
        private System.Windows.Forms.CheckBox chkNoAutoLight;
        private System.Windows.Forms.CheckBox chkWriteTextures;
        private System.Windows.Forms.OpenFileDialog envFileDialog;
    }
}