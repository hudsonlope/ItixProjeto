using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Jogo
/// </summary>
public class Jogo
{

    //
    // TODO: Add constructor logic here
    //
    public int Codigo { get; set; }

    public DateTime DtRegistro { get; set; }

    public List<int> Numeros { get; set; }


    public Jogo(int pCodigo, List<int> pNumeros)
    {
        Codigo = pCodigo;

        DtRegistro = DateTime.Now;

        Numeros = pNumeros;


    }




}


public class JogoLogoMania : Jogo
{
    public JogoLogoMania(int pCodigo, List<int> pNumeros) : base(pCodigo, pNumeros)
    {

        if (pNumeros.Count() != 6)
        {
            throw new Exception("quantidade de números inválida");
        }
    }
}



public class Jogos
{





    public List<Jogo> ListaDeJogos { get; set; }

    int count;

    public Jogos()
    {
        this.ListaDeJogos = new List<Jogo>();


    }

    public void RegistrarJogo(List<int> numkeros)
    {
        var jogo = new Jogo(count++, numkeros);


        ListaDeJogos.Add(jogo);
    }

    public List<Jogo> Rodar()
    {

        var numeroSorteados = new GeradorDeNumeros().Gerar();

        var jogosSorteados = new List<Jogo>();

        foreach (var jogo in ListaDeJogos)
        {
            var num1 = numeroSorteados.Contains(jogo.Numeros[0]);
            var num2 = numeroSorteados.Contains(jogo.Numeros[1]);
            var num3 = numeroSorteados.Contains(jogo.Numeros[2]);
            var num4 = numeroSorteados.Contains(jogo.Numeros[3]);
            var num5 = numeroSorteados.Contains(jogo.Numeros[4]);
            var num6 = numeroSorteados.Contains(jogo.Numeros[5]);

            if (num1 && num2 && num3 && num4 && num5 && num6)
            {
                jogosSorteados.Add(jogo);
            }

        }


        return jogosSorteados;

    }

}


public class GeradorDeNumeros
{

    public List<int> Gerar()
    {
        var random = new Random(60);

        var numerosSorteados = new List<int>();

        while (numerosSorteados.Count != 6)
        {
            var num = random.Next();

            if (numerosSorteados.Contains(num))
            {
                continue;
            }
            else
            {
                numerosSorteados.Add(num);
            }

        }

        return numerosSorteados;
    }
}


public class JogosDAO
{

    public static Jogos Jogos
    {
        get { return HttpContext.Current.Cache["jogos"] as Jogos; }

        set { HttpContext.Current.Cache["jogos"] = value; }


    }

    public static void Start()
    {
        if (Jogos == null)
        {
            Jogos = new Jogos();
        }


    }

}