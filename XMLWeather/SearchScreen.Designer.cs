namespace XMLWeather
{
    partial class SearchScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.enterLable = new System.Windows.Forms.Label();
            this.currentLable = new System.Windows.Forms.Label();
            this.sevenDayLabel = new System.Windows.Forms.Label();
            this.seachTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enterLable
            // 
            this.enterLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterLable.Location = new System.Drawing.Point(84, 86);
            this.enterLable.Name = "enterLable";
            this.enterLable.Size = new System.Drawing.Size(72, 37);
            this.enterLable.TabIndex = 0;
            this.enterLable.Text = "Enter";
            this.enterLable.Click += new System.EventHandler(this.enterLable_Click);
            // 
            // currentLable
            // 
            this.currentLable.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currentLable.Location = new System.Drawing.Point(18, 326);
            this.currentLable.Name = "currentLable";
            this.currentLable.Size = new System.Drawing.Size(89, 42);
            this.currentLable.TabIndex = 1;
            this.currentLable.Text = "Today";
            this.currentLable.Click += new System.EventHandler(this.currentLable_Click);
            // 
            // sevenDayLabel
            // 
            this.sevenDayLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sevenDayLabel.Location = new System.Drawing.Point(101, 326);
            this.sevenDayLabel.Name = "sevenDayLabel";
            this.sevenDayLabel.Size = new System.Drawing.Size(146, 42);
            this.sevenDayLabel.TabIndex = 2;
            this.sevenDayLabel.Text = "7 Day Forcast";
            this.sevenDayLabel.Click += new System.EventHandler(this.sevenDayLabel_Click);
            // 
            // seachTextbox
            // 
            this.seachTextbox.Location = new System.Drawing.Point(39, 34);
            this.seachTextbox.Name = "seachTextbox";
            this.seachTextbox.Size = new System.Drawing.Size(163, 20);
            this.seachTextbox.TabIndex = 3;
            // 
            // SearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.seachTextbox);
            this.Controls.Add(this.sevenDayLabel);
            this.Controls.Add(this.currentLable);
            this.Controls.Add(this.enterLable);
            this.Name = "SearchScreen";
            this.Size = new System.Drawing.Size(250, 400);
            this.Load += new System.EventHandler(this.SearchScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enterLable;
        private System.Windows.Forms.Label currentLable;
        private System.Windows.Forms.Label sevenDayLabel;
        private System.Windows.Forms.TextBox seachTextbox;
    }
}
