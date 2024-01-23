
using System;

class EsqueletoHumano
{
    private string[] huesos;

    public EsqueletoHumano()
    {
        InicializadorHuesos();
    }

    private void InicializadorHuesos()
    {
        huesos = new string[206];

        huesos[0] = "Frontal";
        huesos[1] = "Occipital";
        huesos[2] = "Parietal izquierdo";
        huesos[3] = "Parietal derecho";
        huesos[4] = "Temporal izquierdo";
        huesos[5] = "Temporal derecho";
        huesos[6] = "Esfenoides";
        huesos[7] = "Etmoides";
        huesos[8] = "Maxilar inferior o mandíbula";
        huesos[9] = "Maxilar superior izquierdo";
        huesos[10] = "Maxilar superior derecho";
        huesos[11] = "Palatino izquierdo";
        huesos[12] = "Palatino derecho";
        huesos[13] = "Malar o cigomático izquierdo";
        huesos[14] = "Malar o cigomático derecho";
        huesos[15] = "Nasal izquierdo";
        huesos[16] = "Nasal derecho";
        huesos[17] = "Unguis o lagrimal izquierdo";
        huesos[18] = "Unguis o lagrimal derecho";
        huesos[19] = "Vómer";
        huesos[20] = "Cornete nasal izquierdo";
        huesos[21] = "Cornete nasal derecho";
        huesos[22] = "Martillo izquierdo";
        huesos[23] = "Martillo derecho";
        huesos[24] = "Yunque izquierdo";
        huesos[25] = "Yunque derecho";
        huesos[26] = "Estribo izquierdo";
        huesos[27] = "Estribo derecho";
        huesos[28] = "Hioides";
        huesos[29] = "Vértebra cervical C1.Llamada Atlas";
        huesos[30] = "Vértebra cervical C2.Llamada Axis";
        huesos[31] = "Vértebra cervical C3.Llamada C3";
        huesos[32] = "Vétrebra cervical C4.Llamada C4";
    }

    public void CargarHuesos()
    {
        Console.WriteLine("Lista de huesos del cuerpo humano:");
        Console.WriteLine();
        for (int i = 0; i < huesos.Length; i++)
        {
            Console.WriteLine($"{i + 1}. {huesos[i]}");
        }
    }



}

class Program
{
    static void Main()
    {
     
        EsqueletoHumano esqueleto = new EsqueletoHumano();


        esqueleto.CargarHuesos();

        Console.ReadKey();
    }
}

