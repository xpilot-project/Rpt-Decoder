/*
 * Copyright (C) 2020 Justin Shannon
 *
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *
 * You should have received a copy of the GNU General Public License
 * along with this program. If not, see http://www.gnu.org/licenses/.
*/

using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportDecoder
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length > 0)
            {
                if (File.Exists(args[0]))
                {
                    var data = JsonConvert.DeserializeObject<Report>(File.ReadAllText(args[0]));
                    string ts = DateTime.Now.ToString("hh_mm_ss_fff");
                    File.WriteAllBytes($".\\CrashDump_{ts}.dmp", Convert.FromBase64String(data.dmp_file));
                    File.WriteAllBytes($".\\Log_{ts}.txt", Convert.FromBase64String(data.log_file));
                }
            }
        }
    }

    class Report
    {
        public string dmp_file { get; set; }
        public string log_file { get; set; }
    }
}
