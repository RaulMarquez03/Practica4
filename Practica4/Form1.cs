namespace Practica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int num = 15; /* esto es un comentario. Cuando acabes de escribir, depura y fija un
break-point aqu� y ejecuta paso a paso */
            num = num + 10;
            num = 12 - (42 / 7);
            num++;
            num *= 3;
            // Pregunta 1: �Qu� valor tiene num aqu�?
            //el valor de num es 21
           // MessageBox.Show(num.ToString());
            int cont = 0;
            cont++;
            cont--;
            // fija otro break-point
            // Pregunta 2: �Qu� valor tiene cont aqu�?
            string result = "Hola";
            result += " otra vez " + result;
            MessageBox.Show(result);
            result = "the value is: " + cont; // Pregunta 3: �Qu� valor tiene result aqu�?
                                             // el valor de result es 0
            result = ""; // fija otro break-point
                         // Pregunta 4: �Qu� valor tiene result aqu�?
           // MessageBox.Show(result);
            bool yesNo = false;
            bool anotherBool = true;
            yesNo = !anotherBool;
            // MessageBox.Show(yesNo);
            // Pregunta 5: �Qu� valor tiene yesNo aqu�?
            //El valor de yesNo es false  
            //MessageBox.Show(yesNo.ToString());
        }
    }
}