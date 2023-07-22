using System;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using DevExpress.Pdf;
using System.Collections.Generic;
using static pdfviewer.Form2;
using System.Text.Json;

namespace pdfviewer
{
    public partial class Form1 : Form
    {

        // This class is used to save
        // and restore the selection area coordinates
        public class GraphicsCoordinates
        {
            public GraphicsCoordinates(int pageIndex, PdfPoint point1, PdfPoint point2)
            {
                PageIndex = pageIndex;
                Point1 = point1;
                Point2 = point2;
            }

            public int PageIndex { get; }
            public PdfPoint Point1 { get; }
            public PdfPoint Point2 { get; }
            public bool IsEmpty => Point1 == Point2;
        }

        PdfSignatureAppearance appearance { get; set; }

        public List<GraphicsCoordinates> rectangleCoordinateList = new List<GraphicsCoordinates>();
        public GraphicsCoordinates currentCoordinates;
        bool ActivateDrawing = false;
        public Form1()
        {
            InitializeComponent();
        }

        public bool mouseButtonPressed = false;
        public PdfDocumentPosition startPosition;
        public PdfDocumentPosition endPosition;
        public X509Certificate2 cert;
        public RectangleF rectangleF;
        Form2 form2;

        public void SignDocument(PdfSignatureBuilder signature)
        {
            using (var signer = new PdfDocumentSigner(pdfViewer1.DocumentFilePath))
            {
                string filenameSave = pdfViewer1.DocumentFilePath;
                filenameSave = filenameSave.Replace(".pdf", "_signed.pdf");
                signer.SaveDocument(filenameSave, signature);
                pdfViewer1.LoadDocument(filenameSave);
                MessageBox.Show("Ký số thành công!\nFile: " + filenameSave);
                if (checkButton1_luufilejson.Checked)
                {
                    var data = new
                    {
                        filePath = filenameSave,
                        name = signature.Name,
                        signingTime = signature.SigningTime,
                        applicationName = signature.ApplicationName,
                        certificationLevel = signature.CertificationLevel,
                        contactInfo = signature.ContactInfo,
                        location = signature.Location,
                        reason = signature.Reason,
                        hashCode = signature.GetHashCode()
                    };
                    string json = JsonSerializer.Serialize(data) + "\n";
                    System.IO.File.AppendAllText("summary.jsonl", json);
                }
            }
        }

        private void simpleButton1_kyso_Click(object sender, EventArgs e)
        {
            if (form2 == null)
            {
                form2 = new Form2(this);
            }
            form2.ShowDialog();
        }

        private void simpleButton2_kiemtra_Click(object sender, EventArgs e)
        {
            using (var signer = new PdfDocumentSigner(pdfViewer1.DocumentFilePath))
            {
                var signatures = signer.GetSignatureInfo();
                if (signatures.Count > 0)
                {
                    var certItem = (CertItem)form2.listBoxControl1.SelectedItem;
                    X509Certificate2 cert;
                    if (certItem.CertType != null)
                    {
                        cert = certItem.CertType;
                    }
                    else
                    {
                        cert = new X509Certificate2(certItem.FilePath, certItem.Password, X509KeyStorageFlags.Exportable);
                    }
                    DateTime start = DateTime.Parse(cert.GetEffectiveDateString());
                    DateTime end = DateTime.Parse(cert.GetExpirationDateString());
                    
                    string result = "False";
                    foreach (var signature in signatures)
                    {
                        DateTimeOffset target = (DateTimeOffset)signature.SigningTime;
                        DateTime newTarget = target.UtcDateTime;
                        if (newTarget >= start && newTarget <= end && signature.SignerName == cert.FriendlyName)
                        {
                            result = "True";
                            MessageBox.Show("Chữ ký số hợp lệ!");
                            break;
                        }
                    }

                    if (result == "False")
                    {
                        MessageBox.Show("Chữ ký số KHÔNG hợp lệ!");
                    }
                }
            }
        }

        void PdfViewer1_MouseMove(object sender, MouseEventArgs e)
        {
            if (currentCoordinates != null)
            {
                UpdateCurrentRect(e.Location);
                pdfViewer1.Invalidate();
            }
        }
        void pdfViewer1_MouseUp(object sender, MouseEventArgs e)
        {
            UpdateCurrentRect(e.Location);
            if (currentCoordinates != null)
            {
                if (!currentCoordinates.IsEmpty && ActivateDrawing)
                    rectangleCoordinateList.Add(currentCoordinates);
                currentCoordinates = null;
            }
        }
        void pdfViewer1_MouseDown(object sender, MouseEventArgs e)
        {
            var position = pdfViewer1.GetDocumentPosition(e.Location, true);
            currentCoordinates = new GraphicsCoordinates(position.PageNumber - 1, position.Point, position.Point);
        }

        void UpdateCurrentRect(Point location)
        {
            if (rectangleCoordinateList != null)
            {
                var documentPosition = pdfViewer1.GetDocumentPosition(location, true);
                if (currentCoordinates.PageIndex == documentPosition.PageNumber - 1)
                    currentCoordinates = new GraphicsCoordinates(currentCoordinates.PageIndex, currentCoordinates.Point1, documentPosition.Point);
            }
        }

        private void drawActive_Click(object sender, EventArgs e)
        {
            ActivateDrawing = !ActivateDrawing;
            if (ActivateDrawing)
            {
                pdfViewer1.MouseDown += pdfViewer1_MouseDown;
                pdfViewer1.MouseMove += PdfViewer1_MouseMove;
                pdfViewer1.MouseUp += pdfViewer1_MouseUp;
            }
            else
            {
                pdfViewer1.MouseDown -= pdfViewer1_MouseDown;
                pdfViewer1.MouseMove -= PdfViewer1_MouseMove;
                pdfViewer1.MouseUp -= pdfViewer1_MouseUp;
            }
        }
    }
}
