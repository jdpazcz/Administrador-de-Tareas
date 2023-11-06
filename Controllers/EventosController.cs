using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using System.Data;
using TODOLIST_AGA.ConexiónBaseDatos;
using TODOLIST_AGA.Models;


namespace TODOLIST_AGA.Controllers
{
    public class EventosController : Controller
    {
        ConexionProcedimientos ConexionProcedimientos = new ConexionProcedimientos();
        public IActionResult Consultar()
        {
            var spC = ConexionProcedimientos.Consultar();
            return View(spC);
        }

        public IActionResult Eliminar(int ID)
        {
            var eliM = ConexionProcedimientos.Eliminar(ID);
            return RedirectToAction("Consultar");
        }


        public IActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Agregar(ParametrosEntrada sP_02)
        {
            if (!ModelState.IsValid)
                return View();
            var ans = ConexionProcedimientos.Agregar(sP_02);
            if (ans)
                return RedirectToAction("Consultar");
            else
                return View();
        }

        public IActionResult Actualizar(int ID)
        {
            var acT = ConexionProcedimientos.Obtener(ID);
            return View(acT);
        }

        [HttpPost]
        public IActionResult Actualizar(ParametrosEntrada sP_02)
        {
            var acT = ConexionProcedimientos.Actualizar(sP_02);

            if (acT)
                return RedirectToAction("Consultar");
            else
                return View();
        }
    }



}

