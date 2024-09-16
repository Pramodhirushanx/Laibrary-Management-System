namespace Laibrary_Management_System
{
    partial class Book_Registration
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
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnback = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnregister = new System.Windows.Forms.Button();
            this.rdbborrow = new System.Windows.Forms.RadioButton();
            this.rdbref = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.txtstudentname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtpages = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtauthor = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBookname = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBooktitel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBookid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Silver;
            this.groupBox1.Controls.Add(this.btnback);
            this.groupBox1.Controls.Add(this.btnExit);
            this.groupBox1.Controls.Add(this.btnregister);
            this.groupBox1.Controls.Add(this.rdbborrow);
            this.groupBox1.Controls.Add(this.rdbref);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtstudentname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtpages);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtauthor);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBookname);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBooktitel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBookid);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(26, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(487, 534);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Registration";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnback
            // 
            this.btnback.BackColor = System.Drawing.Color.Cyan;
            this.btnback.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnback.Location = new System.Drawing.Point(203, 464);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(94, 34);
            this.btnback.TabIndex = 17;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = false;
            this.btnback.Click += new System.EventHandler(this.btnback_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Cyan;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(330, 464);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 34);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnregister
            // 
            this.btnregister.BackColor = System.Drawing.Color.Cyan;
            this.btnregister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnregister.Location = new System.Drawing.Point(70, 464);
            this.btnregister.Name = "btnregister";
            this.btnregister.Size = new System.Drawing.Size(94, 34);
            this.btnregister.TabIndex = 15;
            this.btnregister.Text = "Register";
            this.btnregister.UseVisualStyleBackColor = false;
            this.btnregister.Click += new System.EventHandler(this.btnregister_Click);
            // 
            // rdbborrow
            // 
            this.rdbborrow.AutoSize = true;
            this.rdbborrow.Location = new System.Drawing.Point(254, 396);
            this.rdbborrow.Name = "rdbborrow";
            this.rdbborrow.Size = new System.Drawing.Size(117, 24);
            this.rdbborrow.TabIndex = 14;
            this.rdbborrow.TabStop = true;
            this.rdbborrow.Text = "Borrowable";
            this.rdbborrow.UseVisualStyleBackColor = true;
            // 
            // rdbref
            // 
            this.rdbref.AutoSize = true;
            this.rdbref.Location = new System.Drawing.Point(254, 347);
            this.rdbref.Name = "rdbref";
            this.rdbref.Size = new System.Drawing.Size(111, 24);
            this.rdbref.TabIndex = 13;
            this.rdbref.TabStop = true;
            this.rdbref.Text = "Reference";
            this.rdbref.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 375);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Classification :-";
            // 
            // txtstudentname
            // 
            this.txtstudentname.Location = new System.Drawing.Point(231, 298);
            this.txtstudentname.Name = "txtstudentname";
            this.txtstudentname.Size = new System.Drawing.Size(172, 26);
            this.txtstudentname.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(66, 304);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Student Name :-";
            // 
            // txtpages
            // 
            this.txtpages.Location = new System.Drawing.Point(231, 249);
            this.txtpages.Name = "txtpages";
            this.txtpages.Size = new System.Drawing.Size(172, 26);
            this.txtpages.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "No Of Pages :-";
            // 
            // txtauthor
            // 
            this.txtauthor.Location = new System.Drawing.Point(231, 201);
            this.txtauthor.Name = "txtauthor";
            this.txtauthor.Size = new System.Drawing.Size(172, 26);
            this.txtauthor.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Book Author :-";
            // 
            // txtBookname
            // 
            this.txtBookname.Location = new System.Drawing.Point(231, 154);
            this.txtBookname.Name = "txtBookname";
            this.txtBookname.Size = new System.Drawing.Size(172, 26);
            this.txtBookname.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Book Name :-";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtBooktitel
            // 
            this.txtBooktitel.Location = new System.Drawing.Point(231, 107);
            this.txtBooktitel.Name = "txtBooktitel";
            this.txtBooktitel.Size = new System.Drawing.Size(172, 26);
            this.txtBooktitel.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book Titel :-";
            // 
            // txtBookid
            // 
            this.txtBookid.Location = new System.Drawing.Point(231, 63);
            this.txtBookid.Name = "txtBookid";
            this.txtBookid.Size = new System.Drawing.Size(172, 26);
            this.txtBookid.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Id :-";
            // 
            // Book_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(541, 585);
            this.Controls.Add(this.groupBox1);
            this.Name = "Book_Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book_Registration";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBookid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtstudentname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtpages;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtauthor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBookname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBooktitel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton rdbborrow;
        private System.Windows.Forms.RadioButton rdbref;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnregister;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnback;
    }
}