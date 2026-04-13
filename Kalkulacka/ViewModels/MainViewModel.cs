using System;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.VisualBasic;
using System.Data;

namespace Kalkulacka.ViewModels;

public partial class MainViewModel : ViewModelBase
{
    [ObservableProperty]
    private string _greeting = "Welcome to Avalonia!";
    string priklad;

    private static bool v = false;

    private static string x;
    [RelayCommand]
    private void Button0()
    { 
        if (priklad != null)
        {
           priklad = priklad + "0"; 
           Greeting = priklad;
        }
        else
        {
            x = x + "0";
        Greeting = x;
        }  
    }


    [RelayCommand]
    private void Button1()
    {   
        if (priklad != null)
        {
           priklad = priklad + "1"; 
           Greeting = priklad;
        }
        else
        {
            x = x + "1";
        Greeting = x;
        }    
    }
    
    [RelayCommand]
    private void Button2()
    {  
        if (priklad != null)
        {
           priklad = priklad + "2"; 
           Greeting = priklad;
        }
        else
        {
            x = x + "2";
        Greeting = x;

        }
    }

    [RelayCommand]
    private void Button3()
    {  
        if (priklad != null)
        {
           priklad = priklad + "3"; 
           Greeting = priklad;
        }
        else
        {
            x = x + "3";
        Greeting = x;

        }
    }

    [RelayCommand]
    private void Button4()
    {  
        if (priklad != null)
        {
           priklad = priklad + "4"; 
           Greeting = priklad;
        }
        else
        {
            x = x + "4";
        Greeting = x;

        }
    }

    [RelayCommand]
    private void Button5()
    {  
        if (priklad != null)
        {
           priklad = priklad + "5"; 
           Greeting = priklad;
        }
        else
        {
            x = x + "5";
        Greeting = x;

        }
    }
    [RelayCommand]
    private void Button6()
    {  
        if (priklad != null)
        {
           priklad = priklad + "6"; 
           Greeting = priklad;
        }
        else
        {
            x = x + "6";
        Greeting = x;

        }
    }
    [RelayCommand]
    private void Button7()
    {  
        if (priklad != null)
        {
           priklad = priklad + "7"; 
           Greeting = priklad;
        }
        else
        {
            x = x + "7";
        Greeting = x;

        }
    }

    [RelayCommand]
    private void Button8()
    {  
        if (priklad != null)
        {
           priklad = priklad + "8"; 
           Greeting = priklad;
        }
        else
        {
            x = x + "8";
        Greeting = x;

        }
    }

    [RelayCommand]
    private void Button9()
    {  
        if (priklad != null)
        {
           priklad = priklad + "9"; 
           Greeting = priklad;
        }
        else
        {
            x = x + "9";
        Greeting = x;

        }
    }

    [RelayCommand]
    private void ButtonPlus()
    { 
        if (v == true)
        {
            priklad = priklad + " + ";
            Greeting = priklad;   
        }
        else
        {
        x =  x + " + ";
        priklad = x;
        x = "";
        Greeting = priklad; 
        v = true;
        }   
    }

    [RelayCommand]
    private void ButtonMinus()
    { 
        if (v == true)
        {
            priklad = priklad + " - ";
            Greeting = priklad;   
        }
        else
        {
        x =  x + " - ";
        priklad = x;
        x = "";
        Greeting = priklad; 
        v = true;
        }   
    }

    [RelayCommand]
    private void ButtonKrat()
    { 
        if (v == true)
        {
            priklad = priklad + " * ";
            Greeting = priklad;   
        }
        else
        {
        x =  x + " * ";
        priklad = x;
        x = "";
        Greeting = priklad; 
        v = true;
        }   
    }

    [RelayCommand]
    private void ButtonDel()
    { 
        if (v == true)
        {
            priklad = priklad + " / ";
            Greeting = priklad;   
        }
        else
        {
        x =  x + " / ";
        priklad = x;
        x = "";
        Greeting = priklad; 
        v = true;
        }   
    }

    [RelayCommand]
    private void ButtonSmazat()
    {
        if (priklad != null)
        {
            priklad = priklad.Substring(0, priklad.Length - 1);
            Greeting = priklad;
        }
        else
        {
            x = x.Substring(0, x.Length - 1);
            Greeting = x;
        }
    }

    [RelayCommand]
    private void ButtonFinal()
    {
        DataTable dt = new DataTable();
        var vysledek = dt.Compute(priklad, "");


        int result = Convert.ToInt32(vysledek);
        Greeting = result.ToString();
            x = "";
            priklad = "";
    }
}
