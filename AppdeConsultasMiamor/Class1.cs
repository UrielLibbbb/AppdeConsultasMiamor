using AppdeConsultasMiamor;
using System;
using System.Windows.Forms;

public class Class1
{
    private Form formInstance;

    public Class1(Form formToClose)
    {
        formInstance = formToClose;
        formInstance.FormClosing += FormInstance_FormClosing;
    }

    private void FormInstance_FormClosing(object sender, FormClosingEventArgs e)
    {
        LiberarRecursosYAbrirForm2();
    }

    private void LiberarRecursosYAbrirForm2()
    {
        LiberarRecursos();
        AbrirForm2();
    }

    private void LiberarRecursos()
    {
        formInstance.Close(); // Cierra el formulario completamente antes de liberar recursos
        formInstance.Dispose(); // Libera los recursos del formulario
    }

    private void AbrirForm2()
    {
        Form2 form2 = new Form2();
        form2.Show();
    }

    public void CerrarTodoYAbrirForm1()
    {
        LiberarRecursos();
        AbrirForm1();
    }

    private void AbrirForm1()
    {
        Form1 form1 = new Form1();
        form1.Show();
    }
}
