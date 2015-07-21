namespace Bhack.StickerStation
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbCreateSticker = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.lbNotes = new System.Windows.Forms.Label();
            this.tbFee = new System.Windows.Forms.TextBox();
            this.lbFee = new System.Windows.Forms.Label();
            this.tbOwner = new System.Windows.Forms.TextBox();
            this.lbOwner = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cbUsageModel = new System.Windows.Forms.ComboBox();
            this.gbCreateSticker.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usage model:";
            // 
            // gbCreateSticker
            // 
            this.gbCreateSticker.Controls.Add(this.rbLarge);
            this.gbCreateSticker.Controls.Add(this.rbSmall);
            this.gbCreateSticker.Controls.Add(this.label2);
            this.gbCreateSticker.Controls.Add(this.tbNotes);
            this.gbCreateSticker.Controls.Add(this.lbNotes);
            this.gbCreateSticker.Controls.Add(this.tbFee);
            this.gbCreateSticker.Controls.Add(this.lbFee);
            this.gbCreateSticker.Controls.Add(this.tbOwner);
            this.gbCreateSticker.Controls.Add(this.lbOwner);
            this.gbCreateSticker.Controls.Add(this.btnPrint);
            this.gbCreateSticker.Controls.Add(this.cbUsageModel);
            this.gbCreateSticker.Controls.Add(this.label1);
            this.gbCreateSticker.Location = new System.Drawing.Point(8, 8);
            this.gbCreateSticker.Margin = new System.Windows.Forms.Padding(2);
            this.gbCreateSticker.Name = "gbCreateSticker";
            this.gbCreateSticker.Padding = new System.Windows.Forms.Padding(2);
            this.gbCreateSticker.Size = new System.Drawing.Size(369, 135);
            this.gbCreateSticker.TabIndex = 1;
            this.gbCreateSticker.TabStop = false;
            this.gbCreateSticker.Text = "Create a sticker";
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(190, 23);
            this.rbLarge.Margin = new System.Windows.Forms.Padding(2);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(115, 17);
            this.rbLarge.TabIndex = 11;
            this.rbLarge.Text = "Large (100x62 mm)";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Checked = true;
            this.rbSmall.Location = new System.Drawing.Point(79, 23);
            this.rbSmall.Margin = new System.Windows.Forms.Padding(2);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(107, 17);
            this.rbSmall.TabIndex = 10;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "Small (62x50 mm)";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sticker size:";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(79, 107);
            this.tbNotes.Margin = new System.Windows.Forms.Padding(2);
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(233, 20);
            this.tbNotes.TabIndex = 7;
            // 
            // lbNotes
            // 
            this.lbNotes.AutoSize = true;
            this.lbNotes.Location = new System.Drawing.Point(39, 109);
            this.lbNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(38, 13);
            this.lbNotes.TabIndex = 8;
            this.lbNotes.Text = "Notes:";
            // 
            // tbFee
            // 
            this.tbFee.Location = new System.Drawing.Point(79, 86);
            this.tbFee.Margin = new System.Windows.Forms.Padding(2);
            this.tbFee.Name = "tbFee";
            this.tbFee.Size = new System.Drawing.Size(233, 20);
            this.tbFee.TabIndex = 6;
            // 
            // lbFee
            // 
            this.lbFee.AutoSize = true;
            this.lbFee.Location = new System.Drawing.Point(48, 88);
            this.lbFee.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbFee.Name = "lbFee";
            this.lbFee.Size = new System.Drawing.Size(28, 13);
            this.lbFee.TabIndex = 5;
            this.lbFee.Text = "Fee:";
            // 
            // tbOwner
            // 
            this.tbOwner.Location = new System.Drawing.Point(79, 65);
            this.tbOwner.Margin = new System.Windows.Forms.Padding(2);
            this.tbOwner.Name = "tbOwner";
            this.tbOwner.Size = new System.Drawing.Size(233, 20);
            this.tbOwner.TabIndex = 4;
            // 
            // lbOwner
            // 
            this.lbOwner.AutoSize = true;
            this.lbOwner.Location = new System.Drawing.Point(36, 67);
            this.lbOwner.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbOwner.Name = "lbOwner";
            this.lbOwner.Size = new System.Drawing.Size(41, 13);
            this.lbOwner.TabIndex = 3;
            this.lbOwner.Text = "Owner:";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(315, 107);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(50, 20);
            this.btnPrint.TabIndex = 8;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.OnPrintClick);
            // 
            // cbUsageModel
            // 
            this.cbUsageModel.DisplayMember = "Text";
            this.cbUsageModel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUsageModel.FormattingEnabled = true;
            this.cbUsageModel.Location = new System.Drawing.Point(79, 43);
            this.cbUsageModel.Margin = new System.Windows.Forms.Padding(2);
            this.cbUsageModel.Name = "cbUsageModel";
            this.cbUsageModel.Size = new System.Drawing.Size(145, 21);
            this.cbUsageModel.TabIndex = 1;
            this.cbUsageModel.ValueMember = "Id";
            this.cbUsageModel.SelectedIndexChanged += new System.EventHandler(this.OnUsageModelChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 153);
            this.Controls.Add(this.gbCreateSticker);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "StickerStation";
            this.gbCreateSticker.ResumeLayout(false);
            this.gbCreateSticker.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbCreateSticker;
        private System.Windows.Forms.TextBox tbFee;
        private System.Windows.Forms.Label lbFee;
        private System.Windows.Forms.TextBox tbOwner;
        private System.Windows.Forms.Label lbOwner;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.ComboBox cbUsageModel;
        private System.Windows.Forms.TextBox tbNotes;
        private System.Windows.Forms.Label lbNotes;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.Label label2;
    }
}

