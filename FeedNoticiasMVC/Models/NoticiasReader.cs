using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Syndication;
using System.Web;
using System.Xml;

namespace FeedNoticiasMVC.Models
{
    public static class NoticiasReader
    {
        public static List<Noticia> ObterNoticias(string enderecoFeed)
        {
            List<Noticia> noticias = new List<Noticia>();

            SyndicationFeed feed = SyndicationFeed.Load(new XmlTextReader(enderecoFeed));
            foreach (var item in feed.Items)
            {
                noticias.Add(new Noticia()
                {
                    Titulo = item.Title.Text,
                    Link = item.Links.Count > 0 ? item.Links[0].Uri.ToString() : null,
                    DataDePublicacao = item.PublishDate.LocalDateTime,
                    Resumo = item.Summary.Text
                });
            }

            return noticias;
        }
    }
}