using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WMNX2
{
    public partial class MainForm : Form
    {
        byte[] uncSave;
        byte[] encSave;
        int saveAvatar;

        public MainForm()
        {
            MaximizeBox = false;
            FormBorderStyle = FormBorderStyle.FixedDialog;            
            InitializeComponent();
        }

        private void btnPick_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "NX2 Data Files|*.bin";
            openFileDialog.Title = "Select your nx2save file";
            openFileDialog.RestoreDirectory = true;
            openFileDialog.DefaultExt = "bin";
            openFileDialog.InitialDirectory = Environment.CurrentDirectory;

         
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (openFileDialog.SafeFileName == "nx2save.bin")
                {
                    OpenSaveFile(openFileDialog.FileName);
                }
                else
                {
                    MessageBox.Show("just nx2save.bin is supported");
                }
            }
        }

        void OpenSaveFile(string sPath)
        {
            Directory.CreateDirectory("BACKUP");
            File.Copy(sPath, "BACKUP/nx2save.bin", true);

            byte[] saveFile = File.ReadAllBytes(sPath);
            uncSave = saveFile.SubArray(0, 292);

            encSave = saveFile.SubArray(292, saveFile.Length - 292);

            Tools.Decode(encSave);
            Mission.ReadMission(encSave);

            ckWhite.Checked = encSave[9600] == 1;
            ckRed.Checked = encSave[9601] == 1;
            ckYellow.Checked = encSave[9602] == 1;
            ckLightG.Checked = encSave[9603] == 1;
            ckGreen.Checked = encSave[9604] == 1;
            ckSkyBlue.Checked = encSave[9605] == 1;
            ckBlue.Checked = encSave[9606] == 1;
            ckViolet.Checked = encSave[9607] == 1;
            ckPink.Checked = encSave[9608] == 1;
            ckGrey.Checked = encSave[9609] == 1;
            ckBlack.Checked = encSave[9610] == 1;
            ckDarkYellow.Checked = encSave[9611] == 1;

            ckBarharn.Checked = encSave[9744] == 16;
            ckHarena.Checked = encSave[9745] == 16;
            ckRootinia.Checked = encSave[9746] == 16;
            ckMirtain.Checked = encSave[9747] == 16;
            ckShantomia.Checked = encSave[9748] == 16;
            ckMorigin.Checked = encSave[9749] == 16;
            ckCryomiston.Checked = encSave[9750] == 16;

            //File.WriteAllBytes("decoded.bin", saveFile);

            string sName = Encoding.UTF8.GetString(saveFile.SubArray(0, 8));
            string sSerial = Encoding.UTF8.GetString(encSave.SubArray(4, 24));

            byte[] bByte = new byte[4];

            var iAvatar = BitConverter.ToInt32(encSave.SubArray(76, 4), 0);

            saveAvatar = iAvatar;
            numAvatar.Value = saveAvatar;
            picAvatar.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("CH_" + (iAvatar + 1).ToString("000"));
            txtName.Text = sName;
            txtSerial.Text = sSerial;

            int iMilleage = BitConverter.ToInt32(encSave.SubArray(100, 4), 0);
            txtMileage.Text = iMilleage.ToString();

            int iPosition = BitConverter.ToInt32(encSave.SubArray(116, 4), 0);
            txtPosition.Text = iPosition.ToString("X");

            uint crcValue = BitConverter.ToUInt32(encSave.SubArray(0, 4), 0);
            txtAMCRC.Text = crcValue.ToString();
            txtToolCRC.Text = MyCRC(encSave).ToString();

            byte[] strBytes = new byte[128];
            Array.Copy(encSave, 9752, strBytes, 0, 128);
            string result = System.Text.Encoding.UTF8.GetString(strBytes);
            result = result.TrimEnd('\0');
            txtCurrentLand.Text = result;

            strBytes = new byte[128];
            Array.Copy(encSave, 9880, strBytes, 0, 128);
            result = System.Text.Encoding.UTF8.GetString(strBytes);
            result = result.TrimEnd('\0');
            txtCurrentMission.Text = result;

            panelData.Enabled = true;
            groupCheat.Enabled = true;
            panelBarricade.Enabled = true;
            panelPortal.Enabled = true;
            btnSave.Enabled = true;
        }

        uint MyCRC(byte[] enc)
        {
            byte[] newArray = new byte[enc.Length - 4];
            Array.Copy(encSave, 4, newArray, 0, newArray.Length);
            File.WriteAllBytes("other/dec", newArray);
            {
                Process cmd = new Process();
                cmd.StartInfo.FileName = "cmd.exe";
                cmd.StartInfo.RedirectStandardInput = true;
                cmd.StartInfo.RedirectStandardOutput = true;
                cmd.StartInfo.CreateNoWindow = true;
                cmd.StartInfo.UseShellExecute = false;
                cmd.Start();

                cmd.StandardInput.WriteLine("cd other");
                cmd.StandardInput.Flush();
                cmd.StandardInput.WriteLine("rehash.exe -none -adler32 dec -out:raw");
                cmd.StandardInput.Flush();
                cmd.StandardInput.Close();
                cmd.WaitForExit();
                string ss = cmd.StandardOutput.ReadToEnd().Split(new string[] { "Adler32" }, StringSplitOptions.None)[1];
                ss = ss.Trim();
                ss = ss.Substring(2, 8);

                cmd.Close();
                File.Delete("other/dec");
                return Convert.ToUInt32(ss, 16);
            }
        }

        private void btnMission_Click(object sender, EventArgs e)
        {
            ReviewMission r = new ReviewMission();
            r.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string usb = txtSerial.Text;
            string sName = txtName.Text;

            int serialSize = usb.Length < 24 ? usb.Length : 24;
            int nameSize = sName.Length < 8 ? sName.Length : 8;

            for (int i = 0; i < serialSize; i++)
            {
                encSave[i + 4] = (byte)usb[i];
            }
            for (int i = serialSize; i < 24; i++)
            {
                encSave[i + 4] = 0;
            }

            for (int i = 0; i < nameSize; i++)
            {
                uncSave[i] = (byte)sName[i];
            }
            for (int i = nameSize; i < 8; i++)
            {
                uncSave[i] = 0;
            }

            for (int i = 0; i < nameSize; i++)
            {
                encSave[i + 88] = (byte)sName[i];
            }
            for (int i = nameSize; i < 8; i++)
            {
                encSave[i + 88] = 0;
            }

            Buffer.BlockCopy(BitConverter.GetBytes(saveAvatar), 0, encSave, 76, 4);

            int iBaseM = 384;
            int iBaseI = 5504;
            for (int i = 0; i < Mission.allMissionData.Length; i++)
            {
                if (Mission.allMissionData[i].bClear)
                {
                    encSave[iBaseM + Mission.allMissionData[i].iId] = 31;
                }
                else
                {
                    encSave[iBaseM + Mission.allMissionData[i].iId] = 0;
                }

                if (Mission.allMissionData[i].bPass)
                {
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4)] = 3;
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4) + 1] = 0;
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4) + 2] = 0;
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4) + 3] = 0;
                }
                else
                {
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4)] = 0;
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4) + 1] = 0;
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4) + 2] = 0;
                    encSave[iBaseI + (Mission.allMissionData[i].iId * 4) + 3] = 0;
                }
            }

            encSave[9600] = ckWhite.Checked ? (byte)1 : (byte)0;
            encSave[9601] = ckRed.Checked ? (byte)1 : (byte)0;
            encSave[9602] = ckYellow.Checked ? (byte)1 : (byte)0;
            encSave[9603] = ckLightG.Checked ? (byte)1 : (byte)0;
            encSave[9604] = ckGreen.Checked ? (byte)1 : (byte)0;
            encSave[9605] = ckSkyBlue.Checked ? (byte)1 : (byte)0;
            encSave[9606] = ckBlue.Checked ? (byte)1 : (byte)0;
            encSave[9607] = ckViolet.Checked ? (byte)1 : (byte)0;
            encSave[9608] = ckPink.Checked ? (byte)1 : (byte)0;
            encSave[9609] = ckGrey.Checked ? (byte)1 : (byte)0;
            encSave[9610] = ckBlack.Checked ? (byte)1 : (byte)0;
            encSave[9611] = ckDarkYellow.Checked ? (byte)1 : (byte)0;

            encSave[9744] = ckBarharn.Checked ? (byte)16 : (byte)0;
            encSave[9745] = ckHarena.Checked ? (byte)16 : (byte)0;
            encSave[9746] = ckRootinia.Checked ? (byte)16 : (byte)0;
            encSave[9747] = ckMirtain.Checked ? (byte)16 : (byte)0;
            encSave[9748] = ckShantomia.Checked ? (byte)16 : (byte)0;
            encSave[9749] = ckMorigin.Checked ? (byte)16 : (byte)0;
            encSave[9750] = ckCryomiston.Checked ? (byte)16 : (byte)0;

            if (int.TryParse(txtMileage.Text, out int im))
            {
                byte[] bByte = BitConverter.GetBytes(im);

                encSave[100] = bByte[0];
                encSave[101] = bByte[1];
                encSave[102] = bByte[2];
                encSave[103] = bByte[3];
            }

            string inputHex = txtPosition.Text;
            int parsedInt = Convert.ToInt32(inputHex, 16);
            byte[] positionBtye = BitConverter.GetBytes(parsedInt);
            encSave[116] = positionBtye[0];
            encSave[117] = positionBtye[1];
            encSave[118] = positionBtye[2];
            encSave[119] = positionBtye[3];
            
            uint crc = MyCRC(encSave);
            encSave[0] = (byte)(crc >> 0);
            encSave[1] = (byte)(crc >> 8);
            encSave[2] = (byte)(crc >> 16);
            encSave[3] = (byte)(crc >> 24);

            Tools.Encode(encSave);

            File.WriteAllBytes("nx2save.bin", Tools.Combine(uncSave, encSave, new byte[0]));

            MessageBox.Show("Saved\n\nNew File:\t\tTHIS FOLDER\nBackUp:\t\t/BackUp");

            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void btnSerial_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To make your USB works with the NX2 game the correct USBSerial must be here\nI recommend to use USBDeview.exe to grab the correct USBSerial for your device.");
        }

        private void numAvatar_ValueChanged(object sender, EventArgs e)
        {
            saveAvatar = (int)numAvatar.Value;
            picAvatar.Image = (Bitmap)Properties.Resources.ResourceManager.GetObject("CH_" + (saveAvatar + 1).ToString("000"));
        }
    }
}
