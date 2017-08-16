using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using GraphQL;
using GraphQL.Http;
using GraphQL.Types;


namespace WinFormGraphQL
{
    public partial class Form1 : Form
    {
        public string Mensaje = "";

        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            this.Mensaje = textBox1.Text;

            textBox2.Text = await this.RunAsync();
        }

        private async Task<String> RunAsync()
        {
            
            this.Mensaje += "Resultado del JSON: \n";

            var schema = new Schema { Query = new StarWarsQuery() };

            var result = await new DocumentExecuter().ExecuteAsync(_ =>
            {
                _.Schema = schema;
                _.Query = @"
                query {
                  hero {
                    id
                    name
                  }
                }
              ";
            }).ConfigureAwait(false);

            var json = new DocumentWriter(indent: true).Write(result);

            this.Mensaje += json;

            return this.Mensaje;
        }
    }

    public class Droid
    {
        public string Id { get; set; }
        public string Name { get; set; }
    }

    public class DroidType : ObjectGraphType<Droid>
    {
        public DroidType()
        {
            Field(x => x.Id).Description("The Id of the Droid.");
            Field(x => x.Name, nullable: true).Description("The name of the Droid.");
        }
    }

    public class StarWarsQuery : ObjectGraphType
    {
        public StarWarsQuery()
        {
            Field<DroidType>(
              "hero",
              resolve: context => new Droid { Id = "1", Name = "R2-D2" }
            );
        }
    }
}
