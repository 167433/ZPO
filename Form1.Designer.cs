namespace ZPO
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
            BtnNext = new Button();
            classSelectPanel = new Panel();
            textTest = new RichTextBox();
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            textClassOpis = new RichTextBox();
            lblImie = new Label();
            label4 = new Label();
            lblRasa = new Label();
            label3 = new Label();
            lblKlasa = new Label();
            comboBoxRaces = new ComboBox();
            richTextBox1 = new RichTextBox();
            cbClassName = new ComboBox();
            boxStats = new GroupBox();
            txtBoxSTR = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            label7 = new Label();
            label9 = new Label();
            label11 = new Label();
            txtBoxDEX = new TextBox();
            txtBoxWIS = new TextBox();
            btnRollAll = new Button();
            txtBoxCON = new TextBox();
            txtBoxINT = new TextBox();
            txtBoxCHA = new TextBox();
            menuStrip1 = new MenuStrip();
            graczToolStripMenuItem = new ToolStripMenuItem();
            nPCToolStripMenuItem = new ToolStripMenuItem();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnSaveToJSON = new Button();
            btnInteract = new Button();
            btnLinQ = new Button();
            classSelectPanel.SuspendLayout();
            groupBox1.SuspendLayout();
            boxStats.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnNext
            // 
            BtnNext.Location = new Point(16, 405);
            BtnNext.Name = "BtnNext";
            BtnNext.Size = new Size(75, 23);
            BtnNext.TabIndex = 0;
            BtnNext.Text = "Dalej";
            BtnNext.UseVisualStyleBackColor = true;
            BtnNext.Click += button1_Click;
            // 
            // classSelectPanel
            // 
            classSelectPanel.BorderStyle = BorderStyle.FixedSingle;
            classSelectPanel.Controls.Add(textTest);
            classSelectPanel.Controls.Add(groupBox1);
            classSelectPanel.Controls.Add(boxStats);
            classSelectPanel.Location = new Point(12, 27);
            classSelectPanel.Name = "classSelectPanel";
            classSelectPanel.Size = new Size(776, 372);
            classSelectPanel.TabIndex = 2;
            classSelectPanel.Paint += panel1_Paint;
            // 
            // textTest
            // 
            textTest.Location = new Point(453, 10);
            textTest.Name = "textTest";
            textTest.Size = new Size(305, 342);
            textTest.TabIndex = 34;
            textTest.Text = " ";
            textTest.TextChanged += textTest_TextChanged;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(textClassOpis);
            groupBox1.Controls.Add(lblImie);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(lblRasa);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(lblKlasa);
            groupBox1.Controls.Add(comboBoxRaces);
            groupBox1.Controls.Add(richTextBox1);
            groupBox1.Controls.Add(cbClassName);
            groupBox1.Location = new Point(3, 10);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(378, 353);
            groupBox1.TabIndex = 33;
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter_1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(6, 29);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 23;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textClassOpis
            // 
            textClassOpis.Location = new Point(6, 264);
            textClassOpis.Name = "textClassOpis";
            textClassOpis.Size = new Size(358, 61);
            textClassOpis.TabIndex = 32;
            textClassOpis.Text = "";
            // 
            // lblImie
            // 
            lblImie.AutoSize = true;
            lblImie.Location = new Point(6, 11);
            lblImie.Name = "lblImie";
            lblImie.Size = new Size(30, 15);
            lblImie.TabIndex = 19;
            lblImie.Text = "Imię";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 243);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 31;
            label4.Text = "Opis:";
            // 
            // lblRasa
            // 
            lblRasa.AutoSize = true;
            lblRasa.Location = new Point(6, 63);
            lblRasa.Name = "lblRasa";
            lblRasa.Size = new Size(31, 15);
            lblRasa.TabIndex = 20;
            lblRasa.Text = "Rasa";
            lblRasa.Click += lblRasa_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 109);
            label3.Name = "label3";
            label3.Size = new Size(34, 15);
            label3.TabIndex = 30;
            label3.Text = "Opis:";
            // 
            // lblKlasa
            // 
            lblKlasa.AutoSize = true;
            lblKlasa.Location = new Point(6, 199);
            lblKlasa.Name = "lblKlasa";
            lblKlasa.Size = new Size(34, 15);
            lblKlasa.TabIndex = 21;
            lblKlasa.Text = "Klasa";
            // 
            // comboBoxRaces
            // 
            comboBoxRaces.FormattingEnabled = true;
            comboBoxRaces.Location = new Point(6, 81);
            comboBoxRaces.Name = "comboBoxRaces";
            comboBoxRaces.Size = new Size(121, 23);
            comboBoxRaces.TabIndex = 24;
            comboBoxRaces.SelectedIndexChanged += comboBoxRaces_SelectedIndexChanged;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(6, 127);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(358, 56);
            richTextBox1.TabIndex = 27;
            richTextBox1.Text = "";
            richTextBox1.TextChanged += richTextBox1_TextChanged;
            // 
            // cbClassName
            // 
            cbClassName.FormattingEnabled = true;
            cbClassName.Location = new Point(6, 217);
            cbClassName.Name = "cbClassName";
            cbClassName.Size = new Size(121, 23);
            cbClassName.TabIndex = 25;
            cbClassName.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // boxStats
            // 
            boxStats.Controls.Add(txtBoxSTR);
            boxStats.Controls.Add(label1);
            boxStats.Controls.Add(label2);
            boxStats.Controls.Add(label5);
            boxStats.Controls.Add(label7);
            boxStats.Controls.Add(label9);
            boxStats.Controls.Add(label11);
            boxStats.Controls.Add(txtBoxDEX);
            boxStats.Controls.Add(txtBoxWIS);
            boxStats.Controls.Add(btnRollAll);
            boxStats.Controls.Add(txtBoxCON);
            boxStats.Controls.Add(txtBoxINT);
            boxStats.Controls.Add(txtBoxCHA);
            boxStats.Enabled = false;
            boxStats.Location = new Point(398, 3);
            boxStats.Name = "boxStats";
            boxStats.Size = new Size(39, 360);
            boxStats.TabIndex = 29;
            boxStats.TabStop = false;
            boxStats.Enter += groupBox1_Enter;
            // 
            // txtBoxSTR
            // 
            txtBoxSTR.Location = new Point(4, 7);
            txtBoxSTR.MaxLength = 2;
            txtBoxSTR.Name = "txtBoxSTR";
            txtBoxSTR.Size = new Size(30, 23);
            txtBoxSTR.TabIndex = 12;
            txtBoxSTR.Text = "0";
            txtBoxSTR.TextAlign = HorizontalAlignment.Center;
            txtBoxSTR.TextChanged += textBox2_TextChanged;
            // 
            // label1
            // 
            label1.AccessibleRole = AccessibleRole.None;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label1.Location = new Point(4, 33);
            label1.Name = "label1";
            label1.Size = new Size(30, 16);
            label1.TabIndex = 0;
            label1.Text = "STR";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AccessibleRole = AccessibleRole.None;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label2.Location = new Point(4, 88);
            label2.Name = "label2";
            label2.Size = new Size(30, 16);
            label2.TabIndex = 2;
            label2.Text = "DEX";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            label2.Click += label3_Click;
            // 
            // label5
            // 
            label5.AccessibleRole = AccessibleRole.None;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label5.Location = new Point(4, 143);
            label5.Name = "label5";
            label5.Size = new Size(30, 16);
            label5.TabIndex = 4;
            label5.Text = "WIS";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            label5.Click += label5_Click;
            // 
            // label7
            // 
            label7.AccessibleRole = AccessibleRole.None;
            label7.FlatStyle = FlatStyle.Flat;
            label7.Font = new Font("Segoe UI", 7F, FontStyle.Bold);
            label7.Location = new Point(4, 198);
            label7.Name = "label7";
            label7.Size = new Size(30, 16);
            label7.TabIndex = 6;
            label7.Text = "CON";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            label7.Click += label7_Click;
            // 
            // label9
            // 
            label9.AccessibleRole = AccessibleRole.None;
            label9.FlatStyle = FlatStyle.Flat;
            label9.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label9.Location = new Point(4, 254);
            label9.Name = "label9";
            label9.Size = new Size(30, 16);
            label9.TabIndex = 8;
            label9.Text = "CHA";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            label9.Click += label9_Click;
            // 
            // label11
            // 
            label11.AccessibleRole = AccessibleRole.None;
            label11.FlatStyle = FlatStyle.Flat;
            label11.Font = new Font("Segoe UI", 8F, FontStyle.Bold);
            label11.Location = new Point(4, 309);
            label11.Name = "label11";
            label11.Size = new Size(30, 16);
            label11.TabIndex = 10;
            label11.Text = "INT";
            label11.TextAlign = ContentAlignment.MiddleCenter;
            label11.Click += label11_Click;
            // 
            // txtBoxDEX
            // 
            txtBoxDEX.Location = new Point(4, 62);
            txtBoxDEX.MaxLength = 2;
            txtBoxDEX.Name = "txtBoxDEX";
            txtBoxDEX.Size = new Size(30, 23);
            txtBoxDEX.TabIndex = 13;
            txtBoxDEX.Text = "0";
            txtBoxDEX.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxWIS
            // 
            txtBoxWIS.Location = new Point(4, 117);
            txtBoxWIS.MaxLength = 2;
            txtBoxWIS.Name = "txtBoxWIS";
            txtBoxWIS.Size = new Size(30, 23);
            txtBoxWIS.TabIndex = 14;
            txtBoxWIS.Text = "0";
            txtBoxWIS.TextAlign = HorizontalAlignment.Center;
            txtBoxWIS.TextChanged += textBox3_TextChanged;
            // 
            // btnRollAll
            // 
            btnRollAll.Location = new Point(0, 328);
            btnRollAll.Name = "btnRollAll";
            btnRollAll.Size = new Size(39, 23);
            btnRollAll.TabIndex = 18;
            btnRollAll.Text = "Roll";
            btnRollAll.UseVisualStyleBackColor = true;
            btnRollAll.Click += btnRollAll_Click;
            // 
            // txtBoxCON
            // 
            txtBoxCON.Location = new Point(4, 172);
            txtBoxCON.MaxLength = 2;
            txtBoxCON.Name = "txtBoxCON";
            txtBoxCON.Size = new Size(30, 23);
            txtBoxCON.TabIndex = 15;
            txtBoxCON.Text = "0";
            txtBoxCON.TextAlign = HorizontalAlignment.Center;
            txtBoxCON.TextChanged += textBox4_TextChanged;
            // 
            // txtBoxINT
            // 
            txtBoxINT.Location = new Point(4, 283);
            txtBoxINT.MaxLength = 2;
            txtBoxINT.Name = "txtBoxINT";
            txtBoxINT.Size = new Size(30, 23);
            txtBoxINT.TabIndex = 17;
            txtBoxINT.Text = "0";
            txtBoxINT.TextAlign = HorizontalAlignment.Center;
            // 
            // txtBoxCHA
            // 
            txtBoxCHA.Location = new Point(4, 228);
            txtBoxCHA.MaxLength = 2;
            txtBoxCHA.Name = "txtBoxCHA";
            txtBoxCHA.Size = new Size(30, 23);
            txtBoxCHA.TabIndex = 16;
            txtBoxCHA.Text = "0";
            txtBoxCHA.TextAlign = HorizontalAlignment.Center;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { graczToolStripMenuItem, nPCToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // graczToolStripMenuItem
            // 
            graczToolStripMenuItem.Name = "graczToolStripMenuItem";
            graczToolStripMenuItem.Size = new Size(48, 20);
            graczToolStripMenuItem.Text = "Gracz";
            graczToolStripMenuItem.Click += graczToolStripMenuItem_Click;
            // 
            // nPCToolStripMenuItem
            // 
            nPCToolStripMenuItem.Name = "nPCToolStripMenuItem";
            nPCToolStripMenuItem.Size = new Size(43, 20);
            nPCToolStripMenuItem.Text = "NPC";
            // 
            // btnSaveToJSON
            // 
            btnSaveToJSON.Location = new Point(559, 405);
            btnSaveToJSON.Name = "btnSaveToJSON";
            btnSaveToJSON.Size = new Size(124, 23);
            btnSaveToJSON.TabIndex = 5;
            btnSaveToJSON.Text = "ZAPISZ DO JSON";
            btnSaveToJSON.UseVisualStyleBackColor = true;
            btnSaveToJSON.Click += button1_Click_2;
            // 
            // btnInteract
            // 
            btnInteract.Location = new Point(195, 405);
            btnInteract.Name = "btnInteract";
            btnInteract.Size = new Size(142, 23);
            btnInteract.TabIndex = 6;
            btnInteract.Text = "Interakcja Interfejs";
            btnInteract.UseVisualStyleBackColor = true;
            btnInteract.Click += button2_Click;
            // 
            // btnLinQ
            // 
            btnLinQ.Location = new Point(411, 405);
            btnLinQ.Name = "btnLinQ";
            btnLinQ.Size = new Size(75, 23);
            btnLinQ.TabIndex = 7;
            btnLinQ.Text = "LINQ";
            btnLinQ.UseVisualStyleBackColor = true;
            btnLinQ.Click += button1_Click_3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnLinQ);
            Controls.Add(btnInteract);
            Controls.Add(btnSaveToJSON);
            Controls.Add(classSelectPanel);
            Controls.Add(BtnNext);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            classSelectPanel.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            boxStats.ResumeLayout(false);
            boxStats.PerformLayout();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnNext;
        private Panel classSelectPanel;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem graczToolStripMenuItem;
        private ToolStripMenuItem nPCToolStripMenuItem;
        private Label label11;
        private Label label9;
        private Label label7;
        private Label label5;
        private TextBox txtBoxINT;
        private TextBox txtBoxCHA;
        private TextBox txtBoxCON;
        private Button btnRollAll;
        private Label lblImie;
        private Label lblKlasa;
        private Label lblRasa;
        private RichTextBox richTextBox1;
        private ComboBox cbClassName;
        private ComboBox comboBoxRaces;
        private TextBox textBox1;
        private TextBox txtBoxWIS;
        private TextBox txtBoxDEX;
        private TextBox txtBoxSTR;
        private Label label2;
        private Label label1;
        private GroupBox boxStats;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private RichTextBox textClassOpis;
        private Label label4;
        private Label label3;
        private GroupBox groupBox1;
        private RichTextBox textTest;
        private Button btnSaveToJSON;
        private Button btnInteract;
        private Button btnLinQ;
    }
}
