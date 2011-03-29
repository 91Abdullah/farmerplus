using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;

using AudioSoundRecorder;

namespace FarmerPlusClient
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class FarmerPlusRecorder : System.Windows.Forms.Form
	{
        private AudioSoundRecorder.AudioSoundRecorder audioSoundRecorder1;
		private System.Windows.Forms.Button buttonStopRecording;
        private System.Windows.Forms.Button buttonStartRecording;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		private	string	m_strOutputPathname;
		private	string	m_strOutputExtension;
		private	Int16	m_nCurrInputDevice = 0;
		private	Int16	m_nCurrInputChannel = 0;
		private IntPtr	m_hWndVuMeterLeft;
        private Label label10;
        private Label label11;
        private Label label12;
        private ComboBox comboInputDevices;
        private ComboBox comboInputChannels;
        private GroupBox groupBox1;
        private Button buttonPlay;
        private Button buttonPause;
        private Button buttonStop;
        private Label labelSize;
        private Label labelDuration;
        private GroupBox groupBox2;
        private ComboBox comboBoxOutputFormats;
        private ComboBox comboBoxEncodeModes;
        private Label label1;
        private Label label2;
        private GroupBox groupBox3;
        private Label labelVuMeterLeft;
        private Label labelVuMeterRight;
		private IntPtr	m_hWndVuMeterRight;
        private Button buttonUseLatest;

        public string filePathToReturn = "";

		public FarmerPlusRecorder()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FarmerPlusRecorder));
            this.audioSoundRecorder1 = new AudioSoundRecorder.AudioSoundRecorder();
            this.buttonStopRecording = new System.Windows.Forms.Button();
            this.buttonStartRecording = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboInputDevices = new System.Windows.Forms.ComboBox();
            this.comboInputChannels = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelDuration = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxOutputFormats = new System.Windows.Forms.ComboBox();
            this.comboBoxEncodeModes = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelVuMeterLeft = new System.Windows.Forms.Label();
            this.labelVuMeterRight = new System.Windows.Forms.Label();
            this.buttonUseLatest = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // audioSoundRecorder1
            // 
            this.audioSoundRecorder1.EncodeAacCustomString = null;
            this.audioSoundRecorder1.EncodeAacMode = AudioSoundRecorder.enumAacEncodeModes.AAC_ENCODE_VBR_QUALITY;
            this.audioSoundRecorder1.EncodeAacQuality = 0F;
            this.audioSoundRecorder1.EncodeAacWrapInMP4 = false;
            this.audioSoundRecorder1.EncodeFormatForCdRipping = AudioSoundRecorder.enumEncodingFormats.ENCODING_FORMAT_WAV;
            this.audioSoundRecorder1.EncodeFormatForExporting = AudioSoundRecorder.enumEncodingFormats.ENCODING_FORMAT_WAV;
            this.audioSoundRecorder1.EncodeFormatForRecording = AudioSoundRecorder.enumEncodingFormats.ENCODING_FORMAT_WAV;
            this.audioSoundRecorder1.EncodeMp3ABR = 0;
            this.audioSoundRecorder1.EncodeMp3CBR = 0;
            this.audioSoundRecorder1.EncodeMp3CustomString = null;
            this.audioSoundRecorder1.EncodeMp3Downmix = false;
            this.audioSoundRecorder1.EncodeMp3Mode = AudioSoundRecorder.enumMp3EncodeModes.MP3_ENCODE_PRESETS;
            this.audioSoundRecorder1.EncodeMp3Presets = AudioSoundRecorder.enumMp3EncodePresets.MP3_PRESET_MEDIUM;
            this.audioSoundRecorder1.EncodeOggBitrate = 0;
            this.audioSoundRecorder1.EncodeOggCustomString = null;
            this.audioSoundRecorder1.EncodeOggDownmix = false;
            this.audioSoundRecorder1.EncodeOggMode = AudioSoundRecorder.enumOggEncodeModes.OGG_ENCODE_QUALITY;
            this.audioSoundRecorder1.EncodeOggQuality = 0F;
            this.audioSoundRecorder1.EncodeOggResampleFreq = 0;
            this.audioSoundRecorder1.EncodeWmaCBR = -1;
            this.audioSoundRecorder1.EncodeWmaMode = AudioSoundRecorder.enumWmaEncodeModes.WMA_ENCODE_VBR_QUALITY;
            this.audioSoundRecorder1.EncodeWmaVBRQuality = 100;
            this.audioSoundRecorder1.Location = new System.Drawing.Point(582, 12);
            this.audioSoundRecorder1.Name = "audioSoundRecorder1";
            this.audioSoundRecorder1.SilenceThreshold = ((short)(0));
            this.audioSoundRecorder1.Size = new System.Drawing.Size(48, 48);
            this.audioSoundRecorder1.TabIndex = 0;
            this.audioSoundRecorder1.RecordingStarted += new AudioSoundRecorder.AudioSoundRecorder.EventHandler(this.audioSoundRecorder1_RecordingStarted);
            this.audioSoundRecorder1.RecordingStopped += new AudioSoundRecorder.AudioSoundRecorder.RecordingStoppedEventHandler(this.audioSoundRecorder1_RecordingStopped);
            this.audioSoundRecorder1.RecordingSize += new AudioSoundRecorder.AudioSoundRecorder.RecordingSizeEventHandler(this.audioSoundRecorder1_RecordingSize);
            this.audioSoundRecorder1.RecordingDuration += new AudioSoundRecorder.AudioSoundRecorder.RecordingDurationEventHandler(this.audioSoundRecorder1_RecordingDuration);
            this.audioSoundRecorder1.VUMeterValueChange += new AudioSoundRecorder.AudioSoundRecorder.VUMeterValueChangeEventHandler(this.audioSoundRecorder1_VUMeterValueChange);
            // 
            // buttonStopRecording
            // 
            this.buttonStopRecording.Enabled = false;
            this.buttonStopRecording.Location = new System.Drawing.Point(176, 200);
            this.buttonStopRecording.Name = "buttonStopRecording";
            this.buttonStopRecording.Size = new System.Drawing.Size(120, 40);
            this.buttonStopRecording.TabIndex = 72;
            this.buttonStopRecording.Text = "Stop recording";
            this.buttonStopRecording.Click += new System.EventHandler(this.buttonStopRecording_Click);
            // 
            // buttonStartRecording
            // 
            this.buttonStartRecording.Location = new System.Drawing.Point(24, 200);
            this.buttonStartRecording.Name = "buttonStartRecording";
            this.buttonStartRecording.Size = new System.Drawing.Size(120, 40);
            this.buttonStartRecording.TabIndex = 71;
            this.buttonStartRecording.Text = "Start recording";
            this.buttonStartRecording.Click += new System.EventHandler(this.buttonStartRecording_Click);
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(64, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(512, 32);
            this.label10.TabIndex = 69;
            this.label10.Text = "This sample demonstrates how to perform a recording session in various formats";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(12, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(248, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Input devices";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(12, 72);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(248, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "Input channels for selected input device";
            // 
            // comboInputDevices
            // 
            this.comboInputDevices.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInputDevices.Location = new System.Drawing.Point(12, 40);
            this.comboInputDevices.Name = "comboInputDevices";
            this.comboInputDevices.Size = new System.Drawing.Size(248, 21);
            this.comboInputDevices.TabIndex = 2;
            this.comboInputDevices.SelectedIndexChanged += new System.EventHandler(this.comboInputDevices_SelectedIndexChanged);
            // 
            // comboInputChannels
            // 
            this.comboInputChannels.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboInputChannels.Location = new System.Drawing.Point(12, 88);
            this.comboInputChannels.Name = "comboInputChannels";
            this.comboInputChannels.Size = new System.Drawing.Size(248, 21);
            this.comboInputChannels.TabIndex = 3;
            this.comboInputChannels.SelectedIndexChanged += new System.EventHandler(this.comboInputChannels_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboInputChannels);
            this.groupBox1.Controls.Add(this.comboInputDevices);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Location = new System.Drawing.Point(24, 56);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 120);
            this.groupBox1.TabIndex = 70;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input device settings";
            // 
            // buttonPlay
            // 
            this.buttonPlay.Enabled = false;
            this.buttonPlay.Location = new System.Drawing.Point(9, 88);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Size = new System.Drawing.Size(80, 24);
            this.buttonPlay.TabIndex = 65;
            this.buttonPlay.Text = "Play";
            this.buttonPlay.Click += new System.EventHandler(this.buttonPlay_Click);
            // 
            // buttonPause
            // 
            this.buttonPause.Enabled = false;
            this.buttonPause.Location = new System.Drawing.Point(96, 88);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(80, 24);
            this.buttonPause.TabIndex = 66;
            this.buttonPause.Text = "Pause";
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Enabled = false;
            this.buttonStop.Location = new System.Drawing.Point(183, 88);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(80, 24);
            this.buttonStop.TabIndex = 67;
            this.buttonStop.Text = "Stop";
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // labelSize
            // 
            this.labelSize.Location = new System.Drawing.Point(16, 32);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(240, 12);
            this.labelSize.TabIndex = 71;
            this.labelSize.Text = "Recording size in bytes: 0";
            this.labelSize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDuration
            // 
            this.labelDuration.Location = new System.Drawing.Point(56, 56);
            this.labelDuration.Name = "labelDuration";
            this.labelDuration.Size = new System.Drawing.Size(160, 16);
            this.labelDuration.TabIndex = 72;
            this.labelDuration.Text = "Duration: 00:00.000";
            this.labelDuration.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelDuration);
            this.groupBox2.Controls.Add(this.labelSize);
            this.groupBox2.Controls.Add(this.buttonStop);
            this.groupBox2.Controls.Add(this.buttonPause);
            this.groupBox2.Controls.Add(this.buttonPlay);
            this.groupBox2.Location = new System.Drawing.Point(344, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(272, 128);
            this.groupBox2.TabIndex = 73;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Recorded sound";
            // 
            // comboBoxOutputFormats
            // 
            this.comboBoxOutputFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOutputFormats.Enabled = false;
            this.comboBoxOutputFormats.Location = new System.Drawing.Point(16, 40);
            this.comboBoxOutputFormats.Name = "comboBoxOutputFormats";
            this.comboBoxOutputFormats.Size = new System.Drawing.Size(248, 21);
            this.comboBoxOutputFormats.TabIndex = 71;
            this.comboBoxOutputFormats.SelectedIndexChanged += new System.EventHandler(this.comboBoxOutputFormats_SelectedIndexChanged);
            // 
            // comboBoxEncodeModes
            // 
            this.comboBoxEncodeModes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEncodeModes.Enabled = false;
            this.comboBoxEncodeModes.Location = new System.Drawing.Point(16, 88);
            this.comboBoxEncodeModes.Name = "comboBoxEncodeModes";
            this.comboBoxEncodeModes.Size = new System.Drawing.Size(248, 21);
            this.comboBoxEncodeModes.TabIndex = 72;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "Sound format";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 16);
            this.label2.TabIndex = 74;
            this.label2.Text = "Encode mode";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.comboBoxEncodeModes);
            this.groupBox3.Controls.Add(this.comboBoxOutputFormats);
            this.groupBox3.Location = new System.Drawing.Point(344, 56);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(272, 120);
            this.groupBox3.TabIndex = 74;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output format settings";
            // 
            // labelVuMeterLeft
            // 
            this.labelVuMeterLeft.BackColor = System.Drawing.Color.Black;
            this.labelVuMeterLeft.Location = new System.Drawing.Point(304, 59);
            this.labelVuMeterLeft.Name = "labelVuMeterLeft";
            this.labelVuMeterLeft.Size = new System.Drawing.Size(16, 117);
            this.labelVuMeterLeft.TabIndex = 81;
            this.labelVuMeterLeft.Visible = false;
            // 
            // labelVuMeterRight
            // 
            this.labelVuMeterRight.BackColor = System.Drawing.Color.Black;
            this.labelVuMeterRight.Location = new System.Drawing.Point(320, 59);
            this.labelVuMeterRight.Name = "labelVuMeterRight";
            this.labelVuMeterRight.Size = new System.Drawing.Size(16, 117);
            this.labelVuMeterRight.TabIndex = 82;
            this.labelVuMeterRight.Visible = false;
            // 
            // buttonUseLatest
            // 
            this.buttonUseLatest.Enabled = false;
            this.buttonUseLatest.Location = new System.Drawing.Point(71, 267);
            this.buttonUseLatest.Name = "buttonUseLatest";
            this.buttonUseLatest.Size = new System.Drawing.Size(172, 45);
            this.buttonUseLatest.TabIndex = 83;
            this.buttonUseLatest.Text = "Use Latest Recorded and Exit";
            this.buttonUseLatest.UseVisualStyleBackColor = true;
            this.buttonUseLatest.Click += new System.EventHandler(this.buttonUseLatest_Click);
            // 
            // FarmerPlusRecorder
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(640, 326);
            this.Controls.Add(this.buttonUseLatest);
            this.Controls.Add(this.labelVuMeterRight);
            this.Controls.Add(this.labelVuMeterLeft);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.buttonStopRecording);
            this.Controls.Add(this.buttonStartRecording);
            this.Controls.Add(this.audioSoundRecorder1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FarmerPlusRecorder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simple recorder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

		}
		#endregion

		

		private IntPtr CreateVuMeter (Label ctrlPosition)
		{
			// create a new graphic bar
			IntPtr hWnd = audioSoundRecorder1.GraphicBarsManager.Create (this.Handle, ctrlPosition.Left, ctrlPosition.Top,
				ctrlPosition.Width, ctrlPosition.Height);

			// set graphic bar range
			audioSoundRecorder1.GraphicBarsManager.SetRange (hWnd, 0, 32767);

			// disable automatic drop and set vertical orientation
			GRAPHIC_BAR_SETTINGS	settings = new GRAPHIC_BAR_SETTINGS ();
			audioSoundRecorder1.GraphicBarsManager.GetGraphicalSettings (hWnd, ref settings);
			settings.bAutomaticDrop = false;
			settings.nOrientation = enumGraphicBarOrientations.GRAPHIC_BAR_ORIENT_VERTICAL;
			audioSoundRecorder1.GraphicBarsManager.SetGraphicalSettings (hWnd, settings);

			return hWnd;
		}

		private void UpdateInputCombos ()
		{
			// list the available input channels for the chosend input device
			comboInputChannels.Items.Clear ();
			Int16	nInputChannels = audioSoundRecorder1.GetInputDeviceChannelsCount(m_nCurrInputDevice);
			for (Int16 i = 0; i < nInputChannels; i++)
			{
				string	strInputChannel = audioSoundRecorder1.GetInputDeviceChannelDesc(m_nCurrInputDevice, i);
				comboInputChannels.Items.Add (strInputChannel);
			}
			// select the actual system default input channel for the chosen input device
			m_nCurrInputChannel = audioSoundRecorder1.GetInputDeviceChannelDefault(m_nCurrInputDevice);
			comboInputChannels.SelectedIndex = m_nCurrInputChannel;
		}

		private enumEncodingFormats GetSelectedOutputFormat()
		{
			enumEncodingFormats	nFormat;
			switch (comboBoxOutputFormats.SelectedIndex)
			{
			default:
			case 0:		nFormat = enumEncodingFormats.ENCODING_FORMAT_WAV;		break;
			case 1:		nFormat = enumEncodingFormats.ENCODING_FORMAT_MP3;		break;
			case 2:		nFormat = enumEncodingFormats.ENCODING_FORMAT_WMA;		break;
			case 3:		nFormat = enumEncodingFormats.ENCODING_FORMAT_OGG;		break;
			case 4:		nFormat = enumEncodingFormats.ENCODING_FORMAT_AAC;		break;
			case 5:		nFormat = enumEncodingFormats.ENCODING_FORMAT_AIFF;		break;
			case 6:		nFormat = enumEncodingFormats.ENCODING_FORMAT_AU;		break;
			case 7:		nFormat = enumEncodingFormats.ENCODING_FORMAT_PAF;		break;
			case 8:		nFormat = enumEncodingFormats.ENCODING_FORMAT_SVX;		break;
			case 9:		nFormat = enumEncodingFormats.ENCODING_FORMAT_NIST;		break;
			case 10:	nFormat = enumEncodingFormats.ENCODING_FORMAT_VOC;		break;
			case 11:	nFormat = enumEncodingFormats.ENCODING_FORMAT_IRCAM;	break;
			case 12:	nFormat = enumEncodingFormats.ENCODING_FORMAT_W64;		break;
			case 13:	nFormat = enumEncodingFormats.ENCODING_FORMAT_PVF;		break;
			case 14:	nFormat = enumEncodingFormats.ENCODING_FORMAT_CAF;		break;
			case 15:	nFormat = enumEncodingFormats.ENCODING_FORMAT_RAW;		break;
			case 16:	nFormat = enumEncodingFormats.ENCODING_FORMAT_FLAC;		break;
			}

			return nFormat;
		}

		private void UpdateEncodeModes ()
		{
			// get the selected output format
			enumEncodingFormats	nFormat = GetSelectedOutputFormat();
			audioSoundRecorder1.EncodeFormats.ForRecording = nFormat;

			// clear the encoding modes combobox
			comboBoxEncodeModes.Items.Clear ();

			// set the encode mode
			switch (nFormat)
			{
			case enumEncodingFormats.ENCODING_FORMAT_WAV:
				for (Int16 i = 0; i < audioSoundRecorder1.EncodeFormats.WAV.GetEncodeModesCount(); i++)
					comboBoxEncodeModes.Items.Add (audioSoundRecorder1.EncodeFormats.WAV.GetEncodeModeDesc(i));
				m_strOutputExtension = ".wav";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_MP3:
				for (Int16 i = 0; i < audioSoundRecorder1.EncodeFormats.MP3.GetEncodeModesCount(); i++)
					comboBoxEncodeModes.Items.Add (audioSoundRecorder1.EncodeFormats.MP3.GetEncodeModeDesc(i));
				m_strOutputExtension = ".mp3";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_WMA:
				for (Int16 i = 0; i < audioSoundRecorder1.EncodeFormats.WMA.GetEncodeModesCount(); i++)
					comboBoxEncodeModes.Items.Add (audioSoundRecorder1.EncodeFormats.WMA.GetEncodeModeDesc(i));
				m_strOutputExtension = ".wma";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_OGG:
				for (Int16 i = 0; i < audioSoundRecorder1.EncodeFormats.OGG.GetEncodeModesCount(); i++)
					comboBoxEncodeModes.Items.Add (audioSoundRecorder1.EncodeFormats.OGG.GetEncodeModeDesc(i));
				m_strOutputExtension = ".ogg";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_AAC:
				for (Int16 i = 0; i < audioSoundRecorder1.EncodeFormats.AAC.GetEncodeModesCount(); i++)
					comboBoxEncodeModes.Items.Add (audioSoundRecorder1.EncodeFormats.AAC.GetEncodeModeDesc(i));
				m_strOutputExtension = ".aac";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_AIFF:
				for (Int16 i = 0; i < audioSoundRecorder1.EncodeFormats.AIFF.GetEncodeModesCount(); i++)
					comboBoxEncodeModes.Items.Add (audioSoundRecorder1.EncodeFormats.AIFF.GetEncodeModeDesc(i));
				m_strOutputExtension = ".aiff";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_AU:
				for (Int16 i = 0; i < audioSoundRecorder1.EncodeFormats.AU.GetEncodeModesCount(); i++)
					comboBoxEncodeModes.Items.Add (audioSoundRecorder1.EncodeFormats.AU.GetEncodeModeDesc(i));
				m_strOutputExtension = ".au";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_PAF:
				for (Int16 i = 0; i < audioSoundRecorder1.EncodeFormats.PAF.GetEncodeModesCount(); i++)
					comboBoxEncodeModes.Items.Add (audioSoundRecorder1.EncodeFormats.PAF.GetEncodeModeDesc(i));
				m_strOutputExtension = ".paf";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_SVX:
				for (Int16 i = 0; i < audioSoundRecorder1.EncodeFormats.SVX.GetEncodeModesCount(); i++)
					comboBoxEncodeModes.Items.Add (audioSoundRecorder1.EncodeFormats.SVX.GetEncodeModeDesc(i));
				m_strOutputExtension = ".svx";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_NIST:
				for (Int16 i = 0; i < audioSoundRecorder1.EncodeFormats.NIST.GetEncodeModesCount(); i++)
					comboBoxEncodeModes.Items.Add (audioSoundRecorder1.EncodeFormats.NIST.GetEncodeModeDesc(i));
				m_strOutputExtension = ".wav";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_VOC:
				for (Int16 i = 0; i < audioSoundRecorder1.EncodeFormats.VOC.GetEncodeModesCount(); i++)
					comboBoxEncodeModes.Items.Add (audioSoundRecorder1.EncodeFormats.VOC.GetEncodeModeDesc(i));
				m_strOutputExtension = ".voc";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_IRCAM:
				for (Int16 i = 0; i < audioSoundRecorder1.EncodeFormats.IRCAM.GetEncodeModesCount(); i++)
					comboBoxEncodeModes.Items.Add (audioSoundRecorder1.EncodeFormats.IRCAM.GetEncodeModeDesc(i));
				m_strOutputExtension = ".sf";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_W64:
				for (Int16 i = 0; i < audioSoundRecorder1.EncodeFormats.W64.GetEncodeModesCount(); i++)
					comboBoxEncodeModes.Items.Add (audioSoundRecorder1.EncodeFormats.W64.GetEncodeModeDesc(i));
				m_strOutputExtension = ".w64";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_PVF:
				for (Int16 i = 0; i < audioSoundRecorder1.EncodeFormats.PVF.GetEncodeModesCount(); i++)
					comboBoxEncodeModes.Items.Add (audioSoundRecorder1.EncodeFormats.PVF.GetEncodeModeDesc(i));
				m_strOutputExtension = ".pvf";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_CAF:
				for (Int16 i = 0; i < audioSoundRecorder1.EncodeFormats.CAF.GetEncodeModesCount(); i++)
					comboBoxEncodeModes.Items.Add (audioSoundRecorder1.EncodeFormats.CAF.GetEncodeModeDesc(i));
				m_strOutputExtension = ".caf";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_RAW:
				for (Int16 i = 0; i < audioSoundRecorder1.EncodeFormats.RAW.GetEncodeModesCount(); i++)
					comboBoxEncodeModes.Items.Add (audioSoundRecorder1.EncodeFormats.RAW.GetEncodeModeDesc(i));
				m_strOutputExtension = ".raw";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_FLAC:
				for (Int16 i = 0; i < audioSoundRecorder1.EncodeFormats.FLAC.GetEncodeModesCount(); i++)
					comboBoxEncodeModes.Items.Add (audioSoundRecorder1.EncodeFormats.FLAC.GetEncodeModeDesc(i));
				m_strOutputExtension = ".flac";
				break;
			}

			comboBoxEncodeModes.SelectedIndex = 0;
		}

		private void SetOutputFormatAndEncodeMode ()
		{
			// get the selected output format
			enumEncodingFormats	nFormat = GetSelectedOutputFormat();
			audioSoundRecorder1.EncodeFormats.ForRecording = nFormat;

			// set the encode mode
			switch (nFormat)
			{
			case enumEncodingFormats.ENCODING_FORMAT_WAV:
				audioSoundRecorder1.EncodeFormats.WAV.EncodeMode = (enumWavEncodeModes) comboBoxEncodeModes.SelectedIndex;
				break;
			case enumEncodingFormats.ENCODING_FORMAT_MP3:
				audioSoundRecorder1.EncodeFormats.MP3.EncodeMode = (enumMp3EncodeModes) comboBoxEncodeModes.SelectedIndex;
		    
				// set a default value for each of the available MP3 encode modes: which of them will be used
				// depends upon the EncodeFormats.Mp3.EncodeMode property set just above
				audioSoundRecorder1.EncodeFormats.MP3.Preset = enumMp3EncodePresets.MP3_PRESET_MEDIUM;
				audioSoundRecorder1.EncodeFormats.MP3.ABR = 128000;
				audioSoundRecorder1.EncodeFormats.MP3.CBR = audioSoundRecorder1.EncodeFormats.MP3.GetLameEncodingBitrateEx(44100, 4);
				audioSoundRecorder1.EncodeFormats.MP3.CustomString = "-b 160 --cbr";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_WMA:
				audioSoundRecorder1.EncodeFormats.WMA.EncodeMode = (enumWmaEncodeModes) comboBoxEncodeModes.SelectedIndex;
		
				// set a default value for each of the available WMA encode modes: which of them will be used
				// depends upon the EncodeFormats.WMA.EncodeMode property set just above
				audioSoundRecorder1.EncodeFormats.WMA.Quality = audioSoundRecorder1.EncodeFormats.WMA.GetEncodingVBRQualityEx(44100, 2, 0);
				audioSoundRecorder1.EncodeFormats.WMA.CBR = audioSoundRecorder1.EncodeFormats.WMA.GetEncodingBitrateEx(44100, 2, 0);
				break;
			case enumEncodingFormats.ENCODING_FORMAT_OGG:
				audioSoundRecorder1.EncodeFormats.OGG.EncodeMode = (enumOggEncodeModes) comboBoxEncodeModes.SelectedIndex;
		    
				// set a default value for each of the available OGG encode modes: which of them will be used
				// depends upon the EncodeFormats.OGG.EncodeMode property set just above
				audioSoundRecorder1.EncodeFormats.OGG.Quality = 5;
				audioSoundRecorder1.EncodeFormats.OGG.Bitrate = 128000;
				audioSoundRecorder1.EncodeFormats.OGG.CustomString = "-b 96";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_AAC:
				audioSoundRecorder1.EncodeFormats.AAC.EncodeMode = (enumAacEncodeModes) comboBoxEncodeModes.SelectedIndex;
		
				// set a default value for each of the available AAC encode modes: which of them will be used
				// depends upon the EncodeFormats.AAC.EncodeMode property set just above
				audioSoundRecorder1.EncodeFormats.AAC.Quality = 100;
				audioSoundRecorder1.EncodeFormats.AAC.CustomString = "-b 96";
				break;
			case enumEncodingFormats.ENCODING_FORMAT_AIFF:
				audioSoundRecorder1.EncodeFormats.AIFF.EncodeMode = (enumAIFFEncodeModes) comboBoxEncodeModes.SelectedIndex;
				break;
			case enumEncodingFormats.ENCODING_FORMAT_AU:
				audioSoundRecorder1.EncodeFormats.AU.EncodeMode = (enumAUEncodeModes) comboBoxEncodeModes.SelectedIndex;
				break;
			case enumEncodingFormats.ENCODING_FORMAT_PAF:
				audioSoundRecorder1.EncodeFormats.PAF.EncodeMode = (enumPAFEncodeModes) comboBoxEncodeModes.SelectedIndex;
				break;
			case enumEncodingFormats.ENCODING_FORMAT_SVX:
				audioSoundRecorder1.EncodeFormats.SVX.EncodeMode = (enumSVXEncodeModes) comboBoxEncodeModes.SelectedIndex;
				break;
			case enumEncodingFormats.ENCODING_FORMAT_NIST:
				audioSoundRecorder1.EncodeFormats.NIST.EncodeMode = (enumNISTEncodeModes) comboBoxEncodeModes.SelectedIndex;
				break;
			case enumEncodingFormats.ENCODING_FORMAT_VOC:
				audioSoundRecorder1.EncodeFormats.VOC.EncodeMode = (enumVOCEncodeModes) comboBoxEncodeModes.SelectedIndex;
				break;
			case enumEncodingFormats.ENCODING_FORMAT_IRCAM:
				audioSoundRecorder1.EncodeFormats.IRCAM.EncodeMode = (enumIRCAMEncodeModes) comboBoxEncodeModes.SelectedIndex;
				break;
			case enumEncodingFormats.ENCODING_FORMAT_W64:
				audioSoundRecorder1.EncodeFormats.W64.EncodeMode = (enumW64EncodeModes) comboBoxEncodeModes.SelectedIndex;
				break;
			case enumEncodingFormats.ENCODING_FORMAT_PVF:
				audioSoundRecorder1.EncodeFormats.PVF.EncodeMode = (enumPVFEncodeModes) comboBoxEncodeModes.SelectedIndex;
				break;
			case enumEncodingFormats.ENCODING_FORMAT_CAF:
				audioSoundRecorder1.EncodeFormats.CAF.EncodeMode = (enumCAFEncodeModes) comboBoxEncodeModes.SelectedIndex;
				break;
			case enumEncodingFormats.ENCODING_FORMAT_RAW:
				audioSoundRecorder1.EncodeFormats.RAW.EncodeMode = (enumRAWEncodeModes) comboBoxEncodeModes.SelectedIndex;
				break;
			case enumEncodingFormats.ENCODING_FORMAT_FLAC:
				audioSoundRecorder1.EncodeFormats.FLAC.EncodeMode = (enumFLACEncodeModes) comboBoxEncodeModes.SelectedIndex;
				break;
			}
		}

		private void Form1_Load(object sender, System.EventArgs e)
		{
			Int16	nInputDevices = audioSoundRecorder1.GetInputDevicesCount();
			if (nInputDevices == 0)
			{
				MessageBox.Show ("No input device detected and/or connected: the program will now close. Please, try to plug a microphone into the sound card or an external audio device into the Line-In before launching again the program.");
				Close ();
			}
			// init the control
			audioSoundRecorder1.InitRecordingSystem ();

			// list the available input devices
			for (Int16 i = 0; i < nInputDevices; i++)
			{
				string	strInputDevice = audioSoundRecorder1.GetInputDeviceDesc(i);
				comboInputDevices.Items.Add (strInputDevice);
			}
			// select the actual system default input device
			m_nCurrInputDevice = 0;
			comboInputDevices.SelectedIndex = m_nCurrInputDevice;

			// update the input channels combo and the input formats combo
			UpdateInputCombos ();

			// add some of the supported output formats
			comboBoxOutputFormats.Items.Add ("Microsoft WAV (WAV)");
			comboBoxOutputFormats.Items.Add ("MP3 (MP3)");
			comboBoxOutputFormats.Items.Add ("Windows Media Audio (WMA)");
			comboBoxOutputFormats.Items.Add ("OGG Vorbis (OGG)");
			comboBoxOutputFormats.Items.Add ("AAC/MP4 (AAC)");
			comboBoxOutputFormats.Items.Add ("Apple/SGI AIFF (AIF)");
			comboBoxOutputFormats.Items.Add ("Sun/NeXT AU (AU)");
			comboBoxOutputFormats.Items.Add ("Ensoniq PARIS (PAF)");
			comboBoxOutputFormats.Items.Add ("Commodore Amiga IFF/SVX (SVX)");
			comboBoxOutputFormats.Items.Add ("Sphere NIST (WAV)");
			comboBoxOutputFormats.Items.Add ("Creative VOC (VOC)");
			comboBoxOutputFormats.Items.Add ("Berkeley/IRCAM/CARL (SF)");
			comboBoxOutputFormats.Items.Add ("Sonic Foundry's 64 bit RIFF/WAV (W64)");
			comboBoxOutputFormats.Items.Add ("Portable Voice Format (PVF)");
			comboBoxOutputFormats.Items.Add ("Core Audio File (CAF)");
			comboBoxOutputFormats.Items.Add ("Raw file (RAW/VOX)");
			comboBoxOutputFormats.Items.Add ("FLAC (FLAC)");
		    
			// select WAV as first option
			comboBoxOutputFormats.SelectedIndex = 0;

			// add encode modes related to the selected output format
			UpdateEncodeModes ();

			// enable generating VU-Meter events passing 0
			audioSoundRecorder1.DisplayVUMeter.Create (IntPtr.Zero);

			// create some fancy VU-Meter
			m_hWndVuMeterLeft = CreateVuMeter(labelVuMeterLeft);
			m_hWndVuMeterRight = CreateVuMeter(labelVuMeterRight);

            this.comboBoxOutputFormats.SelectedIndex = 1;
		}

		private void comboInputDevices_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			Int16	nCurrInputDevice = (Int16) comboInputDevices.SelectedIndex;
			if (audioSoundRecorder1.VerifyDirectSoundInputDevice(nCurrInputDevice) == enumErrorCodes.ERR_NOERROR)
			{
				m_nCurrInputDevice = (Int16) comboInputDevices.SelectedIndex;

				// list the available input channels for the chosend input device
				UpdateInputCombos ();
			}
			else
			{
				MessageBox.Show ("The selected device is not accessible");
				comboInputDevices.SelectedIndex = m_nCurrInputDevice;
			}				
		}

		private void comboInputChannels_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			m_nCurrInputChannel = (Int16) comboInputChannels.SelectedIndex;
			audioSoundRecorder1.SetInputDeviceChannelDefault(m_nCurrInputDevice, m_nCurrInputChannel);		
		}

		private void buttonStartRecording_Click(object sender, System.EventArgs e)
		{
			// set the output format into the recorder
			SetOutputFormatAndEncodeMode ();
		    
			// use custom resampling format 44100 Hz Stereo
			audioSoundRecorder1.EncodeFormats.ResampleMode = enumResampleModes.RESAMPLE_MODE_CUSTOM_FORMAT;
			audioSoundRecorder1.EncodeFormats.ResampleCustomFrequency = 44100;
			audioSoundRecorder1.EncodeFormats.ResampleCustomChannels = 2;
		    
			// compose the outputh pathname
            string strPathname = (System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\FarmerPlusAudios\FMPAudio_") + System.IO.Directory.GetFiles(System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal) + @"\FarmerPlusAudios\").Length.ToString();
            filePathToReturn = strPathname;
            
			m_strOutputPathname = strPathname + m_strOutputExtension;
		    
			// start recording session
			enumErrorCodes	nResult = audioSoundRecorder1.StartFromDirectSoundDevice(m_nCurrInputDevice, m_nCurrInputChannel, m_strOutputPathname);
			if (nResult != enumErrorCodes.ERR_NOERROR)
				MessageBox.Show ("Cannot start recording: probably a parameter is not compatible with the current resample format");
		}

		private void buttonStopRecording_Click(object sender, System.EventArgs e)
		{
			audioSoundRecorder1.Stop ();
			buttonPause.Text = "Pause";

            this.buttonUseLatest.Enabled = true;
		}

		private void comboBoxOutputFormats_SelectedIndexChanged(object sender, System.EventArgs e)
		{
			UpdateEncodeModes ();
		}

		private void audioSoundRecorder1_VUMeterValueChange(object sender, AudioSoundRecorder.VUMeterValueChangeEventArgs e)
		{
			audioSoundRecorder1.GraphicBarsManager.SetValue (m_hWndVuMeterLeft, e.nPeakLeft);
			audioSoundRecorder1.GraphicBarsManager.SetValue (m_hWndVuMeterRight, e.nPeakRight);		
		}

		private void audioSoundRecorder1_RecordingDuration(object sender, AudioSoundRecorder.RecordingDurationEventArgs e)
		{
			labelDuration.Text = "Recording duration: " + audioSoundRecorder1.GetFormattedTime (e.nDuration, false, true);
		}

		private void audioSoundRecorder1_RecordingSize(object sender, AudioSoundRecorder.RecordingSizeEventArgs e)
		{
			labelSize.Text = "Recording size in bytes: " + e.nDataSize.ToString ();
		}

		private void audioSoundRecorder1_RecordingStarted(object sender, System.EventArgs e)
		{
			buttonStopRecording.Enabled = true;
			buttonStartRecording.Enabled = false;

			buttonPlay.Enabled = false;
			buttonPause.Enabled = false;
			buttonStop.Enabled = false;
		}

		private void audioSoundRecorder1_RecordingStopped(object sender, AudioSoundRecorder.RecordingStoppedEventArgs e)
		{
			buttonStopRecording.Enabled = false;
			buttonStartRecording.Enabled = true;

			buttonPlay.Enabled = true;
			buttonPause.Enabled = true;
			buttonStop.Enabled = true;

			if (e.bResult == true)
				;//MessageBox.Show ("Recording session saved into " + m_strOutputPathname);
			else
				MessageBox.Show ("Recording session failed due to error " + audioSoundRecorder1.LastError.ToString ());
		}

		private void buttonPlay_Click(object sender, System.EventArgs e)
		{
			if (buttonPause.Text == "Pause")
				audioSoundRecorder1.RecordedSound.Play ();
			else
			{
				audioSoundRecorder1.RecordedSound.Resume ();
				buttonPause.Text = "Pause";
			}
		}

		private void buttonPause_Click(object sender, System.EventArgs e)
		{
			if (buttonPause.Text == "Pause")
			{
				audioSoundRecorder1.RecordedSound.Pause ();
				buttonPause.Text = "Resume";
			}
			else
			{
				audioSoundRecorder1.RecordedSound.Resume ();
				buttonPause.Text = "Pause";
			}
		}

		private void buttonStop_Click(object sender, System.EventArgs e)
		{
			audioSoundRecorder1.RecordedSound.Stop ();
			buttonPause.Text = "Pause";

            
		}

        private void buttonUseLatest_Click(object sender, EventArgs e)
        {
            this.Close();
        }
	}
}
