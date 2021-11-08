using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FeedNoticiasMVC.Models
{
    public class Noticia
    {
        public string Titulo { get; set; }
        public string Link { get; set; }
        public DateTime DataDePublicacao { get; set; }
        public string Resumo { get; set; }
    }
}