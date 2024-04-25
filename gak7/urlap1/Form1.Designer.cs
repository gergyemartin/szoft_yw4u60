namespace urlap1
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
            components = new System.ComponentModel.Container();
            tbName = new TextBox();
            tbArea = new TextBox();
            tbPop = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonOk = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // tbName
            // 
            tbName.Location = new Point(246, 142);
            tbName.Name = "tbName";
            tbName.Size = new Size(162, 23);
            tbName.TabIndex = 0;
            // 
            // tbArea
            // 
            tbArea.Location = new Point(246, 242);
            tbArea.Name = "tbArea";
            tbArea.Size = new Size(162, 23);
            tbArea.TabIndex = 1;
            // 
            // tbPop
            // 
            tbPop.Location = new Point(246, 192);
            tbPop.Name = "tbPop";
            tbPop.Size = new Size(162, 23);
            tbPop.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(246, 124);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 3;
            label1.Text = "Country name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 174);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 4;
            label2.Text = "Population";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(246, 224);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 5;
            label3.Text = "Areas in km2";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(449, 242);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 6;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            buttonOk.Click += buttonOk_Click;
            // 
            // bindingSource1
            // 
            bindingSource1.DataSource = typeof(Form1);
            bindingSource1.CurrentChanged += bindingSource1_CurrentChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(buttonOk);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPop);
            Controls.Add(tbArea);
            Controls.Add(tbName);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbName;
        private TextBox tbArea;
        private TextBox tbPop;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonOk;
        private BindingSource bindingSource1;
    }
}