namespace Backprop
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
            btnCreateModel = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            btnTrainModel = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            label9 = new Label();
            label10 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // btnCreateModel
            // 
            btnCreateModel.Location = new Point(276, 42);
            btnCreateModel.Name = "btnCreateModel";
            btnCreateModel.Size = new Size(258, 44);
            btnCreateModel.TabIndex = 2;
            btnCreateModel.Text = "Create Model";
            btnCreateModel.UseVisualStyleBackColor = true;
            btnCreateModel.Click += btnCreateModel_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 153);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(258, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 198);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(258, 23);
            textBox2.TabIndex = 5;
            // 
            // button2
            // 
            button2.Location = new Point(540, 186);
            button2.Name = "button2";
            button2.Size = new Size(258, 44);
            button2.TabIndex = 11;
            button2.Text = "Predict";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnTrainModel
            // 
            btnTrainModel.Location = new Point(540, 42);
            btnTrainModel.Name = "btnTrainModel";
            btnTrainModel.Size = new Size(258, 44);
            btnTrainModel.TabIndex = 3;
            btnTrainModel.Text = "Train";
            btnTrainModel.UseVisualStyleBackColor = true;
            btnTrainModel.Click += btnTrainModel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(17, 9);
            label1.Name = "label1";
            label1.Size = new Size(771, 30);
            label1.TabIndex = 6;
            label1.Text = "PREDICTING COMPUTER SCIENCE STUDENT PERFORMANCE IN PROGRAMMING COURSES AT BOHOL ISLAND STATE UNIVERSITY-BILAR CAMPUS\r\nUSING BACKPROPAGATION\r\n";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 135);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 7;
            label2.Text = "Quizzes";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 180);
            label3.Name = "label3";
            label3.Size = new Size(140, 15);
            label3.TabIndex = 8;
            label3.Text = "Active Class Participation";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 230);
            label4.Name = "label4";
            label4.Size = new Size(122, 15);
            label4.TabIndex = 10;
            label4.Text = "Individual Oral Report";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(12, 248);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(258, 23);
            textBox3.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(276, 135);
            label5.Name = "label5";
            label5.Size = new Size(68, 15);
            label5.TabIndex = 12;
            label5.Text = "Attendance";
            label5.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(276, 153);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(258, 23);
            textBox4.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(276, 180);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 14;
            label6.Text = "Class Standing";
            label6.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(276, 198);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(258, 23);
            textBox5.TabIndex = 8;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(276, 230);
            label7.Name = "label7";
            label7.Size = new Size(215, 15);
            label7.TabIndex = 16;
            label7.Text = "Activities and Outcomes Based Projects";
            label7.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(276, 248);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(258, 23);
            textBox6.TabIndex = 9;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(540, 135);
            label8.Name = "label8";
            label8.Size = new Size(75, 15);
            label8.TabIndex = 18;
            label8.Text = "Major Exams";
            label8.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(540, 153);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(258, 23);
            textBox7.TabIndex = 10;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(276, 341);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(258, 23);
            textBox8.TabIndex = 19;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(276, 323);
            label9.Name = "label9";
            label9.Size = new Size(61, 15);
            label9.TabIndex = 20;
            label9.Text = "Prediction";
            label9.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(12, 107);
            label10.Name = "label10";
            label10.Size = new Size(344, 15);
            label10.TabIndex = 21;
            label10.Text = "Enter Grade in Percent fornat, 0 for lowest, and 1 for the highest.";
            label10.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            button1.Location = new Point(12, 42);
            button1.Name = "button1";
            button1.Size = new Size(258, 44);
            button1.TabIndex = 1;
            button1.Text = "Load Dataset";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(textBox8);
            Controls.Add(label8);
            Controls.Add(textBox7);
            Controls.Add(label7);
            Controls.Add(textBox6);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(label5);
            Controls.Add(textBox4);
            Controls.Add(label4);
            Controls.Add(textBox3);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnTrainModel);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btnCreateModel);
            Name = "Form1";
            Text = "BackPropagation";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCreateModel;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button2;
        private Button btnTrainModel;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private TextBox textBox7;
        private TextBox textBox8;
        private Label label9;
        private Label label10;
        private Button button1;
    }
}