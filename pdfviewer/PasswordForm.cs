using System;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace DevExpress.Docs.Demos {
    public partial class PasswordForm : XtraForm {
        public string Password { get { return textEditPassword.Text; } } 

        public PasswordForm(string fileName) {
            InitializeComponent();
            labelDescription.Text = String.Format("File '{0}' is password protected. Please enter the password in the box below.", fileName.Length < 20 ? fileName : fileName.Substring(0, 17) + "...");
            buttonOK.Enabled = false;
        }
        void tbPassword_EditValueChanging(object sender, ChangingEventArgs e) {
            buttonOK.Enabled = !String.IsNullOrEmpty(e.NewValue as string);
        }
    }
}
