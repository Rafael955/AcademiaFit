using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AcademiaFit.Application.ViewModels.Binders
{
    public class SerieCompletaViewModelModelBinder
    {
        //public override object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        //{
        //    if (bindingContext == null)
        //    {
        //        throw new ArgumentNullException(nameof(bindingContext));
        //    }

        //    var valores = controllerContext.HttpContext.Request.Form;

        //    var ret = new EntradaSaidaProdutoViewModel() { Produtos = new Dictionary<int, int>() };

        //    try
        //    {
        //        ret.Data = DateTime.ParseExact(valores.Get("data"), "yyyy-MM-dd", null);

        //        if (!string.IsNullOrEmpty(valores.Get("produtos")))
        //        {
        //            var produtos = JsonConvert.DeserializeObject<List<dynamic>>(valores.Get("produtos"));

        //            foreach (var produto in produtos)
        //            {
        //                ret.Produtos.Add((int)produto.IdProduto, (int)produto.Quantidade);
        //            }
        //        };
        //    }
        //    catch
        //    {
        //    }

        //    return ret;
        //}

        //public Task BindModelAsync(ControllerContext controllerContext, ModelBindingContext bindingContext)
        //{
        //    if (bindingContext == null)
        //    {
        //        throw new ArgumentNullException(nameof(bindingContext));
        //    }

        //    var valores = controllerContext.HttpContext.Request.Form;

        //    var ret = new SerieCompletaViewModel() { ItensSerie = new List<ItemSerieViewModel>() };

        //    try
        //    {
        //        ret.ProfessorResponsavelId = Guid.Parse(valores["ProfessorResponsavelId"]);
        //        ret.AlunoId = Guid.Parse(valores["AlunoId"]);

        //        if (!string.IsNullOrEmpty(valores["ItensSerie"]))
        //        {
        //            var itensSerie = JsonConvert.DeserializeObject<List<dynamic>>(valores["ItensSerie"]);

        //            foreach (var item in itensSerie)
        //            {
        //                ret.ItensSerie.Add(item);
        //                //ret.Produtos.Add((int)produto.IdProduto, (int)produto.Quantidade);
        //            }
        //        };
        //    }
        //    catch
        //    {
        //    }
        //}

    }
}
