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
    private void Button1()
    {
        x = x + "1";
        Greeting = x;
        if (priklad != null)
        {
           priklad = priklad + "1"; 
           Greeting = priklad;
        }
        
    }
    
    [RelayCommand]
    private void Button2()
    {
        x = x + "2";
        Greeting = x;

        if (priklad != null)
        {
           priklad = priklad + "2"; 
           Greeting = priklad;
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
