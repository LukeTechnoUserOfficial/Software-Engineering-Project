using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Word_Generator__Remove_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string st = "I went to the park for as exemplified by the sea";          
        private void btnRemove_Click(object sender, EventArgs e)
        {
            st = st.Replace("after a while", "");
            st = st.Replace("afterward", "");
            st = st.Replace("at once", "");
            st = st.Replace("at this moment", "");
            st = st.Replace("at this point", "");
            st = st.Replace("before that", "");
            st = st.Replace("finally", "");
            st = st.Replace("first", "");

            st = st.Replace("second", "");

            st = st.Replace("third", "");
            st = st.Replace("here", "");
            st = st.Replace("in the end", "");
            st = st.Replace("lastly", "");
            st = st.Replace("later on", "");
            st = st.Replace("meanwhile", "");
            st = st.Replace("next", "");
            st = st.Replace("next time", "");
            st = st.Replace("now", "");
            st = st.Replace("on another occasion", "");
            st = st.Replace("previously", "");
            st = st.Replace("since", "");
            st = st.Replace("soon", "");
            st = st.Replace("straightaway", "");
            st = st.Replace("then", "");
            st = st.Replace("until then", "");
            st = st.Replace("when", "");
            st = st.Replace("whenever", "");
            st = st.Replace("while", "");
            st = st.Replace("additionally", "");
            st = st.Replace("also", "");
            st = st.Replace("as well", "");
            st = st.Replace("even", "");
            st = st.Replace("furthermore", "");
            st = st.Replace("in addition", "");
            st = st.Replace("indeed", "");
            st = st.Replace("let alone", "");
            st = st.Replace("moreover", "");
            st = st.Replace("not only", "");
            st = st.Replace("alternatively", "");
            st = st.Replace("anyway", "");
            st = st.Replace("but", "");
            st = st.Replace("by contrast", "");
            st = st.Replace("elsewhere", "");
            st = st.Replace("even so", "");
            st = st.Replace("however", "");
            st = st.Replace("in contrast", "");
            st = st.Replace("in fact", "");
            st = st.Replace("in other respects", "");

            st = st.Replace("in spite of this", "");
            st = st.Replace("in that respect", "");
            st = st.Replace("instead", "");
            st = st.Replace("nevertheless", "");
            st = st.Replace("on the contrary", "");
            st = st.Replace("on the other hand", "");
            st = st.Replace("rather", "");
            st = st.Replace("though", "");
            st = st.Replace("whereas", "");
            st = st.Replace("yet", "");
            st = st.Replace("after all", "");
            st = st.Replace("anyway", "");
            st = st.Replace("besides", "");
            st = st.Replace("moreover", "");

            st = st.Replace("besides", "");
            st = st.Replace("for example", "");
            st = st.Replace("for instance", "");
            st = st.Replace("in other words", "");
            st = st.Replace("in that", "");
            st = st.Replace("that is to say", "");

            st = st.Replace("firstly", "");

            st = st.Replace("secondly", "");
            st = st.Replace("first of all", "");
            st = st.Replace("finally", "");
            st = st.Replace("lastly", "");
            st = st.Replace("for one thing", "");
            st = st.Replace("for another", "");
            st = st.Replace("in the first", "");
            st = st.Replace("to begin with", "");
            st = st.Replace("next", "");
            st = st.Replace("in summation", "");
            st = st.Replace("in conclude", "");
            st = st.Replace("accordingly", "");
            st = st.Replace("all the same", "");
            st = st.Replace("an effect of", "");
            st = st.Replace("an outcome of", "");
            st = st.Replace("an upshot of", "");
            st = st.Replace("as a consequence of", "");
            st = st.Replace("as a result of", "");
            st = st.Replace("because", "");
            st = st.Replace("caused by", "");
            st = st.Replace("consequently", "");
            st = st.Replace("despite this", "");
            st = st.Replace("even though", "");
            st = st.Replace("hence", "");
            st = st.Replace("however", "");
            st = st.Replace("in that case", "");
            st = st.Replace("moreover", "");
            st = st.Replace("nevertheless", "");
            st = st.Replace("otherwise", "");
            st = st.Replace("so", "");
            st = st.Replace("so as", "");
            st = st.Replace("stemmed from", "");
            st = st.Replace("still", "");
            st = st.Replace("then", "");
            st = st.Replace("therefore", "");
            st = st.Replace("though", "");
            st = st.Replace("under the circumstances", "");
            st = st.Replace("yet", "");

            st = st.Replace("accordingly", "");
            st = st.Replace("as a result", "");
            st = st.Replace("as exemplified by", "");
            st = st.Replace("consequently", "");
            st = st.Replace("for example", "");
            st = st.Replace("for instance", "");
            st = st.Replace("for one thing", "");
            st = st.Replace("including", "");
            st = st.Replace("provided that", "");
            st = st.Replace("since", "");
            st = st.Replace("so", "");
            st = st.Replace("such as", "");
            st = st.Replace("then", "");
            st = st.Replace("therefore", "");
            st = st.Replace("these include", "");
            st = st.Replace("through", "");
            st = st.Replace("unless", "");
            st = st.Replace("without", "");
            label1.Text = st;

        }
    }
}
