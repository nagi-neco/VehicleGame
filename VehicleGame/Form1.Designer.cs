namespace VehicleGame
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.labelNotice = new System.Windows.Forms.Label();
            this.pictureBoxAmbulance = new System.Windows.Forms.PictureBox();
            this.pictureBoxHelicopter = new System.Windows.Forms.PictureBox();
            this.pictureBoxMotorcycle = new System.Windows.Forms.PictureBox();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmbulance)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelicopter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotorcycle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "すたーと";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelNotice
            // 
            this.labelNotice.AutoSize = true;
            this.labelNotice.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.labelNotice.ForeColor = System.Drawing.Color.Red;
            this.labelNotice.Location = new System.Drawing.Point(121, 19);
            this.labelNotice.Name = "labelNotice";
            this.labelNotice.Size = new System.Drawing.Size(45, 16);
            this.labelNotice.TabIndex = 1;
            this.labelNotice.Text = "label1";
            // 
            // pictureBoxAmbulance
            // 
            this.pictureBoxAmbulance.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAmbulance.Image")));
            this.pictureBoxAmbulance.Location = new System.Drawing.Point(26, 370);
            this.pictureBoxAmbulance.Name = "pictureBoxAmbulance";
            this.pictureBoxAmbulance.Size = new System.Drawing.Size(100, 79);
            this.pictureBoxAmbulance.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxAmbulance.TabIndex = 2;
            this.pictureBoxAmbulance.TabStop = false;
            // 
            // pictureBoxHelicopter
            // 
            this.pictureBoxHelicopter.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHelicopter.Image")));
            this.pictureBoxHelicopter.Location = new System.Drawing.Point(26, 370);
            this.pictureBoxHelicopter.Name = "pictureBoxHelicopter";
            this.pictureBoxHelicopter.Size = new System.Drawing.Size(100, 79);
            this.pictureBoxHelicopter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxHelicopter.TabIndex = 3;
            this.pictureBoxHelicopter.TabStop = false;
            // 
            // pictureBoxMotorcycle
            // 
            this.pictureBoxMotorcycle.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMotorcycle.Image")));
            this.pictureBoxMotorcycle.Location = new System.Drawing.Point(26, 358);
            this.pictureBoxMotorcycle.Name = "pictureBoxMotorcycle";
            this.pictureBoxMotorcycle.Size = new System.Drawing.Size(100, 91);
            this.pictureBoxMotorcycle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxMotorcycle.TabIndex = 4;
            this.pictureBoxMotorcycle.TabStop = false;
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxCar.Image")));
            this.pictureBoxCar.Location = new System.Drawing.Point(944, 299);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(142, 150);
            this.pictureBoxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxCar.TabIndex = 5;
            this.pictureBoxCar.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1084, 461);
            this.Controls.Add(this.pictureBoxCar);
            this.Controls.Add(this.pictureBoxMotorcycle);
            this.Controls.Add(this.pictureBoxHelicopter);
            this.Controls.Add(this.pictureBoxAmbulance);
            this.Controls.Add(this.labelNotice);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Car ugougo";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAmbulance)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHelicopter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMotorcycle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label labelNotice;
        private System.Windows.Forms.PictureBox pictureBoxAmbulance;
        private System.Windows.Forms.PictureBox pictureBoxHelicopter;
        private System.Windows.Forms.PictureBox pictureBoxMotorcycle;
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.Timer timer1;
    }
}

