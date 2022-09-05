
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
            this.RichTextBox_Log = new System.Windows.Forms.RichTextBox();
            this.Text_PlaceForLogs = new System.Windows.Forms.Label();
            this.Text_Log = new System.Windows.Forms.Label();
            this.TextBox_ToSystemOfNumber = new System.Windows.Forms.TextBox();
            this.Text_ToSystemOfNumber = new System.Windows.Forms.Label();
            this.TextBox_Result = new System.Windows.Forms.TextBox();
            this.Text_Result = new System.Windows.Forms.Label();
            this.Button_FinNewNumber = new System.Windows.Forms.Button();
            this.TextBox_FromSystemOfNumber = new System.Windows.Forms.TextBox();
            this.Text_FromSystemOfNumber = new System.Windows.Forms.Label();
            this.Text_EnterNumber = new System.Windows.Forms.Label();
            this.Text_Main = new System.Windows.Forms.Label();
            this.TextBox_NumberForTranslate = new System.Windows.Forms.TextBox();
            this.Panel_Main.SuspendLayout();
            this.SuspendLayout();
            // 
            // Panel_Main
            // 
            resources.ApplyResources(this.Panel_Main, "Panel_Main");
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
            this.Panel_Main.Name = "Panel_Main";
            // 
            // RichTextBox_Log
            // 
            resources.ApplyResources(this.RichTextBox_Log, "RichTextBox_Log");
            this.RichTextBox_Log.Name = "RichTextBox_Log";
            // 
            // Text_PlaceForLogs
            // 
            resources.ApplyResources(this.Text_PlaceForLogs, "Text_PlaceForLogs");
            this.Text_PlaceForLogs.Name = "Text_PlaceForLogs";
            // 
            // Text_Log
            // 
            resources.ApplyResources(this.Text_Log, "Text_Log");
            this.Text_Log.Name = "Text_Log";
            // 
            // TextBox_ToSystemOfNumber
            // 
            resources.ApplyResources(this.TextBox_ToSystemOfNumber, "TextBox_ToSystemOfNumber");
            this.TextBox_ToSystemOfNumber.Name = "TextBox_ToSystemOfNumber";
            this.TextBox_ToSystemOfNumber.TextChanged += new System.EventHandler(this.TextBox_ToSystemOfNumber_TextChanged);
            // 
            // Text_ToSystemOfNumber
            // 
            resources.ApplyResources(this.Text_ToSystemOfNumber, "Text_ToSystemOfNumber");
            this.Text_ToSystemOfNumber.Name = "Text_ToSystemOfNumber";
            // 
            // TextBox_Result
            // 
            resources.ApplyResources(this.TextBox_Result, "TextBox_Result");
            this.TextBox_Result.Name = "TextBox_Result";
            // 
            // Text_Result
            // 
            resources.ApplyResources(this.Text_Result, "Text_Result");
            this.Text_Result.Name = "Text_Result";
            // 
            // Button_FinNewNumber
            // 
            resources.ApplyResources(this.Button_FinNewNumber, "Button_FinNewNumber");
            this.Button_FinNewNumber.Name = "Button_FinNewNumber";
            this.Button_FinNewNumber.UseVisualStyleBackColor = true;
            this.Button_FinNewNumber.Click += new System.EventHandler(this.Button_FinNewNumber_Click);
            // 
            // TextBox_FromSystemOfNumber
            // 
            resources.ApplyResources(this.TextBox_FromSystemOfNumber, "TextBox_FromSystemOfNumber");
            this.TextBox_FromSystemOfNumber.Name = "TextBox_FromSystemOfNumber";
            this.TextBox_FromSystemOfNumber.TextChanged += new System.EventHandler(this.TextBox_FromSystemOfNumber_TextChanged);
            // 
            // Text_FromSystemOfNumber
            // 
            resources.ApplyResources(this.Text_FromSystemOfNumber, "Text_FromSystemOfNumber");
            this.Text_FromSystemOfNumber.Name = "Text_FromSystemOfNumber";
            // 
            // Text_EnterNumber
            // 
            resources.ApplyResources(this.Text_EnterNumber, "Text_EnterNumber");
            this.Text_EnterNumber.Name = "Text_EnterNumber";
            // 
            // Text_Main
            // 
            resources.ApplyResources(this.Text_Main, "Text_Main");
            this.Text_Main.Name = "Text_Main";
            // 
            // TextBox_NumberForTranslate
            // 
            resources.ApplyResources(this.TextBox_NumberForTranslate, "TextBox_NumberForTranslate");
            this.TextBox_NumberForTranslate.Name = "TextBox_NumberForTranslate";
            this.TextBox_NumberForTranslate.TextChanged += new System.EventHandler(this.TextBox_NumberForTranslate_TextChanged);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Panel_Main);
            this.Name = "Form1";
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

