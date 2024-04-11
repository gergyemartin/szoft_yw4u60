namespace urlap
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
            textBoxName = new TextBox();
            textBoxPop = new TextBox();
            textBoxKm = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonOk = new Button();
            bindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(107, 74);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(135, 23);
            textBoxName.TabIndex = 0;
            // 
            // textBoxPop
            // 
            textBoxPop.Location = new Point(107, 121);
            textBoxPop.Name = "textBoxPop";
            textBoxPop.Size = new Size(135, 23);
            textBoxPop.TabIndex = 3;
            // 
            // textBoxKm
            // 
            textBoxKm.Location = new Point(107, 167);
            textBoxKm.Name = "textBoxKm";
            textBoxKm.Size = new Size(135, 23);
            textBoxKm.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(107, 57);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 5;
            label1.Text = "Country name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 104);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 6;
            label2.Text = "Population";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 150);
            label3.Name = "label3";
            label3.Size = new Size(75, 15);
            label3.TabIndex = 7;
            label3.Text = "Areas in km2";
            // 
            // buttonOk
            // 
            buttonOk.Location = new Point(136, 237);
            buttonOk.Name = "buttonOk";
            buttonOk.Size = new Size(75, 23);
            buttonOk.TabIndex = 8;
            buttonOk.Text = "Ok";
            buttonOk.UseVisualStyleBackColor = true;
            // 
            // bindingSource1
            // 
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
            Controls.Add(textBoxKm);
            Controls.Add(textBoxPop);
            Controls.Add(textBoxName);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxName;
        private TextBox textBoxPop;
        private TextBox textBoxKm;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonOk;
        private BindingSource bindingSource1;
    }
}