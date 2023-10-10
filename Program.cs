using ABM;
using System;
using System.Windows.Forms;

public class Program
{
    [STAThread]
    public static void Main(string[] args)
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);

        // Crea una instancia de tu formulario principal y ábrelo
        Application.Run(new FormInicialProductoVendido());
    }
}
