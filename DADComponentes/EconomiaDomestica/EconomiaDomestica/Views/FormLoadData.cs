using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EconomiaDomestica.Views
{

    public partial class FormLoadData : Form, IRegistroView
    {

        FormLoadData formLoadData;

        public FormLoadData()
        {
            InitializeComponent();
        }

        public int Id_Registro { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Fecha { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Concepto { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int Importe { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string SearchValue { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsEdit { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public bool IsSuccessfool { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Message { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event EventHandler SearchEvent;
        public event EventHandler AddNewEvent;
        public event EventHandler EditEvent;
        public event EventHandler DeleteEvent;
        public event EventHandler SaveEvent;
        public event EventHandler CancelEvent;

        public void SetResgistroBindingSource(BindingSource Registro)
        {
            throw new NotImplementedException();
        }

        private void btnLoadView_Click(object sender, EventArgs e)
        {
            formLoadData.Show();
        }
    }
}
