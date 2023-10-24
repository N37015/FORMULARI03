using System.Text.RegularExpressions;

using MySql.Data.MySqlClient;


namespace FORMULARIO3
{
    public partial class Form1 : Form
    {
        string conexionSQL = "Server=localhost;Port=3306;Database=programacionavanzada;Uid=root;Pwd=;";
        public Form1()
        {
            InitializeComponent();

            tbEdad.TextChanged += validarEdad;
            tbEstatura.TextChanged += validarEstatura;
            tbTelefono.TextChanged += validarTelefono;
            tbNombre.TextChanged += validarNombre;
            tbApellidos.TextChanged += validarApellidos;
        }

        private void InsertarRegistro(string nombres, string apellidos, int edad, decimal estatura,string telefono, string genero)
        {
            using (MySqlConnection conection = new MySqlConnection(conexionSQL))
            {
                conection.Open();


                string insertQuery = " INSERT INTO datos(Nombres,Apellidos,Edad,Estatura,Telefono,Genero)" + "VALUES(@Nombres,@Apellidos,@Edad,@Estatura,@Telefono,@Genero)";

                using (MySqlCommand comand = new MySqlCommand(insertQuery, conection))
                {
                    comand.Parameters.AddWithValue("@Nombres", nombres);
                    comand.Parameters.AddWithValue("@Apellidos", apellidos);
                    comand.Parameters.AddWithValue("@Edad", edad);
                    comand.Parameters.AddWithValue("@Estatura", estatura);
                    comand.Parameters.AddWithValue("@Telefono", telefono);
                    comand.Parameters.AddWithValue("@Genero", genero);

                    comand.ExecuteNonQuery();
                }
                conection.Close();



                }
            }
              
                            
        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void guardar_Click(object sender, EventArgs e)
        {
            //Obtener los datos de los TexBox
            string nombres = tbNombre.Text;
            string apellidos = tbApellidos.Text;
            string edad = tbEdad.Text;
            string estatura = tbEstatura.Text;
            string telelfono = tbTelefono.Text;


            //Obtener el genero seleccinado
            string genero = "";
            if (rbHombre.Checked)
            {
                genero = "Hombre";
            }
            else if (rbMujer.Checked)
            {
                genero = "Mujer";
            }
            if (EsEnteroValido(edad) && EsDecimalValido(estatura) && EsEnteroValidoDe10Digitos(telelfono) && EstextoValido(nombres)
                && EstextoValido(apellidos))
            {


                //Crear una cadena con los datos 
                string datos = $"Nombres: {nombres}\r\nApellidos: {apellidos}\r\nTelefono: {telelfono} \r\nEstatura: {estatura}cm\r\nEdad: {edad} años\n\nGenero: {genero}";

                //Guardar los datos en un archivo de texto
                string rutaArchivo = "C:\\Users\\USUARIO\\Documents\\Visual Studio 2022\\FORMULARIO.txt";
                File.WriteAllText(rutaArchivo, datos);
                //Verificar si el el archcivo ya existe 
                bool archivoExiste = File.Exists(rutaArchivo);
                if (archivoExiste == false)
                {
                    File.WriteAllText(rutaArchivo, datos);
                }
                else
                {
                    using (StreamWriter writer = new StreamWriter(rutaArchivo, true))
                    {
                        if (archivoExiste)
                        {
                            // Si el archivo existe, añadir un separador antes del nuevo regristro 
                            writer.WriteLine();
                            writer.WriteLine(datos);
                            //programacion de funcionalidad de insert SQL
                            InsertarRegistro(nombres, apellidos, int.Parse(edad), decimal.Parse(estatura), telelfono, genero);
                            MessageBox.Show("Datos ingresados correctamente.");
                        }
                        else
                        {
                            // Si el archivo no existe.
                            writer.WriteLine(datos);
                            //programacion de funcionalidad de insert SQL
                            InsertarRegistro(nombres, apellidos, int.Parse(edad), decimal.Parse(estatura), telelfono, genero);
                            MessageBox.Show("Datos ingresados correctamente.");
                        }

                    }

                    
                }
                //Mostrar un mensaje con los datos capturados
                MessageBox.Show("Datos guardados con exito:\n\n" + datos, "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("Por favor, ingrese datos validos en los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }
        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }
        private bool EsEnteroValidoDe10Digitos(string input)
        {
            if (input.Length != 10)
            {
                return false;
            }
             if (!input.All(char.IsDigit))
            {
                return false;
            }
            return true;
          }
        private bool EstextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }

        private void validarEdad(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsEnteroValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese una edad válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarEstatura(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EsDecimalValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese una estatura válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarTelefono(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            string input = textBox.Text;
            if (input.Length < 10)
            {
                return;
            }
             if (!EsEnteroValidoDe10Digitos(input))
            {
                MessageBox.Show("Por favor ingrese un número de teléfono válido de 10 dígitos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void validarNombre(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EstextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor, ingrese un valor válido (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();
            }
        }

        private void validarApellidos(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            if (!EstextoValido(textBox.Text))
            {
                MessageBox.Show("Por favor ingrese apellidos válidos (solo letras y espacios).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox.Clear();


            }
        }

        private void cancelar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbApellidos.Clear();
            tbEdad.Clear();
            tbEstatura.Clear();
            tbTelefono.Clear();
            rbHombre.Checked = false;
            rbMujer.Checked = false;
        }
    }
}