namespace Kamatszamitas3
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
            button1 = new Button();
            textBoxKamat = new TextBox();
            textBoxHitelOssz = new TextBox();
            textBoxTorl = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(308, 159);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Számol";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBoxKamat
            // 
            textBoxKamat.Location = new Point(98, 161);
            textBoxKamat.Name = "textBoxKamat";
            textBoxKamat.Size = new Size(125, 27);
            textBoxKamat.TabIndex = 1;
            // 
            // textBoxHitelOssz
            // 
            textBoxHitelOssz.Location = new Point(98, 78);
            textBoxHitelOssz.Name = "textBoxHitelOssz";
            textBoxHitelOssz.Size = new Size(125, 27);
            textBoxHitelOssz.TabIndex = 2;
            // 
            // textBoxTorl
            // 
            textBoxTorl.Location = new Point(294, 78);
            textBoxTorl.Name = "textBoxTorl";
            textBoxTorl.Size = new Size(125, 27);
            textBoxTorl.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(92, 253);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(621, 188);
            dataGridView1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(98, 55);
            label1.Name = "label1";
            label1.Size = new Size(98, 20);
            label1.TabIndex = 5;
            label1.Text = "Hitel összege";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(294, 55);
            label2.Name = "label2";
            label2.Size = new Size(112, 20);
            label2.TabIndex = 6;
            label2.Text = "Törlesztőrészlet";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(98, 138);
            label3.Name = "label3";
            label3.Size = new Size(52, 20);
            label3.TabIndex = 7;
            label3.Text = "Kamat";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(textBoxTorl);
            Controls.Add(textBoxHitelOssz);
            Controls.Add(textBoxKamat);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBoxKamat;
        private TextBox textBoxHitelOssz;
        private TextBox textBoxTorl;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}