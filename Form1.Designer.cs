namespace JwtValidator
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            RichTextBoxForToken = new RichTextBox();
            ButtonPasteToken = new Button();
            ButtonValidateToken = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            TextBoxIssuer = new TextBox();
            label3 = new Label();
            TextBoxAudience = new TextBox();
            label2 = new Label();
            label1 = new Label();
            TextBoxIssuerToken = new TextBox();
            ButtonSaveTokenData = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 45F));
            tableLayoutPanel1.Controls.Add(RichTextBoxForToken, 1, 1);
            tableLayoutPanel1.Controls.Add(ButtonPasteToken, 1, 0);
            tableLayoutPanel1.Controls.Add(ButtonValidateToken, 1, 2);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 2, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(1180, 634);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // RichTextBoxForToken
            // 
            RichTextBoxForToken.Dock = DockStyle.Fill;
            RichTextBoxForToken.Location = new Point(62, 66);
            RichTextBoxForToken.Name = "RichTextBoxForToken";
            RichTextBoxForToken.Size = new Size(584, 501);
            RichTextBoxForToken.TabIndex = 0;
            RichTextBoxForToken.Text = "";
            // 
            // ButtonPasteToken
            // 
            ButtonPasteToken.Dock = DockStyle.Fill;
            ButtonPasteToken.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonPasteToken.Location = new Point(62, 3);
            ButtonPasteToken.Name = "ButtonPasteToken";
            ButtonPasteToken.Size = new Size(584, 57);
            ButtonPasteToken.TabIndex = 1;
            ButtonPasteToken.Text = "Paste Token Below";
            ButtonPasteToken.UseVisualStyleBackColor = true;
            ButtonPasteToken.Click += ButtonPasteToken_Click;
            // 
            // ButtonValidateToken
            // 
            ButtonValidateToken.Dock = DockStyle.Fill;
            ButtonValidateToken.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonValidateToken.Location = new Point(62, 573);
            ButtonValidateToken.Name = "ButtonValidateToken";
            ButtonValidateToken.Size = new Size(584, 58);
            ButtonValidateToken.TabIndex = 2;
            ButtonValidateToken.Text = "Validate Token";
            ButtonValidateToken.UseVisualStyleBackColor = true;
            ButtonValidateToken.Click += ButtonValidateToken_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(TextBoxIssuer, 0, 5);
            tableLayoutPanel2.Controls.Add(label3, 0, 4);
            tableLayoutPanel2.Controls.Add(TextBoxAudience, 0, 3);
            tableLayoutPanel2.Controls.Add(label2, 0, 2);
            tableLayoutPanel2.Controls.Add(label1, 0, 0);
            tableLayoutPanel2.Controls.Add(TextBoxIssuerToken, 0, 1);
            tableLayoutPanel2.Controls.Add(ButtonSaveTokenData, 0, 7);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(652, 66);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 11;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 9.090909F));
            tableLayoutPanel2.Size = new Size(525, 501);
            tableLayoutPanel2.TabIndex = 3;
            // 
            // TextBoxIssuer
            // 
            TextBoxIssuer.Dock = DockStyle.Fill;
            TextBoxIssuer.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxIssuer.Location = new Point(3, 228);
            TextBoxIssuer.Name = "TextBoxIssuer";
            TextBoxIssuer.Size = new Size(519, 31);
            TextBoxIssuer.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(3, 180);
            label3.Name = "label3";
            label3.Size = new Size(67, 28);
            label3.TabIndex = 4;
            label3.Text = "Issuer";
            // 
            // TextBoxAudience
            // 
            TextBoxAudience.Dock = DockStyle.Fill;
            TextBoxAudience.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxAudience.Location = new Point(3, 138);
            TextBoxAudience.Name = "TextBoxAudience";
            TextBoxAudience.Size = new Size(519, 31);
            TextBoxAudience.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(3, 90);
            label2.Name = "label2";
            label2.Size = new Size(100, 28);
            label2.TabIndex = 2;
            label2.Text = "Audience";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(129, 28);
            label1.TabIndex = 0;
            label1.Text = "Issuer Token";
            // 
            // TextBoxIssuerToken
            // 
            TextBoxIssuerToken.Dock = DockStyle.Fill;
            TextBoxIssuerToken.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            TextBoxIssuerToken.Location = new Point(3, 48);
            TextBoxIssuerToken.Name = "TextBoxIssuerToken";
            TextBoxIssuerToken.Size = new Size(519, 31);
            TextBoxIssuerToken.TabIndex = 1;
            // 
            // ButtonSaveTokenData
            // 
            ButtonSaveTokenData.Dock = DockStyle.Fill;
            ButtonSaveTokenData.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ButtonSaveTokenData.Location = new Point(3, 318);
            ButtonSaveTokenData.Name = "ButtonSaveTokenData";
            ButtonSaveTokenData.Size = new Size(519, 39);
            ButtonSaveTokenData.TabIndex = 6;
            ButtonSaveTokenData.Text = "Save Token Data";
            ButtonSaveTokenData.UseVisualStyleBackColor = true;
            ButtonSaveTokenData.Click += ButtonSaveTokenData_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1180, 634);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Main";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private RichTextBox RichTextBoxForToken;
        private Button ButtonPasteToken;
        private Button ButtonValidateToken;
        private TableLayoutPanel tableLayoutPanel2;
        private Label label1;
        private Label label3;
        private TextBox TextBoxAudience;
        private Label label2;
        private TextBox TextBoxIssuerToken;
        private TextBox TextBoxIssuer;
        private Button ButtonSaveTokenData;
    }
}
