namespace Laibrary_Management_System
{
    partial class frm_Dashbord
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Dashbord));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btnissuebook = new System.Windows.Forms.Button();
            this.btnreturnbook = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Silver;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcom To System";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(241, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 558);
            this.panel1.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Gray;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(21, 123);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(146, 39);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Book Registration";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Gray;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(21, 189);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(146, 39);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Add Student";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btnissuebook
            // 
            this.btnissuebook.BackColor = System.Drawing.Color.Gray;
            this.btnissuebook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnissuebook.Location = new System.Drawing.Point(21, 279);
            this.btnissuebook.Name = "btnissuebook";
            this.btnissuebook.Size = new System.Drawing.Size(146, 39);
            this.btnissuebook.TabIndex = 4;
            this.btnissuebook.Text = "Issue Book";
            this.btnissuebook.UseVisualStyleBackColor = false;
            this.btnissuebook.VisibleChanged += new System.EventHandler(this.btnissubook_Click);
            this.btnissuebook.Click += new System.EventHandler(this.btnissuebook_Click_1);
            // 
            // btnreturnbook
            // 
            this.btnreturnbook.BackColor = System.Drawing.Color.Gray;
            this.btnreturnbook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnreturnbook.Location = new System.Drawing.Point(21, 367);
            this.btnreturnbook.Name = "btnreturnbook";
            this.btnreturnbook.Size = new System.Drawing.Size(146, 39);
            this.btnreturnbook.TabIndex = 5;
            this.btnreturnbook.Text = "Return Book";
            this.btnreturnbook.UseVisualStyleBackColor = false;
            this.btnreturnbook.Click += new System.EventHandler(this.btnreturnbook_Click);
            // 
            // frm_Dashbord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(598, 558);
            this.Controls.Add(this.btnreturnbook);
            this.Controls.Add(this.btnissuebook);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "frm_Dashbord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Dashbord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btnissuebook;
        private System.Windows.Forms.Button btnreturnbook;
    }
}