namespace AITECOUI
{
    partial class frmMainUI
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.lblGenerateBtn = new System.Windows.Forms.Label();
            this.lblCreateFileBtn = new System.Windows.Forms.Label();
            this.lblCloseBtn = new System.Windows.Forms.Label();
            this.rtbOutput = new System.Windows.Forms.RichTextBox();
            this.txtLLM = new System.Windows.Forms.TextBox();
            this.txtOpenAI = new System.Windows.Forms.TextBox();
            this.rbLLM = new System.Windows.Forms.RadioButton();
            this.rbOpenAI = new System.Windows.Forms.RadioButton();
            this.lblShowHideCtrl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.White;
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.ForeColor = System.Drawing.SystemColors.GrayText;
            this.txtInput.Location = new System.Drawing.Point(27, 275);
            this.txtInput.Margin = new System.Windows.Forms.Padding(2);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(320, 108);
            this.txtInput.TabIndex = 0;
            this.txtInput.Text = "Describe the test scenario you want to create";
            this.txtInput.Enter += new System.EventHandler(this.txtInput_Enter);
            this.txtInput.Leave += new System.EventHandler(this.txtInput_Leave);
            // 
            // lblGenerateBtn
            // 
            this.lblGenerateBtn.BackColor = System.Drawing.Color.Transparent;
            this.lblGenerateBtn.Image = global::AITECOUI.Properties.Resources.G1;
            this.lblGenerateBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblGenerateBtn.Location = new System.Drawing.Point(112, 398);
            this.lblGenerateBtn.Name = "lblGenerateBtn";
            this.lblGenerateBtn.Size = new System.Drawing.Size(126, 43);
            this.lblGenerateBtn.TabIndex = 6;
            this.lblGenerateBtn.Click += new System.EventHandler(this.lblGenerateBtn_Click);
            this.lblGenerateBtn.MouseLeave += new System.EventHandler(this.lblGenerateBtn_MouseLeave);
            this.lblGenerateBtn.MouseHover += new System.EventHandler(this.lblGenerateBtn_MouseHover);
            // 
            // lblCreateFileBtn
            // 
            this.lblCreateFileBtn.BackColor = System.Drawing.Color.Transparent;
            this.lblCreateFileBtn.Image = global::AITECOUI.Properties.Resources.C11;
            this.lblCreateFileBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCreateFileBtn.Location = new System.Drawing.Point(635, 572);
            this.lblCreateFileBtn.Name = "lblCreateFileBtn";
            this.lblCreateFileBtn.Size = new System.Drawing.Size(129, 45);
            this.lblCreateFileBtn.TabIndex = 6;
            this.lblCreateFileBtn.Click += new System.EventHandler(this.lblCreateFileBtn_Click);
            this.lblCreateFileBtn.MouseLeave += new System.EventHandler(this.lblCreateFileBtn_MouseLeave);
            this.lblCreateFileBtn.MouseHover += new System.EventHandler(this.lblCreateFileBtn_MouseHover);
            // 
            // lblCloseBtn
            // 
            this.lblCloseBtn.BackColor = System.Drawing.Color.Transparent;
            this.lblCloseBtn.Image = global::AITECOUI.Properties.Resources.Close;
            this.lblCloseBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.lblCloseBtn.Location = new System.Drawing.Point(955, -3);
            this.lblCloseBtn.Name = "lblCloseBtn";
            this.lblCloseBtn.Size = new System.Drawing.Size(40, 39);
            this.lblCloseBtn.TabIndex = 6;
            this.lblCloseBtn.Click += new System.EventHandler(this.lblCloseBtn_Click);
            // 
            // rtbOutput
            // 
            this.rtbOutput.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(249)))), ((int)(((byte)(249)))), ((int)(((byte)(249)))));
            this.rtbOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbOutput.Location = new System.Drawing.Point(477, 155);
            this.rtbOutput.Name = "rtbOutput";
            this.rtbOutput.Size = new System.Drawing.Size(423, 399);
            this.rtbOutput.TabIndex = 7;
            this.rtbOutput.Text = "";
            this.rtbOutput.TextChanged += new System.EventHandler(this.rtbOutput_TextChanged);
            // 
            // txtLLM
            // 
            this.txtLLM.Location = new System.Drawing.Point(123, 623);
            this.txtLLM.Name = "txtLLM";
            this.txtLLM.Size = new System.Drawing.Size(241, 20);
            this.txtLLM.TabIndex = 8;
            this.txtLLM.Visible = false;
            // 
            // txtOpenAI
            // 
            this.txtOpenAI.Location = new System.Drawing.Point(123, 600);
            this.txtOpenAI.Name = "txtOpenAI";
            this.txtOpenAI.Size = new System.Drawing.Size(241, 20);
            this.txtOpenAI.TabIndex = 8;
            this.txtOpenAI.Visible = false;
            // 
            // rbLLM
            // 
            this.rbLLM.AutoSize = true;
            this.rbLLM.Location = new System.Drawing.Point(36, 625);
            this.rbLLM.Name = "rbLLM";
            this.rbLLM.Size = new System.Drawing.Size(71, 17);
            this.rbLLM.TabIndex = 9;
            this.rbLLM.Text = "LLM URL";
            this.rbLLM.UseVisualStyleBackColor = true;
            this.rbLLM.Visible = false;
            // 
            // rbOpenAI
            // 
            this.rbOpenAI.AutoSize = true;
            this.rbOpenAI.Checked = true;
            this.rbOpenAI.Location = new System.Drawing.Point(36, 603);
            this.rbOpenAI.Name = "rbOpenAI";
            this.rbOpenAI.Size = new System.Drawing.Size(86, 17);
            this.rbOpenAI.TabIndex = 9;
            this.rbOpenAI.TabStop = true;
            this.rbOpenAI.Text = "OpenAI URL";
            this.rbOpenAI.UseVisualStyleBackColor = true;
            this.rbOpenAI.Visible = false;
            // 
            // lblShowHideCtrl
            // 
            this.lblShowHideCtrl.Location = new System.Drawing.Point(2, 625);
            this.lblShowHideCtrl.Name = "lblShowHideCtrl";
            this.lblShowHideCtrl.Size = new System.Drawing.Size(28, 17);
            this.lblShowHideCtrl.TabIndex = 10;
            this.lblShowHideCtrl.Click += new System.EventHandler(this.lblShowHideCtrl_Click);
            // 
            // frmMainUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::AITECOUI.Properties.Resources.MainUIBG2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1000, 645);
            this.ControlBox = false;
            this.Controls.Add(this.lblShowHideCtrl);
            this.Controls.Add(this.rbOpenAI);
            this.Controls.Add(this.rbLLM);
            this.Controls.Add(this.txtOpenAI);
            this.Controls.Add(this.txtLLM);
            this.Controls.Add(this.rtbOutput);
            this.Controls.Add(this.lblCloseBtn);
            this.Controls.Add(this.lblCreateFileBtn);
            this.Controls.Add(this.lblGenerateBtn);
            this.Controls.Add(this.txtInput);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMainUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = " ";
            this.Load += new System.EventHandler(this.frmMainUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label lblGenerateBtn;
        private System.Windows.Forms.Label lblCreateFileBtn;
        private System.Windows.Forms.Label lblCloseBtn;
        private System.Windows.Forms.RichTextBox rtbOutput;
        private System.Windows.Forms.TextBox txtLLM;
        private System.Windows.Forms.TextBox txtOpenAI;
        private System.Windows.Forms.RadioButton rbLLM;
        private System.Windows.Forms.RadioButton rbOpenAI;
        private System.Windows.Forms.Label lblShowHideCtrl;
    }
}

