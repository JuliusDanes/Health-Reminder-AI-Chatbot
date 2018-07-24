using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BotHealth
{
    class Response
    {
        public static String ResponeMessage(String txtMsg)
        {
            String txtRespone = null;
            String kategori = ".((obat)?(olahraga)?)";
            String nama = "[a-zA-Z0-9 -_+,.()/&*#@!%:;]+";
            String tempat = "\\sdi\\s[a-zA-Z0-9 -_+,./()&*#@!%:;]+";
            String takar = "[0-9]{1,5}\\s((ml)?(l)?(mg)?(g)?(sendok)?(pil)?(butir)?(buah)?(botol)?){1}";
            String frekuensi = "[0-9]{1,3}x";
            String hari = "([, ](senin)?(selasa)?(rabu)?(kamis)?(jumat)?(sabtu)?(minggu)?(tiap hari)?){1,7}";
            String jam = "([, ][0-9]{1,2}.[0-9]{1,2}){1,86400}";
            String periode = "((harian)?(mingguan)?(bulanan)?)";
            String tanggal = "[0-9]{1,2}/[0-9]{1,2}";
            HashSet<dynamic> dtNama, dtTempat, dtTakar, dtFrekuensi, dtHari, dtJam, dtPeriode, dtTanggal;
            dtNama = dtTempat = dtTakar = dtFrekuensi = dtHari = dtJam = dtPeriode = dtTanggal = new HashSet<dynamic>();
            dtTakar = regexMatch(txtMsg, takar);
            dtFrekuensi = regexMatch(txtMsg, frekuensi);
            dtHari = regexMatch(txtMsg, hari);
            dtJam = regexMatch(txtMsg, jam);
            dtPeriode = regexMatch(txtMsg, periode);

            if ((new Regex(".help")).IsMatch(txtMsg.ToLower())) ///Help
            {
                txtRespone = "Help Respone";
            }
            else if ((new Regex(("^.obat\\s" + nama + "((\\s" + takar + ")?)\\s" + frekuensi + "(((\\s)?" + hari + ")?)" + "(((\\s)?" + jam + ")?)" + "((\\s" + periode + ")?)" + "+$")).IsMatch(txtMsg.ToLower()))) ///Add Medicine
            {
                dtNama = regexMatch(txtMsg, nama, new List<string> { kategori }, new List<string> { takar, frekuensi, hari, jam, periode });
                txtRespone = "Pengingat obat berhasil ditambahkan (+)";
            }
            else if ((new Regex(("^.hapus\\sobat\\s" + nama + "$")).IsMatch(txtMsg.ToLower()))) ///Delete Medicine
            {
                txtRespone = "Pengingat obat berhasil dihapus (-)";
            }
            else if ((new Regex(("^.olahraga\\s" + nama + "((" + tempat + ")?)\\s" + tanggal + "(((\\s)?" + hari + ")?)" + "(((\\s)?" + jam + ")?)" + "((\\s" + periode + ")?)" + "+$")).IsMatch(txtMsg.ToLower()))) ///Add Sport
            {
                dtNama = regexMatch(txtMsg, nama, new List<String> { kategori }, new List<String> { tempat, tanggal, hari, jam, periode });
                dtTempat = regexMatch(txtMsg, tempat, new List<string> { kategori }, new List<string> { tanggal });
                String a = dtNama.ElementAt(0);
                dtTempat = new HashSet<dynamic> { ((dtTempat.ElementAt(0)).Substring(a.Count())).Trim() };
                txtRespone = "Pengingat olahraga berhasil ditambahkan (+)";
            }
            else if ((new Regex(("^.hapus\\solahraga\\s" + nama + "$")).IsMatch(txtMsg.ToLower()))) ///Delete Sport
            {
                txtRespone = "Pengingat olahraga berhasil dihapus (-)";
            }
            else ///Failed Format
            {
                txtRespone = "Maaf, format perintah salah 😅 ketik .help ya 😁";
            }
            return txtRespone;
        }

        static HashSet<dynamic> regexMatch(String txtMsg, String strPatt)
        {
            String temp="";
            HashSet<dynamic> dtTemp = new HashSet<dynamic>();
            Regex rgxPatt = new Regex(strPatt, RegexOptions.IgnoreCase);
            Match matchGet = rgxPatt.Match(txtMsg);
            while (matchGet.Success)
            {
                temp = matchGet.Value.Trim();
                if ((temp != "") && (temp != ",") && (rgxPatt.IsMatch(temp)))
                {
                    var matchGrp = temp.Split(',');
                    for (int i = 0; i < matchGrp.Length; i++)
                        dtTemp.Add(matchGrp[i]);
                }
                matchGet = matchGet.NextMatch();
            }
            return dtTemp;
        }

        static HashSet<dynamic> regexMatch(String txtMsg, String strPatt, List<String> PattBefore, List<String> PattAfter)
        {
            String temp = "";
            HashSet<dynamic> dtTemp = new HashSet<dynamic>();
            List<String> PattArround = new List<String>();
            int[] idxLoc = new int[3];
            for (int i=0; i<2; i++)
            {
                if (i == 0) PattArround = PattBefore;
                else PattArround = PattAfter;
                foreach (var PattArround_ in PattArround)
                {
                    Regex rgxPatt = new Regex(PattArround_, RegexOptions.IgnoreCase);
                    Match matchGet = rgxPatt.Match(txtMsg);
                    if (matchGet.Value.Trim() != "")
                    {
                        idxLoc[2] = matchGet.Index - 1; ///To after
                        if (i == 0)
                            idxLoc[2] += matchGet.Length + 2; ///To before
                        if (((((idxLoc[0] < idxLoc[2]) || (idxLoc[0] == 0)) && (i == 0)) || (((idxLoc[1] > idxLoc[2]) || (idxLoc[1] == 0)) && (i == 1))) && (idxLoc[2] != -1)) ///Get nearst
                            idxLoc[i] = idxLoc[2];
                    }
                }
            }
            for (int i = idxLoc[0]; i<=idxLoc[1]; i++)
                temp += txtMsg[i];
            dtTemp.Add(temp=temp.Trim());
            return dtTemp;
        }
    }
}
