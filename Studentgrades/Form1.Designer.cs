﻿namespace Studentgrades
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
            this.lbl_Marks = new System.Windows.Forms.Label();
            this.lbl_Title = new System.Windows.Forms.Label();
            this.lbl_StudentName = new System.Windows.Forms.Label();
            this.lbl_StudentNumber = new System.Windows.Forms.Label();
            this.lbl_Group = new System.Windows.Forms.Label();
            this.lbl_StudentMarks = new System.Windows.Forms.Label();
            this.lbl_English = new System.Windows.Forms.Label();
            this.lbl_Maths = new System.Windows.Forms.Label();
            this.lbl_Science = new System.Windows.Forms.Label();
            this.lbl_Results = new System.Windows.Forms.Label();
            this.lbl_StudentDetails = new System.Windows.Forms.Label();
            this.lbl_AverageMark = new System.Windows.Forms.Label();
            this.lbl_StudentGrade = new System.Windows.Forms.Label();
            this.txt_StudentName = new System.Windows.Forms.TextBox();
            this.txt_StudentNumber = new System.Windows.Forms.TextBox();
            this.txt_Group = new System.Windows.Forms.TextBox();
            this.txt_English = new System.Windows.Forms.TextBox();
            this.txt_Maths = new System.Windows.Forms.TextBox();
            this.txt_Science = new System.Windows.Forms.TextBox();
            this.txt_StudentDetails = new System.Windows.Forms.TextBox();
            this.txt_AverageMark = new System.Windows.Forms.TextBox();
            this.txt_StudentGrade = new System.Windows.Forms.TextBox();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Marks
            // 
            this.lbl_Marks.AutoSize = true;
            this.lbl_Marks.Location = new System.Drawing.Point(12, 54);
            this.lbl_Marks.Name = "lbl_Marks";
            this.lbl_Marks.Size = new System.Drawing.Size(135, 13);
            this.lbl_Marks.TabIndex = 0;
            this.lbl_Marks.Text = "Please enter student marks";
            // 
            // lbl_Title
            // 
            this.lbl_Title.AutoSize = true;
            this.lbl_Title.Location = new System.Drawing.Point(144, 9);
            this.lbl_Title.Name = "lbl_Title";
            this.lbl_Title.Size = new System.Drawing.Size(81, 13);
            this.lbl_Title.TabIndex = 1;
            this.lbl_Title.Text = "Student Grades";
            // 
            // lbl_StudentName
            // 
            this.lbl_StudentName.AutoSize = true;
            this.lbl_StudentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentName.Location = new System.Drawing.Point(5, 84);
            this.lbl_StudentName.Name = "lbl_StudentName";
            this.lbl_StudentName.Size = new System.Drawing.Size(98, 15);
            this.lbl_StudentName.TabIndex = 2;
            this.lbl_StudentName.Text = "Student Name";
            // 
            // lbl_StudentNumber
            // 
            this.lbl_StudentNumber.AutoSize = true;
            this.lbl_StudentNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentNumber.Location = new System.Drawing.Point(4, 109);
            this.lbl_StudentNumber.Name = "lbl_StudentNumber";
            this.lbl_StudentNumber.Size = new System.Drawing.Size(111, 15);
            this.lbl_StudentNumber.TabIndex = 3;
            this.lbl_StudentNumber.Text = "Student Number";
            // 
            // lbl_Group
            // 
            this.lbl_Group.AutoSize = true;
            this.lbl_Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Group.Location = new System.Drawing.Point(4, 131);
            this.lbl_Group.Name = "lbl_Group";
            this.lbl_Group.Size = new System.Drawing.Size(46, 15);
            this.lbl_Group.TabIndex = 4;
            this.lbl_Group.Text = "Group";
            // 
            // lbl_StudentMarks
            // 
            this.lbl_StudentMarks.AutoSize = true;
            this.lbl_StudentMarks.Location = new System.Drawing.Point(13, 152);
            this.lbl_StudentMarks.Name = "lbl_StudentMarks";
            this.lbl_StudentMarks.Size = new System.Drawing.Size(153, 13);
            this.lbl_StudentMarks.TabIndex = 5;
            this.lbl_StudentMarks.Text = "Please enter the student marks";
            // 
            // lbl_English
            // 
            this.lbl_English.AutoSize = true;
            this.lbl_English.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_English.Location = new System.Drawing.Point(9, 174);
            this.lbl_English.Name = "lbl_English";
            this.lbl_English.Size = new System.Drawing.Size(55, 15);
            this.lbl_English.TabIndex = 6;
            this.lbl_English.Text = "English";
            // 
            // lbl_Maths
            // 
            this.lbl_Maths.AutoSize = true;
            this.lbl_Maths.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Maths.Location = new System.Drawing.Point(10, 200);
            this.lbl_Maths.Name = "lbl_Maths";
            this.lbl_Maths.Size = new System.Drawing.Size(46, 15);
            this.lbl_Maths.TabIndex = 7;
            this.lbl_Maths.Text = "Maths";
            // 
            // lbl_Science
            // 
            this.lbl_Science.AutoSize = true;
            this.lbl_Science.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Science.Location = new System.Drawing.Point(10, 223);
            this.lbl_Science.Name = "lbl_Science";
            this.lbl_Science.Size = new System.Drawing.Size(58, 15);
            this.lbl_Science.TabIndex = 8;
            this.lbl_Science.Text = "Science";
            // 
            // lbl_Results
            // 
            this.lbl_Results.AutoSize = true;
            this.lbl_Results.Location = new System.Drawing.Point(15, 244);
            this.lbl_Results.Name = "lbl_Results";
            this.lbl_Results.Size = new System.Drawing.Size(42, 13);
            this.lbl_Results.TabIndex = 9;
            this.lbl_Results.Text = "Results";
            // 
            // lbl_StudentDetails
            // 
            this.lbl_StudentDetails.AutoSize = true;
            this.lbl_StudentDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentDetails.Location = new System.Drawing.Point(5, 267);
            this.lbl_StudentDetails.Name = "lbl_StudentDetails";
            this.lbl_StudentDetails.Size = new System.Drawing.Size(105, 15);
            this.lbl_StudentDetails.TabIndex = 10;
            this.lbl_StudentDetails.Text = "Student Details";
            // 
            // lbl_AverageMark
            // 
            this.lbl_AverageMark.AutoSize = true;
            this.lbl_AverageMark.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_AverageMark.Location = new System.Drawing.Point(6, 291);
            this.lbl_AverageMark.Name = "lbl_AverageMark";
            this.lbl_AverageMark.Size = new System.Drawing.Size(94, 15);
            this.lbl_AverageMark.TabIndex = 11;
            this.lbl_AverageMark.Text = "Average Mark";
            // 
            // lbl_StudentGrade
            // 
            this.lbl_StudentGrade.AutoSize = true;
            this.lbl_StudentGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentGrade.Location = new System.Drawing.Point(7, 316);
            this.lbl_StudentGrade.Name = "lbl_StudentGrade";
            this.lbl_StudentGrade.Size = new System.Drawing.Size(99, 15);
            this.lbl_StudentGrade.TabIndex = 12;
            this.lbl_StudentGrade.Text = "Student Grade";
            // 
            // txt_StudentName
            // 
            this.txt_StudentName.Location = new System.Drawing.Point(113, 78);
            this.txt_StudentName.Name = "txt_StudentName";
            this.txt_StudentName.Size = new System.Drawing.Size(100, 20);
            this.txt_StudentName.TabIndex = 13;
            // 
            // txt_StudentNumber
            // 
            this.txt_StudentNumber.Location = new System.Drawing.Point(113, 102);
            this.txt_StudentNumber.Name = "txt_StudentNumber";
            this.txt_StudentNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_StudentNumber.TabIndex = 14;
            // 
            // txt_Group
            // 
            this.txt_Group.Location = new System.Drawing.Point(113, 129);
            this.txt_Group.Name = "txt_Group";
            this.txt_Group.Size = new System.Drawing.Size(100, 20);
            this.txt_Group.TabIndex = 15;
            // 
            // txt_English
            // 
            this.txt_English.Location = new System.Drawing.Point(113, 171);
            this.txt_English.Name = "txt_English";
            this.txt_English.Size = new System.Drawing.Size(100, 20);
            this.txt_English.TabIndex = 16;
            // 
            // txt_Maths
            // 
            this.txt_Maths.Location = new System.Drawing.Point(113, 197);
            this.txt_Maths.Name = "txt_Maths";
            this.txt_Maths.Size = new System.Drawing.Size(100, 20);
            this.txt_Maths.TabIndex = 17;
            // 
            // txt_Science
            // 
            this.txt_Science.Location = new System.Drawing.Point(113, 220);
            this.txt_Science.Name = "txt_Science";
            this.txt_Science.Size = new System.Drawing.Size(100, 20);
            this.txt_Science.TabIndex = 18;
            // 
            // txt_StudentDetails
            // 
            this.txt_StudentDetails.Location = new System.Drawing.Point(113, 262);
            this.txt_StudentDetails.Name = "txt_StudentDetails";
            this.txt_StudentDetails.Size = new System.Drawing.Size(100, 20);
            this.txt_StudentDetails.TabIndex = 19;
            // 
            // txt_AverageMark
            // 
            this.txt_AverageMark.Location = new System.Drawing.Point(113, 288);
            this.txt_AverageMark.Name = "txt_AverageMark";
            this.txt_AverageMark.Size = new System.Drawing.Size(100, 20);
            this.txt_AverageMark.TabIndex = 20;
            // 
            // txt_StudentGrade
            // 
            this.txt_StudentGrade.Location = new System.Drawing.Point(113, 313);
            this.txt_StudentGrade.Name = "txt_StudentGrade";
            this.txt_StudentGrade.Size = new System.Drawing.Size(100, 20);
            this.txt_StudentGrade.TabIndex = 21;
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Location = new System.Drawing.Point(321, 244);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(75, 23);
            this.btn_Calculate.TabIndex = 22;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.UseVisualStyleBackColor = true;
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(321, 274);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 23;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(321, 304);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 24;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 345);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.txt_StudentGrade);
            this.Controls.Add(this.txt_AverageMark);
            this.Controls.Add(this.txt_StudentDetails);
            this.Controls.Add(this.txt_Science);
            this.Controls.Add(this.txt_Maths);
            this.Controls.Add(this.txt_English);
            this.Controls.Add(this.txt_Group);
            this.Controls.Add(this.txt_StudentNumber);
            this.Controls.Add(this.txt_StudentName);
            this.Controls.Add(this.lbl_StudentGrade);
            this.Controls.Add(this.lbl_AverageMark);
            this.Controls.Add(this.lbl_StudentDetails);
            this.Controls.Add(this.lbl_Results);
            this.Controls.Add(this.lbl_Science);
            this.Controls.Add(this.lbl_Maths);
            this.Controls.Add(this.lbl_English);
            this.Controls.Add(this.lbl_StudentMarks);
            this.Controls.Add(this.lbl_Group);
            this.Controls.Add(this.lbl_StudentNumber);
            this.Controls.Add(this.lbl_StudentName);
            this.Controls.Add(this.lbl_Title);
            this.Controls.Add(this.lbl_Marks);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Marks;
        private System.Windows.Forms.Label lbl_Title;
        private System.Windows.Forms.Label lbl_StudentName;
        private System.Windows.Forms.Label lbl_StudentNumber;
        private System.Windows.Forms.Label lbl_Group;
        private System.Windows.Forms.Label lbl_StudentMarks;
        private System.Windows.Forms.Label lbl_English;
        private System.Windows.Forms.Label lbl_Maths;
        private System.Windows.Forms.Label lbl_Science;
        private System.Windows.Forms.Label lbl_Results;
        private System.Windows.Forms.Label lbl_StudentDetails;
        private System.Windows.Forms.Label lbl_AverageMark;
        private System.Windows.Forms.Label lbl_StudentGrade;
        private System.Windows.Forms.TextBox txt_StudentName;
        private System.Windows.Forms.TextBox txt_StudentNumber;
        private System.Windows.Forms.TextBox txt_Group;
        private System.Windows.Forms.TextBox txt_English;
        private System.Windows.Forms.TextBox txt_Maths;
        private System.Windows.Forms.TextBox txt_Science;
        private System.Windows.Forms.TextBox txt_StudentDetails;
        private System.Windows.Forms.TextBox txt_AverageMark;
        private System.Windows.Forms.TextBox txt_StudentGrade;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Exit;
    }
}

