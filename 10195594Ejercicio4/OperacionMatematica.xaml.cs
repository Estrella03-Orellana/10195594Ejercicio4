namespace _10195594Ejercicio4;

public partial class OperacionMatematica : ContentPage
{
	public OperacionMatematica()
	{
		InitializeComponent();
	}

    /// <summary>
    /// En el evento clicked del botón, le pedimos un número al usuario para cálcular su potencia, donde se 
    /// almacenara en la variable Num. 
    /// Con un If validamos los campos, donde se muestra una ventana de alerta si el usuario ingresa letras o carácteres
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void Button_Clicked(object sender, EventArgs e)
    {
		int Num, Resultado1, Resultado2;
        if (!string.IsNullOrEmpty(Num1.Text))
        {
            if (int.TryParse(Num1.Text, out Num))
            {
                Num = Convert.ToInt32(Num1.Text);
		        Resultado1 = Num * 2;
		        Resultado2 = Num * 3;
		        EntryResultado.Text = "Elevado al cuadrado : " +  Resultado1  + "    Elevado al cubo : " +  Resultado2 ;
            }
            else
            {
                DisplayAlert("ERROR", "Introduce Número, no letras ni otro tipo de carácteres", "OK");
            }
        }
    }
}