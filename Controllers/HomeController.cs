using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using LHPet.Models;

namespace LHPet.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        //instancia do tipo cliente
        Cliente cliente1 = new Cliente(01, "Arthur A. Ferreira", "857.032.950-41","arthurantunes@sp.senai.br","Madruga");
        Cliente cliente2 = new Cliente(02, "willian Henry Gates III", "039.618.250-09", "bill@microsoft.com", "Bug");
        Cliente cliente3 = new Cliente(03, "Ada Lovelace", "800.700.920-50", "ada@ada.language.com", "Byron");
        Cliente cliente4 = new Cliente(04, "Linus Torvalds", "933.622.400-02", "torvalds@0sdl.org", "Pinguim");
        Cliente cliente5 = new Cliente(05, "Grace Hopper", "911.702.988-00", "grace.hopper@cobol.com", "Loboc");

        //lista de cliente e atribuir os clientes
        List<Cliente> listaclientes = new List<Cliente>();
        listaclientes.Add(cliente1);
        listaclientes.Add(cliente2);
        listaclientes.Add(cliente3);
        listaclientes.Add(cliente4);
        listaclientes.Add(cliente5);

        ViewBag.listaclientes = listaclientes;

        //instancia tipo Fornecedores
        Fornecedor fornecedor1 = new Fornecedor(01,"C# PET S/A", "14.182.102/0001-80", "c-sharp@pet.org");
        Fornecedor fornecedor2 = new Fornecedor(02, "Ctrl Alt Dog", "15.836.698/0001-57", "ctrl@altdog.br");
        Fornecedor fornecedor3 = new Fornecedor(03, "BootsPet INK", "40.810.224/0001-83", "boots.pet@gatomania.us");
        Fornecedor fornecedor4 = new Fornecedor(04, "Tik Tok Dogs", "87.945.350/0001-09", "noisnamidia@tiktokdog.uk");
        Fornecedor fornecedor5 = new Fornecedor(05, "Bifinho Forever", "18.760.614/0001-37", "contato@bff.us");

        //lista fornecedores e atribuir fornecedores
        List<Fornecedor> listafornecedor = new List<Fornecedor>();
        listafornecedor.Add(fornecedor1);
        listafornecedor.Add(fornecedor2);
        listafornecedor.Add(fornecedor3);
        listafornecedor.Add(fornecedor4);
        listafornecedor.Add(fornecedor5);

        ViewBag.listafornecedor = listafornecedor;

        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
