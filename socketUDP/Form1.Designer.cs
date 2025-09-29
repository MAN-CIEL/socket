namespace socketUDP
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBoxIpReception = new System.Windows.Forms.TextBox();
            this.textBoxPortDestination = new System.Windows.Forms.TextBox();
            this.textBoxPortReception = new System.Windows.Forms.TextBox();
            this.textBoxIpDestination = new System.Windows.Forms.TextBox();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.textBoxReception = new System.Windows.Forms.TextBox();
            this.buttonCreate = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonReceive = new System.Windows.Forms.Button();
            this.iper = new System.Windows.Forms.Label();
            this.iped = new System.Windows.Forms.Label();
            this.recp = new System.Windows.Forms.Label();
            this.dest = new System.Windows.Forms.Label();
            this.envoi = new System.Windows.Forms.Label();
            this.recp_mess = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // textBoxIpReception
            // 
            this.textBoxIpReception.Location = new System.Drawing.Point(65, 17);
            this.textBoxIpReception.Name = "textBoxIpReception";
            this.textBoxIpReception.Size = new System.Drawing.Size(100, 20);
            this.textBoxIpReception.TabIndex = 0;
            // 
            // textBoxPortDestination
            // 
            this.textBoxPortDestination.Location = new System.Drawing.Point(180, 52);
            this.textBoxPortDestination.Name = "textBoxPortDestination";
            this.textBoxPortDestination.Size = new System.Drawing.Size(88, 20);
            this.textBoxPortDestination.TabIndex = 1;
            // 
            // textBoxPortReception
            // 
            this.textBoxPortReception.Location = new System.Drawing.Point(180, 17);
            this.textBoxPortReception.Name = "textBoxPortReception";
            this.textBoxPortReception.Size = new System.Drawing.Size(88, 20);
            this.textBoxPortReception.TabIndex = 2;
            // 
            // textBoxIpDestination
            // 
            this.textBoxIpDestination.Location = new System.Drawing.Point(65, 52);
            this.textBoxIpDestination.Name = "textBoxIpDestination";
            this.textBoxIpDestination.Size = new System.Drawing.Size(100, 20);
            this.textBoxIpDestination.TabIndex = 3;
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Location = new System.Drawing.Point(65, 95);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(271, 62);
            this.textBoxMessage.TabIndex = 4;
            this.textBoxMessage.TextChanged += new System.EventHandler(this.textBoxMessage_TextChanged);
            // 
            // textBoxReception
            // 
            this.textBoxReception.Location = new System.Drawing.Point(65, 172);
            this.textBoxReception.Multiline = true;
            this.textBoxReception.Name = "textBoxReception";
            this.textBoxReception.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxReception.Size = new System.Drawing.Size(271, 180);
            this.textBoxReception.TabIndex = 5;
            // 
            // buttonCreate
            // 
            this.buttonCreate.Location = new System.Drawing.Point(364, 9);
            this.buttonCreate.Name = "buttonCreate";
            this.buttonCreate.Size = new System.Drawing.Size(148, 34);
            this.buttonCreate.TabIndex = 6;
            this.buttonCreate.Text = "Créer Socket et Bind (IPeR)";
            this.buttonCreate.UseVisualStyleBackColor = true;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(364, 61);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(148, 34);
            this.buttonClose.TabIndex = 7;
            this.buttonClose.Text = "Fermer Close()";
            this.buttonClose.UseVisualStyleBackColor = true;
            // 
            // buttonSend
            // 
            this.buttonSend.Location = new System.Drawing.Point(364, 123);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(148, 34);
            this.buttonSend.TabIndex = 8;
            this.buttonSend.Text = "Envoyer SendTo (IPeD)";
            this.buttonSend.UseVisualStyleBackColor = true;
            // 
            // buttonReceive
            // 
            this.buttonReceive.Location = new System.Drawing.Point(364, 178);
            this.buttonReceive.Name = "buttonReceive";
            this.buttonReceive.Size = new System.Drawing.Size(148, 40);
            this.buttonReceive.TabIndex = 9;
            this.buttonReceive.Text = "Recevoir ReveiveFrom() Bloquant Timeout";
            this.buttonReceive.UseVisualStyleBackColor = true;
            // 
            // iper
            // 
            this.iper.AutoSize = true;
            this.iper.Location = new System.Drawing.Point(285, 20);
            this.iper.Name = "iper";
            this.iper.Size = new System.Drawing.Size(31, 13);
            this.iper.TabIndex = 10;
            this.iper.Text = "IPeR";
            // 
            // iped
            // 
            this.iped.AutoSize = true;
            this.iped.Location = new System.Drawing.Point(285, 55);
            this.iped.Name = "iped";
            this.iped.Size = new System.Drawing.Size(31, 13);
            this.iped.TabIndex = 11;
            this.iped.Text = "IPeD";
            // 
            // recp
            // 
            this.recp.AutoSize = true;
            this.recp.Location = new System.Drawing.Point(12, 20);
            this.recp.Name = "recp";
            this.recp.Size = new System.Drawing.Size(36, 13);
            this.recp.TabIndex = 12;
            this.recp.Text = "Recp.";
            // 
            // dest
            // 
            this.dest.AutoSize = true;
            this.dest.Location = new System.Drawing.Point(12, 55);
            this.dest.Name = "dest";
            this.dest.Size = new System.Drawing.Size(32, 13);
            this.dest.TabIndex = 13;
            this.dest.Text = "Dest.";
            // 
            // envoi
            // 
            this.envoi.AutoSize = true;
            this.envoi.Location = new System.Drawing.Point(12, 98);
            this.envoi.Name = "envoi";
            this.envoi.Size = new System.Drawing.Size(34, 13);
            this.envoi.TabIndex = 14;
            this.envoi.Text = "Envoi";
            // 
            // recp_mess
            // 
            this.recp_mess.AutoSize = true;
            this.recp_mess.Location = new System.Drawing.Point(10, 178);
            this.recp_mess.Name = "recp_mess";
            this.recp_mess.Size = new System.Drawing.Size(36, 13);
            this.recp_mess.TabIndex = 15;
            this.recp_mess.Text = "Recp.";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 362);
            this.Controls.Add(this.recp_mess);
            this.Controls.Add(this.envoi);
            this.Controls.Add(this.dest);
            this.Controls.Add(this.recp);
            this.Controls.Add(this.iped);
            this.Controls.Add(this.iper);
            this.Controls.Add(this.buttonReceive);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonCreate);
            this.Controls.Add(this.textBoxReception);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.textBoxIpDestination);
            this.Controls.Add(this.textBoxPortReception);
            this.Controls.Add(this.textBoxPortDestination);
            this.Controls.Add(this.textBoxIpReception);
            this.Name = "Form1";
            this.Text = "Communication par socket UDP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxIpReception;
        private System.Windows.Forms.TextBox textBoxPortDestination;
        private System.Windows.Forms.TextBox textBoxPortReception;
        private System.Windows.Forms.TextBox textBoxIpDestination;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.TextBox textBoxReception;
        private System.Windows.Forms.Button buttonCreate;
        private System.Windows.Forms.Button buttonClose;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Button buttonReceive;
        private System.Windows.Forms.Label iper;
        private System.Windows.Forms.Label iped;
        private System.Windows.Forms.Label recp;
        private System.Windows.Forms.Label dest;
        private System.Windows.Forms.Label envoi;
        private System.Windows.Forms.Label recp_mess;
        private System.Windows.Forms.Timer timer1;
        //private System.Windows.Forms.Timer timer1;
    }
}

