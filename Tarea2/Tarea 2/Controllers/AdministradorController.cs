using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Aplicacion.Contrato;
using Aplicacion.Core;

namespace Tarea_2.Controllers
{
    public class AdministradorController : Controller
    {
        #region Atributos
        private IAdministradorServicio _administradorServicio;
        #endregion

        #region constructor
        public AdministradorController(IAdministradorServicio pAdministradorServicio) {
            _administradorServicio = pAdministradorServicio;
        }
        #endregion

        // GET: Administrador
        public ActionResult Index()
        {
            var lista = _administradorServicio.ObtenerTodas();
            return View(lista);
        }
        [HttpPost]
        public ActionResult Agregar(int id, string nombre, string contra, string correo)
        {
            AdministradorDTO ad = new AdministradorDTO();
            ad.AdministradorId = id;
            ad.AdministradorNombre = nombre;
            ad.AdministradorContrasenna = contra;
            ad.AdministradorCorreo = correo;

            bool res = _administradorServicio.Agregar(ad);

            ViewBag.Title = "Insertar Administrador";

            if (res) {
                ViewBag.Message = "Se ha realizado la insercion";
            }else
                ViewBag.Message = "No se ha realizado la insercion";

            //var lista = _administradorServicio.ObtenerTodas();
            return View();
        }

        // GET: Administrador/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Administrador/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Administrador/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Administrador/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Administrador/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Administrador/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Administrador/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
