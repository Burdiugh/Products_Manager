
namespace wf_Multi_forms
{
    partial class Form1
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
            this.productsList = new System.Windows.Forms.ListBox();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.ShowBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.readBtn = new System.Windows.Forms.Button();
            this.saveBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // productsList
            // 
            this.productsList.FormattingEnabled = true;
            this.productsList.Location = new System.Drawing.Point(12, 12);
            this.productsList.Name = "productsList";
            this.productsList.Size = new System.Drawing.Size(340, 264);
            this.productsList.TabIndex = 0;
            // 
            // AddBtn
            // 
            this.AddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.AddBtn.Location = new System.Drawing.Point(282, 282);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(70, 37);
            this.AddBtn.TabIndex = 1;
            this.AddBtn.Text = "+";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RemoveBtn.Location = new System.Drawing.Point(12, 282);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(70, 37);
            this.RemoveBtn.TabIndex = 2;
            this.RemoveBtn.Text = "-";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // ShowBtn
            // 
            this.ShowBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ShowBtn.Location = new System.Drawing.Point(183, 282);
            this.ShowBtn.Name = "ShowBtn";
            this.ShowBtn.Size = new System.Drawing.Size(93, 37);
            this.ShowBtn.TabIndex = 3;
            this.ShowBtn.Text = "Show";
            this.ShowBtn.UseVisualStyleBackColor = true;
            this.ShowBtn.Click += new System.EventHandler(this.ShowBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.EditBtn.Location = new System.Drawing.Point(88, 282);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(89, 37);
            this.EditBtn.TabIndex = 4;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // readBtn
            // 
            this.readBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.readBtn.Location = new System.Drawing.Point(12, 325);
            this.readBtn.Name = "readBtn";
            this.readBtn.Size = new System.Drawing.Size(165, 40);
            this.readBtn.TabIndex = 5;
            this.readBtn.Text = "Read";
            this.readBtn.UseVisualStyleBackColor = true;
            this.readBtn.Click += new System.EventHandler(this.readBtn_Click);
            // 
            // saveBtn
            // 
            this.saveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveBtn.Location = new System.Drawing.Point(183, 325);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(169, 40);
            this.saveBtn.TabIndex = 6;
            this.saveBtn.Text = "Save";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 368);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.readBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.ShowBtn);
            this.Controls.Add(this.RemoveBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.productsList);
            this.Name = "Form1";
            this.Text = "Storage";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox productsList;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button ShowBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button readBtn;
        private System.Windows.Forms.Button saveBtn;
    }
}

