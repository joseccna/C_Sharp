public class Carro
{
    public string marca = "Toyota";
    public string modelo = "Corolla";
    public int ano = 2008;

    public void MostrarDetalhes()
    {
        Console.WriteLine($"Marca: {marca}, Modelo: {modelo}, Ano: {ano}");
    }

}