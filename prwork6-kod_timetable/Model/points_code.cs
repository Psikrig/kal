using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static prwork6_kod_timetable.Model.saveload;

namespace prwork6_kod_timetable.Model
{
    internal class points_code
    {
        public class point
        {
            public string point_name;
            public string point_path;
            public bool point_bool;
        }

        public static void imaged_points(DateTime load_time)
        {
            point fruits = new point();
            point kasha = new point();
            point meat = new point();
            point pasta = new point();
            point salad = new point();
            fruits.point_path = "..\\..\\Model\\sourse\\fruits";
            fruits.point_name = "fruits";
            kasha.point_path = "..\\..\\Model\\sourse\\kasha";
            kasha.point_name = "kasha";
            meat.point_path = "..\\..\\Model\\sourse\\meat";
            meat.point_name = "meat";
            pasta.point_path = "..\\..\\Model\\sourse\\pasta";
            pasta.point_name = "pasta";
            salad.point_path = "..\\..\\Model\\sourse\\salad";
            salad.point_name = "salad";
            List<point> points = new List<point>();
            points.Add(fruits);
            points.Add(kasha);
            points.Add(meat);
            points.Add(pasta);
            points.Add(salad);
            save_class l_zamet = jload(load_time);
            foreach(string load_point in l_zamet.save_point)
            {
                foreach(point p in points)
                {
                    if(p.point_name == load_point)
                    {
                        points.Remove(p);
                        p.point_bool = true;
                        points.Add(p);
                    }
                }
            }
        }
    }
}
