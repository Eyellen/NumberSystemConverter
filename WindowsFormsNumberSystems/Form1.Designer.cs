
namespace WindowsFormsNumberSystems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Panel_Main = new System.Windows.Forms.Panel();
            this.TextBox_Result = new System.Windows.Forms.TextBox();
            this.Text_Result = new System.Windows.Forms.Label();
            this.Button_FinNewNumber = new System.Windows.Forms.Button();
            this.TextBox_FromSystemOfNumber = new System.Windows.Forms.TextBox();
            this.Text_FromSystemOfNumber = new System.Windows.Forms.Label();
            this.Text_EnterNumber = new System.Windows.Forms.Label();
            this.Text_Main = new System.Windows.Forms.Label();
            this.TextBox_NumberForTranslate = new System.Windows.Forms.TextBox();
            this.TextBox_ToSystemOfNumber = new System.Windows.Forms.TextBox();
            this.Text_ToSystemOfNumber = new System.Windows.Forms.Label();
            this.Text_Log = new System.Windows.Forms.Label();
            this.Text_PlaceForLogs = new System.Windows.Forms.Label();
            this.RichTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.Panel_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Main
            // 
            this.Panel_Main.Controls.Add(this.RichTextBox_Log);
            this.Panel_Main.Controls.Add(this.Text_PlaceForLogs);
            this.Panel_Main.Controls.Add(this.Text_Log);
            this.Panel_Main.Controls.Add(this.TextBox_ToSystemOfNumber);
            this.Panel_Main.Controls.Add(this.Text_ToSystemOfNumber);
            this.Panel_Main.Controls.Add(this.TextBox_Result);
            this.Panel_Main.Controls.Add(this.Text_Result);
            this.Panel_Main.Controls.Add(this.Button_FinNewNumber);
            this.Panel_Main.Controls.Add(this.TextBox_FromSystemOfNumber);
            this.Panel_Main.Controls.Add(this.Text_FromSystemOfNumber);
            this.Panel_Main.Controls.Add(this.Text_EnterNumber);
            this.Panel_Main.Controls.Add(this.Text_Main);
            this.Panel_Main.Controls.Add(this.TextBox_NumberForTranslate);
            this.Panel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_Main.Location = new System.Drawing.Point(0, 0);
            this.Panel_Main.Name = "Panel_Main";
            this.Panel_Main.Size = new System.Drawing.Size(739, 450);
            this.Panel_Main.TabIndex = 0;
            // 
            // TextBox_Result
            // 
            this.TextBox_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_Result.Location = new System.Drawing.Point(12, 209);
            this.TextBox_Result.Name = "TextBox_Result";
            this.TextBox_Result.Size = new System.Drawing.Size(715, 26);
            this.TextBox_Result.TabIndex = 7;
            // 
            // Text_Result
            // 
            this.Text_Result.AutoSize = true;
            this.Text_Result.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Result.Location = new System.Drawing.Point(12, 186);
            this.Text_Result.Name = "Text_Result";
            this.Text_Result.Size = new System.Drawing.Size(89, 20);
            this.Text_Result.TabIndex = 6;
            this.Text_Result.Text = "Результат";
            // 
            // Button_FinNewNumber
            // 
            this.Button_FinNewNumber.AutoSize = true;
            this.Button_FinNewNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_FinNewNumber.Location = new System.Drawing.Point(12, 153);
            this.Button_FinNewNumber.Name = "Button_FinNewNumber";
            this.Button_FinNewNumber.Size = new System.Drawing.Size(715, 30);
            this.Button_FinNewNumber.TabIndex = 5;
            this.Button_FinNewNumber.Text = "Вычислить";
            this.Button_FinNewNumber.UseVisualStyleBackColor = true;
            this.Button_FinNewNumber.Click += new System.EventHandler(this.Button_FinNewNumber_Click);
            // 
            // TextBox_FromSystemOfNumber
            // 
            this.TextBox_FromSystemOfNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_FromSystemOfNumber.Location = new System.Drawing.Point(12, 121);
            this.TextBox_FromSystemOfNumber.Name = "TextBox_FromSystemOfNumber";
            this.TextBox_FromSystemOfNumber.Size = new System.Drawing.Size(355, 26);
            this.TextBox_FromSystemOfNumber.TabIndex = 4;
            this.TextBox_FromSystemOfNumber.TextChanged += new System.EventHandler(this.TextBox_FromSystemOfNumber_TextChanged);
            // 
            // Text_FromSystemOfNumber
            // 
            this.Text_FromSystemOfNumber.AutoSize = true;
            this.Text_FromSystemOfNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_FromSystemOfNumber.Location = new System.Drawing.Point(12, 98);
            this.Text_FromSystemOfNumber.Name = "Text_FromSystemOfNumber";
            this.Text_FromSystemOfNumber.Size = new System.Drawing.Size(97, 20);
            this.Text_FromSystemOfNumber.TabIndex = 3;
            this.Text_FromSystemOfNumber.Text = "Из системы";
            // 
            // Text_EnterNumber
            // 
            this.Text_EnterNumber.AutoSize = true;
            this.Text_EnterNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_EnterNumber.Location = new System.Drawing.Point(12, 46);
            this.Text_EnterNumber.Name = "Text_EnterNumber";
            this.Text_EnterNumber.Size = new System.Drawing.Size(456, 20);
            this.Text_EnterNumber.TabIndex = 2;
            this.Text_EnterNumber.Text = "Введите число для перевода в другую систему счисления";
            // 
            // Text_Main
            // 
            this.Text_Main.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Text_Main.AutoSize = true;
            this.Text_Main.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Main.Location = new System.Drawing.Point(99, 9);
            this.Text_Main.Name = "Text_Main";
            this.Text_Main.Size = new System.Drawing.Size(559, 24);
            this.Text_Main.TabIndex = 1;
            this.Text_Main.Text = "Программа для перевода в разные системы счисления";
            // 
            // TextBox_NumberForTranslate
            // 
            this.TextBox_NumberForTranslate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_NumberForTranslate.Location = new System.Drawing.Point(12, 69);
            this.TextBox_NumberForTranslate.Name = "TextBox_NumberForTranslate";
            this.TextBox_NumberForTranslate.Size = new System.Drawing.Size(715, 26);
            this.TextBox_NumberForTranslate.TabIndex = 0;
            this.TextBox_NumberForTranslate.TextChanged += new System.EventHandler(this.TextBox_NumberForTranslate_TextChanged);
            // 
            // TextBox_ToSystemOfNumber
            // 
            this.TextBox_ToSystemOfNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TextBox_ToSystemOfNumber.Location = new System.Drawing.Point(373, 121);
            this.TextBox_ToSystemOfNumber.Name = "TextBox_ToSystemOfNumber";
            this.TextBox_ToSystemOfNumber.Size = new System.Drawing.Size(354, 26);
            this.TextBox_ToSystemOfNumber.TabIndex = 9;
            this.TextBox_ToSystemOfNumber.TextChanged += new System.EventHandler(this.TextBox_ToSystemOfNumber_TextChanged);
            // 
            // Text_ToSystemOfNumber
            // 
            this.Text_ToSystemOfNumber.AutoSize = true;
            this.Text_ToSystemOfNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_ToSystemOfNumber.Location = new System.Drawing.Point(373, 98);
            this.Text_ToSystemOfNumber.Name = "Text_ToSystemOfNumber";
            this.Text_ToSystemOfNumber.Size = new System.Drawing.Size(85, 20);
            this.Text_ToSystemOfNumber.TabIndex = 8;
            this.Text_ToSystemOfNumber.Text = "В систему";
            // 
            // Text_Log
            // 
            this.Text_Log.AutoSize = true;
            this.Text_Log.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_Log.Location = new System.Drawing.Point(12, 320);
            this.Text_Log.Name = "Text_Log";
            this.Text_Log.Size = new System.Drawing.Size(36, 19);
            this.Text_Log.TabIndex = 10;
            this.Text_Log.Text = "Log";
            // 
            // Text_PlaceForLogs
            // 
            this.Text_PlaceForLogs.AutoSize = true;
            this.Text_PlaceForLogs.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Text_PlaceForLogs.Location = new System.Drawing.Point(12, 353);
            this.Text_PlaceForLogs.Name = "Text_PlaceForLogs";
            this.Text_PlaceForLogs.Size = new System.Drawing.Size(0, 19);
            this.Text_PlaceForLogs.TabIndex = 11;
            // 
            // RichTextBox_Log
            // 
            this.RichTextBox_Log.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RichTextBox_Log.Location = new System.Drawing.Point(12, 342);
            this.RichTextBox_Log.Name = "RichTextBox_Log";
            this.RichTextBox_Log.Size = new System.Drawing.Size(715, 96);
            this.RichTextBox_Log.TabIndex = 12;
            this.RichTextBox_Log.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 450);
            this.Controls.Add(this.Panel_Main);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Программа для перевода чисел в разные системы счисления";
            this.Panel_Main.ResumeLayout(false);
            this.Panel_Main.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Main;
        private System.Windows.Forms.Label Text_EnterNumber;
        private System.Windows.Forms.Label Text_Main;
        private System.Windows.Forms.TextBox TextBox_NumberForTranslate;
        private System.Windows.Forms.TextBox TextBox_Result;
        private System.Windows.Forms.Label Text_Result;
        private System.Windows.Forms.Button Button_FinNewNumber;
        private System.Windows.Forms.TextBox TextBox_FromSystemOfNumber;
        private System.Windows.Forms.Label Text_FromSystemOfNumber;
        private System.Windows.Forms.TextBox TextBox_ToSystemOfNumber;
        private System.Windows.Forms.Label Text_ToSystemOfNumber;
        private System.Windows.Forms.Label Text_PlaceForLogs;
        private System.Windows.Forms.Label Text_Log;
        private System.Windows.Forms.RichTextBox RichTextBox_Log;
    }
}

