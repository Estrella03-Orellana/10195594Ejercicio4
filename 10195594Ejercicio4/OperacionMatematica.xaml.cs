namespace _10195594Ejercicio4;

public partial class OperacionMatematica : ContentPage
{
	public OperacionMatematica()
	{
		InitializeComponent();
	}

    /// <summary>
    /// En el evento clicked del bot�n, le pedimos un n�mero al usuario para c�lcular su potencia, donde se 
    /// almacenara en la variable Num. 
    /// Con un If validamos los campos, donde se muestra una ventana de alerta si el usuario ingresa letras o car�cteres
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
                DisplayAlert("ERROR", "Introduce N�mero, no letras ni otro tipo de car�cteres", "OK");
            }
        }
    }
}