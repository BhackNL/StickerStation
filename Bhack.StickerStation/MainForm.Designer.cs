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
            this.tbNotes = new System.Windows.Forms.TextBox();
            this.lbNotes = new System.Windows.Forms.Label();
            this.tbFee = new System.Windows.Forms.TextBox();
            this.lbFee = new System.Windows.Forms.Label();
            this.tbOwner = new System.Windows.Forms.TextBox();
            this.lbOwner = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.cbUsageModel = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.gbCreateSticker.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 20);
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
            this.gbCreateSticker.Location = new System.Drawing.Point(12, 12);
            this.gbCreateSticker.Name = "gbCreateSticker";
            this.gbCreateSticker.Size = new System.Drawing.Size(554, 207);
            this.gbCreateSticker.TabIndex = 1;
            this.gbCreateSticker.TabStop = false;
            this.gbCreateSticker.Text = "Create a sticker";
            // 
            // tbNotes
            // 
            this.tbNotes.Location = new System.Drawing.Point(119, 164);
            this.tbNotes.Name = "tbNotes";
            this.tbNotes.Size = new System.Drawing.Size(348, 26);
            this.tbNotes.TabIndex = 7;
            // 
            // lbNotes
            // 
            this.lbNotes.AutoSize = true;
            this.lbNotes.Location = new System.Drawing.Point(58, 167);
            this.lbNotes.Name = "lbNotes";
            this.lbNotes.Size = new System.Drawing.Size(55, 20);
            this.lbNotes.TabIndex = 8;
            this.lbNotes.Text = "Notes:";
            // 
            // tbFee
            // 
            this.tbFee.Location = new System.Drawing.Point(119, 132);
            this.tbFee.Name = "tbFee";
            this.tbFee.Size = new System.Drawing.Size(348, 26);
            this.tbFee.TabIndex = 6;
            // 
            // lbFee
            // 
            this.lbFee.AutoSize = true;
            this.lbFee.Location = new System.Drawing.Point(72, 135);
            this.lbFee.Name = "lbFee";
            this.lbFee.Size = new System.Drawing.Size(41, 20);
            this.lbFee.TabIndex = 5;
            this.lbFee.Text = "Fee:";
            // 
            // tbOwner
            // 
            this.tbOwner.Location = new System.Drawing.Point(119, 100);
            this.tbOwner.Name = "tbOwner";
            this.tbOwner.Size = new System.Drawing.Size(348, 26);
            this.tbOwner.TabIndex = 4;
            // 
            // lbOwner
            // 
            this.lbOwner.AutoSize = true;
            this.lbOwner.Location = new System.Drawing.Point(54, 103);
            this.lbOwner.Name = "lbOwner";
            this.lbOwner.Size = new System.Drawing.Size(59, 20);
            this.lbOwner.TabIndex = 3;
            this.lbOwner.Text = "Owner:";
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(473, 166);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 23);
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
            this.cbUsageModel.Location = new System.Drawing.Point(119, 66);
            this.cbUsageModel.Name = "cbUsageModel";
            this.cbUsageModel.Size = new System.Drawing.Size(215, 28);
            this.cbUsageModel.TabIndex = 1;
            this.cbUsageModel.ValueMember = "Id";
            this.cbUsageModel.SelectedIndexChanged += new System.EventHandler(this.OnUsageModelChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Sticker size:";
            // 
            // rbSmall
            // 
            this.rbSmall.AutoSize = true;
            this.rbSmall.Checked = true;
            this.rbSmall.Location = new System.Drawing.Point(119, 36);
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.Size = new System.Drawing.Size(107, 24);
            this.rbSmall.TabIndex = 10;
            this.rbSmall.TabStop = true;
            this.rbSmall.Text = "62x50 mm";
            this.rbSmall.UseVisualStyleBackColor = true;
            // 
            // rbLarge
            // 
            this.rbLarge.AutoSize = true;
            this.rbLarge.Location = new System.Drawing.Point(232, 36);
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.Size = new System.Drawing.Size(116, 24);
            this.rbLarge.TabIndex = 11;
            this.rbLarge.Text = "100x62 mm";
            this.rbLarge.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 301);
            this.Controls.Add(this.gbCreateSticker);
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

