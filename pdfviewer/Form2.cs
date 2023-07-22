using System;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using DevExpress.Docs.Demos;
using DevExpress.Office.DigitalSignatures;
using DevExpress.Pdf;
using DevExpress.XtraEditors;
using static pdfviewer.Form1;

namespace pdfviewer
{
    public partial class Form2 : Form
    {
        Form1 parent;
        public Form2(Form1 parentC)
        {
            InitializeComponent();
            var comboBoxItems = hashAlgorithmComboBox.Properties.Items;
            foreach (var item in Enum.GetValues(typeof(HashAlgorithmType)))
                comboBoxItems.Add(item);
            hashAlgorithmComboBox.SelectedItem = HashAlgorithmType.SHA256;
            var certificationLevelItems = certificationLevelComboBox.Properties.Items;
            certificationLevelItems.Add("No Certification");
            certificationLevelItems.Add("No Changes Allowed");
            certificationLevelItems.Add("Fill Forms");
            certificationLevelItems.Add("Fill Forms And Annotate");
            certificationLevelComboBox.SelectedIndex = 0;
            parent = parentC;
        }

        public class CertItem
        {
            public static CertItem Create(string filePath, string password)
            {
                try
                {
                    X509Certificate2 newCert = new X509Certificate2(filePath, password, X509KeyStorageFlags.Exportable);
                    if (newCert.HasPrivateKey)
                        return new CertItem(filePath, password, newCert.Subject, newCert.GetEffectiveDateString(), newCert.GetExpirationDateString(), newCert.FriendlyName, null);
                    else
                        XtraMessageBox.Show("The certificate must contain a private key.", "Invalid certificate", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch
                {
                    try
                    {
                        PasswordForm passwordForm = new PasswordForm(filePath);
                        if (passwordForm.ShowDialog() == DialogResult.OK)
                        {
                            X509Certificate2 newCert = new X509Certificate2(filePath, passwordForm.Password, X509KeyStorageFlags.Exportable);
                            return new CertItem(filePath, passwordForm.Password, newCert.Subject, newCert.GetEffectiveDateString(), newCert.GetExpirationDateString(), newCert.FriendlyName, null);
                        }
                    }
                    catch
                    {
                        XtraMessageBox.Show("The password for the certificate is incorrect.", "Incorrect password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                return null;
            }

            public string FilePath { get; private set; }
            public string Password { get; private set; }
            public string Name { get; private set; }
            public string EffectiveDate { get; private set; }
            public string ExpiredDate { get; private set; }
            public string FriendlyName { get; private set; }
            public X509Certificate2 CertType { get; private set; }

            public CertItem(string filePath, string password, string name, string effectiveDate, string expiredDate, string friendlyName, X509Certificate2 certType)
            {
                this.FilePath = filePath;
                this.Password = password;
                this.Name = name;
                this.EffectiveDate = effectiveDate;
                this.ExpiredDate = expiredDate;
                this.FriendlyName = friendlyName;
                this.CertType = certType;
            }
            public override string ToString()
            {
                return Name;
            }
        }

        private void button_load_cer_choose_file_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openDialog = new OpenFileDialog())
            {
                /*openDialog.Filter = "X.509 Certificate (*.cer; *.crt, *.pfx)|*.cer;*.crt;*.pfx";*/
                openDialog.RestoreDirectory = true;
                if (openDialog.ShowDialog() == DialogResult.OK)
                {
                    var cert = CertItem.Create(openDialog.FileName, null);
                    
                    if (cert != null)
                    {
                        listBoxControl1.Items.Add(cert);
                        listBoxControl1.SelectedIndex = listBoxControl1.Items.Count - 1;
                    }
                }
            }
        }

        private void selectedvalue_changed(object sender, EventArgs e)
        {
            var cert = (CertItem) listBoxControl1.SelectedItem;
            teEffE.Text = cert.EffectiveDate;
            teExpD.Text = cert.ExpiredDate;
            teFN.Text = cert.FriendlyName;
        }

        private void button_sign_save_Click(object sender, EventArgs e)
        {
            try
            {
                var cert = ((CertItem)listBoxControl1.SelectedItem);
                var signerTemp = cert.CertType;
                GraphicsCoordinates myrect = parent.rectangleCoordinateList[parent.rectangleCoordinateList.Count - 1];
                var fieldInfo = new PdfSignatureFieldInfo(myrect.PageIndex + 1);
                fieldInfo.Name = $"{DateTime.Now.ToString("yyyyMMdd HHmmss")}";
                
                fieldInfo.SignatureBounds = new PdfRectangle(
                    Math.Min(myrect.Point1.X, myrect.Point2.X),
                    Math.Min(myrect.Point1.Y, myrect.Point2.Y),
                    Math.Max(myrect.Point1.X, myrect.Point2.X),
                    Math.Max(myrect.Point1.Y, myrect.Point2.Y)
                );

                PdfSignatureBuilder signature;
                if (signerTemp != null)
                {
                    var signer = new Pkcs7Signer(signerTemp);
                    signature = new PdfSignatureBuilder(signer, fieldInfo);
                }
                else
                {
                    var signer = new Pkcs7Signer(cert.FilePath, cert.Password, (HashAlgorithmType)hashAlgorithmComboBox.SelectedItem);
                    signature = new PdfSignatureBuilder(signer, fieldInfo);
                }

                PdfSignatureAppearance appearance = new PdfSignatureAppearance();
                appearance.AppearanceType = PdfSignatureAppearanceType.Name;
                appearance.ShowDate = true;
                appearance.ShowName = true;
                appearance.ShowLocation = true;
                appearance.ShowReason = true;
                appearance.ShowDistinguishedName = true;
                appearance.RightToLeftTextDirection = false;
                appearance.ShowLabels = true;
                signature.SetSignatureAppearance(appearance);


                signature.Location = teFN.Text;
                signature.Name = cert.FriendlyName;
                signature.ContactInfo = teEffE.Text;
                signature.Reason = teExpD.Text;
                signature.CertificationLevel = (PdfCertificationLevel)certificationLevelComboBox.SelectedIndex;


                parent.SignDocument(signature);
            }
            catch (Exception exception)
            {
                XtraMessageBox.Show(exception.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static X509Certificate2 GetCertificate()
        {
            X509Store store = new X509Store(StoreLocation.CurrentUser);
            store.Open(OpenFlags.ReadOnly | OpenFlags.OpenExistingOnly);

            X509Certificate2Collection selectedCertificates =
                    X509Certificate2UI.SelectFromCollection(store.Certificates, null, null, X509SelectionFlag.SingleSelection);

            foreach (var certificate in selectedCertificates)
            {
                if (certificate.HasPrivateKey)
                    return certificate;
            }

            return null;
        }

        private void button_load_cer_wstore_Click(object sender, EventArgs e)
        {
            var cert = GetCertificate();
            var newCert = new CertItem("", "", cert.Subject, cert.GetEffectiveDateString(), cert.GetExpirationDateString(), cert.FriendlyName, cert);
            listBoxControl1.Items.Add(newCert);
        }
    }
}
