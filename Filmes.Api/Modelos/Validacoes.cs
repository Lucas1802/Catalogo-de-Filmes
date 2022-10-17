using System.Text.RegularExpressions;

namespace Filmes.Api.Modelos;

public class Validacoes
{
    public static string ValidarSeIgual(object object1, object object2, string mensagem)
    {
        if (object1.Equals(object2))
            return mensagem;

        return string.Empty;
    }

    public static string ValidarSeDiferente(object object1, object object2, string mensagem)
    {
        if (!object1.Equals(object2))
            return mensagem;

        return string.Empty;
    }

    public static string ValidarSeDiferente(string pattern, string valor, string mensagem)
    {
        var regex = new Regex(pattern);

        if (!regex.IsMatch(valor))
            return mensagem;

        return string.Empty;
    }

    public static string ValidarTamanho(string valor, int maximo, string mensagem)
    {
        var length = valor.Trim().Length;
        if (length > maximo)
            return mensagem;

        return string.Empty;
    }

    public static string ValidarTamanho(string valor, int minimo, int maximo, string mensagem)
    {
        var length = valor.Trim().Length;
        if (length < minimo || length > maximo)
            return mensagem;

        return string.Empty;
    }

    public static string ValidarSeVazio(string valor, string mensagem)
    {
        if (valor == null || valor.Trim().Length == 0)
            return mensagem;

        return string.Empty;
    }

    public static string ValidarSeNulo(object object1, string mensagem)
    {
        if (object1 == null)
            return mensagem;

        return string.Empty;
    }

    public static string ValidarMinimoMaximo(double valor, double minimo, double maximo, string mensagem)
    {
        if (valor < minimo || valor > maximo)
            return mensagem;

        return string.Empty;
    }

    public static string ValidarMinimoMaximo(float valor, float minimo, float maximo, string mensagem)
    {
        if (valor < minimo || valor > maximo)
            return mensagem;

        return string.Empty;
    }

    public static string ValidarMinimoMaximo(int valor, int minimo, int maximo, string mensagem)
    {
        if (valor < minimo || valor > maximo)
            return mensagem;

        return string.Empty;
    }

    public static string ValidarMinimoMaximo(long valor, long minimo, long maximo, string mensagem)
    {
        if (valor < minimo || valor > maximo)
            return mensagem;

        return string.Empty;
    }

    public static string ValidarMinimoMaximo(decimal valor, decimal minimo, decimal maximo, string mensagem)
    {
        if (valor < minimo || valor > maximo)
            return mensagem;

        return string.Empty;
    }

    public static string ValidarSeMenorQue(long valor, long minimo, string mensagem)
    {
        if (valor < minimo)
            return mensagem;

        return string.Empty;
    }

    public static string ValidarSeMenorQue(double valor, double minimo, string mensagem)
    {
        if (valor < minimo)
            return mensagem;

        return string.Empty;
    }

    public static string ValidarSeMenorQue(decimal valor, decimal minimo, string mensagem)
    {
        if (valor < minimo)
            return mensagem;

        return string.Empty;
    }

    public static string ValidarSeMenorQue(int valor, int minimo, string mensagem)
    {
        if (valor < minimo)
            return mensagem;

        return string.Empty;
    }

    public static string ValidarSeFalso(bool boolvalor, string mensagem)
    {
        if (!boolvalor)
            return mensagem;

        return string.Empty;
    }

    public static string ValidarSeVerdadeiro(bool boolvalor, string mensagem)
    {
        if (boolvalor)
            return mensagem;

        return string.Empty;
    }
}
