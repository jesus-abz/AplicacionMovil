using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AplicacionMovil
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private void btnBoton_Clicked(object sender, EventArgs e)
        {
            float cantidad = float.Parse(txtCantidad.Text);
            float diezporcen = cantidad * 0.1f;
            lblResultado.Text = diezporcen.ToString();
        }
    }
}
