using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WMNX2
{
    public static class Mission
    {
        public static MissionData[] allMissionData;

        public static void ReadMission(byte[] enc)
        {
            List<MissionData> allMission = new List<MissionData>();
            string[] lines = File.ReadAllLines("other/mission.txt");
            for (int i = 0; i < lines.Length; i++)
            {
                if (lines[i] == "\t*NX_MISSION" && lines[i + 1] == "\t{")
                {
                    if (!lines[i + 6].StartsWith("\t\tMILEAGE\t\t0") || lines[i+15].StartsWith("\t\tNAME\t\t\"PhantomOS\""))                  
                    {
                        if (lines[i + 20].StartsWith("\t\tSTEP"))
                        {
                            string sType = "";
                            if (lines[i + 7] == "\t\tTYPE\t\t\"일반\"")
                                sType = "NORMAL";
                            if (lines[i + 7] == "\t\tTYPE\t\t\"중간보스\"")
                                sType = "SUBBOSS";
                            if (lines[i + 7] == "\t\tTYPE\t\t\"보스\"")
                                sType = "BOSS";
                            if (lines[i + 7] == "\t\tTYPE\t\t\"Hidden\"")
                                sType = "HIDDEN";

                            int iId = int.Parse(lines[i + 20].Substring(11, 3));
                            string sID = lines[i + 20].Substring(9, 5);
                            string sLand = lines[i + 16].Replace("\t\tLAND\t\t\"", string.Empty);
                            sLand = sLand.Replace("\"", string.Empty);
                            string sName = lines[i + 15].Replace("\t\tNAME\t\t\"", string.Empty);
                            sName = sName.Replace("\"", string.Empty);

                            MissionData mAdd = new MissionData();
                            mAdd.sType = sType;
                            mAdd.iId = iId;
                            mAdd.sId = sID;
                            mAdd.sLand = sLand;
                            mAdd.sName = sName;

                            mAdd.bClear = false;
                            mAdd.bPass = false;

                            int iBaseM = 384;
                            int iBaseI = 5504;

                            mAdd.bClear = enc[iBaseM + iId] != 0 ? true : false;
                            mAdd.bPass = enc[iBaseI + (iId * 4)] >= 3 ? true : false;

                            allMission.Add(mAdd);
                        }
                    }
                }
            }

            allMissionData = allMission.ToArray();
        }
    }

    public struct MissionData
    {
        public string sType;
        public int iId;
        public string sId;
        public string sLand;
        public string sName;
        public bool bPass;
        public bool bClear;
    }
}
