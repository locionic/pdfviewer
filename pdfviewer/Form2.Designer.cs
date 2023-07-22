
namespace pdfviewer
{
    partial class Form2
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
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.button_load_cer_wstore = new DevExpress.XtraEditors.SimpleButton();
            this.hashAlgorithmComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.certificationLevelComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.teExpD = new DevExpress.XtraEditors.TextEdit();
            this.teFN = new DevExpress.XtraEditors.TextEdit();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.teEffE = new DevExpress.XtraEditors.TextEdit();
            this.button_sign_save = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.button_load_cer_choose_file = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hashAlgorithmComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationLevelComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teExpD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFN.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEffE.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.AutoSize = true;
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10.76F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 49.24F)});
            this.tablePanel1.Controls.Add(this.button_load_cer_wstore);
            this.tablePanel1.Controls.Add(this.hashAlgorithmComboBox);
            this.tablePanel1.Controls.Add(this.certificationLevelComboBox);
            this.tablePanel1.Controls.Add(this.labelControl7);
            this.tablePanel1.Controls.Add(this.labelControl6);
            this.tablePanel1.Controls.Add(this.teExpD);
            this.tablePanel1.Controls.Add(this.teFN);
            this.tablePanel1.Controls.Add(this.listBoxControl1);
            this.tablePanel1.Controls.Add(this.teEffE);
            this.tablePanel1.Controls.Add(this.button_sign_save);
            this.tablePanel1.Controls.Add(this.labelControl4);
            this.tablePanel1.Controls.Add(this.labelControl3);
            this.tablePanel1.Controls.Add(this.labelControl2);
            this.tablePanel1.Controls.Add(this.button_load_cer_choose_file);
            this.tablePanel1.Controls.Add(this.labelControl1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 90.5F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 53F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 67.5F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 54F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 41.5F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 43F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26.5F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 41.5F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 78F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(1373, 842);
            this.tablePanel1.TabIndex = 0;
            // 
            // button_load_cer_wstore
            // 
            this.tablePanel1.SetColumn(this.button_load_cer_wstore, 1);
            this.button_load_cer_wstore.Location = new System.Drawing.Point(249, 155);
            this.button_load_cer_wstore.Name = "button_load_cer_wstore";
            this.tablePanel1.SetRow(this.button_load_cer_wstore, 2);
            this.button_load_cer_wstore.Size = new System.Drawing.Size(1121, 46);
            this.button_load_cer_wstore.TabIndex = 16;
            this.button_load_cer_wstore.Text = "Load certificate by window store";
            this.button_load_cer_wstore.Click += new System.EventHandler(this.button_load_cer_wstore_Click);
            // 
            // hashAlgorithmComboBox
            // 
            this.tablePanel1.SetColumn(this.hashAlgorithmComboBox, 1);
            this.hashAlgorithmComboBox.Location = new System.Drawing.Point(249, 439);
            this.hashAlgorithmComboBox.Name = "hashAlgorithmComboBox";
            this.hashAlgorithmComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.hashAlgorithmComboBox, 8);
            this.hashAlgorithmComboBox.Size = new System.Drawing.Size(1121, 40);
            this.hashAlgorithmComboBox.TabIndex = 15;
            // 
            // certificationLevelComboBox
            // 
            this.tablePanel1.SetColumn(this.certificationLevelComboBox, 1);
            this.certificationLevelComboBox.Location = new System.Drawing.Point(249, 381);
            this.certificationLevelComboBox.Name = "certificationLevelComboBox";
            this.certificationLevelComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.tablePanel1.SetRow(this.certificationLevelComboBox, 7);
            this.certificationLevelComboBox.Size = new System.Drawing.Size(1121, 40);
            this.certificationLevelComboBox.TabIndex = 14;
            // 
            // labelControl7
            // 
            this.tablePanel1.SetColumn(this.labelControl7, 0);
            this.labelControl7.Location = new System.Drawing.Point(3, 446);
            this.labelControl7.Name = "labelControl7";
            this.tablePanel1.SetRow(this.labelControl7, 8);
            this.labelControl7.Size = new System.Drawing.Size(144, 25);
            this.labelControl7.TabIndex = 13;
            this.labelControl7.Text = "Hash Algorithm";
            // 
            // labelControl6
            // 
            this.tablePanel1.SetColumn(this.labelControl6, 0);
            this.labelControl6.Location = new System.Drawing.Point(3, 388);
            this.labelControl6.Name = "labelControl6";
            this.tablePanel1.SetRow(this.labelControl6, 7);
            this.labelControl6.Size = new System.Drawing.Size(166, 25);
            this.labelControl6.TabIndex = 12;
            this.labelControl6.Text = "Certification Level";
            // 
            // teExpD
            // 
            this.tablePanel1.SetColumn(this.teExpD, 1);
            this.teExpD.Location = new System.Drawing.Point(249, 311);
            this.teExpD.Name = "teExpD";
            this.tablePanel1.SetRow(this.teExpD, 5);
            this.teExpD.Size = new System.Drawing.Size(1121, 40);
            this.teExpD.TabIndex = 11;
            // 
            // teFN
            // 
            this.tablePanel1.SetColumn(this.teFN, 1);
            this.teFN.Location = new System.Drawing.Point(249, 219);
            this.teFN.Name = "teFN";
            this.tablePanel1.SetRow(this.teFN, 3);
            this.teFN.Size = new System.Drawing.Size(1121, 40);
            this.teFN.TabIndex = 10;
            // 
            // listBoxControl1
            // 
            this.tablePanel1.SetColumn(this.listBoxControl1, 1);
            this.listBoxControl1.Location = new System.Drawing.Point(249, 3);
            this.listBoxControl1.Name = "listBoxControl1";
            this.tablePanel1.SetRow(this.listBoxControl1, 0);
            this.listBoxControl1.Size = new System.Drawing.Size(1121, 85);
            this.listBoxControl1.TabIndex = 9;
            this.listBoxControl1.SelectedValueChanged += new System.EventHandler(this.selectedvalue_changed);
            // 
            // teEffE
            // 
            this.tablePanel1.SetColumn(this.teEffE, 1);
            this.teEffE.Location = new System.Drawing.Point(249, 269);
            this.teEffE.Name = "teEffE";
            this.tablePanel1.SetRow(this.teEffE, 4);
            this.teEffE.Size = new System.Drawing.Size(1121, 40);
            this.teEffE.TabIndex = 8;
            // 
            // button_sign_save
            // 
            this.tablePanel1.SetColumn(this.button_sign_save, 1);
            this.button_sign_save.Location = new System.Drawing.Point(249, 648);
            this.button_sign_save.Name = "button_sign_save";
            this.tablePanel1.SetRow(this.button_sign_save, 9);
            this.button_sign_save.Size = new System.Drawing.Size(1121, 43);
            this.button_sign_save.TabIndex = 6;
            this.button_sign_save.Text = "Sign and Save...";
            this.button_sign_save.Click += new System.EventHandler(this.button_sign_save_Click);
            // 
            // labelControl4
            // 
            this.tablePanel1.SetColumn(this.labelControl4, 0);
            this.labelControl4.Location = new System.Drawing.Point(3, 318);
            this.labelControl4.Name = "labelControl4";
            this.tablePanel1.SetRow(this.labelControl4, 5);
            this.labelControl4.Size = new System.Drawing.Size(120, 25);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Expired Date";
            // 
            // labelControl3
            // 
            this.tablePanel1.SetColumn(this.labelControl3, 0);
            this.labelControl3.Location = new System.Drawing.Point(3, 276);
            this.labelControl3.Name = "labelControl3";
            this.tablePanel1.SetRow(this.labelControl3, 4);
            this.labelControl3.Size = new System.Drawing.Size(130, 25);
            this.labelControl3.TabIndex = 3;
            this.labelControl3.Text = "Effective Date";
            // 
            // labelControl2
            // 
            this.tablePanel1.SetColumn(this.labelControl2, 0);
            this.labelControl2.Location = new System.Drawing.Point(3, 226);
            this.labelControl2.Name = "labelControl2";
            this.tablePanel1.SetRow(this.labelControl2, 3);
            this.labelControl2.Size = new System.Drawing.Size(135, 25);
            this.labelControl2.TabIndex = 1;
            this.labelControl2.Text = "Friendly Name";
            // 
            // button_load_cer_choose_file
            // 
            this.tablePanel1.SetColumn(this.button_load_cer_choose_file, 1);
            this.button_load_cer_choose_file.Location = new System.Drawing.Point(249, 94);
            this.button_load_cer_choose_file.Name = "button_load_cer_choose_file";
            this.tablePanel1.SetRow(this.button_load_cer_choose_file, 1);
            this.button_load_cer_choose_file.Size = new System.Drawing.Size(1121, 46);
            this.button_load_cer_choose_file.TabIndex = 2;
            this.button_load_cer_choose_file.Text = "Load certificate by choose file...";
            this.button_load_cer_choose_file.Click += new System.EventHandler(this.button_load_cer_choose_file_Click);
            // 
            // labelControl1
            // 
            this.tablePanel1.SetColumn(this.labelControl1, 0);
            this.labelControl1.Location = new System.Drawing.Point(3, 33);
            this.labelControl1.Name = "labelControl1";
            this.tablePanel1.SetRow(this.labelControl1, 0);
            this.labelControl1.Size = new System.Drawing.Size(95, 25);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Certificate";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 842);
            this.Controls.Add(this.tablePanel1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hashAlgorithmComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.certificationLevelComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teExpD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFN.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teEffE.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SimpleButton button_load_cer_choose_file;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton button_sign_save;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.TextEdit teEffE;
        private DevExpress.XtraEditors.TextEdit teExpD;
        private DevExpress.XtraEditors.TextEdit teFN;
        private DevExpress.XtraEditors.ComboBoxEdit certificationLevelComboBox;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit hashAlgorithmComboBox;
        public DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private DevExpress.XtraEditors.SimpleButton button_load_cer_wstore;
    }
}