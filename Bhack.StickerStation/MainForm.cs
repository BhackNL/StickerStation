using bpac;
using System;
using System.Windows.Forms;

namespace Bhack.StickerStation
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            cbUsageModel.DataSource = new[]
            {
                new UsageModel(1, "FREE TO USE", false),
                new UsageModel(2, "PAY TO USE", true),
                new UsageModel(3, "READ DOCS", true),
                new UsageModel(4, "ASK OWNER", true),
                new UsageModel(5, "OWNER ONLY", false)
            };

            cbUsageModel.SelectedIndex = 0;
            cbUsageModel.Focus();
        }

        private void OnPrintClick(object sender, EventArgs e)
        {
            var type = Type.GetTypeFromProgID("bpac.Document");
            var doc = (Document)Activator.CreateInstance(type);

            var fileName = rbLarge.Checked ? "BhackL.lbx" : rbContents.Checked ? "BhackM.lbx" : "BhackS.lbx";

            if (doc.Open(fileName))
            {
                if (!rbContents.Checked)
                {
                    doc.GetObject("usageModel").Text = cbUsageModel.SelectedItem.ToString();
                    doc.GetObject("owner").Text = tbOwner.Text;
                    doc.GetObject("fee").Text = tbFee.Text.Replace(',', '.');
                    doc.GetObject("notes").Text = tbNotes.Text;
                    doc.GetObject("qrCode").Text = doc.GetObject("qrCode").Text + Guid.NewGuid();
                }
                else
                {
                    doc.GetObject("usageModel").Text = cbUsageModel.SelectedItem.ToString();
                    doc.GetObject("owner").Text = tbOwner.Text;
                    doc.GetObject("fee").Text = tbFee.Text.Replace(',', '.');
                    doc.GetObject("contents").Text = tbNotes.Text;
                    doc.GetObject("qrCode").Text = doc.GetObject("qrCode").Text + Guid.NewGuid();
                }

                doc.StartPrint("", PrintOptionConstants.bpoDefault);
                doc.PrintOut(1, PrintOptionConstants.bpoDefault);
                doc.EndPrint();
                doc.Close();
            }
        }

        private void OnUsageModelChanged(object sender, EventArgs e)
        {
            lbNotes.Text = rbContents.Checked ? "Contents" : "Notes";

            var selectedItem = (UsageModel)cbUsageModel.SelectedItem;

            tbFee.Enabled = selectedItem.HasFee;
            tbFee.Text = "N/A";
        }
    }
}
