
using System.Diagnostics;
using System;
using System.Xml.Linq;
using System.Windows.Forms;
using System.Collections;
using System.Drawing;
using Microsoft.VisualBasic;
using System.Data;
using System.Collections.Generic;
using System.Linq;



namespace Grading_System
{
	[global::Microsoft.VisualBasic.CompilerServices.DesignerGenerated()]public partial class Form1 : System.Windows.Forms.Form
	{
		
		//Form overrides dispose to clean up the component list.
		[System.Diagnostics.DebuggerNonUserCode()]protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

        //Required by the Windows Form Designer
		
		//NOTE: The following procedure is required by the Windows Form Designer
		//It can be modified using the Windows Form Designer.
		//Do not modify it using the code editor.
		[System.Diagnostics.DebuggerStepThrough()]private void InitializeComponent()
		{
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Label1 = new System.Windows.Forms.Label();
            this.TextBox1 = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.TextBox2 = new System.Windows.Forms.TextBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.TextBox5 = new System.Windows.Forms.TextBox();
            this.TextBox4 = new System.Windows.Forms.TextBox();
            this.TextBox3 = new System.Windows.Forms.TextBox();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.TextBox9 = new System.Windows.Forms.TextBox();
            this.TextBox11 = new System.Windows.Forms.TextBox();
            this.TextBox10 = new System.Windows.Forms.TextBox();
            this.GroupBox4 = new System.Windows.Forms.GroupBox();
            this.Label6 = new System.Windows.Forms.Label();
            this.TextBox12 = new System.Windows.Forms.TextBox();
            this.TextBox14 = new System.Windows.Forms.TextBox();
            this.TextBox13 = new System.Windows.Forms.TextBox();
            this.GroupBox5 = new System.Windows.Forms.GroupBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.TextBox15 = new System.Windows.Forms.TextBox();
            this.TextBox17 = new System.Windows.Forms.TextBox();
            this.TextBox16 = new System.Windows.Forms.TextBox();
            this.GroupBox6 = new System.Windows.Forms.GroupBox();
            this.TextBox18 = new System.Windows.Forms.TextBox();
            this.Label9 = new System.Windows.Forms.Label();
            this.TextBox19 = new System.Windows.Forms.TextBox();
            this.Label8 = new System.Windows.Forms.Label();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.TextBox8 = new System.Windows.Forms.TextBox();
            this.TextBox6 = new System.Windows.Forms.TextBox();
            this.TextBox7 = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.Label10 = new System.Windows.Forms.Label();
            this.Button3 = new System.Windows.Forms.Button();
            this.Label11 = new System.Windows.Forms.Label();
            this.Panel1 = new System.Windows.Forms.Panel();
            this.Button4 = new System.Windows.Forms.Button();
            this.Button5 = new System.Windows.Forms.Button();
            this.Button6 = new System.Windows.Forms.Button();
            this.FRST = new System.Windows.Forms.Button();
            this.NXT = new System.Windows.Forms.Button();
            this.LAST = new System.Windows.Forms.Button();
            this.PREV = new System.Windows.Forms.Button();
            this.Button11 = new System.Windows.Forms.Button();
            this.Button7 = new System.Windows.Forms.Button();
            this.STUDID = new System.Windows.Forms.TextBox();
            this.Label12 = new System.Windows.Forms.Label();
            this.ToolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.GroupBox1.SuspendLayout();
            this.GroupBox3.SuspendLayout();
            this.GroupBox4.SuspendLayout();
            this.GroupBox5.SuspendLayout();
            this.GroupBox6.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Button1
            // 
            this.Button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.Green;
            this.Button1.Location = new System.Drawing.Point(90, 308);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(84, 27);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "C&ompute";
            this.ToolTip1.SetToolTip(this.Button1, "COMPUTE GRADES\r\n    Automatically compute all the \r\ngrades of specefic students.");
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.ForeColor = System.Drawing.Color.Maroon;
            this.Button2.Location = new System.Drawing.Point(851, 564);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(107, 36);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "&Exit Program";
            this.ToolTip1.SetToolTip(this.Button2, "EXIT PROGRAM");
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.Green;
            this.Label1.Location = new System.Drawing.Point(24, 74);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(80, 16);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Firstname:";
            // 
            // TextBox1
            // 
            this.TextBox1.Location = new System.Drawing.Point(101, 71);
            this.TextBox1.Name = "TextBox1";
            this.TextBox1.Size = new System.Drawing.Size(144, 20);
            this.TextBox1.TabIndex = 3;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.Color.Green;
            this.Label2.Location = new System.Drawing.Point(258, 73);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 16);
            this.Label2.TabIndex = 4;
            this.Label2.Text = "Lastname:";
            // 
            // TextBox2
            // 
            this.TextBox2.Location = new System.Drawing.Point(336, 70);
            this.TextBox2.Name = "TextBox2";
            this.TextBox2.Size = new System.Drawing.Size(155, 20);
            this.TextBox2.TabIndex = 6;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.Label3);
            this.GroupBox1.Controls.Add(this.TextBox5);
            this.GroupBox1.Controls.Add(this.TextBox4);
            this.GroupBox1.Controls.Add(this.TextBox3);
            this.GroupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox1.Location = new System.Drawing.Point(12, 102);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(228, 51);
            this.GroupBox1.TabIndex = 7;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "Attendance        20            EG         10%";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.Color.Green;
            this.Label3.Location = new System.Drawing.Point(14, 22);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(48, 15);
            this.Label3.TabIndex = 10;
            this.Label3.Text = "Score:";
            // 
            // TextBox5
            // 
            this.TextBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox5.Location = new System.Drawing.Point(168, 19);
            this.TextBox5.Name = "TextBox5";
            this.TextBox5.ReadOnly = true;
            this.TextBox5.Size = new System.Drawing.Size(46, 21);
            this.TextBox5.TabIndex = 12;
            // 
            // TextBox4
            // 
            this.TextBox4.AcceptsTab = true;
            this.TextBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox4.Location = new System.Drawing.Point(116, 19);
            this.TextBox4.Name = "TextBox4";
            this.TextBox4.ReadOnly = true;
            this.TextBox4.Size = new System.Drawing.Size(46, 21);
            this.TextBox4.TabIndex = 11;
            // 
            // TextBox3
            // 
            this.TextBox3.Location = new System.Drawing.Point(64, 19);
            this.TextBox3.Name = "TextBox3";
            this.TextBox3.Size = new System.Drawing.Size(46, 21);
            this.TextBox3.TabIndex = 3;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.Label5);
            this.GroupBox3.Controls.Add(this.TextBox9);
            this.GroupBox3.Controls.Add(this.TextBox11);
            this.GroupBox3.Controls.Add(this.TextBox10);
            this.GroupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(12, 225);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Size = new System.Drawing.Size(228, 62);
            this.GroupBox3.TabIndex = 8;
            this.GroupBox3.TabStop = false;
            this.GroupBox3.Text = "Practical Quiz    50            EG         20%";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.ForeColor = System.Drawing.Color.Green;
            this.Label5.Location = new System.Drawing.Point(14, 22);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(48, 15);
            this.Label5.TabIndex = 18;
            this.Label5.Text = "Score:";
            // 
            // TextBox9
            // 
            this.TextBox9.Location = new System.Drawing.Point(64, 19);
            this.TextBox9.Name = "TextBox9";
            this.TextBox9.Size = new System.Drawing.Size(47, 21);
            this.TextBox9.TabIndex = 5;
            // 
            // TextBox11
            // 
            this.TextBox11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox11.Location = new System.Drawing.Point(169, 19);
            this.TextBox11.Name = "TextBox11";
            this.TextBox11.ReadOnly = true;
            this.TextBox11.Size = new System.Drawing.Size(46, 21);
            this.TextBox11.TabIndex = 19;
            // 
            // TextBox10
            // 
            this.TextBox10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox10.Location = new System.Drawing.Point(117, 19);
            this.TextBox10.Name = "TextBox10";
            this.TextBox10.ReadOnly = true;
            this.TextBox10.Size = new System.Drawing.Size(46, 21);
            this.TextBox10.TabIndex = 20;
            // 
            // GroupBox4
            // 
            this.GroupBox4.Controls.Add(this.Label6);
            this.GroupBox4.Controls.Add(this.TextBox12);
            this.GroupBox4.Controls.Add(this.TextBox14);
            this.GroupBox4.Controls.Add(this.TextBox13);
            this.GroupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox4.Location = new System.Drawing.Point(265, 102);
            this.GroupBox4.Name = "GroupBox4";
            this.GroupBox4.Size = new System.Drawing.Size(228, 51);
            this.GroupBox4.TabIndex = 8;
            this.GroupBox4.TabStop = false;
            this.GroupBox4.Text = "Project              100            EG         30%";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.ForeColor = System.Drawing.Color.Green;
            this.Label6.Location = new System.Drawing.Point(15, 22);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(48, 15);
            this.Label6.TabIndex = 22;
            this.Label6.Text = "Score:";
            // 
            // TextBox12
            // 
            this.TextBox12.Location = new System.Drawing.Point(65, 19);
            this.TextBox12.Name = "TextBox12";
            this.TextBox12.Size = new System.Drawing.Size(46, 21);
            this.TextBox12.TabIndex = 6;
            // 
            // TextBox14
            // 
            this.TextBox14.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox14.Location = new System.Drawing.Point(169, 19);
            this.TextBox14.Name = "TextBox14";
            this.TextBox14.ReadOnly = true;
            this.TextBox14.Size = new System.Drawing.Size(46, 21);
            this.TextBox14.TabIndex = 24;
            // 
            // TextBox13
            // 
            this.TextBox13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox13.Location = new System.Drawing.Point(117, 19);
            this.TextBox13.Name = "TextBox13";
            this.TextBox13.ReadOnly = true;
            this.TextBox13.Size = new System.Drawing.Size(46, 21);
            this.TextBox13.TabIndex = 23;
            // 
            // GroupBox5
            // 
            this.GroupBox5.Controls.Add(this.Label7);
            this.GroupBox5.Controls.Add(this.TextBox15);
            this.GroupBox5.Controls.Add(this.TextBox17);
            this.GroupBox5.Controls.Add(this.TextBox16);
            this.GroupBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox5.Location = new System.Drawing.Point(265, 159);
            this.GroupBox5.Name = "GroupBox5";
            this.GroupBox5.Size = new System.Drawing.Size(228, 57);
            this.GroupBox5.TabIndex = 8;
            this.GroupBox5.TabStop = false;
            this.GroupBox5.Text = "Prelim Exam   100             EG        30%";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.ForeColor = System.Drawing.Color.Green;
            this.Label7.Location = new System.Drawing.Point(15, 22);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(48, 15);
            this.Label7.TabIndex = 26;
            this.Label7.Text = "Score:";
            // 
            // TextBox15
            // 
            this.TextBox15.Location = new System.Drawing.Point(65, 19);
            this.TextBox15.Name = "TextBox15";
            this.TextBox15.Size = new System.Drawing.Size(46, 21);
            this.TextBox15.TabIndex = 7;
            // 
            // TextBox17
            // 
            this.TextBox17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox17.Location = new System.Drawing.Point(174, 19);
            this.TextBox17.Name = "TextBox17";
            this.TextBox17.ReadOnly = true;
            this.TextBox17.Size = new System.Drawing.Size(46, 21);
            this.TextBox17.TabIndex = 27;
            // 
            // TextBox16
            // 
            this.TextBox16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox16.Location = new System.Drawing.Point(119, 19);
            this.TextBox16.Name = "TextBox16";
            this.TextBox16.ReadOnly = true;
            this.TextBox16.Size = new System.Drawing.Size(46, 21);
            this.TextBox16.TabIndex = 28;
            // 
            // GroupBox6
            // 
            this.GroupBox6.Controls.Add(this.TextBox18);
            this.GroupBox6.Controls.Add(this.Label9);
            this.GroupBox6.Controls.Add(this.TextBox19);
            this.GroupBox6.Controls.Add(this.Label8);
            this.GroupBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox6.Location = new System.Drawing.Point(265, 222);
            this.GroupBox6.Name = "GroupBox6";
            this.GroupBox6.Size = new System.Drawing.Size(228, 75);
            this.GroupBox6.TabIndex = 9;
            this.GroupBox6.TabStop = false;
            this.GroupBox6.Text = "PRELIM COMPUTED";
            // 
            // TextBox18
            // 
            this.TextBox18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox18.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox18.Location = new System.Drawing.Point(19, 41);
            this.TextBox18.Name = "TextBox18";
            this.TextBox18.ReadOnly = true;
            this.TextBox18.Size = new System.Drawing.Size(87, 24);
            this.TextBox18.TabIndex = 29;
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.ForeColor = System.Drawing.Color.Green;
            this.Label9.Location = new System.Drawing.Point(116, 22);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(68, 15);
            this.Label9.TabIndex = 30;
            this.Label9.Text = "Remarks:";
            // 
            // TextBox19
            // 
            this.TextBox19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox19.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox19.Location = new System.Drawing.Point(119, 41);
            this.TextBox19.Name = "TextBox19";
            this.TextBox19.ReadOnly = true;
            this.TextBox19.Size = new System.Drawing.Size(98, 24);
            this.TextBox19.TabIndex = 30;
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.ForeColor = System.Drawing.Color.Green;
            this.Label8.Location = new System.Drawing.Point(16, 22);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(96, 15);
            this.Label8.TabIndex = 29;
            this.Label8.Text = "Prelim Grade:";
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.Label4);
            this.GroupBox2.Controls.Add(this.TextBox8);
            this.GroupBox2.Controls.Add(this.TextBox6);
            this.GroupBox2.Controls.Add(this.TextBox7);
            this.GroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(12, 159);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(228, 57);
            this.GroupBox2.TabIndex = 8;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Writtten Quiz      50            EG        10%";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.Color.Green;
            this.Label4.Location = new System.Drawing.Point(14, 22);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(48, 15);
            this.Label4.TabIndex = 14;
            this.Label4.Text = "Score:";
            // 
            // TextBox8
            // 
            this.TextBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox8.Location = new System.Drawing.Point(168, 19);
            this.TextBox8.Name = "TextBox8";
            this.TextBox8.ReadOnly = true;
            this.TextBox8.Size = new System.Drawing.Size(46, 21);
            this.TextBox8.TabIndex = 13;
            // 
            // TextBox6
            // 
            this.TextBox6.Location = new System.Drawing.Point(64, 19);
            this.TextBox6.Name = "TextBox6";
            this.TextBox6.Size = new System.Drawing.Size(46, 21);
            this.TextBox6.TabIndex = 4;
            // 
            // TextBox7
            // 
            this.TextBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox7.Location = new System.Drawing.Point(116, 19);
            this.TextBox7.Name = "TextBox7";
            this.TextBox7.ReadOnly = true;
            this.TextBox7.Size = new System.Drawing.Size(46, 21);
            this.TextBox7.TabIndex = 15;
            // 
            // DataGridView1
            // 
            this.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridView1.Location = new System.Drawing.Point(7, 341);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DataGridView1.RowHeadersWidth = 15;
            this.DataGridView1.Size = new System.Drawing.Size(838, 269);
            this.DataGridView1.TabIndex = 10;
            this.DataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellDoubleClick);
            // 
            // Label10
            // 
            this.Label10.AutoSize = true;
            this.Label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label10.Location = new System.Drawing.Point(780, 319);
            this.Label10.Name = "Label10";
            this.Label10.Size = new System.Drawing.Size(65, 18);
            this.Label10.TabIndex = 11;
            this.Label10.Text = "Results";
            // 
            // Button3
            // 
            this.Button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button3.ForeColor = System.Drawing.Color.Green;
            this.Button3.Location = new System.Drawing.Point(13, 308);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(71, 27);
            this.Button3.TabIndex = 12;
            this.Button3.Text = "&Clear All";
            this.ToolTip1.SetToolTip(this.Button3, "CLEAR ALL\r\nAllows you to erase all the current details \r\nthat can be found in all" +
        " textbox.");
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Label11
            // 
            this.Label11.AutoSize = true;
            this.Label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label11.ForeColor = System.Drawing.Color.Green;
            this.Label11.Location = new System.Drawing.Point(330, 8);
            this.Label11.Name = "Label11";
            this.Label11.Size = new System.Drawing.Size(347, 29);
            this.Label11.TabIndex = 13;
            this.Label11.Text = "STUDENT GRADE RECORD";
            // 
            // Panel1
            // 
            this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel1.Controls.Add(this.Label11);
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panel1.Location = new System.Drawing.Point(0, 0);
            this.Panel1.Name = "Panel1";
            this.Panel1.Size = new System.Drawing.Size(963, 39);
            this.Panel1.TabIndex = 14;
            // 
            // Button4
            // 
            this.Button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button4.ForeColor = System.Drawing.Color.Green;
            this.Button4.Location = new System.Drawing.Point(180, 309);
            this.Button4.Name = "Button4";
            this.Button4.Size = new System.Drawing.Size(96, 27);
            this.Button4.TabIndex = 15;
            this.Button4.Text = "Save";
            this.ToolTip1.SetToolTip(this.Button4, "SAVE RECORD\r\n    It allow\'s the user to save the new record.");
            this.Button4.UseVisualStyleBackColor = true;
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // Button5
            // 
            this.Button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button5.ForeColor = System.Drawing.Color.Green;
            this.Button5.Location = new System.Drawing.Point(851, 342);
            this.Button5.Name = "Button5";
            this.Button5.Size = new System.Drawing.Size(107, 26);
            this.Button5.TabIndex = 16;
            this.Button5.Text = "&Load Students";
            this.ToolTip1.SetToolTip(this.Button5, "LOAD STUDENTS\r\n    It loads all the student information in the datagridview.\r\nAnd" +
        " the user\'s are allow to view specefic student\'s data by\r\ndouble clicking the ce" +
        "lls.");
            this.Button5.UseVisualStyleBackColor = true;
            this.Button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // Button6
            // 
            this.Button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button6.ForeColor = System.Drawing.Color.Green;
            this.Button6.Location = new System.Drawing.Point(851, 379);
            this.Button6.Name = "Button6";
            this.Button6.Size = new System.Drawing.Size(107, 26);
            this.Button6.TabIndex = 17;
            this.Button6.Text = "Show Details";
            this.ToolTip1.SetToolTip(this.Button6, "SHOW DETAILS\r\n     Let\'s you to view the current detail of the specefic \r\nstudent" +
        " you selected in the datagridview.");
            this.Button6.UseVisualStyleBackColor = true;
            this.Button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // FRST
            // 
            this.FRST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRST.ForeColor = System.Drawing.Color.Green;
            this.FRST.Location = new System.Drawing.Point(851, 457);
            this.FRST.Name = "FRST";
            this.FRST.Size = new System.Drawing.Size(107, 26);
            this.FRST.TabIndex = 18;
            this.FRST.Text = "First";
            this.ToolTip1.SetToolTip(this.FRST, "FIRST RECORD");
            this.FRST.UseVisualStyleBackColor = true;
            this.FRST.Click += new System.EventHandler(this.FRST_Click);
            // 
            // NXT
            // 
            this.NXT.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NXT.ForeColor = System.Drawing.Color.Green;
            this.NXT.Location = new System.Drawing.Point(851, 418);
            this.NXT.Name = "NXT";
            this.NXT.Size = new System.Drawing.Size(107, 26);
            this.NXT.TabIndex = 19;
            this.NXT.Text = "Next";
            this.ToolTip1.SetToolTip(this.NXT, "NEXT");
            this.NXT.UseVisualStyleBackColor = true;
            this.NXT.Click += new System.EventHandler(this.NXT_Click);
            // 
            // LAST
            // 
            this.LAST.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LAST.ForeColor = System.Drawing.Color.Green;
            this.LAST.Location = new System.Drawing.Point(851, 497);
            this.LAST.Name = "LAST";
            this.LAST.Size = new System.Drawing.Size(107, 26);
            this.LAST.TabIndex = 20;
            this.LAST.Text = "Last";
            this.ToolTip1.SetToolTip(this.LAST, "LAST RECORD");
            this.LAST.UseVisualStyleBackColor = true;
            this.LAST.Click += new System.EventHandler(this.LAST_Click);
            // 
            // PREV
            // 
            this.PREV.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PREV.ForeColor = System.Drawing.Color.Green;
            this.PREV.Location = new System.Drawing.Point(851, 532);
            this.PREV.Name = "PREV";
            this.PREV.Size = new System.Drawing.Size(107, 26);
            this.PREV.TabIndex = 21;
            this.PREV.Text = "Previous";
            this.ToolTip1.SetToolTip(this.PREV, "PREVIOUS");
            this.PREV.UseVisualStyleBackColor = true;
            this.PREV.Click += new System.EventHandler(this.PREV_Click);
            // 
            // Button11
            // 
            this.Button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button11.ForeColor = System.Drawing.Color.Green;
            this.Button11.Location = new System.Drawing.Point(396, 309);
            this.Button11.Name = "Button11";
            this.Button11.Size = new System.Drawing.Size(97, 27);
            this.Button11.TabIndex = 22;
            this.Button11.Text = "Delete";
            this.ToolTip1.SetToolTip(this.Button11, "DELETE RECORD\r\n     It delete the any unnecessary record.");
            this.Button11.UseVisualStyleBackColor = true;
            this.Button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // Button7
            // 
            this.Button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button7.ForeColor = System.Drawing.Color.Green;
            this.Button7.Location = new System.Drawing.Point(283, 309);
            this.Button7.Name = "Button7";
            this.Button7.Size = new System.Drawing.Size(107, 28);
            this.Button7.TabIndex = 23;
            this.Button7.Text = "Update";
            this.ToolTip1.SetToolTip(this.Button7, "UPDATE RECORD\r\n     It allows you to upadate any changes\r\nyou made to the current" +
        " record.");
            this.Button7.UseVisualStyleBackColor = true;
            this.Button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // STUDID
            // 
            this.STUDID.Location = new System.Drawing.Point(219, 45);
            this.STUDID.Name = "STUDID";
            this.STUDID.Size = new System.Drawing.Size(198, 20);
            this.STUDID.TabIndex = 25;
            // 
            // Label12
            // 
            this.Label12.AutoSize = true;
            this.Label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label12.Location = new System.Drawing.Point(109, 46);
            this.Label12.Name = "Label12";
            this.Label12.Size = new System.Drawing.Size(104, 16);
            this.Label12.TabIndex = 24;
            this.Label12.Text = "STUDENT ID:";
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(499, 46);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 270);
            this.panel2.TabIndex = 26;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(963, 613);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.STUDID);
            this.Controls.Add(this.Label12);
            this.Controls.Add(this.Button7);
            this.Controls.Add(this.Button11);
            this.Controls.Add(this.PREV);
            this.Controls.Add(this.LAST);
            this.Controls.Add(this.NXT);
            this.Controls.Add(this.FRST);
            this.Controls.Add(this.Button6);
            this.Controls.Add(this.Button5);
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Button3);
            this.Controls.Add(this.Label10);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.GroupBox6);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox4);
            this.Controls.Add(this.GroupBox5);
            this.Controls.Add(this.GroupBox1);
            this.Controls.Add(this.TextBox2);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.TextBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Button2);
            this.Controls.Add(this.Button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.Name = "Form1";
            this.Text = "Grading System";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox3.PerformLayout();
            this.GroupBox4.ResumeLayout(false);
            this.GroupBox4.PerformLayout();
            this.GroupBox5.ResumeLayout(false);
            this.GroupBox5.PerformLayout();
            this.GroupBox6.ResumeLayout(false);
            this.GroupBox6.PerformLayout();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            this.Panel1.ResumeLayout(false);
            this.Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

		}
		internal System.Windows.Forms.Button Button1;
		internal System.Windows.Forms.Button Button2;
		internal System.Windows.Forms.Label Label1;
		internal System.Windows.Forms.TextBox TextBox1;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox TextBox2;
		internal System.Windows.Forms.GroupBox GroupBox1;
		internal System.Windows.Forms.GroupBox GroupBox3;
		internal System.Windows.Forms.GroupBox GroupBox4;
		internal System.Windows.Forms.GroupBox GroupBox5;
		internal System.Windows.Forms.GroupBox GroupBox6;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.TextBox TextBox5;
		internal System.Windows.Forms.TextBox TextBox4;
		internal System.Windows.Forms.TextBox TextBox3;
		internal System.Windows.Forms.GroupBox GroupBox2;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.TextBox TextBox8;
		internal System.Windows.Forms.TextBox TextBox6;
		internal System.Windows.Forms.TextBox TextBox7;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox TextBox9;
		internal System.Windows.Forms.TextBox TextBox11;
		internal System.Windows.Forms.TextBox TextBox10;
		internal System.Windows.Forms.Label Label6;
		internal System.Windows.Forms.TextBox TextBox12;
		internal System.Windows.Forms.TextBox TextBox14;
		internal System.Windows.Forms.TextBox TextBox13;
		internal System.Windows.Forms.Label Label7;
		internal System.Windows.Forms.TextBox TextBox15;
		internal System.Windows.Forms.TextBox TextBox17;
		internal System.Windows.Forms.TextBox TextBox16;
		internal System.Windows.Forms.TextBox TextBox18;
		internal System.Windows.Forms.Label Label9;
		internal System.Windows.Forms.TextBox TextBox19;
		internal System.Windows.Forms.Label Label8;
		internal System.Windows.Forms.DataGridView DataGridView1;
		internal System.Windows.Forms.Label Label10;
		internal System.Windows.Forms.Button Button3;
		internal System.Windows.Forms.Label Label11;
		internal System.Windows.Forms.Panel Panel1;
		internal System.Windows.Forms.Button Button4;
		internal System.Windows.Forms.Button Button5;
		internal System.Windows.Forms.Button Button6;
		internal System.Windows.Forms.Button FRST;
		internal System.Windows.Forms.Button NXT;
		internal System.Windows.Forms.Button LAST;
		internal System.Windows.Forms.Button PREV;
		internal System.Windows.Forms.Button Button11;
		internal System.Windows.Forms.Button Button7;
		internal System.Windows.Forms.TextBox STUDID;
		internal System.Windows.Forms.Label Label12;
		internal System.Windows.Forms.ToolTip ToolTip1;
        private System.ComponentModel.IContainer components;
        private Panel panel2;
    }
	
}
