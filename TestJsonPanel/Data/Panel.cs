using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace TestJsonPanel.Data
{
    public class GabChar
    {
        public List<double> H1 { get; set; }
        public List<double> H2 { get; set; }
        public List<double> H3 { get; set; }
        public double Height { get; set; }
        public double Length { get; set; }
        public string Prf { get; set; }
        public double Thickness { get; set; }
    }

    public class Panel
    {
        public List<Rect> Console { get; set; }
        public bool Cuts { get; set; }
        public bool El { get; set; }
        [JsonProperty("gab_char")]
        public GabChar GabChar { get; set; }
        public bool Incuts { get; set; }
        public string Mark { get; set; }
        public List<Rect> Tooth { get; set; }
        public Dictionary<string, List<List<List<double>>>> Vects { get; set; }
        public Dictionary<string, List<List<double>>> Vfa { get; set; }
        public List<Window> Windows { get; set; }
        public List<Zd> Zds { get; set; }
    }

    public class Rect
    {
        public double Height { get; set; }
        public List<List<double>> Vfa { get; set; }
        public double Z { get; set; }
    }

    public class Window
    {
        public List<List<double>> Diag { get; set; }
        public int Id { get; set; }
    }

    public class Zd
    {
        public string Name { get; set; }
        public List<double> Posi { get; set; }
        public double Rotat { get; set; }
    }
}