using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prwork6_kod_timetable.Model
{
    internal class saveload
    {
        public class save_class
        {
            public DateTime save_time;
            public string[] save_point;
        }
        public static void jsave(save_class new_note)
        {
            string json = JsonConvert.SerializeObject(new_note);
            if (!Directory.Exists("D:\\daily food planner"))
            {
                Directory.CreateDirectory("D\\daily food planner");
            }
            if (File.Exists("D:\\daily food planner\\" + new_note.save_time))
            {
                File.Delete("D:\\daily food planner\\" + new_note.save_time);
            }
            File.Create("D:\\daily food planner\\" + new_note.save_time);
            File.WriteAllText("D:\\daily food planner\\" + new_note.save_time, json);
        }

        public static save_class jload(DateTime loadtime)
        {
            string j_disc = File.ReadAllText("D:\\daily food planner\\" + loadtime);
            save_class l_zamet = JsonConvert.DeserializeObject<save_class>(j_disc);
            return l_zamet;
        }
    }  
}
