using PracticaChainOfResponsability;

var vendedor = new Vendedor();
var supervisor = new Supervisor();
var gerente = new Gerente();
var gerenteRegional = new GerenteRegional();

vendedor.AsignarResponsabilidad(supervisor);
supervisor.AsignarResponsabilidad(gerente);
gerente.AsignarResponsabilidad(gerenteRegional);

var c = new Compra();

int importe = 1;

while(importe != 0)
{
    Console.WriteLine("Ingrese monto de compra {0 para terminar}");
    importe = int.Parse(Console.ReadLine());
    c.Importe = importe;
    vendedor.Procesar(c);
}
