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
        return View();
    }

    public IActionResult Privacy()
    {
        //instancia do tipo cliente
        Cliente c1 = new Cliente(1, "Luiz", "456.123.789-45", "luiz@email.com", "max");
        Cliente c2 = new Cliente(2, "Marques Luiz", "123.123.789-45", "marquesluiz@email.com", "teo");
        Cliente c3 = new Cliente(3, "Lu", "456.123.789-45", "lu@email.com", "max2");
        Cliente c4 = new Cliente(4, "Cris", "456.123.789-45", "cris@email.com", "Pluto");
        Cliente c5 = new Cliente(5, "Esther", "123.321.789-45", "sther@email.com", "meggie");
        //lista de clientes e atribui os clientes
        List<Cliente> listaClientes = new List<Cliente>();
        listaClientes.Add(c1);
        listaClientes.Add(c2);
        listaClientes.Add(c3);
        listaClientes.Add(c4);
        listaClientes.Add(c5);
        ViewBag.listaClientes = listaClientes;


        //instancia do tipo fornecedores
        Fornecedor f1 = new Fornecedor(1, "PetCão", "123456789", "petcao@gmail.com");
        Fornecedor f2 = new Fornecedor(2, "CãoPet", "65432978", "caopet@gmail.com");
        Fornecedor f3 = new Fornecedor(3, "Pets", "9878965321", "pets@gmail.com");
        Fornecedor f4 = new Fornecedor(4, "Cãos", "121356798", "caos@gmail.com");
        Fornecedor f5 = new Fornecedor(5, "Papagaios", "123456789", "papagaios@gmail.com");
        //lista de fornecedores e atribui os fornecedores
        List<Fornecedor> listaFornecedores = new List<Fornecedor>();
        listaFornecedores.Add(f1);
        listaFornecedores.Add(f2);
        listaFornecedores.Add(f3);
        listaFornecedores.Add(f4);
        listaFornecedores.Add(f5);
        ViewBag.listaFornecedores = listaFornecedores;

        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
