﻿using Dominio;
using Negocio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace tp_web_equipo_19
{
    public partial class DetalleArticulo : System.Web.UI.Page
    {
        public List<Articulo> ListaArticulos { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["ListaArticulos"] == null)
            {
                ArticuloNegocio articulo = new ArticuloNegocio();
                ListaArticulos = articulo.Listar();
                Session.Add("ListaArticulos", ListaArticulos);
            }
            else
            {
                ListaArticulos = (List<Articulo>)Session["ListaArticulos"];
            }

            if (!IsPostBack)
            {
                // Obtener el ID del artículo de la URL
                if (Request.QueryString["id"] != null)
                {
                    int idSeleccionado = int.Parse(Request.QueryString["id"]);

                    // Buscar el artículo seleccionado en la lista
                    Articulo articuloSeleccionado = ListaArticulos.FirstOrDefault(a => a.Id == idSeleccionado);

                    // Mostrar solo el artículo seleccionado
                    if (articuloSeleccionado != null)
                    {
                        List<Articulo> listaMostrar = new List<Articulo> { articuloSeleccionado };
                        Repeater1.DataSource = listaMostrar;
                        Repeater1.DataBind();
                    }
                }
            }
        }
    }

}