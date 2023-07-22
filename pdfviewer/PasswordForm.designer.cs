namespace DevExpress.Docs.Demos
{
    partial class PasswordForm
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
            this.textEditPassword = new DevExpress.XtraEditors.TextEdit();
            this.labelDescription = new DevExpress.XtraEditors.LabelControl();
            this.butttonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.labePassword = new DevExpress.XtraEditors.LabelControl();
            this.buttonOK = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // textEditPassword
            // 
            this.textEditPassword.Location = new System.Drawing.Point(136, 92);
            this.textEditPassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textEditPassword.Name = "textEditPassword";
            this.textEditPassword.Properties.PasswordChar = '*';
            this.textEditPassword.Size = new System.Drawing.Size(472, 40);
            this.textEditPassword.TabIndex = 0;
            this.textEditPassword.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.tbPassword_EditValueChanging);
            // 
            // labelDescription
            // 
            this.labelDescription.Appearance.Options.UseTextOptions = true;
            this.labelDescription.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Top;
            this.labelDescription.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.labelDescription.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelDescription.Location = new System.Drawing.Point(24, 23);
            this.labelDescription.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(584, 69);
            this.labelDescription.TabIndex = 1;
            this.labelDescription.Text = "File \'\' is password protected. Please enter the password in the box below.";
            // 
            // butttonCancel
            // 
            this.butttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.butttonCancel.Location = new System.Drawing.Point(620, 87);
            this.butttonCancel.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.butttonCancel.Name = "butttonCancel";
            this.butttonCancel.Size = new System.Drawing.Size(150, 44);
            this.butttonCancel.TabIndex = 2;
            this.butttonCancel.Text = "Cancel";
            // 
            // labePassword
            // 
            this.labePassword.Location = new System.Drawing.Point(24, 98);
            this.labePassword.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.labePassword.Name = "labePassword";
            this.labePassword.Size = new System.Drawing.Size(95, 25);
            this.labePassword.TabIndex = 3;
            this.labePassword.Text = "Password:";
            // 
            // buttonOK
            // 
            this.buttonOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOK.Location = new System.Drawing.Point(620, 23);
            this.buttonOK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonOK.Name = "buttonOK";
            this.buttonOK.Size = new System.Drawing.Size(150, 44);
            this.buttonOK.TabIndex = 2;
            this.buttonOK.Text = "OK";
            // 
            // PasswordForm
            // 
            this.AcceptButton = this.buttonOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.butttonCancel;
            this.ClientSize = new System.Drawing.Size(782, 156);
            this.Controls.Add(this.labePassword);
            this.Controls.Add(this.buttonOK);
            this.Controls.Add(this.butttonCancel);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.textEditPassword);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.IconOptions.ShowIcon = false;
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PasswordForm";
            this.Text = "Password needed";
            ((System.ComponentModel.ISupportInitialize)(this.textEditPassword.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private XtraEditors.TextEdit textEditPassword;
        private XtraEditors.LabelControl labelDescription;
        private XtraEditors.SimpleButton butttonCancel;
        private XtraEditors.LabelControl labePassword;
        private XtraEditors.SimpleButton buttonOK;
    }
}
